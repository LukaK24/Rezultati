using System.ComponentModel.DataAnnotations;

namespace Rezultati.Models
{
    public class Liga : Entitet  // Ime klase promijenjeno u 'Liga' za konvenciju
    {
        [Required]  // Ovdje osiguravamo da 'Naziv' mora biti prisutan
        [StringLength(100)]  // Ovdje možemo definirati maksimalnu duljinu naziva
        public string Naziv { get; set; } = "";  // Koristimo PascalCase za svojstva

        [Required]
        [StringLength(100)]
        public string Drzava { get; set; } = "";  // Također, PascalCase i validacija
    }
}
