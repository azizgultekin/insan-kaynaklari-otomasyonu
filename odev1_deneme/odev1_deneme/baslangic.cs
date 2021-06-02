using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace odev1_deneme
{
    public partial class baslangic : Form
    {
        public baslangic()
        {
            InitializeComponent();
        }

        private void baslangic_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            basvuru f1 = new basvuru();
            f1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ik i = new ik();
            i.Show();
            this.Hide();
        }

        private void baslangic_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
