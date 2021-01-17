﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace SpecialtySelectionAssistantLibrary
{
    class ProfessionPairGenerator
    {
        string jsonString;
        ProfessionPairStorage professionPairStorage;

        public ProfessionPairGenerator()
        {
            try
            {
                jsonString = Encoding.UTF8.GetString(Properties.Resources.professions);
                professionPairStorage = new ProfessionPairStorage();
            }
            catch
            {
                Console.WriteLine("Pair generator. Get Json string error");
            }
        }

        public ProfessionPairStorage generatePairs()
        {                
            ProfessionStrorage professionStrorage;
            try
            {
                professionStrorage = JsonSerializer.Deserialize<ProfessionStrorage>(jsonString);

                for (int pairIndex = 0; pairIndex < Constants.COMPARATION_QUESTION_COUNT; pairIndex++)
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
                                firstProfession = getProfession(mainArrIndex, professionStrorage),
                                secondProfession = getProfession(anotherArrIndex, professionStrorage)
                            };

                            professionPairStorage.pairs.Add(tempPair);

                            pairIndex++;
                        }
                    }
                }

            }
            catch
            {
                Console.WriteLine("Pair generator. Json deserialization error");
            }

            return professionPairStorage;
        }

        private Profesion getProfession(int arrNum, ProfessionStrorage professionStrorage)
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
                Console.WriteLine("Pair generator. IndexOutOfRangeException");
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return profesionElem;
        }
    }
}
