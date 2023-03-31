using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ParksExplorer.Models
{
  public class Park
  {
    public int ParkId { get; set; }
    public string Name { get; set; }
    public string Classification { get; set; }
    public string Location { get; set; }
    public string MajorLandmarks { get; set; }
    public string Activities { get; set;}
    public string Facilities { get; set; }
    public int YearFounded { get; set; }

    public static List<Park> GetParks()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Park> parkList = JsonConvert.DeserializeObject<List<Park>>(jsonResponse.ToString());

      return parkList;
    }
  }
}