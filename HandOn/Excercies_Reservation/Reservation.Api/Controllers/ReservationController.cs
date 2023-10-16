using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Reservation.Repository;
using Reservation.Repository.Model;
using Reservation.Repository.Repo;

namespace Reservation.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReservationController : ControllerBase
    {
        private IRepo repository;
        public ReservationController(IRepo repo) => repository = repo;

        [HttpGet]
        public IEnumerable<Reservations> Get() => repository.Reservations;

        [HttpGet("{id}")]
        public ActionResult<Reservations> Get(int id)
        {
            if (id == 0)
                return BadRequest("Value must be passed in the request body.");
            return Ok(repository[id]);
        }

        [HttpPost]
        public Reservations Post([FromBody] Reservations res) =>
        repository.AddReservation(new Reservations
        {
            Name = res.Name,
            StartLocation = res.StartLocation,
            EndLocation = res.EndLocation
        });

        [HttpPut]
        public Reservations Put([FromForm] Reservations res) => repository.UpdateReservation(res);

        [HttpPatch("{id}")]
        public StatusCodeResult Patch(int id, [FromBody] JsonPatchDocument<Reservations> patch)
        {
            var res = (Reservations)((OkObjectResult)Get(id).Result).Value;
            if (res != null)
            {
                patch.ApplyTo(res);
                return Ok();
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public void Delete(int id) => repository.DeleteReservation(id);

    }
}
