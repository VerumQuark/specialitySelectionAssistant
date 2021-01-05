using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace SpecialtySelectionAssistantLibrary
{
    public struct Subject
    {
        [JsonInclude]
        public string name;
        [JsonInclude]
        public double coefficient;
        [JsonInclude]
        public bool isMandatory;
    }

    public struct Specialty
    {
        [JsonInclude]
        public string name;
        [JsonInclude]
        public bool budget;
        [JsonInclude]
        public int ZNO_points;
        [JsonInclude]
        public Subject[] subjects;
        [JsonInclude]
        public string[] professions;
        [JsonInclude]
        public string description;
        [JsonInclude]
        public string[] questions;
        [JsonInclude]
        public int userLikes;
    }

    public struct Faculty
    {
        [JsonInclude]
        public string name;
        [JsonInclude]
        public HollandResult hollandCharacteristics;
        [JsonInclude]
        public Specialty[] specialties;
    }
}
