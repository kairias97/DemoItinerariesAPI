using DemoItinerariesAPI.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoItinerariesAPI.WebAPI.Controllers
{
    [RoutePrefix("api/v1/itineraries")]
    public class ItinerariesController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage CalculateItinerary([FromBody] ItineraryRequest body)
        {
            var response = new Itinerary()
            {
                CalculatedRoutes = new List<int>() { 1, 2, 3, 4 },
                Distance = body.MaxDistance,
                Score = 15.04,
                Message = String.Format("Se calculó la ruta en la ciudad de {0} iniciando en {1} y terminando en {2}",
                body.City, body.FirstVisit, body.LastVisit)
            };
            return Request.CreateResponse(HttpStatusCode.OK, response);
        }
    }
}
