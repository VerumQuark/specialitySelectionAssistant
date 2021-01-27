using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;
using specialitySelectionAssistant.Exceptions;
using specialitySelectionAssistant.Tests.Holland;

namespace specialitySelectionAssistant
{
    public partial class HollandTestForm : MaterialForm
    {
        private bool isProfessionChosen = false;
        private Profesion chosenProfesion = new Profesion();
        private ProfesionPair pairQuestion;

        private HollandTest HollandTest = new HollandTest();

        public HollandTestForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange300, Primary.Orange400, Primary.Orange100, Accent.LightBlue200, TextShade.BLACK);
        }

        private void HollandTestFormForm_Load(object sender, EventArgs e)
        {
            if (HollandTest.isFirstQuestion)
            {
                HollandTest.CreateTest();
            }
            else
            {
                HollandTest.answerStack.Pop();
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
                HollandTest.answerStack.Pop();
                HollandTest.PrevQuestion();
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
                HollandTest.answerStack.Push(chosenProfesion.type);

                if (HollandTest.isLastQuestion)
                {
                    HollandTest.SaveTestResult();
                    Navigation.ToUserPreferencesForm(this);
                }
                else
                {
                    leftProffesionMaterialLabel.Focus();
                    HollandTest.NextQuestion();
                    LoadQuestion();
                }
            }
            catch(Exception ex)
            {
                ExceptionHandler.HandleException(ex);
            }
        }

        private void LoadQuestion()
        {
            try
            {
                pairQuestion = HollandTest.currentComparisonQuestion;

                ChangeProfessions(pairQuestion.firstProfession, leftProffesionMaterialLabel, leftProffesionButton);
                ChangeProfessions(pairQuestion.secondProfession, rightProffesionMaterialLabel, rightProfessionButton);

                questionNumLabel.Text = $"Питання {HollandTest.CurrentComparisonQuestionIndex + 1}/" +
                                                $"{Constants.HOLLAND_QUESTION_COUNT}";
            }
            catch(Exception ex) 
            {
                string message = "Неможливо отримати дані. Перевірте цілісність файлів.";
                ExceptionHandler.HandleException(ex, message);
            }
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

        private void Button_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            Button button = (Button)sender;
            button.PerformClick();
            if (e.KeyCode == Keys.Enter) nextFormMaterialFlatButton.PerformClick();
        }

        private void HollandTestForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) nextFormMaterialFlatButton.PerformClick();
        }

        private void leftProffesionMaterialLabel_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { 
                Exception ex = new AnswerNotSelectedException();
                ExceptionHandler.HandleException(ex, "Оберіть одну з професій");
            }
        }
    }
}
