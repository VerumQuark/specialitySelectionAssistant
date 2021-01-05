using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using SpecialtySelectionAssistantLibrary;

namespace specialitySelectionAssistant
{
    static class Navigation
    {
        static public void startTest(bool haveResult, Form form)
        {
            if (haveResult)
            {
                //new Thread(OpenZnoForm).Start();
            }
            else
            {
                Program.Context.MainForm = new ProfessionsComparisonQuestionForm();
                form.Close();
                Program.Context.MainForm.Show();
            }
        }

        static public void backToRegistrationForm(Form form)
        {
            Program.Context.MainForm = new RegistrationForm();
            form.Close();
            Program.Context.MainForm.Show();
        }

        static public void goToListQuestionsForm(Form form)
        {
            Program.Context.MainForm = new ListQuestionForm();
            form.Close();
            Program.Context.MainForm.Show();
        }

        static public void backToComparisonQuestionForm(Form form)
        {
            Program.Context.MainForm = new ProfessionsComparisonQuestionForm();
            form.Close();
            Program.Context.MainForm.Show();
        }

        static public void goToResultForm(Form form)
        {
            Program.Context.MainForm = new TestResultForm();
            form.Close();
            Program.Context.MainForm.Show();
        }
        
        static public void openHelpForm(Form form)
        {
            //Program.Context.MainForm = new HelpForm();
            form.Close();
            Program.Context.MainForm.Show();
        }
        
    }/////////REWORK
}
