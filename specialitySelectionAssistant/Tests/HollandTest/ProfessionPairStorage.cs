using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace specialitySelectionAssistant.Tests.Holland
{
     public struct ProfesionPair
    {
        public Profesion firstProfession;
        public Profesion secondProfession;

    }

    public class ProfessionPairStorage
    {
        public List<ProfesionPair> pairs;

        public ProfessionPairStorage()
        {
            pairs = new List<ProfesionPair>();
        }

        public ProfesionPair this[int i]
        {
            get { return pairs[i]; }
            set { pairs[i] = value; }
        }
    }
}
    