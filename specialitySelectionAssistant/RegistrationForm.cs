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
            string name = NameMaterialSingleLineTextField.Text;
            bool budget = BudgetMaterialCheckBox.Checked;
            bool contract = ContractMaterialCheckBox.Checked;
            bool haveZno = ZnoMaterialCheckBox.Checked;

            User.setName(name);
            preferredSpecialtiesDeterminant.setEducationForm(budget, contract, haveZno);

            Navigation.startTest(haveZno, this);
        }

        private void helpMaterialFlatButton_Click(object sender, EventArgs e)
        {
            Navigation.openHelpForm(this);
        }
    }
}
