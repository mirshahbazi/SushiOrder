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

            CreateDynamicProductList(MyProducts);
        }
    }





    public void CreateDynamicProductList(Products prodS)
    {
        counter++;
        foreach (Product p in prodS)
        {
            Button btn = new Button();
            btn.Text = "Rimuovi Dal Carrello";
            btn.ID = p.ID.ToString();
            btn.Click += Btn_Click1; ;

            LiteralControl div_card = new LiteralControl("<div class=\"card\" style=\"text-align:center !IMPORTANT\">");
            LiteralControl Title = new LiteralControl("<h5 style=\"text-align:center !IMPORTANT\">" + p.Name + "</h5>");
            LiteralControl Description = new LiteralControl("<p style=\"text-align:center !IMPORTANT\">" + p.Description + "</p>");
            LiteralControl TABLE = new LiteralControl("<table> <tr> <td>QUANTITY</td> <td>INGRIEDIENTS</td> <td>PRICE</td> </tr>  <tr> <td>" + p.Quantity + "</td> <td>" + "x" + "</td> <td>" + p.Price + "</td> </tr></table>");
            LiteralControl div_card_closing = new LiteralControl("</div>");

            plholder.Controls.Add(div_card);
            plholder.Controls.Add(Title);
            plholder.Controls.Add(Description);
            plholder.Controls.Add(TABLE);
            plholder.Controls.Add(btn);
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