using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;
namespace dsistajwebarac
{
    public partial class arac : System.Web.UI.Page
    {
        MySqlConnection connection;
        int gorev_ID = globalsinifimm.gorev_ID;
        int p_ID= globalsinifimm.p_ID;
        int yer_ID=globalsinifimm.yer_ID;
        string tarih_saat = Convert.ToDateTime(globalsinifimm.tarih_saat).ToString("yyyy-MM-dd HH:mm");
        
        protected void Page_Load(object sender, EventArgs e)
        {

            connection = new MySqlConnection("Data Source =localhost; User=root; password =1234 ; Integrated Security = True; database =dsistaj; SslMode = none");
            connection.Open();
            if (!this.IsPostBack)
            {
                DropDownList1.Items.Clear();
                soforsec();
                DropDownList2.Items.Clear();
                aracsec();
            }
        }
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            MySqlCommand com2 = connection.CreateCommand();
            com2.CommandText = "Select p_ad_soyad From personel Where personel.p_ID="+ p_ID;
            MySqlDataReader reader2 = com2.ExecuteReader();
            String p_ad_soyad = null;
            while (reader2.Read())
            {
                p_ad_soyad = reader2["p_ad_soyad"].ToString();
            }
            reader2.Close();
            TextBox1.Text = p_ad_soyad; 
        }
        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            MySqlCommand com2 = connection.CreateCommand();
            com2.CommandText = "Select adres From gidilecek_yerler Where gidilecek_yerler.yer_ID="+ yer_ID;
            MySqlDataReader reader2 = com2.ExecuteReader();
            String adres = null;

            while (reader2.Read())
            {
                adres = reader2["adres"].ToString();
            }
            reader2.Close();
            TextBox2.Text = Convert.ToString(adres);
        }
        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {
            TextBox3.Text = Convert.ToDateTime(tarih_saat).ToString("yyyy-MM-dd HH:mm"); 
        }
        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }
        protected void soforsec()
        {
            MySqlCommand com1 = connection.CreateCommand();
            ListItem ditem = new ListItem();
            ditem.Text = "Seçiniz";
            ditem.Value = "-1";

            //Dropdownliste ekliyoruz
            DropDownList1.Items.Add(ditem);
            com1.CommandText = "SELECT DISTINCT surucu_ad_soyad From soforler";
            MySqlDataReader reader1 = com1.ExecuteReader();
            while (reader1.Read())
            {
                //ListItem oluşturuyoruz
                ListItem litem = new ListItem();

                //Oluşturduğumuz listitemlara value ve text değerlerini 
                //veritabanındaki haliyle ekliyoruz
                litem.Text = reader1["surucu_ad_soyad"].ToString();
                litem.Value = reader1["surucu_ad_soyad"].ToString();

                //Dropdownliste ekliyoruz
                DropDownList1.Items.Add(litem);
            }
            reader1.Close(); //Bağlantıyı kapatıyoruz
        }
        protected void aracsec()
        {
             
            MySqlCommand com2 = connection.CreateCommand();
            ListItem ditem = new ListItem();
            ditem.Text = "Seçiniz";
            ditem.Value = "-1";

            //Dropdownliste ekliyoruz
            DropDownList2.Items.Add(ditem);
            com2.CommandText = "SELECT DISTINCT arac_model From araclar";
            MySqlDataReader reader2 = com2.ExecuteReader();
        
            while (reader2.Read())
            {
                //ListItem oluşturuyoruz
                ListItem litem = new ListItem();

                //Oluşturduğumuz listitemlara value ve text değerlerini 
                //veritabanındaki haliyle ekliyoruz
                litem.Text = reader2["arac_model"].ToString();
                litem.Value = reader2["arac_model"].ToString();

                //Dropdownliste ekliyoruz
                DropDownList2.Items.Add(litem);
            }
            reader2.Close(); //Bağlantıyı kapatıyoruz
        }
        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlCommand com2 = connection.CreateCommand();
            if(DropDownList2.SelectedIndex != -1) { 
            com2.CommandText = "SELECT kurulus From araclar where arac_model='" + DropDownList2.SelectedValue+"'";
            MySqlDataReader reader2 = com2.ExecuteReader();
                String kurulus = null;

                while (reader2.Read())
                {
                    kurulus = reader2["kurulus"].ToString();
                }
                reader2.Close();
                TextBox4.Text = Convert.ToString(kurulus);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
            MySqlCommand com2 = connection.CreateCommand();
            com2.CommandText = "SELECT arac_ID From araclar where arac_model='" + DropDownList2.SelectedValue + "'";
            MySqlDataReader reader2 = com2.ExecuteReader();
            int arac_ID = 0;

            while (reader2.Read())
            {
                arac_ID = Convert.ToInt32(reader2["arac_ID"]);
            }
            reader2.Close();

            MySqlCommand com3 = connection.CreateCommand();
            com3.CommandText = "SELECT surucu_ID From soforler where surucu_ad_soyad='" + DropDownList1.SelectedValue + "'";
            MySqlDataReader reader3 = com3.ExecuteReader();
            int surucu_ID = 0;

            while (reader3.Read())
            {
                surucu_ID = Convert.ToInt32(reader3["surucu_ID"]);
            }
            reader3.Close();

            MySqlCommand com4 = connection.CreateCommand();
            com4.CommandText = "update gorev SET bsofor_onay=1, sofor_ID='"+surucu_ID+"', arac_ID= '"+arac_ID+"' where gorev_ID= '"+gorev_ID +"'";
            MySqlDataReader reader4 = com4.ExecuteReader();

            if (reader4.RecordsAffected > 0)
            {
                Response.AppendHeader("Refresh", "4;url=bsofor.aspx");
                Label1.Text = "ARAÇ YÖNLENDİRME İŞLEMİ BAŞARI İLE TAMAMLANMIŞTIR";

            }
            else
                MessageBox.Show(this.Page, "Araç isteğiniz alınamadı");
        }

        protected void TextBox4_TextChanged1(object sender, EventArgs e)
        {
           
        }
    }
}