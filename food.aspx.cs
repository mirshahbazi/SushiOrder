﻿using System;
using System.Collections.Generic;
using System.Web;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

public partial class _Default : System.Web.UI.Page
{
    List<string> controlIdList   = new List<string>();
    int                counter   = 0;
    protected MySqlConnection cn = new MySqlConnection("database=sushiorder;server=localhost;user id=root;password=masterkey");
    Products AllProducts         = new Products();
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
            if (Session["MyCart"] == null)
            {
            }

            if (Session["MyCart"] != null)
            {
                MyProducts = ((Products)Session["MyCart"]);
            }




            double totalCart          =       Convert.ToDouble(Session["TotalCart"]);
            total_cart.InnerText      = "€" + Convert.ToDouble(Session["TotalCart"]);
            carrello_mobile.InnerText = "€" + Convert.ToDouble(Session["TotalCart"]);

            string       qry = "SELECT * FROM PRODUCTS";
            MySqlCommand cmd = new MySqlCommand(qry, cn);

            //-------------------
            //open the connection
            //-------------------
            cn.Open();


            MySqlDataReader dr = cmd.ExecuteReader();


            int count = 0;
            while (dr.Read())
            {
                count++;
                string a = dr[7].ToString();
                bool   x = Convert.ToBoolean(dr[7]);

                AllProducts.Add(new Product(count, Convert.ToInt32(dr[0]), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), Convert.ToDouble(dr[5]), dr[6].ToString(), x, dr[8].ToString()));
            }


            CreateDynamicProductList(AllProducts);
        }
    }

    public void CreateDynamicProductList(Products prodS)
    {
        counter++;
        foreach (Product p in prodS)
        {
            Button btn   = new Button();
            btn.Text     = "Aggiungi";
            btn.ID       = p.ID.ToString();
            btn.Click   += Btn_Click;
            btn.CssClass = "waves-effect waves-light btn green";

            string x = p.ImgUri + ".jpg";

            LiteralControl div_card            = new LiteralControl("<div class=\"card col s12\" style=\"text-align:center !IMPORTANT; padding-bottom:10px;padding-top:10px;\">");
            LiteralControl div_3               = new LiteralControl("<div class=\"frame col s6\" style=\"text-align:center !IMPORTANT;\">");
            LiteralControl img = new LiteralControl("<span class=\"helper\"></span><img src=\"img/" + x + "\" style=\"width:100%;max-width:500px;padding:20px;vertical-align:middle\"/>");
            LiteralControl div_3card_closing   = new LiteralControl("</div>");
            LiteralControl div_10              = new LiteralControl("<div class=\"col s6\" style=\"text-align:center !IMPORTANT\">");
            LiteralControl Title               = new LiteralControl("<h5 style=\"text-align:center !IMPORTANT\">" + p.Name.ToUpper() + "</h5>");
            LiteralControl Description         = new LiteralControl("<p style=\"text-align:center !IMPORTANT\">" + p.Description + "</p>");
            LiteralControl TABLE = new LiteralControl("<table class=\"responsive-table striped\"> <tr> <td>CONTENENTE</td> <td>INGRIEDIENTI</td> <td>PREZZO</td> </tr>  <tr> <td>" + p.Quantity + "</td> <td>" + p.Ingriedients + "</td> <td style=\"color:red;text-align:right\">" + "€ " + p.Price + "</td> </tr></table>");
            LiteralControl dib_btn             = new LiteralControl("<div class=\"responsive-table striped\" style=\"text-align:right; margin-top:10px\">");
            LiteralControl div_101card_closing = new LiteralControl("</div>");
            LiteralControl div_10card_closing  = new LiteralControl("</div>");
            LiteralControl div_card_closing    = new LiteralControl("</div>");

            plholder.Controls.Add(div_card);
            plholder.Controls.Add(div_3);
            plholder.Controls.Add(img);
            plholder.Controls.Add(div_3card_closing);
            plholder.Controls.Add(div_10);
            plholder.Controls.Add(Title);
            plholder.Controls.Add(Description);
            plholder.Controls.Add(TABLE);
            plholder.Controls.Add(dib_btn);
            plholder.Controls.Add(btn);
            plholder.Controls.Add(div_101card_closing);
            plholder.Controls.Add(div_10card_closing);
            plholder.Controls.Add(div_card_closing);

        }
    }

    private void Btn_Click(object sender, EventArgs e)
    {
        Session["Count"] = (int)Session["Count"] + 1;
        Button thisbtn = (Button)sender;

        int id = int.Parse(thisbtn.ID);

        var i = AllProducts.FindIndex(a => a.ID == id);

        //  int[] v = MyProducts.Select((b, y) => b.ID == id ? i : -1).Where(y => y != -1).ToArray();


        //   var itwice = MyProducts.FindIndex(a => a.ID == id);

        //   if (itwice != -1)
        //   {
        //      int tmp = MyProducts.Count +1 ;

        //     var x = MyProducts.FindIndex(a => a.ID == tmp);

        //      MyProducts.AddItem(tmp, AllProducts[i].IdProduct, AllProducts[i].Name, AllProducts[i].Description, AllProducts[i].Quantity, AllProducts[i].Ingriedients, AllProducts[i].Price, AllProducts[i].Notes, AllProducts[i].IsFrozen, AllProducts[i].ImgUri);
        //  }

        //else
        MyProducts.AddItem((int)Session["Count"], AllProducts[i].IdProduct, AllProducts[i].Name, AllProducts[i].Description, AllProducts[i].Quantity, AllProducts[i].Ingriedients, AllProducts[i].Price, AllProducts[i].Notes, AllProducts[i].IsFrozen, AllProducts[i].ImgUri);



        double thisValue = AllProducts[i].Price;

        // string txt = total_cart.InnerText.ToString().Remove(0, 1);
        //double txtValue = Convert.ToDouble(txt);

        Session["TotalCart"] = Convert.ToDouble(Session["TotalCart"]) + thisValue;
        total_cart.InnerText = "€" + Convert.ToDouble(Session["TotalCart"]);

        Session["MyCart"] = MyProducts;
        //Session["TotalCart"] = MyProducts;
        //Session["TotalCart"]
        //ic++;
        //Button tmpbtn = (Button)sender;
        //string[] tmp = tmpbtn.ID.Split(';');
        //cartitems.AddItem(ic, Convert.ToInt32(tmp[1]), Convert.ToDouble(tmp[0]));

        ////only desktop price 


        //string i = total_cart.InnerText.ToString();
        //string i1 = total_cart.InnerText.ToString().Remove(0, 1);

        //double value = Convert.ToDouble(i1);
        //value += Convert.ToDouble(tmp[1]);
        //Session["TotalCart"] = Convert.ToDouble(Session["TotalCart"]) + value;

        //total_cart.InnerText = "€" + Convert.ToDouble(Session["TotalCart"]); 
    }
}