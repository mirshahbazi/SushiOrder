using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

public partial class _Default : System.Web.UI.Page
{
    List<string> controlIdList = new List<string>();
    int counter = 0;
    protected MySqlConnection cn = new MySqlConnection("database=sushiorder;server=localhost;user id=root;password=masterkey");
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

            double totalCart = Convert.ToDouble(Session["TotalCart"]);
            total_cart.InnerText = "€" + Convert.ToDouble(Session["TotalCart"]);
            carrello_mobile.InnerText = "€" + Convert.ToDouble(Session["TotalCart"]);

            CreateDynamicProductList(MyProducts);
        }
    }





    public void CreateDynamicProductList(Products prodS)
    {
        counter++;
        foreach (Product p in prodS)
        {
            Button btn = new Button();
            btn.Text = "Rimuovi dal carrello";
            btn.ID = p.ID.ToString();
            btn.Click += Btn_Click1;
            btn.CssClass = "waves-effect waves-light btn orange";

            LiteralControl div_card = new LiteralControl("<div class=\"card col s12\" style=\"text-align:center !IMPORTANT; padding-bottom:10px;padding-top:10px\">");
            LiteralControl div_3 = new LiteralControl("<div class=\"col s3\" style=\"text-align:center !IMPORTANT\">");
            LiteralControl img = new LiteralControl("<img src=\"img/bg_blur.jpg\" style=\"width:100%\"/>");
            LiteralControl div_3card_closing = new LiteralControl("</div>");
            LiteralControl div_10 = new LiteralControl("<div class=\"col s9\" style=\"text-align:center !IMPORTANT\">");
            LiteralControl Title = new LiteralControl("<h5 style=\"text-align:center !IMPORTANT\">" + p.Name + "</h5>");
            LiteralControl Description = new LiteralControl("<p style=\"text-align:center !IMPORTANT\">" + p.Description + "</p>");
            LiteralControl TABLE = new LiteralControl("<table> <tr> <td>QUANTITY</td> <td>INGRIEDIENTS</td> <td>PRICE</td> </tr>  <tr> <td>" + p.Quantity + "</td> <td>" + "x" + "</td> <td style=\"color:red\">" + "€ " + p.Price + "</td> </tr></table>");
            LiteralControl div_10card_closing = new LiteralControl("</div>");
            LiteralControl div_card_closing = new LiteralControl("</div>");

            plholder.Controls.Add(div_card);
            plholder.Controls.Add(div_3);
            plholder.Controls.Add(img);
            plholder.Controls.Add(div_3card_closing);
            plholder.Controls.Add(div_10);
            plholder.Controls.Add(Title);
            plholder.Controls.Add(Description);
            plholder.Controls.Add(TABLE);
            plholder.Controls.Add(btn);
            plholder.Controls.Add(div_10card_closing);
            plholder.Controls.Add(div_card_closing);

        }
    }

    private void Btn_Click1(object sender, EventArgs e)
    {
        Button thisbtn = (Button)sender;

        int id = int.Parse(thisbtn.ID);
        var i = MyProducts.FindIndex(a => a.ID == id);

        double thisValue = MyProducts[i].Price;

        Session["TotalCart"] = Convert.ToDouble(Session["TotalCart"]) - thisValue;
        total_cart.InnerText = "€" + Convert.ToDouble(Session["TotalCart"]);

        MyProducts.RemoveAt(i);

        Session["MyProducts"] = MyProducts;
        Response.Redirect("cart.aspx");
    }
}