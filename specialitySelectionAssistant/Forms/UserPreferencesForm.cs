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
using specialitySelectionAssistant.Exceptions;
using specialitySelectionAssistant.Tests.UserPreference;
using specialitySelectionAssistant.Tests;

namespace specialitySelectionAssistant
{
    public partial class UserPreferencesForm : MaterialForm
    {
        Faculty faculty;
        bool isAnswerChosen;
        UserPreference chosenUserPreference;

        public UserPreferencesForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange300, Primary.Orange400, Primary.Orange100, Accent.LightBlue200, TextShade.BLACK);
        }

        private void UserPreferencesForm_Load(object sender, EventArgs e)
        {
            faculty = FacultiesMinDeviation.GetFaculty(User.hollandResult);
            UserPreferencesTest.CreateTest(faculty);

            foreach (Control control in this.Controls)
            {
                control.PreviewKeyDown += new PreviewKeyDownEventHandler(control_PreviewKeyDown);
            }

            foreach(RadioButton radioButton in this.Controls.OfType<RadioButton>())
            {
                radioButton.PreviewKeyDown -= control_PreviewKeyDown;
            }

            LoadQuestion();
        }

        void control_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                veryLikeMaterialRadioButton.Focus();
            }
        }

        private void LoadQuestion()
        {
            try
            {
                string question = UserPreferencesTest.currentListQuestion;

                listQuestionQuestionLabel.Text = question;
                isAnswerChosen = false;
            }
            catch (Exception ex)
            {
                string message = "Неможливо отримати дані. Перевірте цілісність файлів.";
                ExceptionHandler.HandleException(ex, message);
            }
        }

        private void BackMaterialFlatButton_Click(object sender, EventArgs e)
        {
 
            if (UserPreferencesTest.isFirstQuestion)
            {
                Navigation.ToHollandTestForm(this);
            }
            else
            {
                UserPreferencesTest.userPreferencesStack.Pop();
                UserPreferencesTest.PrevQuestion();
                LoadQuestion();
            }
        }

        private void NextMaterialFlatButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (isAnswerChosen == false)
                {
                    throw new AnswerNotSelectedException("Оберіть один із варіантів");
                }

                chosenUserPreference.specialtyIndex = UserPreferencesTest.currentSpecialityIndex;
                UserPreferencesTest.userPreferencesStack.Push(chosenUserPreference);

                if (UserPreferencesTest.isLastQuestion)
                {
                    UserPreferencesTest.SaveTestResult();
                    PreferredSpecialtiesDeterminant.SetSpecialties(UserPreferencesTest.resultSpecialties);
                    Navigation.ToResultForm(this);
                }
                else
                {
                    UserPreferencesTest.NextQuestion();
                    LoadQuestion();
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex);
            }
        }

        private void HelpMaterialFlatButton_Click(object sender, EventArgs e)
        {
            Navigation.ToHelpForm(this);
        }

        private void MaterialRadioButton_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nextMaterialFlatButton.Focus();
                nextMaterialFlatButton.PerformClick();
            }
        }
        private void VeryLikeMaterialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            isAnswerChosen = true;
            chosenUserPreference.preferenceValue = 2;
        }

        private void RatherSoMaterialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            isAnswerChosen = true;
            chosenUserPreference.preferenceValue = 1;
        }

        private void CantAnswerMaterialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            isAnswerChosen = true;
            chosenUserPreference.preferenceValue = 0;
        }

        private void RatherNotMaterialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            isAnswerChosen = true;
            chosenUserPreference.preferenceValue = -1;
        }

        private void VeryDislikeMaterialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            isAnswerChosen = true;
            chosenUserPreference.preferenceValue = -2;
        }

        private void veryLikeMaterialRadioButton_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Left)
            {
                veryDislikeMaterialRadioButton.Focus();
                e.IsInputKey = true;
            }
        }

        private void veryDislikeMaterialRadioButton_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Right)
            {
                veryLikeMaterialRadioButton.Focus();
                e.IsInputKey = true;
            }
        }

        private void UserPreferencesForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) nextMaterialFlatButton.PerformClick();
        }
    }
}
