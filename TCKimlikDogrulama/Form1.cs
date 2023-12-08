using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace TCKimlikDogrulama
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            dogumYili.Format = DateTimePickerFormat.Custom;
            dogumYili.CustomFormat = "yyyy";

        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            long TCKN = long.Parse(txtTCKimlikNo.Text);
            string Ad = txtAd.Text;
            string Soyad = txtSoyad.Text;
            int DogumYili = dogumYili.Value.Year;

            KimlikBilgileri.KPSPublicSoapClient KimlikBilgisi = new KimlikBilgileri.KPSPublicSoapClient();
            bool sonuc = KimlikBilgisi.TCKimlikNoDogrula(TCKN,Ad,Soyad,DogumYili);
            if (sonuc)
            {
                MessageBox.Show("böyle biri var");
            }
            else
            {
                MessageBox.Show("yok");
            }
        }
    }
}
