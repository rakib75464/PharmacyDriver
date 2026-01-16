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
    public partial class Add_Products_Form : Form
    {
        public Add_Products_Form()
        {
            InitializeComponent();
        }

        private void Products_operation_Load(object sender, EventArgs e)
        {

        }

        private void buttonInsertimage_Click(object sender, EventArgs e)
        {
            openFileDialogImage.Filter = "Select image(*.Jpg; *.png; *.Gif)|*.Jpg; *.png; *.Gif";
            if (openFileDialogImage.ShowDialog() == DialogResult.OK)
            {
                pictureBoxProduct.Image = Image.FromFile(openFileDialogImage.FileName);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
