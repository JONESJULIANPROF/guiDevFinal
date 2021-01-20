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
        public double StartingW { get; set; }
        public double CurrentW { get; set; }
        public double DesiredW { get; set; }
        public double HeightInches { get; set; }
        public string Gender { get; set; }
        public List<SelectListItem> GenderList { get; set; } = new List<SelectListItem>
        {
            new SelectListItem{Value="Male",Text="Male"},
            new SelectListItem{Value="Female",Text="Female"}   
        };

        public string ActivityLevel { get; set; }
        public List<SelectListItem> ActivityLevelList { get; set; } = new List<SelectListItem>
        {
            new SelectListItem{Value="Sedentary", Text="Sedentary"},
            new SelectListItem{Value="Light", Text="Light"},
            new SelectListItem{Value="Moderate", Text="Moderate"},
            new SelectListItem{Value="Vigorous", Text="Vigorous"},
            new SelectListItem{Value="Extreme", Text="Extreme"}
            



        };
        public DateTime Birthday { get; set; }
        public int Age
        {
            get;
            set;
        }
        public double NumOcal { get; set; }
        public double Bmr { get; set; }
        
        public double FoodCalories
        {
            //ActivityLevel




            get;

            set;


        }



        [DataContract]
        public class DataPoint
        {
            public DataPoint(string label, double y)
            {
                this.Label = label;
                this.Y = y;
            }



    }
}
