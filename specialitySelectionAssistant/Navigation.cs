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
        static void OpenTestResultForm()
        {
            Application.Run(new TestResultForm());
        }

        static void OpenCoparationQuestionForm()
        {
            Application.Run(new ProfessionsComparisonQuestionForm());
        }

        static void OpenListQuestionForm()
        {
            Application.Run(new ListQuestionForm());
        }

        static public void nextForm(Form form, bool isQuestionAnswered)
        {
            if (isQuestionAnswered)
            {
                isQuestionAnswered = false;

                form.Close();

                if (HollandTest.currentQuestionIndex == Constants.QUESTION_COUNT)
                {
    //thread ???????????????
                    new Thread(OpenTestResultForm).Start();
                }
            
                else
                {    
                    if (HollandTest.currentQuestion.isListQuestion)
                    {
                        new Thread(OpenListQuestionForm).Start();
                        HollandTest.nextQuestion();
                    }

                    else
                    {
                        new Thread(OpenCoparationQuestionForm).Start();
                        HollandTest.nextQuestion();
                    }
                }

            }
            else
            {
                if (HollandTest.currentQuestion.isListQuestion)
                {
                    MessageBox.Show("Оберіть один з варіантів");
                }
                else
                {
                    MessageBox.Show("Оберіть одну з професій");
                }
            }
        }

        static public void startTest(bool haveResult)
        {
            if (haveResult)
            {
                new Thread(OpenZnoForm).Start();
            }

            else
            {
                new Thread(OpenCoparationQuestionForm).Start();
            }
        }
    }
}
