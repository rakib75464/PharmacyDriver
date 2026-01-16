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
    public partial class Admin_View_User : Form
    {
        function fn = new function();
        String query;
        public Admin_View_User()
        {
            InitializeComponent();
        }

        private void Admin_View_User_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet.userTable' table. You can move, or remove it, as needed.
            this.userTableTableAdapter.Fill(this.pharmacyDataSet.userTable);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            query = "select * from userTable";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            query = "select * from userTable where userName like '"+textBox1.Text+"%'";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Admin_Dashboard().Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBox1.Text))
    {
                MessageBox.Show("Please enter a username to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Formulate the query to delete the user with the specific username from the textbox
            query = "DELETE FROM userTable WHERE userName LIKE '" + textBox1.Text + "%'";

            // Ask for confirmation before deleting
            DialogResult result = MessageBox.Show("Are you sure you want to delete the user(s) with the specified username?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Execute the delete command
                fn.setData(query, "User Record(s) Deleted");

                // Refresh the data in DataGridView to reflect the changes
                Admin_View_User_Load(this, null);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Admin_Add_User().Show();
            this.Hide() ;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new FormLogin().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Admin_Update_User().Show();
            this.Hide();
        }
    }
}
