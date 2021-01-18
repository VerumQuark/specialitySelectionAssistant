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
            try 
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BackMaterialFlatButton_Click(object sender, EventArgs e)
        {
            Navigation.ToRegistrationForm(this);
        }

        private void HelpMaterialFlatButton_Click(object sender, EventArgs e)
        {
            Navigation.ToHelpForm(this);
        }

        private void NextMaterialFlatButton_Click(object sender, EventArgs e)
        {
            SaveZnoSubjects();

            if (isMandatoryComboboxsEmpty)
            {
                MessageBox.Show($"Оберіть {Constants.MANDATORY_SUBJECTS_COUNT} обов'язкових предмети");
                isMandatoryComboboxsEmpty = false;
            }
            else
            {
                PreferredSpecialtiesDeterminant.SetZnoSubjects(znoSubjects);
                Navigation.ToComparisonQuestionForm(this);
            }
        }

        private void SaveZnoSubjects()
        {
            znoSubjects = new List<ZnoSubject>();
            try
            {
                for (int i = 0; i < Constants.MANDATORY_SUBJECTS_COUNT; i++)
                {
                    CheckIsComboBoxEmpty(comboBoxesArr[i]);
                }

                for (int i = 0; i < Constants.SUBJECT_COUNT; i++)
                {
                    SaveZnoSubject(comboBoxesArr[i], numericUpDownsArr[i]);
                }
            }
            catch(IndexOutOfRangeException)
            {
                MessageBox.Show("Internal error. Required form objects are missing.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void CheckIsComboBoxEmpty(ComboBox comboBox)
        {
            if (comboBox.Text == "")
            {
                AddBorder(comboBox);

                isMandatoryComboboxsEmpty = true;
            }
        }

        private void AddBorder(Control comboBox)
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

        private void SaveZnoSubject(ComboBox comboBox, NumericUpDown numericUpDown)
        {
            ZnoSubject znoSubject = new ZnoSubject
            {
                name = comboBox.Text,
                points = (int)numericUpDown.Value
            };

            znoSubjects.Add(znoSubject);
        }

        private void SubjectComboBox_Click(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            comboBox.DroppedDown = true;
        }

        private void SubjectComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void SubjectPotintsNumericUpDown_KeyUp(object sender, KeyEventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown) sender;
            if (int.TryParse(numericUpDown.Text, out int value))
            {
                if (value > 200)
                {
                    numericUpDown.Text = "200";
                }
            }
        }

        private void SubjectPotintsNumericUpDown_Leave(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            if(numericUpDown.Value < 100)
            {
                numericUpDown.Value = 100;
            }
        }
    }
}
