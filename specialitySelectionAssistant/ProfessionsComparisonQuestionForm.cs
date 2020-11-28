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
        ProfesionPair question;

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
            HollandTest.Init();

            changeQuestion();
        }
        public void OpenRegistrationForm()
        {
            Application.Run(new RegistrationForm());
        }
        public void OpenListQuestionForm()
        {
            Application.Run(new ListQuestionForm());
        }

        private void BackMaterialFlatButton_Click(object sender, EventArgs e)
        {
            this.Close();/////////////////////////////////REWORK///////////////////////////////////////
            new Thread(OpenRegistrationForm).Start();
        }

        private void nextFormMaterialFlatButton_Click(object sender, EventArgs e)
        {
            if (isProfessionChosen)
            {
                isProfessionChosen = false;

                HollandTest.addCharacteristicsPoint(chosenProfesion);

                if (HollandTest.isLastQuestion)     //REWORK///////////////////////////////////////
                {
                    this.Close();
                    new Thread(OpenListQuestionForm).Start();
                }

                changeQuestion();

                chosenProfesion = new profesion();
            }

            else
            {
                MessageBox.Show("Оберіть одну з професій");
            }
        }

        private void changeQuestion ()
        {
            question = HollandTest.getQuestion();

            changeProfessions(question.firstProfession, leftProffesionMaterialLabel, leftProffesionButton);
            changeProfessions(question.secondProfession, rightProffesionMaterialLabel, rightProfessionButton);

            tempQuestionNumLabel.Text = $"Питання №{HollandTest.CurrentQuestion}";
        }

        private void changeProfessions(profesion profesion, MaterialLabel proffesionLabel, Button proffesionButton)
        {
            ResourceManager rm = Properties.Resources.ResourceManager;
            Image proffesionImg = (Image)rm.GetObject(profesion.img);

            proffesionLabel.Text = profesion.name;
            proffesionButton.BackgroundImage = proffesionImg;
        }

        private void leftProffesionButton_Click(object sender, EventArgs e)
        {
            isProfessionChosen = true;
            chosenProfesion = question.firstProfession;
        }

        private void HelpMaterialFlatButton_Click(object sender, EventArgs e)
        {

        }

        private void leftProfessionButton_Click(object sender, EventArgs e)
        {
            isProfessionChosen = true;
            chosenProfesion = question.firstProfession;
        }

        private void rightProfessionButton_Click(object sender, EventArgs e)
        {
            isProfessionChosen = true;
            chosenProfesion = question.secondProfession;
        }
    }
}
