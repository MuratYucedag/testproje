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
    public partial class FrmOgrenci : Form
    {
        public FrmOgrenci()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        public string numara;
        private void FrmOgrenci_Load(object sender, EventArgs e)
        {
            LblNumara.Text = numara;

            //Numaryaa göre isim bilgisi getirme
            SqlCommand komut = new SqlCommand("Select * From TblOgrenci where Numara=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", numara);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[1] + " " + dr[2];
                pictureBox1.ImageLocation = dr[5].ToString();
            }
            bgl.baglanti().Close();

            //Not Listesi
            SqlCommand komut2 = new SqlCommand("Select * From TblNotlar where Ogrıd=(Select ID From TblOgrenci Where Numara=@p1)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", LblNumara.Text);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                LblSınav1.Text = dr2[1].ToString();
                LblSınav2.Text = dr2[2].ToString();
                LblSınav3.Text = dr2[3].ToString();
                LblProje.Text = dr2[4].ToString();
                LblOrtalama.Text = dr2[5].ToString();
            }
            bgl.baglanti().Close();

            if (Convert.ToDouble(LblOrtalama.Text) >= 50)
            {
                LblDurum.Text = "Geçti";
            }
            else
            {
                LblDurum.Text = "Kaldı";
            }
        }

        //öğrenci formu
        private void BtnMesajlar_Click(object sender, EventArgs e)
        {
            FrmMesjalar frm = new FrmMesjalar();
            frm.numara = LblNumara.Text;
            frm.Show();
        }

        private void BtnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyuruListesi frm = new FrmDuyuruListesi();
            frm.Show();
        }

        private void BtnHesapMakinesi_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.Exe");
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Gerçekten Kaptmak İstiyor Musunuz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();

            }
        }
    }
}
