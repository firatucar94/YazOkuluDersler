using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;

namespace YazOkuluDersler
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityOgrenci entityOgrenci = new EntityOgrenci

            {
                OgrAd = txtOgrAd.Text,
                OgrSoyad = txtOgrSoyad.Text,
                OgrNumara = txtOgrNo.Text,
                OgrFoto = txtOgrFoto.Text,
                OgrSifre = txtOgrSifre.Text,

            };

            BllOgrenci.OgrEkleBll(entityOgrenci);

        }



    }

}