using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialtySelectionAssistantLibrary
{
    public static class HollandTest
    {
        static int currentQuestion = 0;
        static public bool isLastQuestion = false;
        static UserHollandTestResult UserCharacteristics = new UserHollandTestResult();

        static ProfessionComparationPairs professionPairs { get; set; } = new ProfessionComparationPairs();
        static ListQuestions listQuestions { get; set; } = new ListQuestions();

        static Questions questions = new Questions();

        static public int CurrentQuestion
        {
            get
            {
                return currentQuestion;
            }

            set
            {
                if(value > Constants.QUESTION_COUNT)
                {
                    //error
                    //currentQuestion = 0;
                }

                else
                {
                    if (value == Constants.QUESTION_COUNT + 1)
                    {
                        isLastQuestion = true;
                    }

                    currentQuestion = value;
                }
            }
        }

        static public void Init()///////////createest
        {
            CurrentQuestion = 0;
            questions.generateQuestionsArr();

           // professionPairs.generatePairs();
           // listQuestions.generateQuestions();
        }

        static public Question getQuestion()///////////////////////
        {
            return questions.questions[CurrentQuestion++];
        }

        static public void addCharacteristicsPoint(profesion chosenProfesion)
        {
            switch (chosenProfesion.type)
            {
                case "realistic":
                    {
                        UserCharacteristics.realistic += 1;
                        break;
                    }
                case "intelligent":
                    {
                        UserCharacteristics.intelligent += 1;
                        break;
                    }
                case "social":
                    {
                        UserCharacteristics.social += 1;
                        break;
                    }
                case "conventional":
                    {
                        UserCharacteristics.conventional += 1;
                        break;
                    }
                case "enterprising":
                    {
                        UserCharacteristics.enterprising += 1;
                        break;
                    }
                case "artistic":
                    {
                        UserCharacteristics.artistic += 1;
                        break;
                    }
                default:
                    {
                        /////////UNDER CONSTRUCTION////////////
                        break;
                    }
            }
        }
    }
}