using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialtySelectionAssistantLibrary
{
    public struct HollandResult
        {
            public int realistic { get; set; }
            public int intelligent { get; set; }
            public int social { get; set; }
            public int conventional { get; set; }
            public int enterprising { get; set; }
            public int artistic { get; set; }

            public void init()
            {
                realistic = 0;
                intelligent = 0;
                social = 0;
                conventional = 0;
                enterprising = 0;
                artistic = 0;
            }
        }

    struct ZnoSubject {
        string name;
        int scores;
    }

    static public class User
    {
        static public HollandResult hollandResult;
        static string name;


        static User()
        {
            hollandResult.init();
            name = "";
        }

        static public void setName(string nameValue)
        {
            name = nameValue;
        }
    }
}
