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


namespace BonusProje1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=MAT225;Initial Catalog=BonusOkul;Integrated Security=True");

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from TBLOGRENCILER where OGRID=@P1", baglanti);
            komut.Parameters.AddWithValue("@P1", textBox1.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read()) 
            { 
            FrmOgrenciNotlar fr = new FrmOgrenciNotlar();
            fr.numara = textBox1.Text;
            fr.Show();
            this.Hide();
            }
            else
            {
                MessageBox.Show("Numara hatalı veya numaranızı girmediniz!");
            }
            baglanti.Close();

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from TBLOGRETMENLER where OGRTID=@P1", baglanti);
            komut.Parameters.AddWithValue("@P1",textBox1.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
            FrmOgretmen frogretmen = new FrmOgretmen();
            frogretmen.Show();
            this.Hide();
            }
            else
            {
                MessageBox.Show("Numara hatalı veya numaranızı girmediniz!");
            }
            baglanti.Close();
        }
    }
}
