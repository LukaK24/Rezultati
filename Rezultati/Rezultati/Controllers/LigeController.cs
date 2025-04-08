using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rezultati.Data;

namespace Rezultati.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class LigeController : ControllerBase  // Nasljeđuješ ControllerBase
    {
        // koristimo dependency injection
        private readonly RezultatiContext _context;

        // Konstruktor sa dependency injection
        public LigeController(RezultatiContext context)
        {
            _context = context;
        }

        // HTTP GET metoda za dohvat svih liga
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                // Vraćamo sve lige
                return Ok(_context.Lige);
            }
            catch (Exception e)
            {
                // Ako dođe do greške, vraćamo HTTP 400 i poruku greške
                return BadRequest(e.Message);
            }
        }

        // HTTP GET metoda za dohvat lige prema šifri
        [HttpGet]
        [Route("{sifra:int}")]
        public IActionResult GetBysifra(int sifra)
        {
            try
            {
                // Traži entitet sa zadatom šifrom (ID)
                var liga = _context.Lige.Find(sifra);

                // Provjera da li je pronađen entitet
                if (liga == null)
                {
                    // Ako nije pronađen, vraćamo HTTP 404
                    return NotFound();
                }

                // Ako je pronađen, vraćamo HTTP 200 i entitet
                return Ok(liga);
            }
            catch (Exception e)
            {
                // Ako dođe do greške, vraćamo HTTP 400 i poruku greške
                return BadRequest(e.Message);
            }
        }
    }
}
