using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoItinerariesAPI.WebAPI.Models
{
    public class Itinerary
    {
        [JsonProperty("calculatedRoutes")]
        public List<int> CalculatedRoutes;
        [JsonProperty("calculatedDistance")]
        public double Distance;
        [JsonProperty("score")]
        public double Score;
        [JsonProperty("message")]
        public string Message;
    }
}