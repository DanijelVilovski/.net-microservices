using Uris.DTO;

namespace Uris.Data
{
    public class KursStore
    {
        public static List<KursDTO> kursLista = new List<KursDTO>()
        {
            new KursDTO {Id=1, Valuta="rsd", Datum=DateTime.Now},

            new KursDTO {Id=2, Valuta="eur", Datum=DateTime.Now},

            new KursDTO {Id=3, Valuta="hrk", Datum=DateTime.Now}
        };
    }
}
