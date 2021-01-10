using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialtySelectionAssistantLibrary
{
    public struct ZnoSubject
    {
        public string name;
        public int points;
    }

    static public class preferredSpecialtiesDeterminant
    {
        static List<Specialty> specialties;

        static bool isBudget;
        static bool isContract;
        static bool haveZno;
        static List<ZnoSubject> znoSubjects;

        delegate void SpecialtiesCheking();
        static SpecialtiesCheking specialtiesCheking;

        static List<Specialty> determinedSpecialties;

        static preferredSpecialtiesDeterminant()
        {
            isBudget = false;
            isContract = false;
            haveZno = false;
            determinedSpecialties = new List<Specialty>();
        }

        static public List<Specialty> getDetermineSpecialties()
        {
            tune();
            specialtiesCheking?.Invoke();
            return determinedSpecialties;
        }

        static public void setZnoSubjects(List<ZnoSubject> znoSubjectsArr)
        {
            znoSubjects = new List<ZnoSubject>(znoSubjectsArr);
        }

        static public void setSpecialties(Specialty[] specialtiesArr)
        {
            specialties = new List<Specialty>(specialtiesArr);
        }

        static public void setEducationForm(bool isBudgetValue, bool isContractValue, bool haveZnoValue)
        {
            isBudget = isBudgetValue;
            isContract = isContractValue;
            haveZno = haveZnoValue;
        }

        static void tune()
        {
            if (isBudget == true && isContract == false)
                specialtiesCheking += budgetCheck;
            else
                specialtiesCheking -= budgetCheck;

            if (haveZno)
                specialtiesCheking += znoCheck;
            else
                specialtiesCheking -= znoCheck;

            specialtiesCheking += defaultCheck;
        }

        static void defaultCheck()
        {
            List<Specialty> checkedSpecialties = new List<Specialty>();

            specialties.Sort((x, y) => x.userLikes.CompareTo(y.userLikes));

            if(specialties.Count >= 3)
            {
                for(int i = 0; i < 3; i++)
                {
                    determinedSpecialties.Add(specialties[i]);
                }
            }

        }

        static void znoCheck()
        {

        }

        static void budgetCheck()
        {
            List<Specialty> checkedSpecialties = new List<Specialty>();

            foreach(Specialty specialty in specialties)
            {
                if (specialty.budget) checkedSpecialties.Add(specialty);
            }

            specialties = checkedSpecialties;
        }
    }
}
