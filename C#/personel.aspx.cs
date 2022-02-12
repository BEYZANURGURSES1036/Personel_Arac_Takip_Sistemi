using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;

namespace dsistajwebarac
{
    
    public partial class personel : System.Web.UI.Page
    {
        MySqlConnection connection;

        protected void Page_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection("Data Source =localhost; User=root; password =1234 ; Integrated Security = True; database =dsistaj; SslMode = none");
            connection.Open();
            string kullanici_adi = globalsinifim.kullanici_adi;
            MySqlCommand com = connection.CreateCommand();
            com.CommandText = "Select p_ID from personel " +
                "where kullanici_adi='" + kullanici_adi + "'";
            MySqlDataReader reader = com.ExecuteReader();
            int p_ID = 0;
            
                while (reader.Read())
                {
                    p_ID = Convert.ToInt32(reader["p_ID"]);
                    break;
                }
            reader.Close();
            if (!this.IsPostBack)
            {
                DropDownList1.Items.Clear();
                MySqlCommand com1 = connection.CreateCommand();
                ListItem ditem = new ListItem();
                ditem.Text = "Seçiniz";
                ditem.Value = "-1";

                //Dropdownliste ekliyoruz
                DropDownList1.Items.Add(ditem);
                com1.CommandText = "SELECT  adres From gidilecek_yerler";
                MySqlDataReader reader1 = com1.ExecuteReader();
                while (reader1.Read())
                {
                    //ListItem oluşturuyoruz
                    ListItem litem = new ListItem();

                    //Oluşturduğumuz listitemlara value ve text değerlerini 
                    //veritabanındaki haliyle ekliyoruz
                    litem.Text = reader1["adres"].ToString();
                    litem.Value = reader1["adres"].ToString();

                    //Dropdownliste ekliyoruz
                    DropDownList1.Items.Add(litem);
                }
                
                reader1.Close();

                string constr = ConfigurationManager.ConnectionStrings["dsistajConnectionString"].ConnectionString;
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    //onaylama tablosu
                    using (MySqlCommand cmd = new MySqlCommand("Select * from( SELECT   gidilecek_yerler.adres, gorev.tarih_saat, araclar.arac_model,araclar.plaka,soforler.surucu_ad_soyad, araclar.arac_km_cikis" +
                                               ",(case when gorev.bamir_onay = 0 and gorev.bsofor_onay = 0 then 'Amirin Onayı Bekleniyor'" +
                                               " When gorev.bamir_onay = 1 and gorev.bsofor_onay = 0 then'Şoförün Onayı Bekleniyor' " +
                                               "else 'Onaylandı' " +
                                               "end) as DURUM FROM gorev " +
                                               " left JOIN araclar ON gorev.arac_ID = araclar.arac_ID" +
                                               " left JOIN gidilecek_yerler ON gorev.yer_ID = gidilecek_yerler.yer_ID" +
                                               " left JOIN soforler ON gorev.sofor_ID = soforler.surucu_ID  " +
                                               "where gorev.personel_ID=" + p_ID+") sorgu"))
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
            connection.Close();
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            string kullanici_adi = globalsinifim.kullanici_adi;
            MySqlCommand com = connection.CreateCommand();
            com.CommandText = "Select p_ad_soyad,p_unvan from personel " +
                "where kullanici_adi='" + kullanici_adi + "'";
            MySqlDataReader reader = com.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    string p_ad_soyad = reader["p_ad_soyad"].ToString();
                    TextBox1.Text = p_ad_soyad;
                    break;
                }

            }
            catch
            {
                MessageBox.Show(this.Page, "Hata");
            }
            connection.Close();
        }
        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            string kullanici_adi = globalsinifim.kullanici_adi;
            MySqlCommand com = connection.CreateCommand();
            com.CommandText = "Select p_ad_soyad,p_unvan from personel " +
                "where kullanici_adi='" + kullanici_adi + "'";
            MySqlDataReader reader = com.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    string p_unvan = reader["p_unvan"].ToString();
                    TextBox5.Text = p_unvan;
                    break;
                }

            }
            catch
            {
                MessageBox.Show(this.Page, "Hata");
            }
            connection.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            connection.Open();

            string kullanici_adi = globalsinifim.kullanici_adi;
            MySqlCommand com = connection.CreateCommand();
            com.CommandText = "Select p_ID from personel " +
                "where kullanici_adi='" + kullanici_adi + "'";
            MySqlDataReader reader = com.ExecuteReader();
            int personel_ID = 0;
            while (reader.Read())
            {
                personel_ID = Convert.ToInt32(reader["p_ID"]);
                break;
            }

            reader.Close();

            MySqlCommand com1 = connection.CreateCommand();
            string adres = DropDownList1.SelectedValue;
            com1.CommandText = "Select yer_ID from gidilecek_yerler " +
                "where adres='" + adres + "'";
            MySqlDataReader reader1 = com1.ExecuteReader();
            int yer_ID = 0;
            while (reader1.Read())
            {
                yer_ID = Convert.ToInt32(reader1["yer_ID"]);

                break;
            }

            reader1.Close();

            MySqlCommand com5 = connection.CreateCommand();
            com5.CommandText = "Select amirpersonel_ID from personel " +
                "where p_ID=" + personel_ID ;
            MySqlDataReader reader5 = com5.ExecuteReader();
            int bamir_ID = 0;
            while (reader5.Read())
            {
                bamir_ID = Convert.ToInt32(reader5["amirpersonel_ID"]);

                break;
            }

            reader5.Close();

            int onaysiz = 0;

            try
            {
                string tarih_saat = Convert.ToDateTime(TextBox2.Text).ToString("yyyy-MM-dd HH:mm");
                MySqlCommand com3 = connection.CreateCommand();
                
                com3.CommandText = "insert into gorev(personel_ID,tarih_saat,yer_ID, bamir_onay, bsofor_onay,bamir_ID,bsofor_ID" +
                    ") values (" + personel_ID + ",'" + tarih_saat + "'," + yer_ID + ",'" + onaysiz + "'," + onaysiz + ",'"+bamir_ID+"','"+3+"')";
                MySqlDataReader reader3 = com3.ExecuteReader();

                if (reader3.RecordsAffected > 0)
                {
                    Response.AppendHeader("Refresh", "2;url=personel.aspx");
                    Label1.Text = "ARAÇ İSTEĞİNİZ AMİRİNİZE İLETİLMİŞTİR";
                }
                else
                {
                    Response.AppendHeader("Refresh", "2;url=bamir.aspx");
                    Label1.Text = "BAŞARILI GİRİŞ YAPTINIZ";
                }

            }
            catch (Exception)
            {
                MessageBox.Show(this.Page,"Hata: ");
            }
            connection.Close();
        }

     
    }
}
