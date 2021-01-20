using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialtySelectionAssistantLibrary
{
    public struct HollandResult
        {
            public int Realistic { get; set; }
            public int Intelligent { get; set; }
            public int Social { get; set; }
            public int Conventional { get; set; }
            public int Enterprising { get; set; }
            public int Artistic { get; set; }

            public void Init()
            {
                Realistic = 0;
                Intelligent = 0;
                Social = 0;
                Conventional = 0;
                Enterprising = 0;
                Artistic = 0;
            }
        }

    static public class User
    {
        static public HollandResult hollandResult;
        static public string name;


        static User()
        {
            hollandResult.Init();
            name = "";
        }

        static public void SetName(string nameValue)
        {
            name = nameValue;
        }
    }
}
