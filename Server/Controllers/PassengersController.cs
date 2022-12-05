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

        //GET: jendelatravel/<PassengersController>/2
        [HttpGet("{id}")]
        public Passenger Get(int id)
        {
            return passengerRepos.GetPassengerById(id);
        }


    }
}
