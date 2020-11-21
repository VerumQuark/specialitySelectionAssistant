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
using MaterialSkin.Controls;
using MaterialSkin;

namespace specialitySelectionAssistant
{
    public partial class RegistrationForm : MaterialForm
    {
        public RegistrationForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange300, Primary.Orange400, Primary.Orange100, Accent.LightBlue200, TextShade.BLACK);
        }


        private FormWindowState windowState;

        public FormWindowState GetWindowState()
        {
            return windowState;
        }

        public void SetWindowState(FormWindowState value)
        {
            windowState = value;
        }

        public void OpenF2()
        {
            Application.Run(new ProfessionsComparisonQuestionForm());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void materialCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void materialCheckBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            new Thread(OpenF2).Start();
        }
    }
}
