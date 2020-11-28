using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialtySelectionAssistantLibrary
{
     public struct ProfesionPair
    {
        public profesion firstProfession;
        public profesion secondProfession;

    }

    public class ProfessionPairStorage
    {
        private int PairCount = Constants.QUESTION_COUNT;

        public static ProfesionPair[] pairs = new ProfesionPair[Constants.QUESTION_COUNT];

    }
}
    