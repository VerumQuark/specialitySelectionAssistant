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
    public partial class ProfessionsComparisonQuestionForm : MaterialForm
    {
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

            ProfesionPair question = HollandTest.getQuestion();

            leftProffesionMaterialLabel.Text = question.firstProfession.name;
            rightProffesionMaterialLabel.Text = question.secondProfession.name;

            tempQuestionNumLabel.Text = $"Питання №{HollandTest.CurrentQuestion}";
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
            this.Close();
            new Thread(OpenRegistrationForm).Start();
        }

        private void nextFormMaterialFlatButton_Click(object sender, EventArgs e)
        {
            if (HollandTest.isLastQuestion)     //REWORK///////////////////////////////////////
            {
                this.Close();
                new Thread(OpenListQuestionForm).Start();
            }

            ProfesionPair question = HollandTest.getQuestion();

            leftProffesionMaterialLabel.Text = question.firstProfession.name;
            rightProffesionMaterialLabel.Text = question.secondProfession.name;

            
            tempQuestionNumLabel.Text = $"Питання №{HollandTest.CurrentQuestion}";
            this.Text = $"Питання №{HollandTest.CurrentQuestion}";
        }

        private void leftProffesionButton_Click(object sender, EventArgs e)
        {

        }

        private void HelpMaterialFlatButton_Click(object sender, EventArgs e)
        {

        }
    }
}
