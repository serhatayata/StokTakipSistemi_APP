using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakipSistemiAPP.DAL;
using StokTakipSistemiAPP.DAL.DTO;
using StokTakipSistemiAPP.DAL.DAO;

namespace StokTakipSistemiAPP.DAL.DAO
{
    public class KategoriDAO : StokContext, IDAO<KATEGORI, KategoriDetayDTO>
    {
        public bool Delete(KATEGORI entity)
        {
            KATEGORI kk = db.KATEGORI.First(x=> x.ID == entity.ID);
            kk.isDeleted = true;
            kk.DeletedDate = DateTime.Today;
            db.SaveChanges();
            return true;
        }
        public bool GetBack(int ID)
        {
            KATEGORI kk = db.KATEGORI.First(x => x.ID == ID);
            kk.isDeleted = false;
            db.SaveChanges();
            return true;
        }

        public bool Insert(KATEGORI entity)
        {
            try
            {
                db.KATEGORI.Add(entity);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<KategoriDetayDTO> Select()
        {
            try
            {
                var list = db.KATEGORI.Where(x=> x.isDeleted == false);
                List<KategoriDetayDTO> liste = new List<KategoriDetayDTO>();

                foreach (var item in list)
                {
                    KategoriDetayDTO dto = new KategoriDetayDTO();
                    dto.ID = item.ID;
                    dto.KategoriAd = item.KategoriAD;
                    liste.Add(dto);
                }
                return liste;
            }
            catch (Exception ex)
            {
                throw ex;
            } 
        }
        public List<KategoriDetayDTO> Select(bool deleted)
        {
            try
            {
                var list = db.KATEGORI.Where(x => x.isDeleted == deleted);
                List<KategoriDetayDTO> liste = new List<KategoriDetayDTO>();

                foreach (var item in list)
                {
                    KategoriDetayDTO dto = new KategoriDetayDTO();
                    dto.ID = item.ID;
                    dto.KategoriAd = item.KategoriAD;
                    liste.Add(dto);
                }
                return liste;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Update(KATEGORI entity)
        {
            try
            {
                KATEGORI kt = db.KATEGORI.First(x => x.ID == entity.ID);
                kt.KategoriAD = entity.KategoriAD;
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
