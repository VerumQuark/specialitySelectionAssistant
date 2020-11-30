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
        public static List<ProfesionPair> pairs = new List<ProfesionPair>();
    }
}
    