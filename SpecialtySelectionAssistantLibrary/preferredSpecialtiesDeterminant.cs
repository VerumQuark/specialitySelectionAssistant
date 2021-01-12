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
        static bool isBudget;
        static bool isContract;
        static bool isHaveZno;

        static List<ZnoSubject> znoSubjects;
        static List<Specialty> specialties;
        static List<Specialty> defaultCheckedSpecialties;
        static List<Specialty> determinedSpecialties;

        delegate void SpecialtiesCheking();
        static SpecialtiesCheking specialtiesCheking;


        static preferredSpecialtiesDeterminant()
        {
            isBudget = false;
            isContract = false;
            isHaveZno = false;

            znoSubjects = new List<ZnoSubject>();
            specialties = new List<Specialty>();
            determinedSpecialties = new List<Specialty>();
            defaultCheckedSpecialties = new List<Specialty>();
        }

        static public List<Specialty> getDetermineSpecialties()
        {
            configureCheck();
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

        static public void setEducationForm(bool isBudgetValue, bool isContractValue, bool isHaveZnoValue)
        {
            isBudget = isBudgetValue;
            isContract = isContractValue;
            isHaveZno = isHaveZnoValue;
        }

        static void configureCheck()
        {
            specialtiesCheking = defaultCheck;

            if (isBudget == true && isContract == false)
                specialtiesCheking += budgetCheck;

            if (isHaveZno)
                specialtiesCheking += znoCheck;

            specialtiesCheking += fillingCheck;
        }
        static void defaultCheck()
        {
            specialties.Sort((x, y) => x.userLikes.CompareTo(y.userLikes));

            defaultCheckedSpecialties = specialties;
        }

        static void budgetCheck()
        {
            List<Specialty> checkedSpecialties = new List<Specialty>();

            foreach (Specialty specialty in specialties)
            {
                if (specialty.budget) checkedSpecialties.Add(specialty);
            }

            specialties = checkedSpecialties;
        }

        static void znoCheck()
        {
            List<Specialty> checkedSpecialties = new List<Specialty>();

            foreach (Specialty specialty in specialties)
            {
                double totalPoints = 0;
                List<double> optionalPoints = new List<double>();

                foreach(Subject subject in specialty.subjects)
                {
                    if (znoSubjects.Exists(x => x.name == subject.name))
                    {
                        ZnoSubject znoSubject = znoSubjects.Find(x => x.name.Contains(subject.name));

                        if (subject.isMandatory)
                        {
                            totalPoints += znoSubject.points * subject.coefficient;
                        }
                        else
                        {
                            optionalPoints.Add(znoSubject.points * subject.coefficient);
                        }
                    }
                    else
                    {
                        if (subject.isMandatory) break;
                    }
                }
                if(optionalPoints.Count != 0) totalPoints += optionalPoints.Max();

                if (totalPoints * 1.05 >= specialty.ZNO_points)
                {
                    checkedSpecialties.Add(specialty);
                }
            }

            specialties = checkedSpecialties;
        }

        static void fillingCheck()
        {
            if (specialties.Count >= 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    determinedSpecialties.Add(specialties[i]);
                }
            }
            else
            {
                int i = 0;
                while (determinedSpecialties.Count <= 3)
                {
                    determinedSpecialties.Add(defaultCheckedSpecialties[i]);

                    i++;
                }
            }
        }

    }
}
