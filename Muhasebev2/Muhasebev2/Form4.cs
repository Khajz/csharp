using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muhasebev2
{
    public partial class Form4 : Form
    {
        public Form1 _form1;
        public Form4(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != _form1.kadi ) { label4.Text = "Kullanıcı adı yanlış!"; }
            else if (textBox2.Text != _form1.sifre) { label4.Text = "Eski şifre yanlış!"; }
            else if (textBox3.Text == _form1.sifre) { label4.Text = "Eski şifre ile yeni şifre aynı olamaz!"; }
            else if (textBox3.Text.Length < 8) { label4.Text = "Yeni şifre 8 karakterden kısa olamaz!"; }
            else 
            {
                _form1.sifre = textBox3.Text;
                Form2 hesap = new Form2(_form1);
                hesap.Show();
                this.Hide();
                
            }
        }
    }
}
