using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialtySelectionAssistantLibrary
{
    public static class HollandTest
    {
        static public bool isLastQuestion;
        static public bool isFirstQuestion;

        static ProfessionPairStorage comparisonQuestionsStorage;
        static public ProfesionPair currentComparisonQuestion;
        
        static public Stack<string> chosenProfessionsTypesStack;

        static private int currentComparisonQuestionIndex;

        static public int CurrentComparisonQuestionIndex
        {
            get
            {
                return currentComparisonQuestionIndex;
            }

            set
            {
                if (value > Constants.COMPARATION_QUESTION_COUNT)
                {
                    //error
                    //currentQuestion = 0;
                }
                else
                {
                    if (value == Constants.COMPARATION_QUESTION_COUNT - 1)
                    {
                        isLastQuestion = true;
                    }
                    else if (value == 0)
                    {
                        isFirstQuestion = true;
                    }
                    else
                    {
                        isFirstQuestion = false;
                        isLastQuestion = false;
                    }


                    currentComparisonQuestionIndex = value;
                }
            }
        }

        static public void nextComparisonQuestion()
        {
            CurrentComparisonQuestionIndex++;
            currentComparisonQuestion = comparisonQuestionsStorage[CurrentComparisonQuestionIndex];

            if(CurrentComparisonQuestionIndex == Constants.COMPARATION_QUESTION_COUNT)
            {
                isLastQuestion = true;
            }
        }

        static public void prevComparisonQuestion()
        {
            CurrentComparisonQuestionIndex--;
            currentComparisonQuestion = comparisonQuestionsStorage[CurrentComparisonQuestionIndex];

            if (CurrentComparisonQuestionIndex == 0)
            {
                isFirstQuestion = true;
            }
        }

        static HollandTest()
        {
            isLastQuestion = false;
            isFirstQuestion = false;
            chosenProfessionsTypesStack = new Stack<string>();

            CreateTest();
        }

        static public void CreateTest()
        {
            comparisonQuestionsStorage = generateComparisonQuestions();
            CurrentComparisonQuestionIndex = 0;
            currentComparisonQuestion = comparisonQuestionsStorage[CurrentComparisonQuestionIndex];
            chosenProfessionsTypesStack.Clear();
        }

        static ProfessionPairStorage generateComparisonQuestions()
        {
            ProfessionPairGenerator professionPairGenerator = new ProfessionPairGenerator();
            return professionPairGenerator.generatePairs();
        }

        static public void saveTestResult()
        {
            foreach(string type in chosenProfessionsTypesStack)
            {
                addCharacteristicsPoint(type);
            }
        }

        static public void addCharacteristicsPoint(string type)
        {
            switch (type)
            {
                case "realistic":
                    {
                        User.hollandResult.realistic += 1;
                        break;
                    }
                case "intelligent":
                    {
                        User.hollandResult.intelligent += 1;
                        break;
                    }
                case "social":
                    {
                        User.hollandResult.social += 1;
                        break;
                    }
                case "conventional":
                    {
                        User.hollandResult.conventional += 1;
                        break;
                    }
                case "enterprising":
                    {
                        User.hollandResult.enterprising += 1;
                        break;
                    }
                case "artistic":
                    {
                        User.hollandResult.artistic += 1;
                        break;
                    }
                default:
                    {
                        /////////UNDER CONSTRUCTION////////////REWORK
                        break;
                    }
            }
        }
    }
}