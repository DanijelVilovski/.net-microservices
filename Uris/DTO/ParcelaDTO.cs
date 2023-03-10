using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Uris.Models;

namespace Uris.DTO
{
    public class ParcelaDTO
    {
        public int Id { get; set; }

        public int BrojParcele { get; set; }

        public int BrojListaNepokretnosti { get; set; }

        public float Povrsina { get; set; }

        public bool ZasticenaZona { get; set; }

        public OblikSvojine OblikSvojine { get; set; }

        public Odvodnjavanje Odvodnjavanje { get; set; }

        public int KulturaID { get; set; }

        public int KvalitetZemljistaID { get; set; }

        public int KatastarskaOpstinaID { get; set; }

        //public Kupac Kupac { get; set; }
    }
}
