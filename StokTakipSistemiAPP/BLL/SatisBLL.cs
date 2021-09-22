using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakipSistemiAPP.DAL.DAO;
using StokTakipSistemiAPP.DAL.DTO;
using StokTakipSistemiAPP.DAL;

namespace StokTakipSistemiAPP.BLL
{
    public class SatisBLL : IBLL<SatisDetayDTO, SatisDTO>
    {
        KategoriDAO kategorilerDAO = new KategoriDAO();
        MusteriDAO musterilerDAO = new MusteriDAO();
        UrunDAO urunlerDAO = new UrunDAO();
        SatisDAO dao = new SatisDAO();
        public bool Delete(SatisDetayDTO entity)
        {
            SATIS satis = new SATIS();
            satis.ID = entity.SatisID;
            dao.Delete(satis);
            urunlerDAO.stokGuncelle(entity);
            return true;
        }
        public bool GetBack(SatisDetayDTO entity)
        {
            dao.GetBack(entity.SatisID);
            URUN urun = new URUN();
            urun.ID = entity.UrunID;
            int temp = entity.StokMiktar + entity.SatisMiktar;
            urun.Stok = temp;
            urunlerDAO.Update(urun);
            return true;
        }
        public bool Insert(SatisDetayDTO entity)
        {
            SATIS satis = new SATIS();
            satis.UrunID = entity.UrunID;
            satis.MusteriID = entity.MusteriID;
            satis.SatisMiktar = entity.SatisMiktar;
            satis.SatisTarih = DateTime.Today;
            satis.SatisFiyat = entity.Fiyat;
            satis.KategoriID = entity.KategoriID;
            dao.Insert(satis);
            //Burada Satis yaptık ve ürün update ile stok miktarı değiştirilir.
            URUN urun = new URUN();
            urun.ID = entity.UrunID;
            int temp = entity.StokMiktar - entity.SatisMiktar;
            urun.Stok = temp;
            urunlerDAO.Update(urun);
            return true;
        }

        public SatisDTO Select()
        {
            SatisDTO dto = new SatisDTO();
            dto.Kategoriler = kategorilerDAO.Select();
            dto.Musteriler = musterilerDAO.Select();
            dto.Urunler = urunlerDAO.Select();
            dto.Satislar = dao.Select();
            return dto;
        }
        public SatisDTO Select(bool deleted)
        {
            SatisDTO dto = new SatisDTO();
            dto.Kategoriler = kategorilerDAO.Select(deleted);
            dto.Musteriler = musterilerDAO.Select(deleted);
            dto.Urunler = urunlerDAO.Select(deleted);
            dto.Satislar = dao.Select(deleted);
            return dto;
        }

        public bool Update(SatisDetayDTO entity)
        {
            SATIS satis = new SATIS();
            satis.SatisMiktar = entity.SatisMiktar;
            satis.ID = entity.SatisID;
            dao.Update(satis);
            //Satış miktarı değişeceği için stokta değişecek bu nedenle toplam stoktan yapılan satış düşülür.
            int temp = entity.StokMiktar;
            URUN urun = new URUN();
            urun.Stok = entity.StokMiktar - (entity.SatisMiktar - temp);
            urun.ID = entity.UrunID;
            urunlerDAO.Update(urun);
            return true;
        }
    }
}
