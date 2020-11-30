using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace SpecialtySelectionAssistantLibrary
{
    class ListQuestions
    {
        public ListQuestionStorage listQuestionsArrrr = new ListQuestionStorage();

        public void generateQuestions()
        {
            string jsonString = Encoding.UTF8.GetString(Properties.Resources.listQuestions);
            listQuestionsArrrr = JsonSerializer.Deserialize<ListQuestionStorage>(jsonString);
        }
    }
}
