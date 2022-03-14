namespace TUGASADWEEK4
{
    partial class FormInput
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
            this.LabelNama = new System.Windows.Forms.Label();
            this.TextBoxNama = new System.Windows.Forms.TextBox();
            this.LabelAlamat = new System.Windows.Forms.Label();
            this.LabelTlp = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ButtonKembali = new System.Windows.Forms.Button();
            this.ButtonLihatData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelNama
            // 
            this.LabelNama.AutoSize = true;
            this.LabelNama.Location = new System.Drawing.Point(12, 22);
            this.LabelNama.Name = "LabelNama";
            this.LabelNama.Size = new System.Drawing.Size(39, 15);
            this.LabelNama.TabIndex = 0;
            this.LabelNama.Text = "Nama";
            // 
            // TextBoxNama
            // 
            this.TextBoxNama.Location = new System.Drawing.Point(57, 19);
            this.TextBoxNama.Name = "TextBoxNama";
            this.TextBoxNama.Size = new System.Drawing.Size(277, 23);
            this.TextBoxNama.TabIndex = 1;
            this.TextBoxNama.TextChanged += new System.EventHandler(this.TextBoxNama_TextChanged);
            // 
            // LabelAlamat
            // 
            this.LabelAlamat.AutoSize = true;
            this.LabelAlamat.Location = new System.Drawing.Point(12, 58);
            this.LabelAlamat.Name = "LabelAlamat";
            this.LabelAlamat.Size = new System.Drawing.Size(45, 15);
            this.LabelAlamat.TabIndex = 2;
            this.LabelAlamat.Text = "Alamat";
            // 
            // LabelTlp
            // 
            this.LabelTlp.AutoSize = true;
            this.LabelTlp.Location = new System.Drawing.Point(12, 93);
            this.LabelTlp.Name = "LabelTlp";
            this.LabelTlp.Size = new System.Drawing.Size(28, 15);
            this.LabelTlp.TabIndex = 3;
            this.LabelTlp.Text = "Telp";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(57, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 23);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(57, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(277, 23);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ButtonKembali
            // 
            this.ButtonKembali.Location = new System.Drawing.Point(57, 147);
            this.ButtonKembali.Name = "ButtonKembali";
            this.ButtonKembali.Size = new System.Drawing.Size(75, 23);
            this.ButtonKembali.TabIndex = 6;
            this.ButtonKembali.Text = "Simpan";
            this.ButtonKembali.UseVisualStyleBackColor = true;
            this.ButtonKembali.Click += new System.EventHandler(this.ButtonKembali_Click);
            // 
            // ButtonLihatData
            // 
            this.ButtonLihatData.Location = new System.Drawing.Point(178, 147);
            this.ButtonLihatData.Name = "ButtonLihatData";
            this.ButtonLihatData.Size = new System.Drawing.Size(75, 23);
            this.ButtonLihatData.TabIndex = 7;
            this.ButtonLihatData.Text = "Lihat Data";
            this.ButtonLihatData.UseVisualStyleBackColor = true;
            this.ButtonLihatData.Click += new System.EventHandler(this.ButtonLihatData_Click_1);
            // 
            // FormInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 235);
            this.Controls.Add(this.ButtonLihatData);
            this.Controls.Add(this.ButtonKembali);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LabelTlp);
            this.Controls.Add(this.LabelAlamat);
            this.Controls.Add(this.TextBoxNama);
            this.Controls.Add(this.LabelNama);
            this.Name = "FormInput";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelNama;
        private System.Windows.Forms.TextBox TextBoxNama;
        private System.Windows.Forms.Label LabelAlamat;
        private System.Windows.Forms.Label LabelTlp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button ButtonKembali;
        private System.Windows.Forms.Button ButtonLihatData;
    }
}
