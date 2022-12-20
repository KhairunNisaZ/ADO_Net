using Microsoft.AspNetCore.Mvc;
using Server.Services;
using DataPenumpang;
using Microsoft.AspNetCore.Mvc.Routing;

public class Passanger
{
    public string Nama { get { return this.Nama; } set { this.Nama = value; } }
    public string Nik { get { return this.Nik; } set { this.Nik = value; } }
    public string Tujuan { get { return this.Tujuan; } set { this.Tujuan = value; } }
    public string Kursi { get { return this.Kursi; } set { this.Kursi = value; } }
    public string Jenis { get { return this.Jenis; } set { this.Jenis = value; } }
    public string Tanggal { get { return this.Tanggal; } set { this.Tanggal = value; } }
    public string KodeBooking { get { return this.KodeBooking; } set { this.KodeBooking = value; } }
    public string Updater { get { return this.Updater; } set { this.Updater = value; } }
    public string Harga { get { return this.Harga; } set { this.Harga = value; } }

    public Passanger()
    {

    }
}


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

        [HttpPut("{KodeBooking}")]
        public void Put([FromBody]Passanger passanger)
        {

            passengerRepos.UpdatePassenger(passanger);
        }
    }
}
