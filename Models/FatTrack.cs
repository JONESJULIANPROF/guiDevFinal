using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace FianlGUI.Models
{
    public partial class FatTrack
    {
        public int ProfileNum { get; set; }
        public string FirstN { get; set; }
        public string LastN { get; set; }
        public string Email { get; set; }
        public int? StartingW { get; set; }
        public int? CurrentW { get; set; }
        public int? DesiredW { get; set; }
        public int? HeightInches { get; set; }
        public string Gender { get; set; }
        public string ActivityLevel { get; set; }
        public DateTime? Birthday { get; set; }
        public int? Age { get; set; }
        public int? NumOcal { get; set; }
        public string Bmr { get; set; }

        
    }
}
