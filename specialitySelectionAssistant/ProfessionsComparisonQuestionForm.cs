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
        ProfesionPair pairQuestion;

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
            if(HollandTest.isFirstQuestion)
            {
                HollandTest.CreateTest();
            }
            else
            {
                HollandTest.chosenProfessionsTypesStack.Pop();
            }
            
            loadQuestion();
        }

        private void BackMaterialFlatButton_Click(object sender, EventArgs e)
        {
            isProfessionChosen = false;

            if (HollandTest.isFirstQuestion)
            {
                Navigation.backToRegistrationForm(this);
            }
            else
            {
                HollandTest.chosenProfessionsTypesStack.Pop();
                HollandTest.prevComparisonQuestion();
                loadQuestion();
            }
        }

        private void nextFormMaterialFlatButton_Click(object sender, EventArgs e)
        {
            if (isProfessionChosen)
            {
                isProfessionChosen = false;
                HollandTest.chosenProfessionsTypesStack.Push(chosenProfesion.type);

                if (HollandTest.isLastQuestion)
                {
                    HollandTest.saveTestResult();
                    Navigation.goToListQuestionsForm(this);
                }
                else
                {
                    HollandTest.nextComparisonQuestion();
                    loadQuestion();
                }
                
            }
            else
            {
                MessageBox.Show("Оберіть одну з професій");
            }
        }

        private void loadQuestion()
        {
            pairQuestion = HollandTest.currentComparisonQuestion;

            changeProfessions(pairQuestion.firstProfession, leftProffesionMaterialLabel, leftProffesionButton);
            changeProfessions(pairQuestion.secondProfession, rightProffesionMaterialLabel, rightProfessionButton);
            //
            //
            //  REWORK
            //
            //
            //
            tempQuestionNumLabel.Text = $"Питання №{HollandTest.CurrentComparisonQuestionIndex}";
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
            Navigation.openHelpForm(this);
        }

        private void leftProfessionButton_Click(object sender, EventArgs e)
        {
            isProfessionChosen = true;
            chosenProfesion = pairQuestion.firstProfession;
        }

        private void rightProfessionButton_Click(object sender, EventArgs e)
        {
            isProfessionChosen = true;
            chosenProfesion = pairQuestion.secondProfession;
        }

        private void rightProffesionMaterialLabel_Click(object sender, EventArgs e)
        {
            ///тест
        }
    }
}
