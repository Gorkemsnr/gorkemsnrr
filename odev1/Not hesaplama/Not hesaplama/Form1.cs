using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Not_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1,sayi2,ort;
            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);
            ort = sayi1 * 0.4 + sayi2 * 0.6;
            label3.Text = ort.ToString();
            if (ort>=84)
            {
                label5.Text= "AA";
                label6.Text = "GEÇTİNİZ";
            }
           else if (ort >= 77 && ort<=83)
            {
                label5.Text = "AB";
                label6.Text = "GEÇTİNİZ";
            }
            else if (ort >= 71 && ort <= 76)
            {
                label5.Text = "BA";
                label6.Text = "GEÇTİNİZ";
            }
            else if (ort >= 66 && ort <= 70)
            {
                label5.Text = "BB";
                label6.Text = "GEÇTİNİZ";
            }
            else if (ort >= 61 && ort <= 65)
            {
                label5.Text = "BC";
                label6.Text = "GEÇTİNİZ";
            }
            else if (ort >= 56 && ort <= 60)
            {
                label5.Text = "CB";
                label6.Text = "GEÇTİNİZ";
            }
            else if (ort >= 50 && ort <= 55)
            {
                label5.Text = "CC";
                label6.Text = "GEÇTİNİZ";
            }
            else if (ort >= 46 && ort <= 49)
            {
                label5.Text = "CD";
                label6.Text = "KALDINIZ";
            }
            else if (ort >= 40 && ort <= 45)
            {
                label5.Text = "DC";
                label6.Text = "KALDINIZ";
            }
            else if (ort >= 30 && ort <= 39)
            {
                label5.Text = "DD";
                label6.Text = "KALDINIZ";
            }
            else
            {
                label5.Text = "FF";
                label6.Text = "KALDINIZ";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
