using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace FianlGUI.Models
{
    public class CompleteInfo
    {
        private static List<FatTrack> models = new List<FatTrack>();

        public static IEnumerable<FatTrack> ListModels
        {
            
            get { return models; }
        }

        
        public static void addModel(FatTrack newModel)
        {
            
            models.Add(newModel);
        }
    }
}
