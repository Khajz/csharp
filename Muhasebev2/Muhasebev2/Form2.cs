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
    public partial class Form2 : Form
    {
        private Form6 _form6;
        private Form1 _form1;
        private Form7 _form7;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 kadi = new Form5(_form1);
            kadi.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != _form1.kadi || textBox2.Text != _form1.sifre)
            {
                label3.Text = "Kullanıcı adı ya da şifre yanlış!";
            }

            else if (textBox1.Text == _form1.kadi && textBox2.Text == _form1.sifre)
            {
                Form3 muhasebe = new Form3(_form1,_form6,_form7);
                muhasebe.Show();
                this.Hide();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 sifredegis = new Form4(_form1);
            sifredegis.Show();
            this.Hide(); 
        }
    }
}
