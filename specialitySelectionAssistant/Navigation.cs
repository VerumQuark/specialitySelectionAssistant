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
        static System.Windows.Forms.Form prevForm;

        static public void startTest(bool haveResult, Form form)
        {
            if (haveResult)
            {
                Program.Context.MainForm = new ZnoForm();
                form.Close();
                Program.Context.MainForm.Show();
            }
            else
            {
                Program.Context.MainForm = new ProfessionsComparisonQuestionForm();
                form.Close();
                Program.Context.MainForm.Show();
            }
        }

        static public void toPrevForm(System.Windows.Forms.Form form)
        {
            Program.Context.MainForm = prevForm;
            form.Close();
            Program.Context.MainForm.Show();
        }

        static public void toRegistrationForm(System.Windows.Forms.Form form)
        {
            Program.Context.MainForm = new RegistrationForm();
            form.Close();
            Program.Context.MainForm.Show();
        }

        static public void toListQuestionsForm(System.Windows.Forms.Form form)
        {
            Program.Context.MainForm = new ListQuestionForm();
            form.Close();
            Program.Context.MainForm.Show();
        }

        static public void toComparisonQuestionForm(System.Windows.Forms.Form form)
        {
            Program.Context.MainForm = new ProfessionsComparisonQuestionForm();
            form.Close();
            Program.Context.MainForm.Show();
        }

        static public void toResultForm(System.Windows.Forms.Form form)
        {
            Program.Context.MainForm = new TestResultForm();
            form.Close();
            Program.Context.MainForm.Show();
        }
        
        static public void toHelpForm(System.Windows.Forms.Form form)
        {
            prevForm = form;

            Program.Context.MainForm = new HelpForm();
            prevForm.Hide();
            Program.Context.MainForm.Show();
        }
        
    }/////////REWORK
}
