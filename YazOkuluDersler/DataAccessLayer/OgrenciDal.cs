using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;

namespace DataAccessLayer
{
  public  class OgrenciDal
    {
        public static int OgrEkle(EntityOgrenci entityOgrenci)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Ogrenci  (OgrAd,OgrSoyad,OgrNumara,OgrFoto,OgrSifre) values (@p1,@p2,@p3,@p4,@p5)", Baglanti.bgl);

            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }

            komut.Parameters.AddWithValue("@p1",entityOgrenci.OgrAd);
            komut.Parameters.AddWithValue("@p2", entityOgrenci.OgrSoyad);
            komut.Parameters.AddWithValue("@p3", entityOgrenci.OgrNumara);
            komut.Parameters.AddWithValue("@p4", entityOgrenci.OgrFoto);
            komut.Parameters.AddWithValue("@p5", entityOgrenci.OgrSifre);

            return komut.ExecuteNonQuery();
        }

        public static List<EntityOgrenci> OgrListesi()
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Ogrenci",Baglanti.bgl);

            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }

            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci entityOgrenci = new EntityOgrenci
                {
                    OgrId = Convert.ToInt32(dr[0]),
                    OgrAd = dr[1].ToString(),
                    OgrSoyad = dr[2].ToString(),
                    OgrNumara = dr[3].ToString(),
                    OgrFoto = dr[4].ToString(),
                    OgrSifre = dr[5].ToString(),
                    OgrBakiye = Convert.ToDouble(dr[6])
                          };
                degerler.Add(entityOgrenci);
                    }
            dr.Close();
            return degerler;
        }

        public static bool OgrSil(int deger)
        {
            SqlCommand komut = new SqlCommand("Delete From Tbl_Ogrenci where OgrId=@p1",Baglanti.bgl);
            
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }

            komut.Parameters.AddWithValue("@p1", deger);
            return komut.ExecuteNonQuery() > 0;
        }

        public static List<EntityOgrenci> OgrGuncelle(int id)
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Ogrenci where OgrId=@p1", Baglanti.bgl);
            komut.Parameters.AddWithValue("@p1",id);

            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }


            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci entityOgrenci = new EntityOgrenci
                {
                    
                    OgrAd = dr[1].ToString(),
                    OgrSoyad = dr[2].ToString(),
                    OgrNumara = dr[3].ToString(),
                    OgrFoto = dr[4].ToString(),
                    OgrSifre = dr[5].ToString(),
                    OgrBakiye = Convert.ToDouble(dr[6])
                };
                degerler.Add(entityOgrenci);
            }
            dr.Close();
            return degerler;
        }

        public static bool OgrUpdate(EntityOgrenci deger)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Ogrenci set OgrAd=@p1,OgrSoyad=@p2,OgrNumara=@p3,OgrFoto=@p4,OgrSifre=@p5 where OgrId=@p6",Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }

            komut.Parameters.AddWithValue("@p1",deger.OgrAd);
            komut.Parameters.AddWithValue("@p2", deger.OgrSoyad);
            komut.Parameters.AddWithValue("@p3", deger.OgrNumara);
            komut.Parameters.AddWithValue("@p4", deger.OgrFoto);
            komut.Parameters.AddWithValue("@p5", deger.OgrSifre);
            komut.Parameters.AddWithValue("@p6", deger.OgrId);

            return komut.ExecuteNonQuery() > 0;
        }
    }
}
