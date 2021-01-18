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

            //REWORK
            firstSpecialtyNameMaterialLabel.Text = specialties[0].name;
            firstSpecialtyDescriptionLabel.Text = specialties[0].description;
            firstSpecialtyProfessionsLabel.Text = getProfessionsStr(specialties[0].professions);

            secondSpecialtyNameMaterialLabel.Text = specialties[1].name;
            secondSpecialtyDescriptionLabel.Text = specialties[1].description;
            secondSpecialtyProfessionsLabel.Text = getProfessionsStr(specialties[1].professions);

            thirdSpecialtyNameMaterialLabel.Text = specialties[2].name;
            thirdSpecialtyDescriptionLabel.Text = specialties[2].description;
            thirdSpecialtyProfessionsLabel.Text = getProfessionsStr(specialties[2].professions);
        }

        private string getProfessionsStr(string[] professions)
        {

            string specialtyProffesions = "Професії: ";
            int professionLenght = professions.Length - 1;

            for (int i = 0; i < professionLenght; i++)
            {
                specialtyProffesions += professions[i] + ", ";
            }

            specialtyProffesions += professions.Last() + ".";

            return specialtyProffesions;
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
