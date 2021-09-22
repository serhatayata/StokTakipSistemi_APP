using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipSistemiAPP.DAL.DTO
{
    public class UrunDetayDTO
    {
        public int ID { get; set; }
        public string UrunAd { get; set; }
        public string KategoriAd { get; set; }
        public int StokMiktari { get; set; }
        public int Fiyat { get; set; }
        public int KategoriID { get; set; }
        public bool isStokEkleme { get; set; }
        public bool isKategoriDeleted { get; set; }
    }
}
