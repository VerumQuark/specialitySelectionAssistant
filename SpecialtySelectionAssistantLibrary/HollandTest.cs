using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialtySelectionAssistantLibrary
{
    public static class HollandTest
    {
        static public User user = new User();


































        static QuestionsStorage questionsStorage = generateQuestions();
        static public int currentQuestionIndex = 0;
        static public Question currentQuestion = questionsStorage[currentQuestionIndex];

        static QuestionsStorage generateQuestions()
        {
            ListQuestionsStorage listQuestionsStorage;
            ListQuestionsGenerator listQuestionsGenerator = new ListQuestionsGenerator();

            listQuestionsStorage = listQuestionsGenerator.generateListQuestions();


            ProfessionPairStorage professionPairStorage;
            ProfessionPairGenerator professionPairGenerator = new ProfessionPairGenerator();

            professionPairStorage = professionPairGenerator.generatePairs();


            QuestionsGenerator questionsGenerator = new QuestionsGenerator();

            return questionsGenerator.questionsGenerate(listQuestionsStorage, professionPairStorage);
        }

        static public void nextQuestion()
        {
            currentQuestionIndex++;
            currentQuestion = questionsStorage[currentQuestionIndex];
        }
        
        

        static public bool isLastQuestion = false;
        static UserHollandTestResult UserCharacteristics = new UserHollandTestResult();
        /*
        static ProfessionComparationPairs professionPairs { get; set; } = new ProfessionComparationPairs();
        static ListQuestions listQuestions { get; set; } = new ListQuestions();

        static Questions questions = new Questions();
        */
        static public int CurrentQuestionIndex
        {
            get
            {
                return currentQuestionIndex;
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

                    currentQuestionIndex = value;
                }
            }
        }

        static public void Init()///////////createest
        {
            QuestionsStorage questionsStorage = generateQuestions();

            /*
            CurrentQuestion = 0;
            questions.generateQuestionsArr();*/

            // professionPairs.generatePairs();
            // listQuestions.generateQuestions();
        }

        static public void getQuestion()///////////////////////
        {/*
            return questions.questions[CurrentQuestion++];*/
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