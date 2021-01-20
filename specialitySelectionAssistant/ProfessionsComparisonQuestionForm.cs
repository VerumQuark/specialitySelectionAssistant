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
        Profesion chosenProfesion = new Profesion();
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
            if (HollandTest.isFirstQuestion)
            {
                HollandTest.CreateTest();
            }
            else
            {
                HollandTest.chosenProfessionsTypesStack.Pop();
            }

            foreach (Control control in this.Controls)
            {
                control.PreviewKeyDown += new PreviewKeyDownEventHandler(control_PreviewKeyDown);
            }

            LoadQuestion();
        }

        void control_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                e.IsInputKey = true;
            }
        }

        private void BackMaterialFlatButton_Click(object sender, EventArgs e)
        {
            isProfessionChosen = false;

            if (HollandTest.isFirstQuestion)
            {
                Navigation.ToRegistrationForm(this);
            }
            else
            {
                HollandTest.chosenProfessionsTypesStack.Pop();
                HollandTest.PrevComparisonQuestion();
                LoadQuestion();
            }
        }

        private void NextFormMaterialFlatButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (isProfessionChosen == false)
                {
                    throw new AnswerNotSelectedException("Оберіть одну з професій");
                }

                isProfessionChosen = false;
                HollandTest.chosenProfessionsTypesStack.Push(chosenProfesion.type);

                if (HollandTest.isLastQuestion)
                {
                    HollandTest.SaveTestResult();
                    Navigation.ToListQuestionsForm(this);
                }
                else
                {
                    nextFormMaterialFlatButton.Focus();
                    HollandTest.NextComparisonQuestion();
                    LoadQuestion();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadQuestion()
        {
            pairQuestion = HollandTest.currentComparisonQuestion;

            ChangeProfessions(pairQuestion.firstProfession, leftProffesionMaterialLabel, leftProffesionButton);
            ChangeProfessions(pairQuestion.secondProfession, rightProffesionMaterialLabel, rightProfessionButton);

            questionNumLabel.Text = $"Питання №{HollandTest.CurrentComparisonQuestionIndex + 1}";
        }

        private void ChangeProfessions(Profesion profesion, MaterialLabel proffesionLabel, Button proffesionButton)
        {
            ResourceManager rm = Properties.Resources.ResourceManager;
            Image proffesionImg = (Image)rm.GetObject(profesion.img);

            proffesionLabel.Text = profesion.name;
            proffesionButton.BackgroundImage = proffesionImg;
        }

        private void HelpMaterialFlatButton_Click(object sender, EventArgs e)
        {
            Navigation.ToHelpForm(this);
        }

        private void LeftProfessionButton_Click(object sender, EventArgs e)
        {
            isProfessionChosen = true;
            chosenProfesion = pairQuestion.firstProfession;
        }

        private void RightProfessionButton_Click(object sender, EventArgs e)
        {
            isProfessionChosen = true;
            chosenProfesion = pairQuestion.secondProfession;
        }

        private void SkipButton_Click(object sender, EventArgs e)
        {
            HollandTest.SkipTest();
            Navigation.ToListQuestionsForm(this);
        }

        private void ProfessionsComparisonQuestionForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) nextFormMaterialFlatButton.PerformClick();
        }

        private void LeftProffesionButton_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) nextFormMaterialFlatButton.PerformClick();
        }

        private void RightProfessionButton_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) nextFormMaterialFlatButton.PerformClick();
        }
    }
}
