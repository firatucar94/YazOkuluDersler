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
 public   class DerslerDal
    {
        public static List<EntityDersler> DersListesi()
        {
            List<EntityDersler> degerler = new List<EntityDersler>();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Dersler", Baglanti.bgl);

            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }

            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityDersler entityDersler = new EntityDersler
                {
                    DersId = Convert.ToInt32(dr[0]),
                    DersAd = dr[1].ToString(),
                    DersMinKon = Convert.ToInt32(dr[2]),
                    DersMaxKon = Convert.ToInt32(dr[3])

                };
                degerler.Add(entityDersler);
            }
            dr.Close();
            return degerler;
        }

        public static int TalepEkle(EntityBasvuru entityBasvuru)
        {

            SqlCommand komut = new SqlCommand("insert into Tbl_Basvuru (OgrId,DersId) values (@p1,@p2)",Baglanti.bgl);
            komut.Parameters.AddWithValue("@p1",entityBasvuru.OgrId);
            komut.Parameters.AddWithValue("@p2", entityBasvuru.DersId);

            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }

            return komut.ExecuteNonQuery();

        }

    }
}
