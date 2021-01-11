using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
  public  class BllDersler
    {
        public static List<EntityDersler> DersListeleBll()
        {
            return DerslerDal.DersListesi();

        }

        public static int BllTalepEkle(EntityBasvuru entityBasvuru)
        {
            if(entityBasvuru.OgrId !=null && entityBasvuru.DersId != null)
            {
                return DerslerDal.TalepEkle(entityBasvuru);
            }

            return -1;

        }

    }
}
