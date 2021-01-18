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
                Navigation.toRegistrationForm(this);
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
                    Navigation.toListQuestionsForm(this);
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

            questionNumLabel.Text = $"Питання №{HollandTest.CurrentComparisonQuestionIndex + 1}";
        }

        private void changeProfessions(Profesion profesion, MaterialLabel proffesionLabel, Button proffesionButton)
        {
            ResourceManager rm = Properties.Resources.ResourceManager;
            Image proffesionImg = (Image)rm.GetObject(profesion.img);

            proffesionLabel.Text = profesion.name;
            proffesionButton.BackgroundImage = proffesionImg;
        }

        private void HelpMaterialFlatButton_Click(object sender, EventArgs e)
        {
            Navigation.toHelpForm(this);
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

        private void skipButton_Click(object sender, EventArgs e)
        {
            HollandTest.skipTest();
            Navigation.toListQuestionsForm(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HollandTest.skipTest();
            Navigation.toListQuestionsForm(this);
        }

        private void ProfessionsComparisonQuestionForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) nextFormMaterialFlatButton.PerformClick();
        }

        private void leftProffesionButton_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) nextFormMaterialFlatButton.PerformClick();
        }

        private void rightProfessionButton_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) nextFormMaterialFlatButton.PerformClick();
        }
    }
}
