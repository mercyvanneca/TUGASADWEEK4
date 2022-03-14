using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TUGASADWEEK4
{
    public partial class FormInput : Form
    {
        public FormInput()
        {
            InitializeComponent();
        }

        private void ButtonLihatData_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormOutput formOutput = new FormOutput();
            formOutput.ShowDialog();
            this.Close();
        }

        private void ButtonKembali_Click(object sender, EventArgs e)
        {
          
        }

        private void ButtonLihatData_Click_1(object sender, EventArgs e)
        {

        }

        private void TextBoxNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
