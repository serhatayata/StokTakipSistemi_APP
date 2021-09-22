using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakipSistemiAPP.DAL.DAO;
using StokTakipSistemiAPP.DAL.DTO;
using StokTakipSistemiAPP.DAL;
namespace StokTakipSistemiAPP.DAL.DAO
{
    public class UrunDAO : StokContext, IDAO<URUN, UrunDetayDTO>
    {
        public bool Delete(URUN entity)
        {
            if (entity.ID != 0)
            {
                URUN urun = db.URUN.First(x => x.ID == entity.ID);
                urun.isDeleted = true;
                urun.DeletedDate = DateTime.Today;
                db.SaveChanges();
            }
            else if (entity.KategoriID != 0)
            {
                List<URUN> list = db.URUN.Where(x=> x.KategoriID == entity.KategoriID).ToList();
                foreach (var item in list)
                {
                    item.isDeleted = true;
                    item.DeletedDate = DateTime.Today;
                    List<SATIS> satis = db.SATIS.Where(x=> x.UrunID == item.ID).ToList();
                    foreach (var item2 in satis)
                    {
                        item2.isDeleted = true;
                        item2.DeletedDate = DateTime.Today;
                    }
                    db.SaveChanges();
                }
                db.SaveChanges();
            }
            return true;
        }

        public bool GetBack(int ID)
        {
            URUN urun = db.URUN.First(x=> x.ID == ID);
            urun.isDeleted = false;
            db.SaveChanges();
            return true;
        }

        public bool Insert(URUN entity)
        {
            try
            {
                db.URUN.Add(entity);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        internal void stokGuncelle(SatisDetayDTO entity)
        {
            URUN urun = db.URUN.First(x => x.ID == entity.UrunID);
            int temp = urun.Stok + entity.SatisMiktar;
            urun.Stok = temp;
            db.SaveChanges();
        }

        public List<UrunDetayDTO> Select()
        {
            List<UrunDetayDTO> liste = new List<UrunDetayDTO>();
            var list = (from u in db.URUN.Where(x=> x.isDeleted == false)
                        join
                        k in db.KATEGORI on u.KategoriID equals k.ID
                        select new
                        {
                            urunAd = u.UrunAd,
                            stok = u.Stok,
                            fiyat = u.Fiyat,
                            urunID = u.ID,
                            kategoriAd = k.KategoriAD,
                            kategoriID = k.ID
                        }
                        ).OrderBy(x => x.urunAd).ToList();
            foreach (var item in list)
            {
                UrunDetayDTO dto = new UrunDetayDTO();
                dto.Fiyat = item.fiyat;
                dto.ID = item.urunID;
                dto.KategoriAd = item.kategoriAd;
                dto.KategoriID = item.kategoriID;
                dto.StokMiktari = item.stok;
                dto.UrunAd = item.urunAd;
                liste.Add(dto);
            }
            return liste;
        }
        public List<UrunDetayDTO> Select(bool deleted)
        {
            List<UrunDetayDTO> liste = new List<UrunDetayDTO>();
            var list = (from u in db.URUN.Where(x => x.isDeleted == deleted)
                        join
                        k in db.KATEGORI on u.KategoriID equals k.ID
                        select new
                        {
                            urunAd = u.UrunAd,
                            stok = u.Stok,
                            fiyat = u.Fiyat,
                            urunID = u.ID,
                            kategoriAd = k.KategoriAD,
                            kategoriID = k.ID,
                            kategoriisDeleted = k.isDeleted
                        }
                        ).OrderBy(x => x.urunAd).ToList();
            foreach (var item in list)
            {
                UrunDetayDTO dto = new UrunDetayDTO();
                dto.Fiyat = item.fiyat;
                dto.ID = item.urunID;
                dto.KategoriAd = item.kategoriAd;
                dto.KategoriID = item.kategoriID;
                dto.StokMiktari = item.stok;
                dto.UrunAd = item.urunAd;
                dto.isKategoriDeleted = item.kategoriisDeleted;
                liste.Add(dto);
            }
            return liste;
        }


        public bool Update(URUN entity)
        {
            try
            {
                URUN urun = db.URUN.First(x=> x.ID == entity.ID);
                //BLL'de fiyata dair bir işlem yapmadık bu nedenle urun.fiyat 0 dır.
                //If için onu kullanabiliriz.
                if (true)
                {
                    if (entity.Fiyat ==0)
                    {
                        urun.Stok = entity.Stok;
                    }
                    else
                    {
                        urun.KategoriID = entity.KategoriID;
                        urun.UrunAd = entity.UrunAd;
                        urun.Fiyat = entity.Fiyat;
                    }
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
