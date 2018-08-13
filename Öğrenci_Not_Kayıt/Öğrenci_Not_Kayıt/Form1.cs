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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        private void BtnOgretmenGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From TblOgretmen where Numara=@p1 and Sıfre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskOgretmenNumara.Text);
            komut.Parameters.AddWithValue("@p2", TxtOgretmenSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmOgretmen frm = new FrmOgretmen();
                frm.numara = MskOgretmenNumara.Text;
                frm.Show();
                MessageBox.Show("Sisteme Hoş Geldiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Numara ya da Şifre", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            bgl.baglanti().Close();
        }

        private void BtnOgrenciGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From TblOgrenci where Numara=@p1 and Sıfre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskOgrenciNumara.Text);
            komut.Parameters.AddWithValue("@p2", TxtOGrenciSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmOgrenci frm = new FrmOgrenci();
                frm.numara = MskOgrenciNumara.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Numara ya da Şifre", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            bgl.baglanti().Close();
        }
    }
}
