namespace WinFormsApp2
{
    public partial class Form1 : Form
    {

        List<string> malzemeSecim = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(textBox3.Text);
            listBox4.Items.Add(comboBox1.Text);
            listBox5.Items.Add(comboBox2.Text);
            if (checkBox1.Checked) { malzemeSecim.Add(checkBox1.Text); };
            if (checkBox2.Checked) { malzemeSecim.Add(checkBox2.Text); };
            if (checkBox3.Checked) { malzemeSecim.Add(checkBox3.Text); };
            if (checkBox4.Checked) { malzemeSecim.Add(checkBox4.Text); };
            if (checkBox5.Checked) { malzemeSecim.Add(checkBox5.Text); };
            if (checkBox6.Checked) { malzemeSecim.Add(checkBox6.Text); };
            string birlesmis = string.Join(",", malzemeSecim);
            listBox6.Items.Add(birlesmis);
            malzemeSecim.Clear();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            malzemeSecim.Clear();
        }
    }
}
