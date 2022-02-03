using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane_Otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string constr = @"Data Source=.\;Initial Catalog=Kutuphane;Integrated Security=True";
        
        private void btnKitapListele_Click(object sender, EventArgs e)
        {
            try
            {
                KitapListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kitaplar Bulunamadı" + ex.Message);
                throw;
            }
            
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Kitap kitap = new Kitap
                {
                    KitapAdi = txtEklenenKitapAdi.Text,
                    KitaplikNo = Convert.ToInt32(txtKitaplikNo.Text),
                    RafNo = Convert.ToInt32(txtRafNo.Text)
                };
                KitapEkle(kitap);
                MessageBox.Show("Kitap Başarıyla Eklendi");
                EkranTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kitap eklenemedi!!!"+ex.Message);
                throw ex;
            }
            
        }
        public void KitapEkle(Kitap kitap)
        {
            
            SqlConnection connection = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand("Insert Into Kitaplar (KitapAdi,KitaplikNo,RafNo) values (@Ad,@KitaplikNo,@RafNo)", connection);
            cmd.Parameters.AddWithValue("Ad", kitap.KitapAdi);
            cmd.Parameters.AddWithValue("KitaplikNo", kitap.KitaplikNo);
            cmd.Parameters.AddWithValue("RafNo", kitap.RafNo);
            connection.Open();
            cmd.ExecuteNonQuery();
        }

        public void KitapListele()
        {
            SqlConnection connection = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand("Select * From Kitaplar", connection);
            connection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dgwKitaplar.DataSource = dataSet.Tables[0];

        }
        private void EkranTemizle()
        {
            txtAlinanKitapNo.Text = "";
            txtAlinanUyeNo.Text="";
            txtEklenenKitapAdi.Text = "";
            txtKitapAdi.Text = "";
            txtKitaplikNo.Text = "";
            txtKitapNo.Text = "";
            txtRafNo.Text = "";
            txtUyeAdi.Text = "";
            txtUyeKayitAdi.Text = "";
            txtUyeNo.Text = "";
            mTxtVerilisTarihi.Text = "";
        }

        private void btnUyeKayit_Click(object sender, EventArgs e)
        {
            try
            {
                Uye uye = new Uye
                {
                    UyeAdi = txtUyeKayitAdi.Text
                };
                UyeEkle(uye);
                MessageBox.Show("Üye Başarıyla Eklendi");
                EkranTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Üye Eklenemedi!!"+ex.Message);
                throw ex;
            }
        }
        public void UyeEkle(Uye uye)
        {

            SqlConnection connection = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand("Insert Into Uyeler (UyeIsim) values (@Ad)", connection);
            cmd.Parameters.AddWithValue("Ad", uye.UyeAdi);
            connection.Open();
            cmd.ExecuteNonQuery();
        }

        private void btnUyeListele_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand("Select * From Uyeler", connection);
            connection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dgwUyeler.DataSource = dataSet.Tables[0];
        }

        private void btnKitabiVer_Click(object sender, EventArgs e)
        {
            try
            {
                OduncKitap oduncKitap = new OduncKitap
                {
                    KitapAdi = txtKitapAdi.Text,
                    KitapNo=Convert.ToInt32(txtKitapNo.Text),
                    UyeNo=Convert.ToInt32(txtUyeNo.Text),
                    UyeIsmi=txtUyeAdi.Text,
                    VerilisTarihi=Convert.ToDateTime(mTxtVerilisTarihi.Text)
                };
                OduncKitapEkle(oduncKitap);
                MessageBox.Show("Kayıt Başarıyla Eklendi");
                EkranTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt Eklenemedi!!"+ex.Message);
                throw ex;
            }
        }
        public void OduncKitapEkle(OduncKitap oduncKitap)
        {
            SqlConnection connection = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand("Insert Into OduncKitaplar (UyeAdi,UyeNo,VerilisTarihi,KitapAdi,KitapNo) values (@UyeAd,@UyeNo,@VerilisTarihi,@KitapAdi,@KitapNo)", connection);
            cmd.Parameters.AddWithValue("UyeAd", oduncKitap.UyeIsmi);
            cmd.Parameters.AddWithValue("KitapNo", oduncKitap.KitapNo);
            cmd.Parameters.AddWithValue("UyeNo", oduncKitap.UyeNo);
            cmd.Parameters.AddWithValue("KitapAdi", oduncKitap.KitapAdi);
            cmd.Parameters.AddWithValue("VerilisTarihi", oduncKitap.VerilisTarihi);
            connection.Open();
            cmd.ExecuteNonQuery();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnOduncKitapListele_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand("Select * From OduncKitaplar", connection);
            connection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dgvOduncKitapListesi.DataSource = dataSet.Tables[0];
        }

        private void btnAlinanKitapKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                AlinanKitap();
                MessageBox.Show("Kayıt Başarıyla Silinid");
                EkranTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt Bulunamadı"+ex.Message);
                throw ex;
            }
            
        }
        public void AlinanKitap()
        {
            SqlConnection connection = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand("Delete From OduncKitaplar Where UyeNo=@UyeNo AND KitapNo=@KitapNo", connection);
            cmd.Parameters.AddWithValue("UyeNo",Convert.ToInt32(txtAlinanUyeNo.Text));
            cmd.Parameters.AddWithValue("KitapNo", Convert.ToInt32(txtAlinanKitapNo.Text));
            connection.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
