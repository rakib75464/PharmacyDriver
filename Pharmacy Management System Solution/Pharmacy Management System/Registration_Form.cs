using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System
{
    public partial class Registration_Form : Form
    {
        public Registration_Form()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox7.UseSystemPasswordChar = false;
                textBox8.UseSystemPasswordChar = false;
            }
            else
            {
                textBox7.UseSystemPasswordChar = true;
                textBox8.UseSystemPasswordChar = true;
            }
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "DD/MM/YYYY")
            {
                textBox5.Text = "";
                textBox5.ForeColor = Color.Black;
            }


        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "DD/MM/YYYY";
                textBox5.ForeColor = Color.Silver;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registration_Form about = new Registration_Form();
            about.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormLogin SigninForm = new FormLogin();
            SigninForm.Show();

            this.Hide();
        }
    }
}
