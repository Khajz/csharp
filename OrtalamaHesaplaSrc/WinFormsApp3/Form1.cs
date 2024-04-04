namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        private int sinav1;
        private int sinav2;
        private int ortalama;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="" || textBox2.Text=="" || textBox3.Text =="") { MessageBox.Show("Tüm alanlarý doðru doldurunuz!"); }
            else {
                sinav1 = int.Parse(textBox2.Text);
                sinav2 = int.Parse(textBox3.Text);
                ortalama = (sinav1 + sinav2)/2;

                listBox1.Items.Add(textBox1.Text);
                listBox2.Items.Add(textBox2.Text);
                listBox3.Items.Add(textBox3.Text);
                listBox4.Items.Add(ortalama.ToString());

                if (ortalama > 50) { listBox5.Items.Add("GEÇTÝ"); }
                else { listBox5.Items.Add("KALDI"); };
            }
            
            
            



        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int sel = listBox1.SelectedIndex;
            if (sel == -1) { MessageBox.Show("Lütfen Ad Soyad'dan bir öge seçin!"); }
            else
            {
                listBox1.Items.RemoveAt(sel);
                listBox2.Items.RemoveAt(sel);
                listBox3.Items.RemoveAt(sel);
                listBox4.Items.RemoveAt(sel);
                listBox5.Items.RemoveAt(sel);
            }



        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
        }
    }
}
