using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

public partial class _Default : System.Web.UI.Page
{
    protected MySqlConnection cn;
    private   Products        MyProducts;



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

            double totalCart          =       Convert.ToDouble(Session["TotalCart"]);
            total_cart.InnerText      = "€" + Convert.ToDouble(Session["TotalCart"]);
            carrello_mobile.InnerText = "€" + Convert.ToDouble(Session["TotalCart"]);

        }
    }

    protected void btnSubmit_ServerClick(object sender, EventArgs e)
    {
        string nome       = first_name     .Value;
        string cognome    = last_name      .Value;
        string email      = myEmail        .Text;
        string telefono   = icon_telephone .Value;
        string dataRitiro = dtpicker       .Value;
        string oraRitiro  = selectOraRitiro.Value;

       

        if(!cartcheckbox.Checked)
        {
            errore.InnerText = "DEVI CONFERMARE IL CARRELLO PRIMA DI ODINARE!";
            return;
        }
        
        if(nome == "" || nome == null)
        {
            errore.InnerText = "DEVI INSERIRE UN NOME!";
            return;
        }
        if (cognome == "" || cognome == null)
        {
            errore.InnerText = "DEVI INSERIRE UN COGNOME!";
            return;
        }
        if (email == "" || email == null)
        {
            errore.InnerText = "DEVI INSERIRE UNA EMAIL!";
            return;
        }
        if (telefono == "" || telefono == null)
        {
            errore.InnerText = "DEVI INSERIRE UN NUMERO DI TELEFONO!";
            return;
        }
        if (dataRitiro == "" || dataRitiro == null)
        {
            errore.InnerText = "DEVI INSERIRE LA DATA DEL RITIRO!";
            return;
        }
        if (oraRitiro == "" || oraRitiro == null)
        {
            errore.InnerText = "DEVI INSERIRE L'ORA DEL RITIRO!";
            return;
        }


        cn = new MySqlConnection("database=sushiorder;server=localhost;user id=root;password=masterkey");

        string qry = "INSERT INTO CUSTOMERS VALUES (null, @NAME, @SURNAME,02-02-2016, @CELL, @MAIL)";

        MySqlCommand cmd = new MySqlCommand(qry, cn);
        cmd.Parameters.AddWithValue("@NAME",       nome);
        cmd.Parameters.AddWithValue("@SURNAME", cognome);
        cmd.Parameters.AddWithValue("@CELL",   telefono);
        cmd.Parameters.AddWithValue("@MAIL",      email);


        cn.Open();
        cmd.ExecuteNonQuery();
        cn.Close();

        if (MyProducts == null)
        {
            errore.InnerText = "ATTENZIONE! IL TUO CARRELLO E' VUOTO";
            return;
        }

        cn = new MySqlConnection("database=sushiorder;server=localhost;user id=root;password=masterkey");

        string qry1 = "SELECT idcustomer FROM CUSTOMERS WHERE  NAME = \""+nome+ "\" AND SURNAME = \"" + cognome + "\" AND CELL = \"" + telefono + "\"";

        MySqlCommand cmd1 = new MySqlCommand(qry1, cn);

        
        cn.Open();
        MySqlDataReader dr = cmd1.ExecuteReader();
        int id = -1;
        while (dr.Read())
        {
            id = Convert.ToInt32(dr[0].ToString());
        }

        cn.Close();

        UpdateTable(MyProducts, id, dataRitiro);
        Response.Write(@"<script language='javascript'>alert('The following errors have occurred: \n" +"ok"+" .');</script>");
    }

    public void UpdateTable(Products ps, int id, string datar)
    {
        cn         = new MySqlConnection("database=sushiorder;server=localhost;user id=root;password=masterkey");
        string qry = "INSERT INTO SHOPPINGCART VALUES (@IDCUSTOMER, @IDPRODUCT, @ORDERDATE, @PICKUPDATE, @TOTAL, @PAYMETHOD, @NOTES)";

        foreach (Product p in ps)
        {
            MySqlCommand cmd = new MySqlCommand(qry, cn);
            cmd.Parameters.AddWithValue("@IDCUSTOMER",                         id);
            cmd.Parameters.AddWithValue("@IDPRODUCT",                 p.IdProduct);
            cmd.Parameters.AddWithValue("@ORDERDATE",                DateTime.Now);
            cmd.Parameters.AddWithValue("@PICKUPDATE",                      datar);
            cmd.Parameters.AddWithValue("@TOTAL",                         p.Price);
            cmd.Parameters.AddWithValue("@PAYMETHOD", "\"" + "not defined" + "\"");
            cmd.Parameters.AddWithValue("@NOTES",        "\"" + "no notes" + "\"");

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        Session.Clear();
        Session.RemoveAll();

        Response.Redirect("index.aspx");
    }
}