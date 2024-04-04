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
    
    public partial class Form5 : Form
    {
        public Form1 _form1;
        public Form5(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != _form1.kadi) { label4.Text = "Kullanıcı adı yanlış!"; }
            else if (textBox2.Text.Length < 4) { label4.Text = "Yeni kullanıcı adı 4 karakterden az olamaz!"; }
            else if (textBox3.Text != _form1.sifre) { label4.Text = "Şifre yanlış!"; }
            else
            {
                _form1.kadi = textBox2.Text;
                Form2 hesap = new Form2(_form1);
                hesap.Show();
                this.Hide();
            }
        }
    }
}
