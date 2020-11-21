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

        private void Form2_Load(object sender, EventArgs e)
        {
            HollandTest.Init();

            ProfesionPair question = HollandTest.getQuestion();

            materialLabel1.Text = question.firstProfession.name;
            materialLabel2.Text = question.secondProfession.name;
        }
        public void OpenF1()
        {
            Application.Run(new RegistrationForm());
        }
        public void OpenF3()
        {
            Application.Run(new ListQuestionForm());
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            this.Close();
            new Thread(OpenF1).Start();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            ProfesionPair question = HollandTest.getQuestion();

            materialLabel1.Text = question.firstProfession.name;
            materialLabel2.Text = question.secondProfession.name;

            //this.Close();
            //new Thread(OpenF3).Start();
        }
    }
}
