using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipSistemiAPP.DAL.DTO
{
    public class SatisDetayDTO
    {
        public string UrunAd { get; set; }
        public string MusteriAd { get; set; }
        public string KategoriAd { get; set; }
        public int Fiyat { get; set; }
        public DateTime SatisTarihi { get; set; }
        public int SatisMiktar { get; set; }
        public int StokMiktar { get; set; }
        public int UrunID { get; set; }
        public int MusteriID { get; set; }
        public int KategoriID { get; set; }
        public int SatisID { get; set; }

        public bool kDeleted { get; set; }
        public bool mDeleted { get; set; }
        public bool uDeleted { get; set; }
    }
}
