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
    public partial class FrmMesjalar : Form
    {
        public FrmMesjalar()
        {
            InitializeComponent();
        }

       

        SqlBaglantisi bgl = new SqlBaglantisi();

        void GelenMesajlar()
        {
            SqlCommand komut = new SqlCommand("Select * From TblMesajlar Where Alıcı=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", numara);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void GidenMesajlar()
        {
            SqlCommand komut = new SqlCommand("Select * From TblMesajlar Where Gonderen=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", numara);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }
        //Mesajlar Formu
        public string numara;

        private void FrmMesjalar_Load(object sender, EventArgs e)
        {
            MskGonderen.Text = numara;

            GelenMesajlar();

            GidenMesajlar();
        }

        private void BtnGonder_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TblMesajlar (Gonderen,Alıcı,Baslık,Icerık) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskGonderen.Text);
            komut.Parameters.AddWithValue("@p2", MskAlıcı.Text);
            komut.Parameters.AddWithValue("@p3", TxtKonu.Text);
            komut.Parameters.AddWithValue("@p4", RchMesaj.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Mesajınız İletildi...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.baglanti().Close();
            GelenMesajlar();
            GidenMesajlar();
        }
    }
}
