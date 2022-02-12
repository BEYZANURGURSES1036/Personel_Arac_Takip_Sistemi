using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;
using System.Web.UI.HtmlControls;

namespace dsistajwebarac
{
    public static class globalsinifim
    {
        public static string kullanici_adi = null;
        public static int pamir_ID = 0;
    }
    public static class MessageBox
    {
        public static void Show(this Page Page, String Message)
        {
            Page.ClientScript.RegisterStartupScript(
               Page.GetType(),
               "MessageBox",
               "<script language='javascript'>alert('" + Message + "');</script>"
            );
        }
      
        }
    public partial class login : System.Web.UI.Page
    {
        MySqlConnection connection;
        private void checkMysqlConnection()
        {
        }
        public login()
        {
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection("Data Source =localhost; User=root; password =1234 ; Integrated Security = True; database =dsistaj; SslMode = none");
        }
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
        }
        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
        }
        protected void Button1_Click1(object sender, EventArgs e)
        {
            connection.Open();
            globalsinifim.kullanici_adi = TextBox1.Text;
            string kullanici_adi = TextBox1.Text;
            string sifre = TextBox2.Text;
            MySqlCommand com5 = connection.CreateCommand();
            com5.CommandText = "Select p_ID from personel where kullanici_adi='" + kullanici_adi + "' and sifre='" + sifre + "'";
            MySqlDataReader reader5 = com5.ExecuteReader();
            int pamirr_ID = 0;

            while (reader5.Read())
            {
                pamirr_ID = Convert.ToInt32(reader5["p_ID"]);
            }
            globalsinifim.pamir_ID = pamirr_ID;
            reader5.Close();


            MySqlCommand com = connection.CreateCommand();
            com.CommandText = "Select kullanici_adi,sifre,birim_ID from personel " +
                "where kullanici_adi='" + kullanici_adi + "' and sifre='" + sifre + "'";
            MySqlDataReader reader = com.ExecuteReader();

                try
            {
                while (reader.Read())
                {
                    
                    string birim = reader["birim_ID"].ToString();
                    if ((int)reader["birim_ID"] == 1)
                    {
                        Response.AppendHeader("Refresh", "2;url=personel.aspx");
                        Label1.Text = "BAŞARILI GİRİŞ YAPTINIZ";


                    }
                    else if ((int)reader["birim_ID"] == 2)
                    {
                        Response.AppendHeader("Refresh", "2;url=bamir.aspx");
                        Label1.Text = "BAŞARILI GİRİŞ YAPTINIZ";
                    }
                    else if ((int)reader["birim_ID"] == 3)
                    {
                        Response.AppendHeader("Refresh", "2;url=bsofor.aspx");
                        Label1.Text = "BAŞARILI GİRİŞ YAPTINIZ";
                    }
                    break;
                }

            }
            catch
            {
              
            }
        }

    }
}