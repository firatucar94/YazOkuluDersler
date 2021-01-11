using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
 public   class BllOgrenci
    {
        public static int OgrEkleBll (EntityOgrenci entityOgrenci)
        {
            if (entityOgrenci.OgrAd!=null && entityOgrenci.OgrSoyad!=null && entityOgrenci.OgrNumara!=null && entityOgrenci.OgrSifre!=null && entityOgrenci.OgrFoto!=null)
            {
                return OgrenciDal.OgrEkle(entityOgrenci);

            }

            return -1;
        }

        public static List<EntityOgrenci> OgrListeleBll()
        {
            return OgrenciDal.OgrListesi();

        }

        public static bool OgrSilBll(int p)
        {
            if (p != null)
            {
                return OgrenciDal.OgrSil(p);
            }

            return false;
        }

        public static List<EntityOgrenci> OgrGuncelleBll(int id)
        {
            return OgrenciDal.OgrGuncelle(id);

        }

        public static bool OgrUpdateBll(EntityOgrenci entityOgrenci)
        {
            if (entityOgrenci.OgrAd != null && entityOgrenci.OgrSoyad != null && entityOgrenci.OgrNumara != null && entityOgrenci.OgrSifre != null && entityOgrenci.OgrFoto != null && entityOgrenci.OgrId>0)
            {
                return OgrenciDal.OgrUpdate(entityOgrenci);
            }

            return false;

        }

    }
}
