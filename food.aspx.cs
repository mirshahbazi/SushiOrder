using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

public partial class _Default : System.Web.UI.Page
{
    List<string> controlIdList = new List<string>();
    int counter = 0;
    protected MySqlConnection cn = new MySqlConnection("database=sushiorder;server=localhost;user id=root;password=masterkey");

    protected override void LoadViewState(object savedState)
    {
        base.LoadViewState(savedState);
        //before page loading here

        controlIdList = (List<string>)ViewState["controlIdList"]; //riconverto!!

        foreach (string Id in controlIdList)
        {
            counter++;

            Label lb = new Label();
            lb.ID = "TextBox" + counter;
            lb.Text = "ciao";

            counter++;
            TextBox tb1 = new TextBox();
            tb1.ID = "TextBox" + counter;
            tb1.BackColor = System.Drawing.ColorTranslator.FromHtml("#eeeeee");
            tb1.BorderStyle = BorderStyle.Ridge;
            LiteralControl lineBreak = new LiteralControl("<div class=\"col-md-6\" style=\"text-align:right;border-right:solid\">");
            plholder.Controls.Add(lineBreak);
            plholder.Controls.Add(lb);
            LiteralControl lineBreak1 = new LiteralControl("</div>");
            plholder.Controls.Add(lineBreak1);
            LiteralControl lineBreak2 = new LiteralControl("<div class=\"col-md-6\"> ");
            plholder.Controls.Add(lineBreak2);
            plholder.Controls.Add(tb1);
            LiteralControl lineBreak13 = new LiteralControl("</div>");
            plholder.Controls.Add(lineBreak13);
        }
    }

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
                Test(dr[1].ToString(), dr[4].ToString());
            }







            //session active

        }
    }
    public void Test(string dbK, string dbV)
    {
        counter++;

        Label lblDescription = new Label();
        lblDescription.ID = "TextBox" + counter;
        lblDescription.Text = dbK + " ";

        Label lblPrezzo = new Label();
        lblPrezzo.ID = "TextBox" + counter;
        lblPrezzo.Text =" €"+ dbV;

        counter++;
        TextBox txtPrezzo = new TextBox();
        txtPrezzo.ID = "TextBox" + counter;
        txtPrezzo.BackColor = System.Drawing.ColorTranslator.FromHtml("#eeeeee");
        txtPrezzo.BorderStyle = BorderStyle.Ridge;
        txtPrezzo.Text = dbV;
        txtPrezzo.Enabled = false;

        //style=\"text-align:right;border-right:solid;margin-top:10px\

        LiteralControl div_card = new LiteralControl("<div class=\"card\" style=\"text-align:center\">");

        plholder.Controls.Add(div_card);
        //plholder.Controls.Add(lblDescription);

        //LiteralControl K = new LiteralControl("<p>" + dbK + " <//p>");
        //LiteralControl D = new LiteralControl("<p>"+dbV+" <//p>");
        plholder.Controls.Add(lblDescription);
        plholder.Controls.Add(lblPrezzo);
        //LiteralControl lineBreak1 = new LiteralControl("</div>");
        //plholder.Controls.Add(lineBreak1);
        //LiteralControl lineBreak2 = new LiteralControl("<div class=\"col-md-6 card\" style=\"margin-top:5px\"> ");
        //plholder.Controls.Add(lineBreak2);
        //plholder.Controls.Add(lblPrezzo);
        LiteralControl div_card_closing = new LiteralControl("</div>");
        plholder.Controls.Add(div_card_closing);

        controlIdList.Add(lblDescription.ID);
        controlIdList.Add(lblDescription.Text);
        ViewState["controlIdList"] = controlIdList; //Salvo gli id de nuovi generati qui (td)

        //tb perse dopo in postback......in teoria
    }

}