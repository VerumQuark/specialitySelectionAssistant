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

namespace specialitySelectionAssistant
{
    public partial class ListQuestionForm : MaterialForm
    {
        Faculty faculty;
        bool isAnswerChosen;
        UserPreference chosenUserPreference;

        public ListQuestionForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange300, Primary.Orange400, Primary.Orange100, Accent.LightBlue200, TextShade.BLACK);
        }

        private void ListQuestionForm_Load(object sender, EventArgs e)
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
            string question = UserPreferencesTest.currentListQuestion;

            listQuestionQuestionLabel.Text = question;            
            isAnswerChosen = false;
        }

        private void BackMaterialFlatButton_Click(object sender, EventArgs e)
        {
 
            if (UserPreferencesTest.isFirstQuestion)
            {
                Navigation.ToComparisonQuestionForm(this);
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
                MessageBox.Show(ex.Message);
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

        private void RatherSoMaterialRadioButton_Click(object sender, EventArgs e)
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

        private void SkipButton_Click(object sender, EventArgs e)
        {
            Stack<UserPreference> s = new Stack<UserPreference>();
            UserPreference u = new UserPreference
            {
                specialtyIndex = 5,
                preferenceValue = 2
            };
            s.Push(u);
            u.specialtyIndex = 4;
            u.preferenceValue = -1;
            s.Push(u);
            u.specialtyIndex = 3;
            u.preferenceValue = 1;
            s.Push(u);
            u.specialtyIndex = 2;
            u.preferenceValue = -2;
            s.Push(u);
            u.specialtyIndex = 1;
            u.preferenceValue = 0;
            s.Push(u);
            u.specialtyIndex = 0;
            u.preferenceValue = 2;
            s.Push(u);

            UserPreferencesTest.userPreferencesStack = s;
            UserPreferencesTest.SaveTestResult();
            PreferredSpecialtiesDeterminant.SetSpecialties(UserPreferencesTest.resultSpecialties);
            Navigation.ToResultForm(this);
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

        private void ListQuestionForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) nextMaterialFlatButton.PerformClick();
        }
    }
}
