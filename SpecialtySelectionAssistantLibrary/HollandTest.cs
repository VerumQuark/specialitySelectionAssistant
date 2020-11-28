using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialtySelectionAssistantLibrary
{
    public static class HollandTest
    {
        static int currentQuestion;
        static public bool isLastQuestion = false;
        static UserHollandTestResult UserCharacteristics = new UserHollandTestResult();

        static ProfessionComparationPairs professionPairs { get; set; } = new ProfessionComparationPairs();

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

        static public void Init()
        {
            CurrentQuestion = 0;

            professionPairs.generatePairs();
        }

        static public ProfesionPair getQuestion()
        {
            return ProfessionPairStorage.pairs[CurrentQuestion++];
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