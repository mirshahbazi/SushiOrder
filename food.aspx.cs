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
        if(Session["Base"] == null)
        {
            
        }
        else
        {


            string qry = "SELECT * FROM PRODUCTS";
            MySqlCommand cmd = new MySqlCommand(qry, cn);

            //-------------------
            //open the connection
            //-------------------
            cn.Open();


            MySqlDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {
                Test(dr[1].ToString(), dr[2].ToString(), dr[4].ToString(), dr[3].ToString(), dr[5].ToString());
            }







            //session active

        }
    }
    public void Test(string title, string description, string ingriedients, string qty, string price)
    {
        counter++;

        Button btn = new Button();
        btn.Text = "Aggiungi Al carrello";
        btn.ID = price;
        btn.Click += Btn_Click;

        LiteralControl div_card = new LiteralControl("<div class=\"card\" style=\"text-align:center !IMPORTANT\">");

        plholder.Controls.Add(div_card);

        LiteralControl Title = new LiteralControl("<h5 style=\"text-align:center !IMPORTANT\">" + title + "</h5>");
        LiteralControl Description = new LiteralControl("<p style=\"text-align:center !IMPORTANT\">" + description + "</p>");


        LiteralControl TABLE = new LiteralControl("<table> <tr> <td>QUANTITY</td> <td>INGRIEDIENTS</td> <td>PRICE</td> </tr>  <tr> <td>"+qty+"</td> <td>"+ingriedients+"</td> <td>" + price + "</td> </tr></table>");
        plholder.Controls.Add(Title);
        plholder.Controls.Add(Description);
        plholder.Controls.Add(TABLE);
        plholder.Controls.Add(btn);

        LiteralControl div_card_closing = new LiteralControl("</div>");
        plholder.Controls.Add(div_card_closing);

    }

    private void Btn_Click(object sender, EventArgs e)
    {
        Button tmpbtn = (Button)sender;
        string i = total_cart.InnerText.ToString();
        string i1 = total_cart.InnerText.ToString().Remove(0, 1);
        double value = Convert.ToDouble(i1);
        value += Convert.ToDouble(tmpbtn.ID);

        total_cart.InnerText = "€" + value; 
    }
}