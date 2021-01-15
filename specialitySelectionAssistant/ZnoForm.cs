using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpecialtySelectionAssistantLibrary;

namespace specialitySelectionAssistant
{
    public partial class ZnoForm : MaterialForm
    {
        List<ZnoSubject> znoSubjects;

        bool isMandatoryComboboxsEmpty = false;

        ComboBox[] comboBoxesArr;
        NumericUpDown[] numericUpDownsArr;

        public ZnoForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange300, Primary.Orange400, Primary.Orange100, Accent.LightBlue200, TextShade.BLACK);
        }

        private void ZnoForm_Load(object sender, EventArgs e)
        {
            isMandatoryComboboxsEmpty = false;

            znoSubjects = new List<ZnoSubject>();

            firstSubjectComboBox.Items.AddRange(Constants.FIRST_ZNO_SUBJECTS);
            secondSubjectComboBox.Items.AddRange(Constants.SECOND_ZNO_SUBJECTS);
            thirdSubjectComboBox.Items.AddRange(Constants.THIRD_ZNO_SUBJECTS);
            fourthSubjectComboBox.Items.AddRange(Constants.OTHER_ZNO_SUBJECTS);
            fifthSubjectComboBox.Items.AddRange(Constants.OTHER_ZNO_SUBJECTS);

            foreach (NumericUpDown numericUpDown in this.Controls.OfType<NumericUpDown>())
            {
                numericUpDown.Maximum = Constants.MAX_ZNO_POINTS;
                numericUpDown.Minimum = Constants.MIN_ZNO_POINTS;
                ((TextBox)numericUpDown.Controls[1]).MaxLength = Constants.MAX_ZNO_POINTS_DIGIT_COUNT;
            }

            comboBoxesArr = new[]
            {
                firstSubjectComboBox,
                secondSubjectComboBox,
                thirdSubjectComboBox,
                fourthSubjectComboBox,
                fifthSubjectComboBox
            };

            numericUpDownsArr = new[]
            {
                firstSubjectPotintsNumericUpDown,
                secondSubjectPotintsNumericUpDown,
                thirdSubjectPotintsNumericUpDown,
                fourthSubjectPotintsNumericUpDown,
                fifthSubjectPotintsNumericUpDown
            };
        }

        private void backMaterialFlatButton_Click(object sender, EventArgs e)
        {
            Navigation.toRegistrationForm(this);
        }

        private void helpMaterialFlatButton_Click(object sender, EventArgs e)
        {
            Navigation.toHelpForm(this);
        }

        private void nextMaterialFlatButton_Click(object sender, EventArgs e)
        {
            saveZnoSubjects();

            if (isMandatoryComboboxsEmpty)
            {
                MessageBox.Show($"Оберіть {Constants.MANDATORY_SUBJECTS_COUNT} обов'язкових предмети");
                isMandatoryComboboxsEmpty = false;
            }
            else
            {
                preferredSpecialtiesDeterminant.setZnoSubjects(znoSubjects);
                Navigation.toComparisonQuestionForm(this);
            }
        }

        private void saveZnoSubjects()
        {
            znoSubjects = new List<ZnoSubject>();
            try
            {
                for (int i = 0; i < Constants.MANDATORY_SUBJECTS_COUNT; i++)
                {
                    checkIsComboBoxEmpty(comboBoxesArr[i]);
                }

                for (int i = 0; i < Constants.SUBJECT_COUNT; i++)
                {
                    saveZnoSubject(comboBoxesArr[i], numericUpDownsArr[i]);
                }
            }
            catch(IndexOutOfRangeException)
            {

            }
            catch
            {

            }

        }

        private void checkIsComboBoxEmpty(ComboBox comboBox)
        {
            if (comboBox.Text == "")
            {
                addBorder(comboBox);

                isMandatoryComboboxsEmpty = true;
            }
        }

        private void addBorder(Control comboBox)
        {
            Graphics formGraphics;
            formGraphics = this.CreateGraphics();

            formGraphics.DrawRectangle(
            Pens.Red,
            comboBox.Left - 1,
            comboBox.Top - 1,
            comboBox.Width + 1,
            comboBox.Height + 1);
        }

        private void saveZnoSubject(ComboBox comboBox, NumericUpDown numericUpDown)
        {
            ZnoSubject znoSubject = new ZnoSubject();

            znoSubject.name = comboBox.Text;
            znoSubject.points = (int)numericUpDown.Value;

            znoSubjects.Add(znoSubject);
        }

        private void subjectComboBox_Click(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            comboBox.DroppedDown = true;
        }

        private void subjectComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void subjectPotintsNumericUpDown_KeyUp(object sender, KeyEventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown) sender;
            int value;
            if (int.TryParse(numericUpDown.Text, out value))
            {
                if (value > 200)
                {
                    numericUpDown.Text = "200";
                } 
            }
        }

        private void subjectPotintsNumericUpDown_Leave(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            if(numericUpDown.Value < 100)
            {
                numericUpDown.Value = 100;
            }
        }
    }
}
