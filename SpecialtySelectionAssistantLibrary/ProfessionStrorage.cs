using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SpecialtySelectionAssistantLibrary
{
    public struct Profesion
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
        public List<List<Profesion>> professions;

        public List<Profesion> this[int i]
        {
            get { return professions[i]; }
            set { professions[i] = value; }
        }

        public Profesion this[int i, int j]
        {
            get { return professions[i][j]; }
            set { professions[i][j] = value; }
        }
    }
}
