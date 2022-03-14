namespace TUGASADWEEK4
{
    partial class FormOutput
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
            this.LabelNama2 = new System.Windows.Forms.Label();
            this.TextBoxNama2 = new System.Windows.Forms.TextBox();
            this.LabelAlamat2 = new System.Windows.Forms.Label();
            this.TextBoxAlamat2 = new System.Windows.Forms.TextBox();
            this.LabelTlp2 = new System.Windows.Forms.Label();
            this.TextBoxTelp2 = new System.Windows.Forms.TextBox();
            this.ButtonSimpan2 = new System.Windows.Forms.Button();
            this.ButtonPrevData = new System.Windows.Forms.Button();
            this.ButtonNextData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelNama2
            // 
            this.LabelNama2.AutoSize = true;
            this.LabelNama2.Location = new System.Drawing.Point(12, 22);
            this.LabelNama2.Name = "LabelNama2";
            this.LabelNama2.Size = new System.Drawing.Size(39, 15);
            this.LabelNama2.TabIndex = 0;
            this.LabelNama2.Text = "Nama";
            // 
            // TextBoxNama2
            // 
            this.TextBoxNama2.Location = new System.Drawing.Point(57, 19);
            this.TextBoxNama2.Name = "TextBoxNama2";
            this.TextBoxNama2.Size = new System.Drawing.Size(277, 23);
            this.TextBoxNama2.TabIndex = 2;
            this.TextBoxNama2.TextChanged += new System.EventHandler(this.TextBoxNama2_TextChanged);
            // 
            // LabelAlamat2
            // 
            this.LabelAlamat2.AutoSize = true;
            this.LabelAlamat2.Location = new System.Drawing.Point(12, 58);
            this.LabelAlamat2.Name = "LabelAlamat2";
            this.LabelAlamat2.Size = new System.Drawing.Size(45, 15);
            this.LabelAlamat2.TabIndex = 3;
            this.LabelAlamat2.Text = "Alamat";
            // 
            // TextBoxAlamat2
            // 
            this.TextBoxAlamat2.Location = new System.Drawing.Point(57, 55);
            this.TextBoxAlamat2.Name = "TextBoxAlamat2";
            this.TextBoxAlamat2.Size = new System.Drawing.Size(277, 23);
            this.TextBoxAlamat2.TabIndex = 5;
            this.TextBoxAlamat2.TextChanged += new System.EventHandler(this.TextBoxAlamat2_TextChanged);
            // 
            // LabelTlp2
            // 
            this.LabelTlp2.AutoSize = true;
            this.LabelTlp2.Location = new System.Drawing.Point(12, 93);
            this.LabelTlp2.Name = "LabelTlp2";
            this.LabelTlp2.Size = new System.Drawing.Size(28, 15);
            this.LabelTlp2.TabIndex = 6;
            this.LabelTlp2.Text = "Telp";
            // 
            // TextBoxTelp2
            // 
            this.TextBoxTelp2.Location = new System.Drawing.Point(57, 90);
            this.TextBoxTelp2.Name = "TextBoxTelp2";
            this.TextBoxTelp2.Size = new System.Drawing.Size(277, 23);
            this.TextBoxTelp2.TabIndex = 7;
            this.TextBoxTelp2.TextChanged += new System.EventHandler(this.TextBoxTelp2_TextChanged);
            // 
            // ButtonSimpan2
            // 
            this.ButtonSimpan2.Location = new System.Drawing.Point(57, 147);
            this.ButtonSimpan2.Name = "ButtonSimpan2";
            this.ButtonSimpan2.Size = new System.Drawing.Size(75, 23);
            this.ButtonSimpan2.TabIndex = 8;
            this.ButtonSimpan2.Text = "Simpan";
            this.ButtonSimpan2.UseVisualStyleBackColor = true;
            this.ButtonSimpan2.Click += new System.EventHandler(this.ButtonSimpan2_Click);
            // 
            // ButtonPrevData
            // 
            this.ButtonPrevData.Location = new System.Drawing.Point(152, 147);
            this.ButtonPrevData.Name = "ButtonPrevData";
            this.ButtonPrevData.Size = new System.Drawing.Size(75, 23);
            this.ButtonPrevData.TabIndex = 9;
            this.ButtonPrevData.Text = "Prev Data";
            this.ButtonPrevData.UseVisualStyleBackColor = true;
            this.ButtonPrevData.Click += new System.EventHandler(this.ButtonPrevData_Click);
            // 
            // ButtonNextData
            // 
            this.ButtonNextData.Location = new System.Drawing.Point(245, 147);
            this.ButtonNextData.Name = "ButtonNextData";
            this.ButtonNextData.Size = new System.Drawing.Size(75, 23);
            this.ButtonNextData.TabIndex = 10;
            this.ButtonNextData.Text = "Next Data";
            this.ButtonNextData.UseVisualStyleBackColor = true;
            this.ButtonNextData.Click += new System.EventHandler(this.ButtonNextData_Click);
            // 
            // FormOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 235);
            this.Controls.Add(this.ButtonNextData);
            this.Controls.Add(this.ButtonPrevData);
            this.Controls.Add(this.ButtonSimpan2);
            this.Controls.Add(this.TextBoxTelp2);
            this.Controls.Add(this.LabelTlp2);
            this.Controls.Add(this.TextBoxAlamat2);
            this.Controls.Add(this.LabelAlamat2);
            this.Controls.Add(this.TextBoxNama2);
            this.Controls.Add(this.LabelNama2);
            this.Location = new System.Drawing.Point(57, 90);
            this.Name = "FormOutput";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelNama2;
        private System.Windows.Forms.TextBox TextBoxNama2;
        private System.Windows.Forms.Label LabelAlamat2;
        private System.Windows.Forms.TextBox TextBoxAlamat2;
        private System.Windows.Forms.Label LabelTlp2;
        private System.Windows.Forms.TextBox TextBoxTelp2;
        private System.Windows.Forms.Button ButtonSimpan2;
        private System.Windows.Forms.Button ButtonPrevData;
        private System.Windows.Forms.Button ButtonNextData;
    }
}