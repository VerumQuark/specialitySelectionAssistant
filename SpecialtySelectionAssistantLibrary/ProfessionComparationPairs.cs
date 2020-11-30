using System.Text.Json;
using System.Text;
using System.IO;
using System;
using System.Text.RegularExpressions;
using System.Resources;

namespace SpecialtySelectionAssistantLibrary
{
	public class ProfessionComparationPairs
	{
		string jsonString = Encoding.UTF8.GetString(Properties.Resources.professions);
		public ProfessionStrorage professionStrorage = new ProfessionStrorage();
		
		public ProfessionComparationPairs()
		{

		}

		public void generatePairs()
		{
			professionStrorage = JsonSerializer.Deserialize<ProfessionStrorage>(jsonString);

			for (int pairNum = 0;  pairNum < Constants.COMPARATION_QUESTION_COUNT; pairNum++)
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

                        ProfessionPairStorage.pairs.Add( tempPair );

						pairNum++;
					}
                }
            }
		}
		private profesion getProfession (int arrNum)
        {
			profesion profesionElem;
			var rand = new Random();

			int arrLenght = professionStrorage.professionArr[arrNum].Count - 1;

			int professionIndex = rand.Next(0, arrLenght);

			profesionElem = professionStrorage.professionArr[arrNum][professionIndex];

			professionStrorage.professionArr[arrNum].RemoveAt(professionIndex);

			return profesionElem;
        }
	}
}