using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using specialitySelectionAssistant.Exceptions;
using specialitySelectionAssistant.Utility;

namespace specialitySelectionAssistant.Tests.Holland
{
    class ProfessionPairGenerator
    {
        private string jsonString;
        private ProfessionPairStorage professionPairStorage;

        public ProfessionPairGenerator()
        {
            try
            {
                jsonString = Encoding.UTF8.GetString(Properties.Resources.professions);
                professionPairStorage = new ProfessionPairStorage();
            }
            catch(Exception ex)
            {
                string message = "Pair generator. Get Json string error";
                ExceptionHandler.CriticalException(ex, message);
            }
        }

        public ProfessionPairStorage GeneratePairs()
        {                
            ProfessionStrorage professionStrorage;
            try
            {
                professionStrorage = JsonSerializer.Deserialize<ProfessionStrorage>(jsonString);

                for (int pairIndex = 0; pairIndex < Constants.HOLLAND_QUESTION_COUNT; pairIndex++)
                {
                    int typeArrCount = 6;

                    for (int mainArrIndex = 0, anotherArrStartIndex = 1;
                             mainArrIndex < 5;
                             mainArrIndex++, anotherArrStartIndex++)

                    {
                        for (int anotherArrIndex = anotherArrStartIndex;
                                 anotherArrIndex < typeArrCount;
                                 anotherArrIndex++)

                        {
                            ProfesionPair tempPair = new ProfesionPair
                            {
                                firstProfession = GetProfession(mainArrIndex, professionStrorage),
                                secondProfession = GetProfession(anotherArrIndex, professionStrorage)
                            };

                            professionPairStorage.pairs.Add(tempPair);

                            pairIndex++;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                string message = "Pair generator. Json deserialization error";
                ExceptionHandler.CriticalException(ex, message);
            }

            return professionPairStorage;
        }

        private Profesion GetProfession(int arrNum, ProfessionStrorage professionStrorage)
        {
            Profesion profesionElem = new Profesion();
            try
            {
                var rand = new Random();

                int arrLenght = professionStrorage[arrNum].Count - 1;

                int professionIndex = rand.Next(0, arrLenght);

                profesionElem = professionStrorage[arrNum][professionIndex];

                professionStrorage[arrNum].RemoveAt(professionIndex);

                
            }
            catch(IndexOutOfRangeException ex)
            {
                string message = "Pair generator. IndexOutOfRangeException";
                ExceptionHandler.CriticalException(ex, message);
            }
            catch (Exception ex)
            {
                ExceptionHandler.CriticalException(ex);
            }
            return profesionElem;
        }
    }
}
