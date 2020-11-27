using System.Text.Json;
using System.Text;
using System.IO;
using System;
using System.Text.RegularExpressions;

namespace SpecialtySelectionAssistantLibrary
{
	public class ProfessionComparationPairs
	{
        readonly string jsonString = File.ReadAllText("professions.json", Encoding.UTF8);
		ProfessionStrorage profesionStrorage = new ProfessionStrorage();
		
		public ProfessionComparationPairs()
		{
			profesionStrorage = JsonSerializer.Deserialize<ProfessionStrorage>(jsonString);

		}

		public void generatePairs()
		{

			for (int pairNum = 0;  pairNum < Constants.QUESTION_COUNT; pairNum++)
            {
				for (int mainArrNum = 0, anotherArrCountIndex = 6, anotherArrStartNum = 1;
					mainArrNum < 5;
					mainArrNum++, anotherArrStartNum++)

                {
					for(int anotherArrNum = anotherArrStartNum;
						anotherArrNum < anotherArrCountIndex;
						anotherArrNum++)

                    {
                        ProfesionPair tempPair = new ProfesionPair
                        {
                            firstProfession = getProfession(mainArrNum),
                            secondProfession = getProfession(anotherArrNum)
                        };

                        ProfessionPairStorage.pairs[pairNum] =  tempPair;

						pairNum++;
					}
                }
            }
		}
		private profesion getProfession (int arrNum)
        {
			var rand = new Random();

			int arrLenght = profesionStrorage.professionArr[arrNum].Count - 1;

			profesion profesionElem;

			int randValue = rand.Next(0, arrLenght);

			profesionElem = profesionStrorage.professionArr[arrNum][randValue];

			//profesionStrorage.swapProfession(arrNum, randValue, arrLenght);

			profesionStrorage.professionArr[arrNum].RemoveAt(randValue);

			return profesionElem;
        }
	}
}/*
string fileName = ".."
jsonString = File.ReadAllText(fileName);
weatherForecast = JsonSerializer.Deserialize<WeatherForecast>(jsonString);*/