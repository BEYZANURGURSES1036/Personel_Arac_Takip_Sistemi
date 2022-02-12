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
    static class globalsinifimm
    {
        public static int gorev_ID = 0;
        public static int yer_ID = 0;
        public static string tarih_saat = null;
        public static int p_ID = 0;
    }
    public partial class bsofor : System.Web.UI.Page
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
                    using (MySqlCommand cmd = new MySqlCommand("SELECT   personel.p_ad_soyad, gidilecek_yerler.adres, gorev.tarih_saat,personel.p_ID ,gidilecek_yerler.yer_ID " +
                                                                         "FROM gorev " +
                                                                         "INNER JOIN gidilecek_yerler ON gorev.yer_ID = gidilecek_yerler.yer_ID " +
                                                                         "INNER JOIN personel ON gorev.personel_ID = personel.p_ID " +
                                                                         "WHERE gorev.bamir_onay=1 and gorev.bsofor_onay=0" ))
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
            {
                if (e.CommandName == "get")
                {
                    int index = Convert.ToInt32(e.CommandArgument);// get row index which you select 
                    GridViewRow row = GridView1.Rows[index];// get the row 
                                                            //Response.Write(GridView1.Rows[index].Cells[1].Text);// get the text in the cell you select in the row
                                                          

                    string tarih_saat = Convert.ToDateTime(GridView1.Rows[index].Cells[2].Text).ToString("yyyy-MM-dd HH:mm");
                    globalsinifimm.tarih_saat = tarih_saat;
                    //int p_ID = Convert.ToInt32( GridView1.Rows[index].Cells[4].Text);
                    //globalsinifimm.p_ID = p_ID;
                    //int yer_ID = Convert.ToInt32(GridView1.Rows[index].Cells[5].Text);
                    //globalsinifimm.yer_ID = yer_ID;
                    int p_ID = Convert.ToInt32(GridView1.DataKeys[index].Values["p_ID"].ToString());
                    globalsinifimm.p_ID = p_ID;
                    int yer_ID = Convert.ToInt32(GridView1.DataKeys[index].Values["yer_ID"].ToString());
                    globalsinifimm.yer_ID = yer_ID;

                    MySqlCommand com5 = connection.CreateCommand();
                    com5.CommandText = "Select gorev_ID From gorev " +
                        " where yer_ID='" + yer_ID + "'AND personel_ID='" + p_ID + "'";

                    MySqlDataReader reader5 = com5.ExecuteReader();
                    int gorev_ID = 0;
                    while (reader5.Read())
                    {
                        gorev_ID = Convert.ToInt32(reader5["gorev_ID"]);
                    }
                    globalsinifimm.gorev_ID = gorev_ID;
                    reader5.Close();
                    Response.Redirect("arac.aspx");
                    //globalsinifimm.p_Ad_soyad = p_ad_soyad;

                }

            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
   
}