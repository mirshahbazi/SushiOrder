using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Base"] == null)
        {

        }
        else
        {
            if (Session["TotalCart"] == null)
            {
                Session["TotalCart"] = 0;
            }


            double totalCart = Convert.ToDouble(Session["TotalCart"]);
            total_cart.InnerText = "€" + Convert.ToDouble(Session["TotalCart"]);
            carrello_mobile.InnerText = "€" + Convert.ToDouble(Session["TotalCart"]);
        }
    }
}