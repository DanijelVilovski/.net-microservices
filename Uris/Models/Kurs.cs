using System.ComponentModel.DataAnnotations;

namespace Uris.Models
{
    public class Kurs
    {
        [Required]
        public int Id { get; set; }

        public DateTime Datum{ get; set; }

        public string Valuta{ get; set; }
    }
}
