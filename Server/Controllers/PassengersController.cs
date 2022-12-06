using Microsoft.AspNetCore.Mvc;
using Server.Models;
using Server.Services;
using DataPenumpang;

namespace Server.Controllers
{
    [Route("jendelatravel/[controller]")]
    [ApiController]
    public class PassengersController : Controller
    {
        private readonly PassengerRepos passengerRepos;

        public PassengersController()
        {
            this.passengerRepos = new PassengerRepos();
        }

        // GET: jendelatravel/<PassengersController>
        [HttpGet]
        public List<Penumpang> Get()
        {
            return passengerRepos.GetAllPassenger();
        }

        //GET: jendelatravel/<PassengersController>/:id
        [HttpGet("{KodeBooking}")]
        public Penumpang Get([FromRoute]string KodeBooking)
        {
            return passengerRepos.GetPassengerById(KodeBooking);
        }

        //POST: jendelatravel/<PassengersController>/
        [HttpPost]
        public void Post([FromBody]Penumpang penumpang)
        {
            passengerRepos.AddPassenger(penumpang);
        }

        //DELETE: jendelatravel/<PassengersController>/:id
        [HttpDelete("{KodeBooking}")]
        public void Delete([FromRoute]string KodeBooking)
        {
            passengerRepos.DeletePassenger(KodeBooking);
        }
    }
}
