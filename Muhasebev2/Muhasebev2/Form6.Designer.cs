namespace Muhasebev2
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Caviar Dreams", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(79, 24);
            label1.TabIndex = 4;
            label1.Text = "Sicil No";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Caviar Dreams", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox1.Location = new Point(138, 9);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(189, 30);
            textBox1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Caviar Dreams", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 58);
            label2.Name = "label2";
            label2.Size = new Size(102, 24);
            label2.TabIndex = 7;
            label2.Text = "Ad Soyad";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Caviar Dreams", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox2.Location = new Point(138, 52);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(189, 30);
            textBox2.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Caviar Dreams", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 105);
            label3.Name = "label3";
            label3.Size = new Size(61, 24);
            label3.TabIndex = 9;
            label3.Text = "Maaş";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Caviar Dreams", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox3.Location = new Point(138, 105);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(189, 30);
            textBox3.TabIndex = 10;
            // 
            // button1
            // 
            button1.Font = new Font("Caviar Dreams", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(177, 198);
            button1.Name = "button1";
            button1.Size = new Size(148, 51);
            button1.TabIndex = 12;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Caviar Dreams", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(12, 198);
            button2.Name = "button2";
            button2.Size = new Size(148, 51);
            button2.TabIndex = 13;
            button2.Text = "Geri Dön";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Caviar Dreams", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 156);
            label4.Name = "label4";
            label4.Size = new Size(0, 24);
            label4.TabIndex = 14;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 263);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form6";
            Text = "Listeye Veri Ekle";
            Load += Form6_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Label label4;
    }
}