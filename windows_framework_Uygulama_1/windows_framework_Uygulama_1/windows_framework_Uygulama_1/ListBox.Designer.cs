namespace windows_framework_Uygulama_1
{
    partial class ListBox
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtYazi = new System.Windows.Forms.TextBox();
            this.btnSeciliSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHepsiniSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(26, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(181, 186);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(223, 9);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(83, 49);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtYazi
            // 
            this.txtYazi.Location = new System.Drawing.Point(321, 24);
            this.txtYazi.Name = "txtYazi";
            this.txtYazi.Size = new System.Drawing.Size(100, 20);
            this.txtYazi.TabIndex = 2;
            // 
            // btnSeciliSil
            // 
            this.btnSeciliSil.Location = new System.Drawing.Point(223, 96);
            this.btnSeciliSil.Name = "btnSeciliSil";
            this.btnSeciliSil.Size = new System.Drawing.Size(83, 57);
            this.btnSeciliSil.TabIndex = 3;
            this.btnSeciliSil.Text = "Seçili Olanı\r\n Sil";
            this.btnSeciliSil.UseVisualStyleBackColor = true;
            this.btnSeciliSil.Click += new System.EventHandler(this.btnSeciliSil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(191, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "List Item";
            // 
            // btnHepsiniSil
            // 
            this.btnHepsiniSil.Location = new System.Drawing.Point(321, 96);
            this.btnHepsiniSil.Name = "btnHepsiniSil";
            this.btnHepsiniSil.Size = new System.Drawing.Size(83, 57);
            this.btnHepsiniSil.TabIndex = 5;
            this.btnHepsiniSil.Text = "Hepsini Sil";
            this.btnHepsiniSil.UseVisualStyleBackColor = true;
            this.btnHepsiniSil.Click += new System.EventHandler(this.btnHepsiniSil_Click);
            // 
            // ListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 374);
            this.Controls.Add(this.btnHepsiniSil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSeciliSil);
            this.Controls.Add(this.txtYazi);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.listBox1);
            this.Name = "ListBox";
            this.Text = "ListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtYazi;
        private System.Windows.Forms.Button btnSeciliSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHepsiniSil;
    }
}