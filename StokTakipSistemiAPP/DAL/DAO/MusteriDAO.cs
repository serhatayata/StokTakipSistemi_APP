using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakipSistemiAPP.DAL.DTO;
namespace StokTakipSistemiAPP.DAL.DAO
{
    public class MusteriDAO : StokContext, IDAO<MUSTERI, MusteriDetayDTO>
    {
        public bool Delete(MUSTERI entity)
        {
            MUSTERI mm = db.MUSTERI.First(x => x.ID == entity.ID);
            mm.isDeleted = true;
            mm.DeletedDate = DateTime.Today;
            db.SaveChanges();
            return true;
        }
        public bool GetBack(int ID)
        {
            MUSTERI mm = db.MUSTERI.First(x => x.ID == ID);
            db.SaveChanges();
            mm.isDeleted = false;
            return true;
        }
        public bool Insert(MUSTERI entity)
        {
            try
            {
                db.MUSTERI.Add(entity);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<MusteriDetayDTO> Select()
        {
            try
            {
                List<MusteriDetayDTO> liste = new List<MusteriDetayDTO>();
                var list = db.MUSTERI.Where(x => x.isDeleted == false);
                foreach (var item in list)
                {
                    MusteriDetayDTO dto = new MusteriDetayDTO();
                    dto.ID = item.ID;
                    dto.MusteriAd = item.MusteriAD;
                    liste.Add(dto);
                }
                return liste;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<MusteriDetayDTO> Select(bool deleted)
        {
            try
            {
                List<MusteriDetayDTO> liste = new List<MusteriDetayDTO>();
                var list = db.MUSTERI.Where(x => x.isDeleted == deleted);
                foreach (var item in list)
                {
                    MusteriDetayDTO dto = new MusteriDetayDTO();
                    dto.ID = item.ID;
                    dto.MusteriAd = item.MusteriAD;
                    liste.Add(dto);
                }
                return liste;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Update(MUSTERI entity)
        {
            try
            {
                MUSTERI mm = db.MUSTERI.First(x => x.ID == entity.ID);
                mm.MusteriAD = entity.MusteriAD;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
