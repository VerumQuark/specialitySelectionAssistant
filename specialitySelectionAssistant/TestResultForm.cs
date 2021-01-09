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
    public partial class TestResultForm : MaterialForm
    {
        public TestResultForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange300, Primary.Orange400, Primary.Orange100, Accent.LightBlue200, TextShade.BLACK);
        }

        private void testResultForm_Load(object sender, EventArgs e)
        {
            List<Specialty> specialties = preferredSpecialtiesDeterminant.getDetermineSpecialties();

            firstSpecialtyNameMaterialLabel.Text = specialties[0].name;
            secondSpecialtyNameMaterialLabel.Text = specialties[1].name;
            thirdSpecialtyNameMaterialLabel.Text = specialties[2].name;
        }

        private void helpMaterialFlatButton_Click(object sender, EventArgs e)
        {
            Navigation.toHelpForm(this);
        }

        private void closeMaterialFlatButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
