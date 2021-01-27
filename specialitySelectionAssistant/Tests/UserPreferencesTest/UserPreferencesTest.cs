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

    public class UserPreferencesTest : TwoIndexTest<UserPreference>
    {
        public override bool isFirstQuestion { get; set; } = false;
        public override bool isLastQuestion { get; set; } = false;

        private Faculty faculty;
        public Specialty currentSpeciality;
        public string currentListQuestion;

        public override int _currentSpecialityIndex { get; set; }
        public override int _currentListQuestionIndex { get; set; }
        public override int _currentTotalQuestionNumber { get; set; }

        public override int TotalQuestionCount { get; set; }

        public override Stack<UserPreference> answerStack { get; set; }

        public Specialty[] resultSpecialties;

        public int CurrentSpecialityIndex
        {
            get
            {
                return _currentSpecialityIndex;
            }

            set
            {
                try
                {
                    if (value >= faculty.specialties.Length)
                    {
                        throw new RangeException();
                    }
                    else if (value < 0)
                    {
                        throw new RangeException();
                    }
                    else
                    {
                        _currentSpecialityIndex = value;
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

        public int CurrentListQuestionIndex
        {
            get
            {
                return _currentListQuestionIndex;
            }

            set
            {
                try
                {
                    int questionsLenght = faculty.specialties[_currentSpecialityIndex].questions.Length;

                    if (value > questionsLenght)
                    {
                        throw new RangeException();
                    }
                    else
                    {
                        if (value == questionsLenght)
                        {
                            _currentListQuestionIndex = 0;
                            _currentSpecialityIndex++;
                        }
                        else if (value < 0)
                        {
                            _currentListQuestionIndex = questionsLenght - 1;
                            _currentSpecialityIndex--;
                        }
                        else
                        {
                            _currentListQuestionIndex = value;
                        }

                        isLastQuestion = false;
                        isFirstQuestion = false;

                        if (_currentSpecialityIndex == faculty.specialties.Length - 1 &&
                            _currentListQuestionIndex == faculty.specialties[_currentSpecialityIndex].questions.Length - 1)
                        {
                            isLastQuestion = true;
                        }

                        if (_currentSpecialityIndex == 0 &&
                            _currentListQuestionIndex == 0)
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

        public int CurrentTotalQuestionNumber
        {
            get => _currentTotalQuestionNumber;

            set
            {
                if(value < 0)
                {
                    throw new RangeException();
                }
                else
                {
                    _currentTotalQuestionNumber = value;
                }
            }
        }

        public override void NextQuestion()
        {
            try
            {
                CurrentListQuestionIndex++;
                CurrentTotalQuestionNumber++;
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

        public override void PrevQuestion()
        {
            try
            {
                CurrentListQuestionIndex--;
                CurrentTotalQuestionNumber--;
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

        public UserPreferencesTest(Faculty facultyValue)
        {
            CreateTest(facultyValue);
        }

        public override void CreateTest(Faculty facultyValue)
        {
            try
            {
                faculty = facultyValue;

                CurrentSpecialityIndex = 0;
                CurrentListQuestionIndex = 0;
                CurrentTotalQuestionNumber = 1;

                TotalQuestionCount = GetTotalQuestionCount();

                currentSpeciality = faculty.specialties[CurrentSpecialityIndex];
                currentListQuestion = currentSpeciality.questions[CurrentListQuestionIndex];

                isFirstQuestion = true;
                isLastQuestion = false;

                answerStack = new Stack<UserPreference>();
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

        public override void SaveTestResult()
        {
            foreach(UserPreference userPreference in answerStack)
            {
                int specialtyIndex = userPreference.specialtyIndex;
                int userLikes = userPreference.preferenceValue;
                faculty.specialties[specialtyIndex].userLikes += userLikes;
            }

            resultSpecialties = faculty.specialties;
        }

        private int GetTotalQuestionCount()
        {
            int questionCount = 0;

            foreach (Specialty specialty in faculty.specialties)
            {
                foreach (string question in specialty.questions)
                {
                    questionCount++;
                }
            }

            return questionCount;
        }
    }
}
