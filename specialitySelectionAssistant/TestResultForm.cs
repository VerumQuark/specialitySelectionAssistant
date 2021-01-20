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

        private void TestResultForm_Load(object sender, EventArgs e)
        {
            List<Specialty> specialties = PreferredSpecialtiesDeterminant.GetDetermineSpecialties();

            titleLabel.Text = $"{User.name}, за результатами тесту вам більш підходять такі спеціальності як:";

            //REWORK
            firstSpecialtyNameMaterialLabel.Text = specialties[0].name;
            firstSpecialtyDescriptionLabel.Text = specialties[0].description;
            firstSpecialtyProfessionsLabel.Text = GetProfessionsStr(specialties[0].professions);

            secondSpecialtyNameMaterialLabel.Text = specialties[1].name;
            secondSpecialtyDescriptionLabel.Text = specialties[1].description;
            secondSpecialtyProfessionsLabel.Text = GetProfessionsStr(specialties[1].professions);

            thirdSpecialtyNameMaterialLabel.Text = specialties[2].name;
            thirdSpecialtyDescriptionLabel.Text = specialties[2].description;
            thirdSpecialtyProfessionsLabel.Text = GetProfessionsStr(specialties[2].professions);
        }

        private string GetProfessionsStr(string[] professions)
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

        private void HelpMaterialFlatButton_Click(object sender, EventArgs e)
        {
            Navigation.ToHelpForm(this);
        }

        private void CloseMaterialFlatButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
