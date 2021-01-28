using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace specialitySelectionAssistant.Utility
{
    static class Navigation
    {
        static Form prevForm;
        static Form hollandForm;

        static public void StartTest(bool haveResult, Form form)
        {
            if (haveResult)
            {
                ChangeForm(new ZnoForm(), form);
            }
            else
            {
                ToHollandTestForm(form);
            }
        }

        static public void ToRegistrationForm(Form form)
        {
            ChangeForm(new RegistrationForm(), form);
        }

        static public void ToUserPreferencesForm(Form form)
        {
            hollandForm = form;

            Program.Context.MainForm = new UserPreferencesForm();
            hollandForm.Hide();
            Program.Context.MainForm.Show();
        }

        static public void ToHollandTestForm(Form form)
        {
            ChangeForm(new HollandTestForm(), form);
        }

        static public void backToHollandTestForm(Form form)
        {
            ChangeForm(hollandForm, form);
        }

        static public void ToResultForm(Form form)
        {
            ChangeForm(new TestResultForm(), form);
        }
        
        static public void ToHelpForm(Form form)
        {
            ChangeHelpForm(new HelpForm(), form);
        }

        static public void ToAboutForm(Form form)
        {
            ChangeHelpForm(new AboutForm(), form);
        }

        static public void ToPrevForm(Form form)
        {
            ChangeForm(prevForm, form);
        }

        private static void ChangeForm(Form formToOpen, Form formToClose)
        {
            Program.Context.MainForm = formToOpen;
            Program.Context.MainForm.Show();
            formToClose.Close();
        }

        private static void ChangeHelpForm(Form formToOpen, Form formToHide)
        {
            if (formToHide is HelpForm == false &&
                formToHide is AboutForm == false   ) prevForm = formToHide;

            Program.Context.MainForm = formToOpen;
            Program.Context.MainForm.Show();
            formToHide.Hide();
        }

    }
}
