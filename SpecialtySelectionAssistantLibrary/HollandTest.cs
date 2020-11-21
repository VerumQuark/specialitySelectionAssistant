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

        static ProfessionComparationPairs professionPairs { get; set; } = new ProfessionComparationPairs();

        static public int CurrentQuestion
        {
            get
            {
                return currentQuestion;
            }

            set
            {
                if (value > Constants.QUESTION_COUNT)
                {
                    //переход на форму результатов
                }

                else currentQuestion = value;
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
    }
}