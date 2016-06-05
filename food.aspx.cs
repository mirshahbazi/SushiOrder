using System;
using System.Collections.Generic;
using System.Web;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using testProducts;

public partial class _Default : System.Web.UI.Page
{
    List<string> controlIdList   = new List<string>();
    int                counter   = 0;
    protected MySqlConnection cn = new MySqlConnection("database=y;server=x;user id=b;password=a");
    Products AllProducts         = new Products();
    Products MyProducts = new Products();



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
            //if (Session["MyCart"] == null)
            //{
            //    MyProducts = ((Products)Session["MyCart"]);
            //}

            if (Session["MyCart"] != null)
            {
                MyProducts = ((Products)Session["MyCart"]);
            }




            double totalCart          =       Convert.ToDouble(Session["TotalCart"]);
            total_cart.InnerText      = "Carrello: €" + Convert.ToDouble(Session["TotalCart"]);
            carrello_mobile.InnerText = "Carrello: €" + Convert.ToDouble(Session["TotalCart"]);

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

            LiteralControl a = new LiteralControl("<div class=\"col s12 m7 center-block\">");
    LiteralControl b = new LiteralControl("<div class=\"card\">");
    LiteralControl c = new LiteralControl("<div class=\"card-image\">");
    LiteralControl d = new LiteralControl("<img src=\"img/"+x+"\">");
    LiteralControl e = new LiteralControl("<span class=\"card-title\">"+p.Name+"</span>");
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



            //LiteralControl div4price =                    new LiteralControl("<div class=\"col s4\" style=\"text-align:right !IMPORTANT\">");
            //LiteralControl price                          = new LiteralControl("<p style=\"text-align:right !IMPORTANT\">" +"€ "+ p.Price + "</p>");
            //LiteralControl div4priceclose                    = new LiteralControl("</div>");
            //LiteralControl dv4btn =                             new LiteralControl("<div class=\"col s4\" style=\"text-align:right !IMPORTANT\">");
            //LiteralControl dv4btnclose = new LiteralControl("</div>");

            //LiteralControl TABLE = new LiteralControl(" <tr> <td>CONTENENTE</td> <td>INGRIEDIENTI</td> <td>PREZZO</td> </tr>  <tr> <td>" + p.Quantity + "</td> <td>" + p.Ingriedients + "</td> <td style=\"color:red;text-align:right\">" + "€ " + p.Price + "</td> </tr></table>");
            //LiteralControl div6bigclose = new LiteralControl("</div>");
            //LiteralControl div12close = new LiteralControl("</div>");

          //  plholder.Controls.Add(div12);
          //            plholder.Controls.Add(div6);
          //                 plholder.Controls.Add(img);
          //            plholder.Controls.Add(div6close);
          //  plholder.Controls.Add(div6big);
          //   plholder.Controls.Add(div4);
          //   plholder.Controls.Add(Title);
          //   plholder.Controls.Add(td);
          //plholder.Controls.Add(btn);
          //plholder.Controls.Add(td1);
          //plholder.Controls.Add(div4close);

          //  plholder.Controls.Add(div12close1);
          //  plholder.Controls.Add(div12close2);
          //  //plholder.Controls.Add(dv4btnclose);


            //plholder.Controls.Add(TABLE);
            //plholder.Controls.Add(div6bigclose);
            //plholder.Controls.Add(div12close);
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
        total_cart.InnerText = "Carrello: €" + Convert.ToDouble(Session["TotalCart"]);
        carrello_mobile.InnerText = "Carrello: €" + Convert.ToDouble(Session["TotalCart"]);

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