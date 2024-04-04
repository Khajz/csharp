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
    public partial class Form3 : Form
    {
        private Form6 _form6;
        private Form1 _form1;
        private Form7 _form7;

        public Form3(Form1 form1, Form6 form6, Form7 form7)
        {
            InitializeComponent();
            _form1 = form1;
            _form6 = form6;
            _form7 = form7;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 hesap = new Form2(_form1);
            hesap.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_form6 != null)
            {
                _form6.Show();
                this.Hide();
            }
            else
            {
                Form6 sicil = new Form6(_form1,this,_form7);
                sicil.Show();
                this.Hide();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
                Form7 liste = new Form7(_form1, _form6, this);
                liste.Show();
                this.Hide();

        }
    }
}
