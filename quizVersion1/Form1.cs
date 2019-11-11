using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quizVersion1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void EkraniHazirla()
        {
            txtPersonelNo.Text = txtAd.Text = txtSoyad.Text = txtBirim.Text = " ";
            txtPersonelNo.Focus();
        }
        Fabrika seyrek = new Fabrika();
        private void BtnListeyeEkle_Click(object sender, EventArgs e)
        {
            int a =Convert.ToInt32(txtPersonelNo.Text);
            Personel pers = new Personel(a);
            pers.kimlik.Ad = txtAd.Text;
            pers.kimlik.Soyad = txtSoyad.Text;
            pers.CalistigiBirim = txtBirim.Text;
            seyrek.ListeyeEkle(pers);
            EkraniHazirla();
            
        }

        private void btnListeyiGoster_Click(object sender, EventArgs e)
        {
            txtListeyiGoster.Text = seyrek.CalisanListesi();
        }
    }
}
