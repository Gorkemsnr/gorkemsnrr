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
    public partial class Anaekran : Form
    {
        public Anaekran()
        {
            InitializeComponent();
        }

        
        
        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kitapekle kitapEkle = new kitapekle(this);
            kitapEkle.Show();
           
        }
        private void yazarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void ekleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            kitapekle Yazarekle = new kitapekle(this);
            Yazarekle.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Anaekran_Load(object sender, EventArgs e)
        {
            
        }

        public void Kitapekle(string kitapAdi)
        {
            listBox1.Items.Add(kitapAdi);           
        }
        public void Yazarekle(string yazaradi)
        {
            listBox2.Items.Add(yazaradi);
        }
        public void düzenle(string Düzenle)
        {
            int index = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(index);
            listBox1.Items.Insert(index,Düzenle);
        }
        

        private void kitaplarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult sil = new DialogResult();
            sil = MessageBox.Show("Veriyi silmek istiyor musunuz?","uyarı",MessageBoxButtons.YesNo);
            if (sil==DialogResult.Yes)
            {
                int sira = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(sira);
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            düzenle Düzenle = new düzenle(this);
            Düzenle.Show();
        }


    }
}
