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
    public partial class OgrGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            int x = Convert.ToInt32(Request.QueryString["OgrId"]);
            txtOgrId.Text = x.ToString();
            txtOgrId.Enabled = false;

            if (Page.IsPostBack == false)
            {

                List<EntityOgrenci> OgrList = BllOgrenci.OgrGuncelleBll(x);

                txtOgrAd.Text = OgrList[0].OgrAd.ToString();
                txtOgrSoyad.Text = OgrList[0].OgrSoyad.ToString();
                txtOgrNo.Text = OgrList[0].OgrNumara.ToString();
                txtOgrFoto.Text = OgrList[0].OgrFoto.ToString();
                txtOgrSifre.Text = OgrList[0].OgrSifre.ToString();

            }
        }





        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityOgrenci entityOgrenci = new EntityOgrenci();
            entityOgrenci.OgrAd = txtOgrAd.Text;
            entityOgrenci.OgrSoyad = txtOgrSoyad.Text;
            entityOgrenci.OgrNumara = txtOgrNo.Text;
            entityOgrenci.OgrFoto = txtOgrFoto.Text;
            entityOgrenci.OgrSifre = txtOgrSifre.Text;
            entityOgrenci.OgrId = Convert.ToInt32(txtOgrId.Text);

            BllOgrenci.OgrUpdateBll(entityOgrenci);
            Response.Redirect("OgrenciListesi.aspx");

        }
    }
}