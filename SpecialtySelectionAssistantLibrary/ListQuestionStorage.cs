using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace SpecialtySelectionAssistantLibrary
{
    public struct ListQuestion
    {
        [JsonInclude]
        public string question;
        [JsonInclude]
        public string type;
    }

    struct ListQuestionStorage
    {
        [JsonInclude]
        public List<ListQuestion> listQuestionsArr;
    }
}
