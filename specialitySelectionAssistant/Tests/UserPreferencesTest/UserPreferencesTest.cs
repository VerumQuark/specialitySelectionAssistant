using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using specialitySelectionAssistant.Exceptions;

namespace specialitySelectionAssistant.Tests.UserPreference
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

        static public int CurrentSpecialityIndex
        {
            get
            {
                return currentSpecialityIndex;
            }

            set
            {
                try
                {
                    if (value >= faculty.specialties.Length)
                    {
                        currentSpecialityIndex = faculty.specialties.Length - 1;

                        throw new RangeException();
                    }
                    else if (value < 0)
                    {
                        currentSpecialityIndex = 0;

                        throw new RangeException();
                    }
                    else
                    {
                        currentSpecialityIndex = value;
                    }
                }
                catch (RangeException ex)
                {
                    string message = "UserPreferencesTest. Specialty index assignment error.";
                    ExceptionHandler.CriticalException(ex, message);
                }
                catch (Exception ex)
                {
                    ExceptionHandler.CriticalException(ex);
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
                try
                {
                    int questionsLenght = faculty.specialties[currentSpecialityIndex].questions.Length;

                    if (value > questionsLenght)
                    {
                        currentListQuestionIndex = questionsLenght;

                        throw new RangeException();
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
                catch (RangeException ex)
                {
                    string message = "UserPreferencesTest. List question index assignment error.";
                    ExceptionHandler.CriticalException(ex, message);
                }
                catch (Exception ex)
                {
                    ExceptionHandler.CriticalException(ex);
                }
            }
        }

        static public void NextQuestion()
        {
            try
            {
                CurrentListQuestionIndex++;
                currentSpeciality = faculty.specialties[CurrentSpecialityIndex];
                currentListQuestion = currentSpeciality.questions[CurrentListQuestionIndex];
            }
            catch (IndexOutOfRangeException ex)
            {
                string message = "UserPreferencesTest. Index error.";
                ExceptionHandler.CriticalException(ex, message);
            }
            catch (Exception ex)
            {
                ExceptionHandler.CriticalException(ex);
            }
        }

        static public void PrevQuestion()
        {
            try
            {
                CurrentListQuestionIndex--;
                currentSpeciality = faculty.specialties[CurrentSpecialityIndex];
                currentListQuestion = currentSpeciality.questions[CurrentListQuestionIndex];
            }
            catch (IndexOutOfRangeException ex)
            {
                string message = "UserPreferencesTest. Index error.";
                ExceptionHandler.CriticalException(ex, message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ExceptionHandler.CriticalException(ex);
            }
        }

        static public void CreateTest(Faculty facultyValue)
        {
            try
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
            catch (IndexOutOfRangeException ex)
            {
                string message = "UserPreferencesTest. Index error.";
                ExceptionHandler.CriticalException(ex, message);
            }
            catch (Exception ex)
            {
                ExceptionHandler.CriticalException(ex);
            }
        }

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
    }
}
