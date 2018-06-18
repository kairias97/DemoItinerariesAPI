using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoItinerariesAPI.WebAPI.Models
{
    public class ItineraryRequest
    {
        [JsonProperty("city")]
        public string City;
        [JsonProperty("maxDistance")]
        public double MaxDistance;
        [JsonProperty("maxVisitTime")]
        public double MaxVisitTime;
        [JsonProperty("placesPreference")]
        public double[] PlacesPreference;
        [JsonProperty("firstVisit")]
        public double FirstVisit;
        [JsonProperty("lastVisit")]
        public double LastVisit;

    }
}