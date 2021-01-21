using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using specialitySelectionAssistant.Exceptions;

namespace specialitySelectionAssistant.Tests.Holland
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
                try
                {
                    if (value >= Constants.COMPARATION_QUESTION_COUNT)
                    {
                        isLastQuestion = true;
                        currentComparisonQuestionIndex = Constants.COMPARATION_QUESTION_COUNT - 1;

                        throw new RangeException();
                    }
                    else if(value < 0)
                    {
                        isFirstQuestion = true;
                        currentComparisonQuestionIndex = 0;

                        throw new RangeException();
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
                catch(RangeException ex)
                {
                    string message = "Holland test. Index assignment error.";
                    ExceptionHandler.CriticalException(ex, message);
                }
                catch(Exception ex)
                {
                    ExceptionHandler.CriticalException(ex);
                }
            }
        }

        static public void NextComparisonQuestion()
        {
            try
            {
                CurrentComparisonQuestionIndex++;
                currentComparisonQuestion = comparisonQuestionsStorage[CurrentComparisonQuestionIndex];
            }
            catch (IndexOutOfRangeException ex)
            {
                string message = "Holland test. Comparison question index error.";
                ExceptionHandler.CriticalException(ex, message);
            }
            catch (Exception ex)
            {
                ExceptionHandler.CriticalException(ex);
            }
        }

        static public void PrevComparisonQuestion()
        {
            try
            {
                CurrentComparisonQuestionIndex--;
                currentComparisonQuestion = comparisonQuestionsStorage[CurrentComparisonQuestionIndex];
            }
            catch (IndexOutOfRangeException ex)
            {
                string message = "Holland test. Comparison question index error.";
                ExceptionHandler.CriticalException(ex, message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ExceptionHandler.CriticalException(ex);
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
            try
            {
                comparisonQuestionsStorage = GenerateComparisonQuestions();
                CurrentComparisonQuestionIndex = 0;
                currentComparisonQuestion = comparisonQuestionsStorage[CurrentComparisonQuestionIndex];
                chosenProfessionsTypesStack.Clear();
            }
            catch (IndexOutOfRangeException ex)
            {
                string message = "Holland test. Comparison question index error.";
                ExceptionHandler.CriticalException(ex, message);
            }
            catch (Exception ex)
            {
                ExceptionHandler.CriticalException(ex);
            }
        }

        static ProfessionPairStorage GenerateComparisonQuestions()
        {
            ProfessionPairGenerator professionPairGenerator = new ProfessionPairGenerator();
            return professionPairGenerator.GeneratePairs();
        }

        static public void SaveTestResult()
        {
            User.hollandResult = new HollandResult();

            foreach(string type in chosenProfessionsTypesStack)
            {
                AddCharacteristicsPoint(type);
            }
        }

        static public void AddCharacteristicsPoint(string type)
        {
            try
            {
                switch (type)
                {
                    case "realistic":
                        {
                            User.hollandResult.Realistic += 1;
                            break;
                        }
                    case "intelligent":
                        {
                            User.hollandResult.Intelligent += 1;
                            break;
                        }
                    case "social":
                        {
                            User.hollandResult.Social += 1;
                            break;
                        }
                    case "conventional":
                        {
                            User.hollandResult.Conventional += 1;
                            break;
                        }
                    case "enterprising":
                        {
                            User.hollandResult.Enterprising += 1;
                            break;
                        }
                    case "artistic":
                        {
                            User.hollandResult.Artistic += 1;
                            break;
                        }
                    default:
                        {
                            throw new UnexpectedHollandTypeException("Holland test.Add characteristics error.");
                        }
                }
            }
            catch(Exception ex)
            {
                string message = "Holland test. Add characteristics error.";
                ExceptionHandler.CriticalException(ex, message);
            }
        }
    }
}