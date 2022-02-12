using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace dsistajwebarac
{
    public partial class bamir : System.Web.UI.Page
    {
        MySqlConnection connection;
        protected void Page_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection("Data Source =localhost; User=root; password =1234 ; Integrated Security = True; database =dsistaj; SslMode = none");
            connection.Open();
            if (!this.IsPostBack)
            {

                string constr = ConfigurationManager.ConnectionStrings["dsistajConnectionString"].ConnectionString;

                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    int pamir_ID = globalsinifim.pamir_ID;
                    using (MySqlCommand cmd = new MySqlCommand("SELECT personel.p_ID, personel.p_ad_soyad,gidilecek_yerler.yer_ID, gidilecek_yerler.adres, gorev.tarih_saat  " +
                                                                         " FROM gorev " +
                                                                         " INNER JOIN gidilecek_yerler ON gorev.yer_ID = gidilecek_yerler.yer_ID " +
                                                                         " INNER JOIN personel ON gorev.personel_ID = personel.p_ID " +
                                                                         " WHERE gorev.bamir_onay=0 and gorev.bsofor_onay=0 and personel.amirpersonel_ID =" + pamir_ID))
                    {
                        using (MySqlDataAdapter sda = new MySqlDataAdapter())
                        {
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;

                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                GridView1.DataSource = dt;
                                GridView1.DataBind();
                            }
                        }
                    }
                }
            }

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "get")
            {
                int index = Convert.ToInt32(e.CommandArgument);// get row index which you select 
                GridViewRow row = GridView1.Rows[index];// get the row 
                                                        //Response.Write(GridView1.Rows[index].Cells[1].Text);// get the text in the cell you select in the row

                int personel_ID = Convert.ToInt32(GridView1.DataKeys[index].Values["p_ID"].ToString());

                int yer_ID = Convert.ToInt32(GridView1.DataKeys[index].Values["yer_ID"].ToString());

                MySqlCommand com3 = connection.CreateCommand();
                com3.CommandText = "update gorev set bamir_onay=1 where yer_ID=" + yer_ID + " AND personel_ID=" + personel_ID;
                MySqlDataReader reader3 = com3.ExecuteReader();

                if (reader3.RecordsAffected > 0)
                {
                    Response.AppendHeader("Refresh", "4;url=bamir.aspx");
                    Label1.Text = "PERSONELİNİZİN ARAÇ İSTEĞİ BAŞ ŞOFÖRE İLETİLMİŞTİR ";
                }
                else
                    MessageBox.Show(this.Page, "ARAÇ İSTEĞİ ONAYLANMAMIŞTIR");

            }

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}