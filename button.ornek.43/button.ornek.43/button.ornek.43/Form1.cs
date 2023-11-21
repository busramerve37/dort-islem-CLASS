using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button.ornek._43
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            Sinif sinif = new Sinif();
            sinif.sayi1 = Convert.ToInt32(txtSayi1.Text);
            sinif.sayi2 = Convert.ToInt32(txtSayi2.Text);

            lblToplama.Text = "Sonuç " + sinif.Toplama();
            lblCikarma.Text="Sonuç "+sinif.Cikarma();
            lblCarpma.Text = "Sonuc " + sinif.Carpma();
            lblBolme.Text = "Sonuç " + sinif.Bol();

        }
    }
}
