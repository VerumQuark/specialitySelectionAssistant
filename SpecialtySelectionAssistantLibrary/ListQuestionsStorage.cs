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

    public struct ListQuestionsStorage
    {
        [JsonInclude]
        public List<ListQuestion> listQuestionsArr;

        public ListQuestion this[int i]
        {
            get { return listQuestionsArr[i]; }
            set { listQuestionsArr[i] = value; }
        }
    }
}
