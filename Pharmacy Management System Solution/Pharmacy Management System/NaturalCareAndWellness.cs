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
    public partial class NaturalCareAndWellness : Form
    {
        public NaturalCareAndWellness()
        {
            InitializeComponent();
        }

        private void buttonHealthCare_Click(object sender, EventArgs e)
        {
            HealthCare healthCare = new HealthCare();
            healthCare.Show();
            this.Hide();
        }

        private void buttonBeautyCare_Click(object sender, EventArgs e)
        {
            BeautyCare beautyCare = new BeautyCare();
            beautyCare.Show();
            this.Hide();
        }

        private void buttonBabyMomCare_Click(object sender, EventArgs e)
        {
            BabyAndMomCare babyAndMomCare = new BabyAndMomCare();
            babyAndMomCare.Show();
            this.Hide();
        }

        private void buttonNaturalCare_Click(object sender, EventArgs e)
        {
            NaturalCareAndWellness naturalCareAndWellness = new NaturalCareAndWellness();
            naturalCareAndWellness.Show();
            this.Hide();
        }

        private void NaturalCareAndWellness_Load(object sender, EventArgs e)
        {

        }

        private void buttonBackToHome_Click(object sender, EventArgs e)
        {
            Homepage home = new Homepage();
            home.Show();
            this.Hide();
        }
    }
}
