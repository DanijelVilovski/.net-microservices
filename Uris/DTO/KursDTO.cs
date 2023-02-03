using System.ComponentModel.DataAnnotations;

namespace Uris.DTO
{
    public class KursDTO
    {
        public int Id { get; set; }

        public DateTime Datum { get; set; }

        public string Valuta { get; set; }
    }
}
