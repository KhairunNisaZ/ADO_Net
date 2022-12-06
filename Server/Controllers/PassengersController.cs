using Microsoft.AspNetCore.Mvc;
using Server.Models;
using Server.Services;

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
        public List<Passenger> Get()
        {
            return passengerRepos.GetAllPassenger();
        }

        //GET: jendelatravel/<PassengersController>/:id
        [HttpGet("{id}")]
        public Passenger Get(int id)
        {
            return passengerRepos.GetPassengerById(id);
        }

        //POST: jendelatravel/<PassengersController>/
        [HttpPost]
        public void Post()
        {
            passengerRepos.AddPassenger();
        }

        //DELETE: jendelatravel/<PassengersController>/:id
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            passengerRepos.DeletePassenger(id);
        }
    }
}
