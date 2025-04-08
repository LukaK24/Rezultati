using System.ComponentModel.DataAnnotations;

namespace Rezultati.Models
{
    public abstract class Entitet
    {
        [Key]
        public int Sifra { get; set; }  // Jedinstveni identifikator (primarni ključ)
    }
}
