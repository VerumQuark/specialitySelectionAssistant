﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace specialitySelectionAssistant.Tests.Holland
{
    public struct Profesion
    {
        public string name { get; set; }
        public string type { get; set; }
        public string img { get; set; }
    }

    public struct ProfessionStrorage
    {
        public List<List<Profesion>> professions { get; set; }

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
