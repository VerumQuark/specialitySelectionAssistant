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
        public ZnoForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange300, Primary.Orange400, Primary.Orange100, Accent.LightBlue200, TextShade.BLACK);
        }

        private void backMaterialFlatButton_Click(object sender, EventArgs e)
        {
            Navigation.toRegistrationForm(this);
        }

        private void nextMaterialFlatButton_Click(object sender, EventArgs e)
        {

            Navigation.toComparisonQuestionForm(this);
        }

        private void ZnoForm_Load(object sender, EventArgs e)
        {
            firstSubjectComboBox.Items.AddRange(Constants.FIRST_ZNO_SUBJECTS);
            secondSubjectComboBox.Items.AddRange(Constants.SECOND_ZNO_SUBJECTS);
            thirdSubjectComboBox.Items.AddRange(Constants.THIRD_ZNO_SUBJECTS);
            fourthSubjectComboBox.Items.AddRange(Constants.OTHER_ZNO_SUBJECTS);
            fifthSubjectComboBox.Items.AddRange(Constants.OTHER_ZNO_SUBJECTS);

            foreach (NumericUpDown numericUpDown in this.Controls.OfType<NumericUpDown>())
            {
                numericUpDown.Maximum = 200;
                numericUpDown.Minimum = 100;
                ((TextBox)numericUpDown.Controls[1]).MaxLength = 3;
            }
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

        private void helpMaterialFlatButton_Click(object sender, EventArgs e)
        {
            Navigation.toHelpForm(this);
        }

        private void subjectComboBox_Click(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            comboBox.DroppedDown = true;
        }
    }
}
