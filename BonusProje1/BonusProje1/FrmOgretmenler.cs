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
    public partial class FrmOgretmenler : Form
    {
        public FrmOgretmenler()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=MAT225;Initial Catalog=BonusOkul;Integrated Security=True");

        void liste()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBLOGRETMENLER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void FrmOgretmenler_Load(object sender, EventArgs e)
        {
            liste();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtOgretmenId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtBrans.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            TxtAdSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            liste();
        }
    }
}
