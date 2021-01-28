using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using specialitySelectionAssistant;

namespace specialitySelectionAssistant
{
    public struct ZnoSubject
    {
        public string name;
        public int points;
    }

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

        static public bool isBudget;
        static public bool isContract;
        static public bool isHaveZno;

        static public List<ZnoSubject> znoSubjects;

        static User()
        {
            Reset();
        }

        static public void Reset()
        {
            hollandResult.Init();
            name = "";

            isBudget = false;
            isContract = false;
            isHaveZno = false;

            znoSubjects = new List<ZnoSubject>();
        }

        static public void SetName(string nameValue)
        {
            name = nameValue;
        }

        static public void SetZnoSubjects(List<ZnoSubject> znoSubjectsArr)
        {
            znoSubjects = new List<ZnoSubject>(znoSubjectsArr);
        }

        static public void SetEducationForm(bool isBudgetValue, bool isContractValue, bool isHaveZnoValue)
        {
            isBudget = isBudgetValue;
            isContract = isContractValue;
            isHaveZno = isHaveZnoValue;
        }
    }
}
