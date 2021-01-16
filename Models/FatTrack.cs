using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
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
        public List<SelectListItem> ActivityLevel { get; set; } = new List<SelectListItem>
        {
            new SelectListItem{Value="Sedentary", Text="Sedentary"},
            new SelectListItem{Value="Light", Text="Light"},
            new SelectListItem{Value="Moderate", Text="Moderate"},
            new SelectListItem{Value="Vigorous", Text="Vigorous"},
            new SelectListItem{Value="Extreme", Text="Extreme"}
            



        };
        public DateTime? Birthday { get; set; }
        public int? Age { get; set; }
        public int? NumOcal { get; set; }
        public string Bmr { get; set; }
        
        public double FoodCalories
        {
            //ActivityLevel




            get;

            set;


        }






    }
}
