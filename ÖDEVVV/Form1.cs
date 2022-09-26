using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÖDEVVV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string onbin, bin, yuz, on, bir;

        
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtSayi.Clear();

            lblYazi.Text = String.Empty;
        }

        private void txtSayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(txtSayi.Text);

            double onbinler, binler, yuzler, onlar, birler;

          


            birler = sayi % 10;
            sayi = sayi - birler;
            onlar = sayi % 100;
            sayi = sayi - onlar;
            yuzler = sayi % 1000;
            sayi = sayi - yuzler;
            binler = sayi % 10000;
            onbinler = sayi - binler;

            switch (onbinler)
            {
                case 00000: onbin = ""; break;
                case 10000: onbin = "ON "; break;
                case 20000: onbin = "YİRMİ "; break;
                case 30000: onbin = "OTUZ "; break;
                case 40000: onbin = "KIRK "; break;
                case 50000: onbin = "ELLİ "; break;
                case 60000: onbin = "ALTMIŞ "; break;
                case 70000: onbin = "YETMİŞ "; break;
                case 80000: onbin = "SEKSEN "; break;
                case 90000: onbin = "DOKSAN "; break;
            }
            switch (binler)
            {
                case 0000: bin = ""; break;
                case 1000: bin = " BİR BİN "; break;
                case 2000: bin = "İKİ BİN "; break;
                case 3000: bin = "ÜÇ BİN "; break;
                case 4000: bin = "DÖRT BİN "; break;
                case 5000: bin = "BEŞ BİN "; break;
                case 6000: bin = "ALTI BİN "; break;
                case 7000: bin = "YEDİ BİN "; break;
                case 8000: bin = "SEKİZ BİN "; break;
                case 9000: bin = "DOKUZ BİN "; break;
            }
            switch (yuzler)
            {
                case 000: yuz = ""; break;
                case 100: yuz = "YÜZ "; break;
                case 200: yuz = "İKİ YÜZ "; break;
                case 300: yuz = "ÜÇ YÜZ "; break;
                case 400: yuz = "DÖRT YÜZ "; break;
                case 500: yuz = "BEŞ YÜZ "; break;
                case 600: yuz = "ALTI YÜZ "; break;
                case 700: yuz = "YEDİ YÜZ "; break;
                case 800: yuz = "SEKİZ YÜZ "; break;
                case 900: yuz = "DOKUZ YÜZ "; break;
            }
            switch (onlar)
            {
                case 00: on = ""; break;
                case 10: on = "ON "; break;
                case 20: on = "YİRMİ "; break;
                case 30: on = "OTUZ "; break;
                case 40: on = "KIRK "; break;
                case 50: on = "ELLİ "; break;
                case 60: on = "ALTMIŞ "; break;
                case 70: on = "YETMİŞ "; break;
                case 80: on = "SEKSEN "; break;
                case 90: on = "DOKSAN "; break;
            }
            switch (birler)
            {
                case 0: bir = ""; break;
                case 1: bir = "BİR "; break;
                case 2: bir = "İKİ "; break;
                case 3: bir = "ÜÇ "; break;
                case 4: bir = "DÖRT "; break;
                case 5: bir = "BEŞ "; break;
                case 6: bir = "ALTI "; break;
                case 7: bir = "YEDİ "; break;
                case 8: bir = "SEKİZ "; break;
                case 9: bir = "DOKUZ "; break;
            }
            sayi = Convert.ToDouble(txtSayi.Text);
            

            if (sayi <= 99999 && sayi >= 0.0001)
            {
                birler = sayi % 10;
                if (birler == 0)
                    lblYazi.Text = onbin + bin + yuz + on + "TL";
                sayi = sayi - birler;

                onlar = sayi % 100;
                if (onlar == 0)
                    lblYazi.Text = onbin + bin + yuz + bir + "TL" ;
                sayi = sayi - onlar;

                yuzler = sayi % 1000;
                if (yuzler == 0)
                    lblYazi.Text = onbin + bin + on + bir + "TL" ;

                sayi = sayi - yuzler;

                binler = sayi % 10000;
                if (binler == 0)
                    lblYazi.Text = onbin + "BİN " + yuz + on + bir + "TL" ;

                if (onbinler == 0)
                {
                    if (binler == 1000)
                        lblYazi.Text = "BİN " + yuz + on + bir + "TL" ;

                    else
                        lblYazi.Text = bin + yuz + on + bir + "TL" ;
                }
                if (birler != 0 && onlar != 0 && yuzler != 0 && binler != 0 && onbinler != 0)

                    lblYazi.Text = onbin + bin + yuz + on + bir + "TL" ;

            }
            else
                MessageBox.Show("Beş taneden fazla rakam girmeyiniz");
        }
    }
}
    

