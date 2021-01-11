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
    public partial class Dersler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                List<EntityDersler> entityDerslers = BllDersler.DersListeleBll();
                DropDownList1.DataSource = BllDersler.DersListeleBll();
                DropDownList1.DataTextField = "DersAd";
                DropDownList1.DataValueField = "DersId";
                DropDownList1.DataBind();

            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // TextBox1.Text = DropDownList1.SelectedValue.ToString();
            EntityBasvuru entityBasvuru = new EntityBasvuru();
            entityBasvuru.OgrId = Convert.ToInt32(TextBox1.Text);
            entityBasvuru.DersId = Convert.ToInt32(DropDownList1.SelectedValue);

            BllDersler.BllTalepEkle(entityBasvuru);

        }
    }
}