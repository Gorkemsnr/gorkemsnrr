using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kütüphane
{
    public partial class düzenle : Form
    {
        Anaekran anaEkran;
        public düzenle(Anaekran parametredenGelenEkran)
        {
            InitializeComponent();
            anaEkran = parametredenGelenEkran;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            anaEkran.düzenle(textBox1.Text);
            anaEkran.düzenle(textBox2.Text);
            this.Close();
            
        }
    }
}
