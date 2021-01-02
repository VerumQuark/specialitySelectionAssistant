using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialtySelectionAssistantLibrary
{
    struct HollandResult
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

    public class User
    {
        HollandResult hollandResult;
        string name;
        bool budget;
        bool contract;
        List<ZnoSubject> znoSubjects;

        public User()
        {
            hollandResult.init();
            name = "";
            budget = false;
            contract = false;
        }

        public User(string nameF, bool budgetF, bool contractF)
        {
            hollandResult.init();
            name = nameF;
            budget = budgetF;
            contract = contractF;
        }
    }
}
