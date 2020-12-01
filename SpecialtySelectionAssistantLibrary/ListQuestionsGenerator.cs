using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace SpecialtySelectionAssistantLibrary
{
    public class ListQuestionsGenerator
    {
        string jsonString = Encoding.UTF8.GetString(Properties.Resources.listQuestions);

        public ListQuestionsStorage generateListQuestions()
        {
            ListQuestionsStorage listQuestionsStorage;
            listQuestionsStorage = JsonSerializer.Deserialize<ListQuestionsStorage>(jsonString);

            return listQuestionsStorage;
        }
    }
}
