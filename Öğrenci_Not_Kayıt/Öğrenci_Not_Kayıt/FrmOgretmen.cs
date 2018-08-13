using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Öğrenci_Not_Kayıt
{
    public partial class FrmOgretmen : Form
    {
        public FrmOgretmen()
        {
            InitializeComponent();
        }

        public string numara;
        SqlBaglantisi bgl = new SqlBaglantisi();

        //Metot olarak öğrenci listesi kodlarımızı yazıyoruz.
        void OgrenciListesi()
        {
            SqlCommand komut = new SqlCommand("Select * From TblOgrenci", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void NotListesi()
        {
            SqlCommand komut = new SqlCommand("Execute Ogrenciler", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void FrmOgretmen_Load(object sender, EventArgs e)
        {
            //Numarayı Label aracına yazdırma.
            LblNumara.Text = numara;

            //Numaryaa göre isim bilgisi getirme
            SqlCommand komut = new SqlCommand("Select * From TblOgretmen where Numara=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", numara);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[1] + " " + dr[2];
            }
            bgl.baglanti().Close();

            //Form Loadda metodumuzu çağırıyoruz.
            OgrenciListesi();

            //Form Loadda 2.metodumuzu çağırıyoruz.
            NotListesi();
        }
        string Fotograf;
        private void BtnFotografSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            Fotograf = openFileDialog1.FileName;
            pictureBox1.ImageLocation = Fotograf;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tblogrenci (ad,soyad,numara,sıfre,fotograf) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskNumara.Text);
            komut.Parameters.AddWithValue("@p4", TxtSifre.Text);
            komut.Parameters.AddWithValue("@p5", Fotograf);
            komut.ExecuteNonQuery();
            MessageBox.Show("Öğrenci Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.baglanti().Close();
            OgrenciListesi();
            NotListesi();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            MskNumara.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtSifre.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            pictureBox1.ImageLocation = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

            SqlCommand komut = new SqlCommand("Select * From TblNotlar where Ogrıd=(Select ID From TblOgrenci Where Numara=@p1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskNumara.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtSınav1.Text = dr[1].ToString();
                TxtSınav2.Text = dr[2].ToString();
                TxtSınav3.Text = dr[3].ToString();
                TxtProje.Text = dr[4].ToString();
                TxtOrtalama.Text = dr[5].ToString();
                TxtDurum.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            //Öğrenci Bilgilerini Güncelleme
            SqlCommand komut = new SqlCommand("update tblogrenci set ad=@p1,soyad=@p2,sıfre=@p3,fotograf=@p4 where numara=@p5", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", TxtSifre.Text);
            komut.Parameters.AddWithValue("@p4", Fotograf);
            komut.Parameters.AddWithValue("@p5", MskNumara.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            //Not Bilgilerini Güncelleme
            SqlCommand komut2 = new SqlCommand("update TblNotlar set Sınav1=@p1,Sınav2=@p2,Sınav3=@p3,Proje=@p4,Ortalama=@p5,Durum=@p6 where OGRID=(Select ID From TblOgrenci Where Numara=@p7)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", TxtSınav1.Text);
            komut2.Parameters.AddWithValue("@p2", TxtSınav2.Text);
            komut2.Parameters.AddWithValue("@p3", TxtSınav3.Text);
            komut2.Parameters.AddWithValue("@p4", TxtProje.Text);
            komut2.Parameters.AddWithValue("@p5", Convert.ToDecimal(TxtOrtalama.Text));
            komut2.Parameters.AddWithValue("@p6", TxtDurum.Text);
            komut2.Parameters.AddWithValue("@p7", MskNumara.Text);
            komut2.ExecuteNonQuery();
            MessageBox.Show("Öğrenci Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            bgl.baglanti().Close();
            OgrenciListesi();
            NotListesi();

        }

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            double sınav1, sınav2, sınav3, proje, ortalama;
            sınav1 = Convert.ToDouble(TxtSınav1.Text);
            sınav2 = Convert.ToDouble(TxtSınav2.Text);
            sınav3 = Convert.ToDouble(TxtSınav3.Text);
            proje = Convert.ToDouble(TxtProje.Text);
            ortalama = (sınav1 + sınav2 + sınav3 + proje) / 4;
            TxtOrtalama.Text = ortalama.ToString();
            if (ortalama >= 50)
            {
                TxtDurum.Text = "True";
            }
            else
            {
                TxtDurum.Text = "False";
            }
        }

        private void BtnDuyuruOlustur_Click(object sender, EventArgs e)
        {
            FrmDuyuruOlustur frm = new FrmDuyuruOlustur();
            frm.Show();
        }

        private void BtnDuyuruListesi_Click(object sender, EventArgs e)
        {
            FrmDuyuruListesi frm = new FrmDuyuruListesi();
            frm.Show();
        }

        private void BtnMesajlar_Click(object sender, EventArgs e)
        {
            FrmMesjalar frm = new FrmMesjalar();
            frm.numara = LblNumara.Text;
            frm.Show();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
