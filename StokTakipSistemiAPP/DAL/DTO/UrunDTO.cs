using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakipSistemiAPP.DAL.DTO;
namespace StokTakipSistemiAPP.DAL.DTO
{
    public class UrunDTO
    {
        public List<UrunDetayDTO> Urunler { get; set; }
        public List<KategoriDetayDTO> Kategoriler { get; set; }
    }
}
