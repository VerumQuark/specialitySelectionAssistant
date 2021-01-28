using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using specialitySelectionAssistant.Exceptions;

namespace specialitySelectionAssistant.Tests
{
    static public class PreferredSpecialtiesDeterminant
    {
        static private bool isBudget;
        static private bool isContract;
        static private bool isHaveZno;

        static private List<ZnoSubject> znoSubjects;

        static private List<Specialty> specialties;
        static private List<Specialty> defaultCheckedSpecialties;
        static private List<Specialty> determinedSpecialties;

        private delegate void SpecialtiesCheking();
        static private SpecialtiesCheking specialtiesCheking;


        static PreferredSpecialtiesDeterminant()
        {
            Reset();
        }

        static public void Reset()
        {
            isBudget = User.isBudget;
            isContract = User.isContract;
            isHaveZno = User.isHaveZno;

            znoSubjects = User.znoSubjects;

            specialties = new List<Specialty>();
            determinedSpecialties = new List<Specialty>();
            defaultCheckedSpecialties = new List<Specialty>();
        }

        static public List<Specialty> GetDetermineSpecialties()
        {
            ConfigureCheck();

            try
            {
                specialtiesCheking?.Invoke();
            }
            catch(Exception ex)
            {
                string message = "PreferredSpecialtiesDeterminant. Check error.";
                ExceptionHandler.CriticalException(ex, message);
            }

            return determinedSpecialties;
        }

        static public void SetSpecialties(Specialty[] specialtiesArr)
        {
            specialties = new List<Specialty>(specialtiesArr);
        }

        static private void ConfigureCheck()    
        {
            try
            {
                specialtiesCheking = DefaultCheck;

                if (isBudget == true && isContract == false)
                    specialtiesCheking += BudgetCheck;

                if (isHaveZno)
                    specialtiesCheking += ZnoCheck;

                specialtiesCheking += FillingCheck;
            }
            catch(Exception ex)
            {
                string message = "PreferredSpecialtiesDeterminant. Check delegate error.";
                ExceptionHandler.CriticalException(ex, message);
            }
        }
        static private void DefaultCheck()
        {
            specialties.Sort((x, y) => y.userLikes.CompareTo(x.userLikes));

            defaultCheckedSpecialties = specialties;
        }

        static private void BudgetCheck()
        {
            List<Specialty> checkedSpecialties = new List<Specialty>();

            foreach (Specialty specialty in specialties)
            {
                if (specialty.budget) checkedSpecialties.Add(specialty);
            }

            specialties = checkedSpecialties;
        }
        
        static private void ZnoCheck()
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

        static private void FillingCheck()
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
                while (determinedSpecialties.Count < 3)
                {
                    determinedSpecialties.Add(defaultCheckedSpecialties[determinedSpecialties.Count]);
                }
            }
        }

    }
}
