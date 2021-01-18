using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialtySelectionAssistantLibrary
{
    public struct UserPreference
    {
        public int specialtyIndex;
        public int preferenceValue;
    }

    static public class UserPreferencesTest
    {
        static Faculty faculty;
        static public Specialty currentSpeciality;
        static public string currentListQuestion;

        static public int currentSpecialityIndex;
        static public int currentListQuestionIndex;

        static public bool isFirstQuestion = false;
        static public bool isLastQuestion = false;

        static public Stack<UserPreference> userPreferencesStack;

        static public Specialty[] resultSpecialties;

        static public void SaveTestResult()
        {
            foreach(UserPreference userPreference in userPreferencesStack)
            {
                int specialtyIndex = userPreference.specialtyIndex;
                int userLikes = userPreference.preferenceValue;
                faculty.specialties[specialtyIndex].userLikes += userLikes;
            }

            resultSpecialties = faculty.specialties;
        }

        //static constructor REWORK

        static public void CreateTest(Faculty facultyValue)
        {
            faculty = facultyValue;

            CurrentSpecialityIndex = 0;
            CurrentListQuestionIndex = 0;

            currentSpeciality = faculty.specialties[CurrentSpecialityIndex];
            currentListQuestion = currentSpeciality.questions[CurrentListQuestionIndex];

            isFirstQuestion = true;
            isLastQuestion = false;

            userPreferencesStack = new Stack<UserPreference>();
        }

        static public void NextQuestion()
        {
            CurrentListQuestionIndex++;
            currentSpeciality = faculty.specialties[CurrentSpecialityIndex];
            currentListQuestion = currentSpeciality.questions[CurrentListQuestionIndex];
        }

        static public void PrevQuestion()
        {
            CurrentListQuestionIndex--;
            currentSpeciality = faculty.specialties[CurrentSpecialityIndex];
            currentListQuestion = currentSpeciality.questions[CurrentListQuestionIndex];
        }

        static public int CurrentSpecialityIndex
        {
            get
            {
                return currentSpecialityIndex;
            }

            set
            {
                if (value >= faculty.specialties.Length)
                {
                    //error
                    //currentQuestion = 0;
                }
                else
                {
                    currentSpecialityIndex = value;
                }
            }
        }

        static public int CurrentListQuestionIndex
        {
            get
            {
                return currentListQuestionIndex;
            }

            set
            {
                int questionsLenght = faculty.specialties[currentSpecialityIndex].questions.Length;

                if (value > questionsLenght)
                {
                    //error
                    //currentQuestion = 0;
                }
                else
                {
                    if (value == questionsLenght)
                    {
                        currentSpecialityIndex++;
                        currentListQuestionIndex = 0;
                    }
                    else if (value < 0)
                    {
                        currentSpecialityIndex--;
                        currentListQuestionIndex = questionsLenght - 1;
                    }
                    else
                    {
                        currentListQuestionIndex = value;
                    }

                    isLastQuestion = false;
                    isFirstQuestion = false;

                    if (currentSpecialityIndex == faculty.specialties.Length - 1 &&
                      currentListQuestionIndex == faculty.specialties[currentSpecialityIndex].questions.Length - 1)
                    {
                        isLastQuestion = true;
                    }

                    if (currentSpecialityIndex == 0 &&
                       currentListQuestionIndex == 0)
                    {
                        isFirstQuestion = true;
                    }
                }
            }
        }
    }
}
