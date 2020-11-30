using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialtySelectionAssistantLibrary
{
    public struct Question
    {
        public bool isListQuestion;
        public ListQuestion listQuestion;
        public ProfesionPair profesionPair;
    }

    public class Questions
    {
        public Question[] questions = new Question[Constants.QUESTION_COUNT];
        Random rand = new Random();
        int testListQuestionCount = 0;

        ListQuestions listQuestions = new ListQuestions();
        ProfessionComparationPairs comparationQuestion = new ProfessionComparationPairs();

        public Questions()
        {
            generateQuestionsArr();
        }

        private void generateQuestions ()
        {
            listQuestions.generateQuestions();
            comparationQuestion.generatePairs();
        }

        public void generateQuestionsArr()
        {
            generateQuestions();

            testListQuestionCount = 0;

            for (int questionNum = 0; questionNum < Constants.QUESTION_COUNT; questionNum++)
            {
                if(testListQuestionCount < 5)
                {
                    bool isComparationQuestion = Convert.ToBoolean(rand.Next(0, 3));

                    if (isComparationQuestion)
                    {
                        addComparationQuestion(questionNum);
                    }
                    else
                    {
                        addListQuestion(questionNum);
                    }
                }
                else
                {
                    addComparationQuestion(questionNum);
                }
            }
        }

        void addComparationQuestion(int questionNum)
        {
            int comparationQuestionCount = ProfessionPairStorage.pairs.Count;
            int comparationQuestionIndex = rand.Next(0, comparationQuestionCount-1);

            questions[questionNum].profesionPair = ProfessionPairStorage.pairs[comparationQuestionIndex];
            questions[questionNum].isListQuestion = false;

            ProfessionPairStorage.pairs.RemoveAt(comparationQuestionIndex);
        }

        void addListQuestion(int questionNum)
        {
            int listQuestionCount = listQuestions.listQuestionsArrrr.listQuestionsArr.Count;
            int listQuestionIndex = rand.Next(0, listQuestionCount);

            questions[questionNum].listQuestion = listQuestions.listQuestionsArrrr.listQuestionsArr[listQuestionIndex];
            questions[questionNum].isListQuestion = true;

            listQuestions.listQuestionsArrrr.listQuestionsArr.RemoveAt(listQuestionIndex);

            testListQuestionCount++;
        }

    }
}
