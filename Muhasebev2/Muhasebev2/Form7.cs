using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Muhasebev2
{
    public partial class Form7 : Form
    {
        public Form6 _form6;
        public Form1 _form1;
        public Form3 _form3;
        private Form6 form6;
        private Form1 form1;
        private Form3 form3;

        public Form7(Form1 form1, Form6 form6, Form3 form3)
        {
            _form6 = form6;
            InitializeComponent();
            if (form6 != null && form6.sicilno != null && form6.adsoyad != null && form6.maas != null)
            {
                listBox1.Items.AddRange(form6.sicilno.ToArray());
                listBox2.Items.AddRange(form6.adsoyad.ToArray());
                listBox3.Items.AddRange(form6.maas.ToArray());
            }


            _form1 = form1;

            _form3 = form3;


        }

        public Form7(Form6 form6, Form1 form1, Form3 form3)
        {
            this.form6 = form6;
            this.form1 = form1;
            this.form3 = form3;
        }

        public void button1_Click(object sender, EventArgs e)
        {

            int selIdx = listBox1.SelectedIndex;

            if (selIdx >=0)
            {
                _form6.sicilno.RemoveAt(selIdx);
                _form6.adsoyad.RemoveAt(selIdx);
                _form6.maas.RemoveAt(selIdx);

                listBox1.Items.Clear();
                listBox2.Items.Clear();
                listBox3.Items.Clear();

                listBox1.Items.AddRange(_form6.sicilno.ToArray());
                listBox2.Items.AddRange(_form6.adsoyad.ToArray());
                listBox3.Items.AddRange(_form6.maas.ToArray());
            }
            else
            {
                MessageBox.Show("Lütfen bir öğe seçin!");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            _form3 = new Form3(_form1, _form6, this);
            _form3.Show();
            this.Hide();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
