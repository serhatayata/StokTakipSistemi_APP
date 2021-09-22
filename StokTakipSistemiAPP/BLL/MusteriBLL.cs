using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakipSistemiAPP.DAL.DTO;
using StokTakipSistemiAPP.DAL.DAO;
using StokTakipSistemiAPP.DAL;
namespace StokTakipSistemiAPP.BLL
{
    public class MusteriBLL : IBLL<MusteriDetayDTO, MusteriDTO>
    {
        MusteriDAO dao = new MusteriDAO();
        public bool Delete(MusteriDetayDTO entity)
        {
            MUSTERI musteri = new MUSTERI();
            musteri.ID = entity.ID;
            dao.Delete(musteri);
            return true;
        }

        public bool GetBack(MusteriDetayDTO entity)
        {
            return dao.GetBack(entity.ID);
        }
        public bool Insert(MusteriDetayDTO entity)
        {
            MUSTERI musteri = new MUSTERI();
            musteri.MusteriAD = entity.MusteriAd;
            musteri.isDeleted = false;
            return dao.Insert(musteri);
        }
        public MusteriDTO Select()
        {
            MusteriDTO dto = new MusteriDTO();
            dto.Musteriler = dao.Select();
            return dto;
        }
        public bool Update(MusteriDetayDTO entity)
        {
            MUSTERI musteri = new MUSTERI();
            musteri.ID = entity.ID;
            musteri.MusteriAD = entity.MusteriAd;
            return dao.Update(musteri);
        }
    }
}
