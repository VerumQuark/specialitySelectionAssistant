using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace specialitySelectionAssistant
{
    public struct Subject
    {
        
        public string name { get; set; }
        
        public double coefficient { get; set; }
        
        public bool isMandatory { get; set; }
    }

    public struct Specialty
    {
        
        public string name { get; set; }

        public bool budget { get; set; }
        
        public int ZNO_points { get; set; }
        
        public Subject[] subjects { get; set; }
        
        public string[] professions { get; set; }
        
        public string description { get; set; }
        
        public string[] questions { get; set; }
        
        public int userLikes { get; set; }
    }

    public struct Faculty
    {
        
        public string name { get; set; }
        
        public HollandResult hollandCharacteristics { get; set; }
        
        public Specialty[] specialties { get; set; }
    }
}
