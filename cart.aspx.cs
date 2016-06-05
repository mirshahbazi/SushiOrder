using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using testProducts;

public partial class _Default : System.Web.UI.Page
{ 
    List<string>   controlIdList = new List<string>();
    int                  counter = 0;
    protected MySqlConnection cn = new MySqlConnection("database=Sql932431_2;server=62.149.150.176;user id=Sql932431;password=8i78d0gow3");
    Products MyProducts;



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

            if (Session["MyCart"] != null)
            {
                MyProducts = ((Products)Session["MyCart"]);
            }
			            if (Session["MyCart"] == null)
            {
                MyProducts = ((Products)Session["MyCart"]);
            }

            double totalCart          =      Convert.ToDouble(Session["TotalCart"]);
            total_cart.InnerText = "Carrello: €" + Convert.ToDouble(Session["TotalCart"]);
            carrello_mobile.InnerText = "Carrello: €" + Convert.ToDouble(Session["TotalCart"]);

            cart_info.InnerText = "Totale Carrello: €" + totalCart + " - Item: " + MyProducts.Count;
            CreateDynamicProductList(MyProducts);
        }
    }





    public void CreateDynamicProductList(Products prodS)
    {
        counter++;
        foreach (Product p in prodS)
        {
            Button btn   = new Button();
            btn.Text     = "Rimuovi";
            btn.ID       = p.ID.ToString();
            btn.Click   += Btn_Click1;
            btn.CssClass = "waves-effect waves-light btn blue orange";


            string x = p.ImgUri + ".jpg";


            LiteralControl a = new LiteralControl("<div class=\"col s12 m7 center-block\">");
            LiteralControl b = new LiteralControl("<div class=\"card\">");
            LiteralControl c = new LiteralControl("<div class=\"card-image\">");
            LiteralControl d = new LiteralControl("<img src=\"img/" + x + "\">");
            LiteralControl e = new LiteralControl("<span class=\"card-title\">" + p.Name + "</span>");
            LiteralControl f = new LiteralControl("</div>");
            LiteralControl g = new LiteralControl("<div class=\"card-content\"  style=\"text-align:right\">");
            LiteralControl h = new LiteralControl("<p style=\"text-align:right\">" + p.Description + "</p>");
            LiteralControl i = new LiteralControl("<p style=\"text-align:right\"><b> € " + p.Price + "</b></p>");
            LiteralControl l = new LiteralControl("</div>");
            LiteralControl m = new LiteralControl("<div class=\"card-action\" style=\"text-align:right\">");
            LiteralControl n = new LiteralControl("</div>");
            LiteralControl o = new LiteralControl("</div>");
            LiteralControl pa = new LiteralControl("</div>");



            plholder.Controls.Add(a);
            plholder.Controls.Add(b);
            plholder.Controls.Add(c);
            plholder.Controls.Add(d);
            plholder.Controls.Add(e);
            plholder.Controls.Add(f);
            plholder.Controls.Add(g);
            plholder.Controls.Add(h);
            plholder.Controls.Add(i);
            plholder.Controls.Add(l);
            plholder.Controls.Add(m);
            plholder.Controls.Add(btn);
            plholder.Controls.Add(n);
            plholder.Controls.Add(o);
            plholder.Controls.Add(pa);

            //LiteralControl div12 = new LiteralControl("<div class=\"card col s12\" style=\"text-align:center !IMPORTANT; padding-bottom:10px;padding-top:10px;\">");
            //LiteralControl div6 = new LiteralControl("<div class=\"frame col s6\" style=\"text-align:center !IMPORTANT;\">");
            //LiteralControl img = new LiteralControl("<span class=\"helper\"></span><img src=\"img/" + x + "\" style=\"width:100%;max-width:500px;padding:20px;vertical-align:middle\"/>");
            //LiteralControl div6close = new LiteralControl("</div>");
            //LiteralControl div6big = new LiteralControl("<div class=\"col s6\" style=\"text-align:center\">");

            //LiteralControl div4 = new LiteralControl("<table class=\"responsive-table striped\" style=\"margin-top:40px !IMPORTANT\">");
            //LiteralControl Title = new LiteralControl("<tr> <td>" + p.Name + "</td> <td style=\"color:red;\">" + "€ " + p.Price + "</td>");

            //LiteralControl td = new LiteralControl("<td style=\"text-align:right !IMPORTANT\">");
            //LiteralControl td1 = new LiteralControl("<td> </tr>");
            //LiteralControl div4close = new LiteralControl("</table>");
            //LiteralControl div12close1 = new LiteralControl("</div>");
            //LiteralControl div12close2 = new LiteralControl("</div>");


            //LiteralControl div4price =                    new LiteralControl("<div class=\"col s4\" style=\"text-align:right !IMPORTANT\">");
            //LiteralControl price                          = new LiteralControl("<p style=\"text-align:right !IMPORTANT\">" +"€ "+ p.Price + "</p>");
            //LiteralControl div4priceclose                    = new LiteralControl("</div>");
            //LiteralControl dv4btn =                             new LiteralControl("<div class=\"col s4\" style=\"text-align:right !IMPORTANT\">");
            //LiteralControl dv4btnclose = new LiteralControl("</div>");

            //LiteralControl TABLE = new LiteralControl(" <tr> <td>CONTENENTE</td> <td>INGRIEDIENTI</td> <td>PREZZO</td> </tr>  <tr> <td>" + p.Quantity + "</td> <td>" + p.Ingriedients + "</td> <td style=\"color:red;text-align:right\">" + "€ " + p.Price + "</td> </tr></table>");
            //LiteralControl div6bigclose = new LiteralControl("</div>");
            //LiteralControl div12close = new LiteralControl("</div>");

            //plholder.Controls.Add(div12);
            //plholder.Controls.Add(div6);
            //plholder.Controls.Add(img);
            //plholder.Controls.Add(div6close);
            //plholder.Controls.Add(div6big);
            //plholder.Controls.Add(div4);
            //plholder.Controls.Add(Title);
            //plholder.Controls.Add(td);
            //plholder.Controls.Add(btn);
            //plholder.Controls.Add(td1);
            //plholder.Controls.Add(div4close);

            //plholder.Controls.Add(div12close1);
            //plholder.Controls.Add(div12close2);
            //plholder.Controls.Add(dv4btnclose);


            //plholder.Controls.Add(TABLE);
            //plholder.Controls.Add(div6bigclose);
            //plholder.Controls.Add(div12close);
        }
    }

    private void Btn_Click1(object sender, EventArgs e)
    {
        Button thisbtn = (Button)sender;

        int id = int.Parse(thisbtn.ID);
        var i  = MyProducts.FindIndex(a => a.ID == id);

        double thisValue = MyProducts[i].Price;

        Session["TotalCart"] = Convert.ToDouble(Session["TotalCart"]) - thisValue;
        total_cart.InnerText = "Carrello: €" + Convert.ToDouble(Session["TotalCart"]);
        carrello_mobile.InnerText = "Carrello: €" + Convert.ToDouble(Session["TotalCart"]);

        MyProducts.RemoveAt(i);

        Session["MyProducts"] = MyProducts;
        Response.Redirect("cart.aspx");
    }
}