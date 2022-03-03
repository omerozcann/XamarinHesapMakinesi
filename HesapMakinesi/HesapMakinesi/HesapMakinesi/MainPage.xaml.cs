using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HesapMakinesi
{
    public partial class MainPage : ContentPage
    {
        Double? s1=null, s2=null, sonuc;
        String islem = "";
        public MainPage()
        {
            InitializeComponent();
        }

        private void btn7_Clicked(object sender, EventArgs e)
        {
            sonuclbl.Text = sonuclbl.Text + "7";
        }


        private void btn8_Clicked(object sender, EventArgs e)
        {
            sonuclbl.Text = sonuclbl.Text + "8";
        }

        private void btn9_Clicked(object sender, EventArgs e)
        {
            sonuclbl.Text = sonuclbl.Text + "9";
        }

        private void btnbol_Clicked(object sender, EventArgs e)
        {
            s1 = Convert.ToDouble(sonuclbl.Text);
            islem = "/";
            sonuclbl.Text = "";
        }

        private void btn4_Clicked(object sender, EventArgs e)
        {
            sonuclbl.Text = sonuclbl.Text + "4";
        }

        private void btn5_Clicked(object sender, EventArgs e)
        {
            sonuclbl.Text = sonuclbl.Text + "5";
        }

        private void btn6_Clicked(object sender, EventArgs e)
        {
            sonuclbl.Text = sonuclbl.Text + "6";
        }

        private void btncarp_Clicked(object sender, EventArgs e)
        {
            s1 = Convert.ToDouble(sonuclbl.Text);
            islem = "*";
            sonuclbl.Text = "";
        }

        private void btn1_Clicked(object sender, EventArgs e)
        {
            sonuclbl.Text = sonuclbl.Text + "1";
        }

        private void btn2_Clicked(object sender, EventArgs e)
        {
            sonuclbl.Text = sonuclbl.Text + "2";
        }

        private void btn3_Clicked(object sender, EventArgs e)
        {
            sonuclbl.Text = sonuclbl.Text + "3";
        }

        private void btncikar_Clicked(object sender, EventArgs e)
        {
            s1 = Convert.ToDouble(sonuclbl.Text);
            islem = "-";
            sonuclbl.Text = "";
        }

        private void btnc_Clicked(object sender, EventArgs e)
        {
            sonuclbl.Text = "";
            s1 = null;
            s2 = null;
            islem = null;
        }

        private void btn0_Clicked(object sender, EventArgs e)
        {
            sonuclbl.Text = sonuclbl.Text + "0";
        }

        private void btnnokta_Clicked(object sender, EventArgs e)
        {
            if (sonuclbl.Text.Contains(".") == false)
            {
                sonuclbl.Text = sonuclbl.Text + ".";
            }
        }

        private void btntopla_Clicked(object sender, EventArgs e)
        {
            s1 = Convert.ToDouble(sonuclbl.Text);
            islem = "+";
            sonuclbl.Text = "";
        }

        private void btnesittir_Clicked(object sender, EventArgs e)
        {
            if(sonuclbl.Text!="")
            {
                s2 = Convert.ToDouble(sonuclbl.Text);
            }
            if (s1 == null || s2 == null)
            {
                sonuclbl.Text = "Sayı gir!";
            }
            else
            {                     
                if (islem == "/")
                {
                    sonuc = s1 / s2;
                }
                else if (islem == "*")
                {
                    sonuc = s1 * s2;
                }
                else if (islem == "-")
                {
                    sonuc = s1 - s2;
                }
                else if (islem == "+")
                {
                    sonuc = s1 + s2;
                }
                else
                {
                    sonuclbl.Text = "İşlem Seç!";
                }
                sonuclbl.Text = sonuc.ToString();
            }
        }
    }
}
