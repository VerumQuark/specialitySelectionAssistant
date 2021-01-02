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
using System.Threading;
using SpecialtySelectionAssistantLibrary;
using System.Resources;

namespace specialitySelectionAssistant
{
    public partial class ProfessionsComparisonQuestionForm : MaterialForm
    {
        bool isProfessionChosen = false;
        profesion chosenProfesion = new profesion();
        Question question;

        public ProfessionsComparisonQuestionForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange300, Primary.Orange400, Primary.Orange100, Accent.LightBlue200, TextShade.BLACK);
        }

        private void ProfessionsComparisonQuestionForm_Load(object sender, EventArgs e)
        {
            loadQuestion();
        }

        private void BackMaterialFlatButton_Click(object sender, EventArgs e)
        {
            /////////////////////////////////UNDER_CONSTRUCTION///////////////////////////////////////
        }

        private void nextFormMaterialFlatButton_Click(object sender, EventArgs e)
        {
            Navigation.nextForm(this, isProfessionChosen);
        }

        private void loadQuestion()
        {
            question = HollandTest.currentQuestion;

            changeProfessions(question.profesionPair.firstProfession, leftProffesionMaterialLabel, leftProffesionButton);
            changeProfessions(question.profesionPair.secondProfession, rightProffesionMaterialLabel, rightProfessionButton);

            tempQuestionNumLabel.Text = $"Питання №{HollandTest.CurrentQuestionIndex}";
        }

        private void changeProfessions(profesion profesion, MaterialLabel proffesionLabel, Button proffesionButton)
        {
            ResourceManager rm = Properties.Resources.ResourceManager;
            Image proffesionImg = (Image)rm.GetObject(profesion.img);

            proffesionLabel.Text = profesion.name;
            proffesionButton.BackgroundImage = proffesionImg;
        }

        private void HelpMaterialFlatButton_Click(object sender, EventArgs e)
        {

        }

        private void leftProfessionButton_Click(object sender, EventArgs e)
        {
            isProfessionChosen = true;
            chosenProfesion = question.profesionPair.firstProfession;
        }

        private void rightProfessionButton_Click(object sender, EventArgs e)
        {
            isProfessionChosen = true;
            chosenProfesion = question.profesionPair.secondProfession;
        }
    }
}
