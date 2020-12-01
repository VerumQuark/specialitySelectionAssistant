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
        [JsonInclude]
        public string img;
    }

    public struct ProfessionStrorage
    {
        [JsonInclude]
        public List<List<profesion>> professions;

        public List<profesion> this[int i]
        {
            get { return professions[i]; }
            set { professions[i] = value; }
        }

        public profesion this[int i, int j]
        {
            get { return professions[i][j]; }
            set { professions[i][j] = value; }
        }
    }
}
