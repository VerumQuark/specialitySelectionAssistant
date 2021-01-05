﻿using MaterialSkin;
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
            faculty = FacultiesMinDeviation.getFaculty(User.hollandResult);
            UserPreferencesTest.createTest(faculty);
            isAnswerChosen = false;
        }

        private void loadQuestion()
        {
            string question = UserPreferencesTest.currentListQuestion;

            listQuestionQuestionLabel.Text = question;            

            veryLikeMaterialRadioButton.Checked = false;
            ratherSoMaterialRadioButton.Checked = false;
            cantAnswerMaterialRadioButton.Checked = false;
            ratherNotMaterialRadioButton.Checked = false;
            veryDislikeMaterialRadioButton.Checked = false;

            isAnswerChosen = false;
        }

        private void backMaterialFlatButton_Click(object sender, EventArgs e)
        {
 
            if (UserPreferencesTest.isFirstQuestion)
            {
                Navigation.backToComparisonQuestionForm(this);
            }
            else
            {
                UserPreferencesTest.userPreferencesStack.Pop();
                UserPreferencesTest.prevQuestion();
                loadQuestion();
            }
        }

        private void nextMaterialFlatButton_Click(object sender, EventArgs e)
        {
            if (isAnswerChosen)
            {
                chosenUserPreference.specialtyIndex = UserPreferencesTest.currentSpecialityIndex;
                UserPreferencesTest.userPreferencesStack.Push(chosenUserPreference);

                if (UserPreferencesTest.isLastQuestion)
                {
                    UserPreferencesTest.saveTestResult();
                    preferredSpecialtiesDeterminant.setSpecialties(UserPreferencesTest.resultSpecialties);
                    Navigation.goToResultForm(this);
                }
                else
                {
                    UserPreferencesTest.nextQuestion();
                    loadQuestion();
                }

            }
            else
            {
                MessageBox.Show("Оберіть один з варіантів");
            }
        }

        private void helpMaterialFlatButton_Click(object sender, EventArgs e)
        {
            //REWORK
        }

        private void veryLikeMaterialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            isAnswerChosen = true;
            chosenUserPreference.preferenceValue = 2;
        }

        private void ratherSoMaterialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            isAnswerChosen = true;
            chosenUserPreference.preferenceValue = 1;
        }

        private void cantAnswerMaterialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            isAnswerChosen = true;
            chosenUserPreference.preferenceValue = 0;
        }

        private void ratherNotMaterialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            isAnswerChosen = true;
            chosenUserPreference.preferenceValue = -1;
        }

        private void veryDislikeMaterialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            isAnswerChosen = true;
            chosenUserPreference.preferenceValue = -2;
        }
    }
}
