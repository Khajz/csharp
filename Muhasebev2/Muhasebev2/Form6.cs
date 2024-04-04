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
    public partial class Form6 : Form
    {
        public Form3 _form3;
        public Form1 _form1;
        public Form7 _form7;

        public List<string> sicilno { get; set; } = new List<string>();
        public List<string> adsoyad { get; set; } = new List<string>();
        public List<string> maas { get; set; } = new List<string>();

        public Form6(Form1 form1, Form3 form3, Form7 form7)
        {
            InitializeComponent();
            _form3 = form3;
            _form1 = form1;
            _form7 = form7;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _form3 = new Form3(_form1, this,_form7);
            _form3.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int maasint = int.Parse(textBox3.Text);
            if (textBox1.Text.Length == 0) { label4.Text = "Sicil no boş olamaz!"; }
            else if (textBox2.Text.Length <= 4) { label4.Text = "Ad Soyad 4 karakterden az olamaz!"; }
            else if (maasint < 17002) { label4.Text = "Maaş 17002'den az olamaz!"; }
            else
            {
                sicilno.Add(textBox1.Text);
                adsoyad.Add(textBox2.Text);
                maas.Add(textBox3.Text);
                label4.Text = textBox1.Text + " sicil nolu kişi eklendi!";
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
