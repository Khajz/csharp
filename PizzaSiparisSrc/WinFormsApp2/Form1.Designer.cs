namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            groupBox1 = new GroupBox();
            checkBox6 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            listBox1 = new ListBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            listBox4 = new ListBox();
            listBox5 = new ListBox();
            listBox6 = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("LEMON MILK", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(421, 9);
            label1.Name = "label1";
            label1.Size = new Size(284, 53);
            label1.TabIndex = 0;
            label1.Text = "Pizza Sipariş";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("LEMON MILK", 15F);
            label2.Location = new Point(12, 88);
            label2.Name = "label2";
            label2.Size = new Size(117, 29);
            label2.TabIndex = 1;
            label2.Text = "AD SOYAD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("LEMON MILK", 15F);
            label3.Location = new Point(12, 135);
            label3.Name = "label3";
            label3.Size = new Size(105, 29);
            label3.TabIndex = 2;
            label3.Text = "Telefon";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("LEMON MILK", 15F);
            label4.Location = new Point(12, 179);
            label4.Name = "label4";
            label4.Size = new Size(80, 29);
            label4.TabIndex = 3;
            label4.Text = "ADRES";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("LEMON MILK", 15F);
            label5.Location = new Point(12, 297);
            label5.Name = "label5";
            label5.Size = new Size(123, 29);
            label5.TabIndex = 4;
            label5.Text = "BOY SEÇİM";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("LEMON MILK", 15F);
            label6.Location = new Point(12, 344);
            label6.Name = "label6";
            label6.Size = new Size(153, 29);
            label6.TabIndex = 5;
            label6.Text = "İÇEÇEK SEÇİM";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("LEMON MILK", 15F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox1.Location = new Point(182, 82);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(176, 35);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("LEMON MILK", 15F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox2.Location = new Point(182, 129);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(176, 35);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("LEMON MILK", 15F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox3.Location = new Point(182, 179);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(176, 106);
            textBox3.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("LEMON MILK", 15F, FontStyle.Regular, GraphicsUnit.Point, 162);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "KÜÇÜK", "ORTA", "BÜYÜK" });
            comboBox1.Location = new Point(182, 291);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(176, 37);
            comboBox1.TabIndex = 11;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("LEMON MILK", 15F, FontStyle.Regular, GraphicsUnit.Point, 162);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "KOLA", "FANTA", "GAZOZ", "AYRAN" });
            comboBox2.Location = new Point(182, 334);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(176, 37);
            comboBox2.TabIndex = 12;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox6);
            groupBox1.Controls.Add(checkBox5);
            groupBox1.Controls.Add(checkBox4);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Font = new Font("LEMON MILK", 15F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(12, 377);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(346, 181);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "MALZEME SEÇİM";
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(182, 123);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(91, 33);
            checkBox6.TabIndex = 5;
            checkBox6.Text = "SOSİS";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(6, 123);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(88, 33);
            checkBox5.TabIndex = 4;
            checkBox5.Text = "BİBER";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(182, 84);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(119, 33);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "MANTAR";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(6, 84);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(85, 33);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "MISIR";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(182, 45);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(103, 33);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "ZEYTİN";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 45);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(102, 33);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "SUCUK";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("LEMON MILK", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.Location = new Point(223, 564);
            button1.Name = "button1";
            button1.Size = new Size(135, 33);
            button1.TabIndex = 6;
            button1.Text = "SİPARİŞ AL";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("LEMON MILK", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button2.Location = new Point(12, 564);
            button2.Name = "button2";
            button2.Size = new Size(135, 33);
            button2.TabIndex = 14;
            button2.Text = "TEMİZLE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("LEMON MILK", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 17;
            listBox1.Location = new Point(488, 82);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(217, 89);
            listBox1.TabIndex = 15;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("LEMON MILK", 15F);
            label7.Location = new Point(488, 179);
            label7.Name = "label7";
            label7.Size = new Size(117, 29);
            label7.TabIndex = 21;
            label7.Text = "AD SOYAD";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("LEMON MILK", 15F);
            label8.Location = new Point(774, 179);
            label8.Name = "label8";
            label8.Size = new Size(105, 29);
            label8.TabIndex = 22;
            label8.Text = "Telefon";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("LEMON MILK", 15F);
            label9.Location = new Point(488, 364);
            label9.Name = "label9";
            label9.Size = new Size(80, 29);
            label9.TabIndex = 23;
            label9.Text = "ADRES";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("LEMON MILK", 15F);
            label10.Location = new Point(774, 364);
            label10.Name = "label10";
            label10.Size = new Size(123, 29);
            label10.TabIndex = 24;
            label10.Text = "BOY SEÇİM";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("LEMON MILK", 15F);
            label11.Location = new Point(488, 561);
            label11.Name = "label11";
            label11.Size = new Size(153, 29);
            label11.TabIndex = 25;
            label11.Text = "İÇEÇEK SEÇİM";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("LEMON MILK", 15F);
            label12.Location = new Point(774, 561);
            label12.Name = "label12";
            label12.Size = new Size(180, 29);
            label12.TabIndex = 26;
            label12.Text = "MALZEME SEÇİM";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("LEMON MILK", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label13.Location = new Point(421, 278);
            label13.Name = "label13";
            label13.Size = new Size(0, 53);
            label13.TabIndex = 27;
            // 
            // listBox2
            // 
            listBox2.Font = new Font("LEMON MILK", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 17;
            listBox2.Location = new Point(774, 82);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(217, 89);
            listBox2.TabIndex = 28;
            // 
            // listBox3
            // 
            listBox3.Font = new Font("LEMON MILK", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 17;
            listBox3.Location = new Point(488, 272);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(217, 89);
            listBox3.TabIndex = 29;
            // 
            // listBox4
            // 
            listBox4.Font = new Font("LEMON MILK", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 17;
            listBox4.Location = new Point(774, 272);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(217, 89);
            listBox4.TabIndex = 30;
            // 
            // listBox5
            // 
            listBox5.Font = new Font("LEMON MILK", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            listBox5.FormattingEnabled = true;
            listBox5.ItemHeight = 17;
            listBox5.Location = new Point(488, 469);
            listBox5.Name = "listBox5";
            listBox5.Size = new Size(217, 89);
            listBox5.TabIndex = 31;
            // 
            // listBox6
            // 
            listBox6.Font = new Font("LEMON MILK", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            listBox6.FormattingEnabled = true;
            listBox6.ItemHeight = 17;
            listBox6.Location = new Point(774, 469);
            listBox6.Name = "listBox6";
            listBox6.Size = new Size(217, 89);
            listBox6.TabIndex = 32;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1003, 600);
            Controls.Add(listBox6);
            Controls.Add(listBox5);
            Controls.Add(listBox4);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "THE ULTIMATE PIZZA ORDERING SYSTEM";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private GroupBox groupBox1;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private Button button1;
        private Button button2;
        private ListBox listBox1;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private ListBox listBox2;
        private ListBox listBox3;
        private ListBox listBox4;
        private ListBox listBox5;
        private ListBox listBox6;
    }
}
