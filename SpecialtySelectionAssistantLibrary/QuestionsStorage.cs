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


    public class QuestionsStorage
    {
        public List<Question> questions;

        public QuestionsStorage(ProfessionPairStorage professionPairStorage)
        {
            questions = new List<Question>();

            for(int questionNum = 0;
                    questionNum < Constants.COMPARATION_QUESTION_COUNT;
                    questionNum++)
            {
                Question question = new Question();

                question.isListQuestion = false;
                question.profesionPair = professionPairStorage.pairs[questionNum];

                questions.Add(question);
            }

        }

        public QuestionsStorage() { }

        public Question this[int i]
        {
            get { return questions[i]; }
            set { questions[i] = value; }
        }
    }
}
