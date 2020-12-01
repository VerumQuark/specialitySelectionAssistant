using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace SpecialtySelectionAssistantLibrary
{
    class ProfessionPairGenerator
    {
        string jsonString = Encoding.UTF8.GetString(Properties.Resources.professions);
        ProfessionPairStorage professionPairStorage = new ProfessionPairStorage();

        public ProfessionPairStorage generatePairs()
        {
            ProfessionStrorage professionStrorage;
            professionStrorage = JsonSerializer.Deserialize<ProfessionStrorage>(jsonString);

            for (int pairNum = 0; pairNum < Constants.COMPARATION_QUESTION_COUNT; pairNum++)
            {
                int anotherArrCountIndex = 6;

                for (int mainArrNum = 0, anotherArrStartNum = 1;
                         mainArrNum < 5;
                         mainArrNum++, anotherArrStartNum++)

                {
                    for (int anotherArrNum = anotherArrStartNum;
                        anotherArrNum < anotherArrCountIndex;
                        anotherArrNum++)

                    {
                        ProfesionPair tempPair = new ProfesionPair
                        {
                            firstProfession = getProfession(mainArrNum, professionStrorage),
                            secondProfession = getProfession(anotherArrNum, professionStrorage)
                        };

                        professionPairStorage.pairs.Add(tempPair);

                        pairNum++;
                    }
                }
            }

            return professionPairStorage;
        }

        private profesion getProfession(int arrNum, ProfessionStrorage professionStrorage)
        {
            profesion profesionElem;
            var rand = new Random();

            int arrLenght = professionStrorage[arrNum].Count - 1;

            int professionIndex = rand.Next(0, arrLenght);

            profesionElem = professionStrorage[arrNum][professionIndex];

            professionStrorage[arrNum].RemoveAt(professionIndex);

            return profesionElem;
        }
    }
}
