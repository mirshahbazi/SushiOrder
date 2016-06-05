﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using testProducts;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        Products MyProducts = new Products();


        if (Session["Base"] == null)
        {
            Session["Base"] = "Attivo";
            Session["MyCart"] = MyProducts;
            Session["Count"] = 0;
            Session["TotalCart"] = 0;

        }


        if (Session["TotalCart"] != null)
        {
            double totalCart = Convert.ToDouble(Session["TotalCart"]);
            total_cart.InnerText = "Carrello: €" + Convert.ToDouble(Session["TotalCart"]);
            carrello_mobile.InnerText = "Carrello: €" + Convert.ToDouble(Session["TotalCart"]);
        }

    }
}