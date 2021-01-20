using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static FianlGUI.Models.FatTrack;

namespace FianlGUI.Controllers
{
    public class GraphController : Controller
    {
		public ActionResult Index()
		{
			List<DataPoint> dataPoints = new List<DataPoint>();

			dataPoints.Add(new DataPoint("Calories Left", Model.CalLeft));
			dataPoints.Add(new DataPoint("Calories Had", Model.Calalreadyhad));
			dataPoints.Add(new DataPoint("Weight Lost", Model.WeightLost));

			ViewBag.DataPoints = JsonConvert.SerializeObject(dataPoints);

			return View();
		}
	}
}
