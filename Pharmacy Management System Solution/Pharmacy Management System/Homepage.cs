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
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();

        }
       
        private void Homepage_Load(object sender, EventArgs e)
        {
            
           
        }

        private void searchBox_Enter_1(object sender, EventArgs e)
        {
            if (searchBox.Text == "Search Here...")
            {
                searchBox.Text = "";
                searchBox.ForeColor = Color.Black;
            }

        }

        private void searchBox_Leave_1(object sender, EventArgs e)
        {
            if (searchBox.Text == "")
            {
                searchBox.Text = "Search Here...";
                searchBox.ForeColor = Color.Silver;
            }

        }
        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count < 7)
            {

                pictureBox2.Image = imageList1.Images[count];
                count++;
            }
            else
            {
                count = 0;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void buttonBeauty_Click(object sender, EventArgs e)
        {
            BeautyCare beautyCare = new BeautyCare();
            beautyCare.Show();
            this.Hide();
        }

        private void buttonNatural_Click(object sender, EventArgs e)
        {
            NaturalCareAndWellness n = new NaturalCareAndWellness();
            n.Show();
            this.Hide();
        }

        private void buttonMaBcare_Click(object sender, EventArgs e)
        {
            BabyAndMomCare b = new BabyAndMomCare();
            b.Show();
            this.Hide();
        }

        private void buttonHealth_Click(object sender, EventArgs e)
        {
            HealthCare h = new HealthCare();
            h.Show();
            this.Hide();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            FormLogin home = new FormLogin();
            home.Show();
            this.Hide();
        }
    }
}
