﻿namespace Muhasebev2
{
    partial class Form2
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Caviar Dreams", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(126, 24);
            label1.TabIndex = 1;
            label1.Text = "Kullanıcı Adı";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Caviar Dreams", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox1.Location = new Point(152, 15);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(196, 30);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Caviar Dreams", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 61);
            label2.Name = "label2";
            label2.Size = new Size(49, 24);
            label2.TabIndex = 4;
            label2.Text = "Şifre";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Caviar Dreams", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox2.Location = new Point(152, 61);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(196, 30);
            textBox2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Caviar Dreams", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 110);
            label3.Name = "label3";
            label3.Size = new Size(0, 24);
            label3.TabIndex = 6;
            // 
            // button1
            // 
            button1.Font = new Font("Caviar Dreams", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(12, 137);
            button1.Name = "button1";
            button1.Size = new Size(336, 51);
            button1.TabIndex = 7;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Caviar Dreams", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(12, 207);
            button2.Name = "button2";
            button2.Size = new Size(155, 51);
            button2.TabIndex = 8;
            button2.Text = "Şifre Değiştir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Caviar Dreams", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button3.Location = new Point(193, 207);
            button3.Name = "button3";
            button3.Size = new Size(155, 51);
            button3.TabIndex = 9;
            button3.Text = "Kullanıcı Adı değiştir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 273);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Hesap Kontrol";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}