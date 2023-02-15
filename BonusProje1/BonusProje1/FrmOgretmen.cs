using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BonusProje1
{
    public partial class FrmOgretmen : Form
    {
        public FrmOgretmen()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmKulup fr = new FrmKulup();
            fr.Show();
        }

        private void BtnDers_Click(object sender, EventArgs e)
        {
            FrmDersler fr = new FrmDersler();
            fr.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnOgrenciIslemleri_Click(object sender, EventArgs e)
        {
            FrmOgrenci fr = new FrmOgrenci();
            fr.Show();
        }

        private void BynSinavNotlari_Click(object sender, EventArgs e)
        {
            FrmSinavNotlar fr = new FrmSinavNotlar();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmOgretmenler fr = new FrmOgretmenler();
            fr.Show();
        }
    }
}
