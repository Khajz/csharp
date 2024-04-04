namespace Muhasebev2
{
    partial class Form3
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Caviar Dreams", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(12, 26);
            button1.Name = "button1";
            button1.Size = new Size(317, 51);
            button1.TabIndex = 11;
            button1.Text = "Listeye Veri Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Caviar Dreams", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(12, 100);
            button2.Name = "button2";
            button2.Size = new Size(317, 51);
            button2.TabIndex = 12;
            button2.Text = "Listedeki Verileri Düzenle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Caviar Dreams", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button3.Location = new Point(12, 182);
            button3.Name = "button3";
            button3.Size = new Size(317, 51);
            button3.TabIndex = 13;
            button3.Text = "Hesap Ayaları";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 265);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form3";
            Text = "Muhasebe Sistemi";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
    }
}