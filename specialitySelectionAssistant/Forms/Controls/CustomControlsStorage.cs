using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using specialitySelectionAssistant.Tests;
using specialitySelectionAssistant.Utility;
using specialitySelectionAssistant.Exceptions;
using System.Drawing;

namespace specialitySelectionAssistant.Forms.Controls
{
    static class CustomControlsStorage
    {
        static public MenuStrip GetCustomMenuStrip()
        {
            MenuStrip CustomMenuStrip = new MenuStrip();

            CustomMenuStrip.Dock = DockStyle.None;
            CustomMenuStrip.BackColor = Color.FromArgb(252, 164, 36);

            ToolStripMenuItem RepeatItem = new ToolStripMenuItem("Повторити тест");
            RepeatItem.Click += RepeatItem_Click;
            CustomMenuStrip.Items.Add(RepeatItem);

            ToolStripMenuItem SaveResultItem = new ToolStripMenuItem("Зберегти результат");
            SaveResultItem.Click += SaveResultItem_Click;
            CustomMenuStrip.Items.Add(SaveResultItem);

            ToolStripMenuItem AboutItem = new ToolStripMenuItem("Про програму");
            AboutItem.Click += AboutItem_Click;
            CustomMenuStrip.Items.Add(AboutItem);

            ToolStripMenuItem DevelopersItem = new ToolStripMenuItem("Розробники");
            DevelopersItem.Click += DevelopersItem_Click;
            CustomMenuStrip.Items.Add(DevelopersItem);

            ToolStripMenuItem HelpResultItem = new ToolStripMenuItem("Довідка");
            HelpResultItem.Click += HelpItem_Click;
            CustomMenuStrip.Items.Add(HelpResultItem);

            return CustomMenuStrip;
        }

        static private void RepeatItem_Click(object sender, EventArgs e)
        {
            User.Reset();
            PreferredSpecialtiesDeterminant.Reset();

            Navigation.ToRegistrationForm(Program.Context.MainForm);
        }

        static private void SaveResultItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Program.Context.MainForm is TestResultForm)
                {
                    TestResultForm resultForm = (TestResultForm)Program.Context.MainForm;

                    resultForm.SaveResultToFile();
                }
                else
                {
                    throw new FormMismatchException();
                }
            }
            catch (FormMismatchException ex)
            {
                string message = "Зберегти результат можливо тільки після проходження тесту.";
                ExceptionHandler.HandleException(ex, message);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex);
            }
        }

        static private void DevelopersItem_Click(object sender, EventArgs e)
        {
            Navigation.ToHelpForm(Program.Context.MainForm);
        }

        static private void HelpItem_Click(object sender, EventArgs e)
        {
            Navigation.ToHelpForm(Program.Context.MainForm);
        }

        static private void AboutItem_Click(object sender, EventArgs e)
        {
            Navigation.ToAboutForm(Program.Context.MainForm);
        }
    }
}
    