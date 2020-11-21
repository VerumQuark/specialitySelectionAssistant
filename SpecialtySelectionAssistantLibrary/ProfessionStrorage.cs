using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SpecialtySelectionAssistantLibrary
{
    public struct profesion
    {
        [JsonInclude]
        public string name;
        [JsonInclude]
        public string type;
    }

    class ProfessionStrorage
    {
        [JsonInclude]
        public List<List<profesion>> professionArr;

        public void swapProfession(int arrNum, int firstItem, int secondItem)
        {
            profesion temp = professionArr[arrNum][firstItem];
            professionArr[arrNum][firstItem] = professionArr[arrNum][secondItem];
            professionArr[arrNum][secondItem] = temp;
        }
    }
}
