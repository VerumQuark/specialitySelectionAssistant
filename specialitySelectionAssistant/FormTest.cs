using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpecialtySelectionAssistantLibrary;

namespace specialitySelectionAssistant
{
    public partial class FormTest : Form
    {
        ProfessionComparationPairs professionComparationPairs = new ProfessionComparationPairs();
        int currentQuestion = 0;
        public FormTest()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            professionComparationPairs.generatePairs();

            label1.Text = "сложно сложно ничего не понятно";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = ProfessionPairStorage.pairs[currentQuestion].firstProfession.name;
            label2.Text = ProfessionPairStorage.pairs[currentQuestion].secondProfession.name;

            currentQuestion++;
        }
    }
}
