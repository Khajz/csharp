namespace Muhasebev2
{
    public partial class Form1 : Form
    {
        public string kadi { get;  set; }
        public string sifre { get;  set; }
        private Form2? _form2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kadi = textBox1.Text;
            sifre = textBox2.Text;
            if (textBox1.Text.Length < 4) {
                label3.Text = "Kullanýcý Adý 4 karakterden az olamaz!";
            }
            else if (textBox2.Text.Length < 8)
            {
                label3.Text = "Þifre 8 karakterden az olamaz!";
            }
            else
            {
                _form2 = new Form2(this);
                _form2.Show();
                this.Hide();
                
            }
        }
    }
}
