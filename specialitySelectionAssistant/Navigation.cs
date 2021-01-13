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
        static Form prevForm;

        static public void startTest(bool haveResult, Form form)
        {
            if (haveResult)
            {
                changeForm(new ZnoForm(), form);
            }
            else
            {
                toComparisonQuestionForm(form);
            }
        }

        static public void toPrevForm(Form form)
        {
            Program.Context.MainForm = prevForm;
            form.Close();
            Program.Context.MainForm.Show();
        }

        static public void toRegistrationForm(Form form)
        {
            changeForm(new RegistrationForm(), form);
        }

        static public void toListQuestionsForm(Form form)
        {
            changeForm(new ListQuestionForm(), form);
        }

        static public void toComparisonQuestionForm(Form form)
        {
            changeForm(new ProfessionsComparisonQuestionForm(), form);
        }

        static public void toResultForm(Form form)
        {
            changeForm(new TestResultForm(), form);
        }
        
        static public void toHelpForm(Form form)
        {
            prevForm = form;

            Program.Context.MainForm = new HelpForm();
            prevForm.Hide();
            Program.Context.MainForm.Show();
        }

        private static void changeForm(Form formToOpen, Form formToClose)
        {
            Program.Context.MainForm = formToOpen;
            formToClose.Close();
            Program.Context.MainForm.Show();
        }

    }/////////REWORK
}
