namespace Muhasebev2
{
    partial class Form7
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
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 44);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(312, 94);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(12, 189);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(312, 94);
            listBox2.TabIndex = 1;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(12, 329);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(312, 94);
            listBox3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Caviar Dreams", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(79, 24);
            label1.TabIndex = 5;
            label1.Text = "Sicil No";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Caviar Dreams", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 162);
            label2.Name = "label2";
            label2.Size = new Size(102, 24);
            label2.TabIndex = 8;
            label2.Text = "Ad Soyad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Caviar Dreams", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 302);
            label3.Name = "label3";
            label3.Size = new Size(61, 24);
            label3.TabIndex = 10;
            label3.Text = "Maaş";
            // 
            // button1
            // 
            button1.Font = new Font("Caviar Dreams", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(372, 315);
            button1.Name = "button1";
            button1.Size = new Size(187, 51);
            button1.TabIndex = 13;
            button1.Text = "Veri Sil";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Caviar Dreams", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(372, 372);
            button2.Name = "button2";
            button2.Size = new Size(187, 51);
            button2.TabIndex = 14;
            button2.Text = "Geri Dön";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Caviar Dreams", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(386, 44);
            label4.Name = "label4";
            label4.Size = new Size(0, 24);
            label4.TabIndex = 15;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 450);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Name = "Form7";
            Text = "Form7";
            Load += Form7_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Label label4;
    }
}