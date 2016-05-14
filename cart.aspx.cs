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

            Test((CartItems)Session["ListCart"]);

        }
    }
    public void Test(CartItems c)
    {
        counter++;

        //Button btn = new Button();
        //btn.Text = "Aggiungi Al carrello";
        //btn.ID = c.pri;
        //btn.Click += Btn_Click;

        foreach(Item i in CartItems)
        {
            
        }


        LiteralControl div_card = new LiteralControl("<div class=\"card\" style=\"text-align:center !IMPORTANT\">");

        plholder.Controls.Add(div_card);

        LiteralControl Title = new LiteralControl("<h5 style=\"text-align:center !IMPORTANT\">" + title + "</h5>");
        LiteralControl Description = new LiteralControl("<p style=\"text-align:center !IMPORTANT\">" + description + "</p>");


        LiteralControl TABLE = new LiteralControl("<table> <tr> <td>QUANTITY</td> <td>INGRIEDIENTS</td> <td>PRICE</td> </tr>  <tr> <td>" + qty + "</td> <td>" + ingriedients + "</td> <td>" + price + "</td> </tr></table>");
        plholder.Controls.Add(Title);
        plholder.Controls.Add(Description);
        plholder.Controls.Add(TABLE);
        plholder.Controls.Add(btn);

        LiteralControl div_card_closing = new LiteralControl("</div>");
        plholder.Controls.Add(div_card_closing);

    }

    private void Btn_Click(object sender, EventArgs e)
    {
        //only desktop price 
        Button tmpbtn = (Button)sender;

        string i = total_cart.InnerText.ToString();
        string i1 = total_cart.InnerText.ToString().Remove(0, 1);

        double value = Convert.ToDouble(i1);
        value += Convert.ToDouble(tmpbtn.ID);
        Session["TotalCart"] = Convert.ToDouble(Session["TotalCart"]) + value;

        total_cart.InnerText = "€" + Convert.ToDouble(Session["TotalCart"]);
    }
}