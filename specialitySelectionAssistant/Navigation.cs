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

        static public void StartTest(bool haveResult, Form form)
        {
            if (haveResult)
            {
                ChangeForm(new ZnoForm(), form);
            }
            else
            {
                ToComparisonQuestionForm(form);
            }
        }

        static public void ToRegistrationForm(Form form)
        {
            ChangeForm(new RegistrationForm(), form);
        }

        static public void ToListQuestionsForm(Form form)
        {
            ChangeForm(new ListQuestionForm(), form);
        }

        static public void ToComparisonQuestionForm(Form form)
        {
            ChangeForm(new ProfessionsComparisonQuestionForm(), form);
        }

        static public void ToResultForm(Form form)
        {
            ChangeForm(new TestResultForm(), form);
        }
        
        static public void ToHelpForm(Form form)
        {
            prevForm = form;

            Program.Context.MainForm = new HelpForm();
            prevForm.Hide();
            Program.Context.MainForm.Show();
        }

        static public void ToPrevForm(Form form)
        {
            ChangeForm(prevForm, form);
        }

        private static void ChangeForm(Form formToOpen, Form formToClose)
        {
            Program.Context.MainForm = formToOpen;
            formToClose.Close();
            Program.Context.MainForm.Show();
        }

    }/////////REWORK
}
