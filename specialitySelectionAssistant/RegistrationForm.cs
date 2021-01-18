using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MaterialSkin.Controls;
using MaterialSkin;
using SpecialtySelectionAssistantLibrary;
using System.Text.RegularExpressions;

namespace specialitySelectionAssistant
{
    public partial class RegistrationForm : MaterialForm
    {
        public RegistrationForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange300, Primary.Orange400, Primary.Orange100, Accent.LightBlue200, TextShade.BLACK);
        }

        private void nextMaterialFlatButton_Click(object sender, EventArgs e)
        {
            try
            {
                checkNameField();

                string name = NameMaterialSingleLineTextField.Text;
                bool budget = BudgetMaterialCheckBox.Checked;
                bool contract = ContractMaterialCheckBox.Checked;
                bool haveZno = ZnoMaterialCheckBox.Checked;

                User.setName(name);
                preferredSpecialtiesDeterminant.setEducationForm(budget, contract, haveZno);

                Navigation.startTest(haveZno, this);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void helpMaterialFlatButton_Click(object sender, EventArgs e)
        {
            Navigation.toHelpForm(this);
        }

        private void NameMaterialSingleLineTextField_KeyPress(object sender, KeyPressEventArgs e)
        {
            string pattern = "[А-ЩЬЮЯҐЄІЇа-щьюяґєії\\b'`’ʼ -]";
            string inputValue = e.KeyChar.ToString();

            if (Regex.IsMatch(inputValue, pattern, RegexOptions.IgnoreCase) == false)
            {
                addNameBorder(Pens.Red);
                nameEnterErrorLabel.Visible = true;
                e.Handled = true;
            }
            else
            {
                addNameBorder(Pens.White);
                nameEnterErrorLabel.Visible = false;
            }
        }

        private void addNameBorder(Pen pen)
        {
            Graphics formGraphics;
            formGraphics = this.CreateGraphics();

            formGraphics.DrawRectangle(
            pen,
            NameMaterialSingleLineTextField.Left - 1,
            NameMaterialSingleLineTextField.Top - 1,
            NameMaterialSingleLineTextField.Width + 1,
            NameMaterialSingleLineTextField.Height + 1); ;
        }

        private void checkNameField()
        {
            string pattern = "^\\s*$";
            string inputValue = NameMaterialSingleLineTextField.Text;

            if (Regex.IsMatch(inputValue, pattern, RegexOptions.IgnoreCase))
            {
                addNameBorder(Pens.Red);
                throw new Exception("Введіть ПІБ");
            }
        }
    }
}
