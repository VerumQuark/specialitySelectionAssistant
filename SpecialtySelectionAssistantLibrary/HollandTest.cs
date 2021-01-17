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
                catch(RangeException)
                {
                    Console.WriteLine("Holland test.Index assignment error.");
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        static public void nextComparisonQuestion()
        {
            try
            {
                CurrentComparisonQuestionIndex++;
                currentComparisonQuestion = comparisonQuestionsStorage[CurrentComparisonQuestionIndex];
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Holland test. Comparison index error.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static public void prevComparisonQuestion()
        {
            try
            {
                CurrentComparisonQuestionIndex--;
                currentComparisonQuestion = comparisonQuestionsStorage[CurrentComparisonQuestionIndex];
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Holland test. Comparison index error.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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
                comparisonQuestionsStorage = generateComparisonQuestions();
                CurrentComparisonQuestionIndex = 0;
                currentComparisonQuestion = comparisonQuestionsStorage[CurrentComparisonQuestionIndex];
                chosenProfessionsTypesStack.Clear();
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Holland test. Comparison index error.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
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

        static public void skipTest()
        {
            HollandResult skip = new HollandResult();

            skip.artistic = 10;
            skip.conventional = 6;
            skip.enterprising = 8;
            skip.intelligent = 2;
            skip.realistic = 0;
            skip.social = 4;

            User.hollandResult = skip;
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
                        Console.WriteLine("Holland test. Add characteristics error.");
                        break;
                    }
            }
        }
    }
}