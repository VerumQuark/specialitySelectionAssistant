using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialtySelectionAssistantLibrary
{
    public class QuestionsGenerator
    {
        public QuestionsStorage questionsGenerate(ListQuestionsStorage listQuestionsStorage, ProfessionPairStorage professionPairStorage)
        {
            Random rand = new Random();
            QuestionsStorage questionsStorage = new QuestionsStorage(professionPairStorage);

            for (int listQuestionNum = 0;
                     listQuestionNum < Constants.LIST_QUESTION_COUNT;
                     listQuestionNum++)
            {
                int questionCountPlusOne = questionsStorage.questions.Count + 1;
                int randValue = rand.Next(0, questionCountPlusOne);

                if (randValue == questionCountPlusOne)
                {
                    Question question = generateQuestion(listQuestionsStorage, listQuestionNum);

                    questionsStorage.questions.Add(question);
                }

                else
                {
                    Question question = generateQuestion(listQuestionsStorage, listQuestionNum);
                    Question tempQuestion = questionsStorage[randValue];

                    questionsStorage[randValue] = question;

                    questionsStorage.questions.Add(tempQuestion);
                }
            }



            return questionsStorage;
        }

        Question generateQuestion(ListQuestionsStorage listQuestionStorage, int listQuestionNum)
        {
            Question question = new Question();

            question.isListQuestion = true;
            question.listQuestion = listQuestionStorage[listQuestionNum];

            return question;
        }
    }
}