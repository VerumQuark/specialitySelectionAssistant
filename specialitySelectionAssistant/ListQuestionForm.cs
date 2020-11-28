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

namespace specialitySelectionAssistant
{
    public partial class ListQuestionForm : MaterialForm
    {
        public ListQuestionForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange300, Primary.Orange400, Primary.Orange100, Accent.LightBlue200, TextShade.BLACK);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        public void OpenF2()
        {
            Application.Run(new ProfessionsComparisonQuestionForm());
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            this.Close();
            new Thread(OpenF2).Start();
        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
