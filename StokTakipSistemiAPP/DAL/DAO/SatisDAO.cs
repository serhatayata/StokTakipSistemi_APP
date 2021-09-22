using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakipSistemiAPP.DAL.DTO;
using StokTakipSistemiAPP.DAL.DAO;

namespace StokTakipSistemiAPP.DAL.DAO
{
    public class SatisDAO : StokContext, IDAO<SATIS, SatisDetayDTO>
    {
        public bool Delete(SATIS entity)
        {
            try
            {
                if (entity.ID != 0)
                {
                    SATIS satis = db.SATIS.First(x => x.ID == entity.ID);
                    satis.isDeleted = true;
                    satis.DeletedDate = DateTime.Today;
                    db.SaveChanges();
                }
                else if (entity.UrunID != 0)
                {
                    List<SATIS> list = db.SATIS.Where(x => x.UrunID == entity.UrunID).ToList();
                    foreach (var item in list)
                    {
                        item.isDeleted = true;
                        item.DeletedDate = DateTime.Today;
                    }
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool GetBack(int ID)
        {
            SATIS ss = db.SATIS.First(x=> x.ID == ID);
            ss.isDeleted = false;
            db.SaveChanges();
            return true;
        }

        public bool Insert(SATIS entity)
        {
            try
            {
                db.SATIS.Add(entity);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<SatisDetayDTO> Select()
        {
            try
            {
                List<SatisDetayDTO> liste = new List<SatisDetayDTO>();
                var list = (from s in db.SATIS.Where(x=> x.isDeleted ==false)
                            join u in db.URUN on s.UrunID equals u.ID
                            join k in db.KATEGORI on s.KategoriID equals k.ID
                            join m in db.MUSTERI on s.MusteriID equals m.ID
                            select new
                            {
                                musteriAd = m.MusteriAD,
                                urunAd = u.UrunAd,
                                kategoriAd = k.KategoriAD,
                                fiyat = s.SatisFiyat,
                                satisTarihi = s.SatisTarih,
                                satisMiktari = s.SatisMiktar,
                                stok = u.Stok,
                                satisId = s.ID,
                                urunId = u.ID,
                                musteriId = s.MusteriID,
                                kategoriId = s.KategoriID
                            }
                    ).OrderBy(x => x.satisTarihi);
                foreach (var item in list)
                {
                    SatisDetayDTO dto = new SatisDetayDTO();
                    dto.MusteriAd = item.musteriAd;
                    dto.UrunAd = item.urunAd;
                    dto.KategoriAd = item.kategoriAd;
                    dto.Fiyat = item.fiyat;
                    dto.SatisTarihi = item.satisTarihi;
                    dto.SatisMiktar = item.satisMiktari;
                    dto.StokMiktar = item.stok;
                    dto.SatisID = item.satisId;
                    dto.UrunID = item.urunId;
                    dto.MusteriID = item.musteriId;
                    dto.KategoriID = item.kategoriId;
                    liste.Add(dto);
                }
                return liste;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<SatisDetayDTO> Select(bool deleted)
        {
            try
            {
                List<SatisDetayDTO> liste = new List<SatisDetayDTO>();
                var list = (from s in db.SATIS.Where(x => x.isDeleted == deleted)
                            join u in db.URUN on s.UrunID equals u.ID
                            join k in db.KATEGORI on s.KategoriID equals k.ID
                            join m in db.MUSTERI on s.MusteriID equals m.ID
                            select new
                            {
                                musteriAd = m.MusteriAD,
                                urunAd = u.UrunAd,
                                kategoriAd = k.KategoriAD,
                                fiyat = s.SatisFiyat,
                                satisTarihi = s.SatisTarih,
                                satisMiktari = s.SatisMiktar,
                                stok = u.Stok,
                                satisId = s.ID,
                                urunId = u.ID,
                                musteriId = s.MusteriID,
                                kategoriId = s.KategoriID,
                                kategoriDeleted = k.isDeleted,
                                musteriDeleted = m.isDeleted,
                                urunDeleted = u.isDeleted
                            }
                    ).OrderBy(x => x.satisTarihi);
                foreach (var item in list)
                {
                    SatisDetayDTO dto = new SatisDetayDTO();
                    dto.MusteriAd = item.musteriAd;
                    dto.UrunAd = item.urunAd;
                    dto.KategoriAd = item.kategoriAd;
                    dto.Fiyat = item.fiyat;
                    dto.SatisTarihi = item.satisTarihi;
                    dto.SatisMiktar = item.satisMiktari;
                    dto.StokMiktar = item.stok;
                    dto.SatisID = item.satisId;
                    dto.UrunID = item.urunId;
                    dto.MusteriID = item.musteriId;
                    dto.KategoriID = item.kategoriId;
                    dto.kDeleted = item.kategoriDeleted;
                    dto.mDeleted = item.musteriDeleted;
                    dto.uDeleted = item.urunDeleted;
                    liste.Add(dto);
                }
                return liste;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public bool Update(SATIS entity)
        {
            SATIS SS = db.SATIS.First(x=> x.ID == entity.ID);
            SS.SatisMiktar = entity.SatisMiktar;
            db.SaveChanges();
            return true;

        }
    }
}
