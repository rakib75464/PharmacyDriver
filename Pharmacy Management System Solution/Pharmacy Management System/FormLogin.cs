using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pharmacy_Management_System
{
    public partial class FormLogin : Form
    {
        function fn;
        public FormLogin()
        {
            InitializeComponent();
            fn = new function();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            // textBoxPassword.PasswordChar = checkBoxShowPassword.Checked ? '\0' : '*';
            
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked == true)
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            Registration_Form SigninForm = new Registration_Form();
            SigninForm.Show();

            this.Hide();

        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            if (textBoxUserName.Text.Length <= 0 || textBoxPassword.Text.Length <= 0)
            {
                MessageBox.Show("Fields cannot be empty", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            /*}

            else
            {
                MessageBox.Show("Credentials don't match", "Wrong Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/

            else
            {
                //try
                //{
                string name = textBoxUserName.Text;
                string pass = textBoxPassword.Text;
                string query = "select * from userTable where userName ='{0}'";
                query = string.Format(query, name);
                SqlDataReader reader = fn.ReadData(query);
                if (reader.Read())
                {
                    string storedpass = reader["password"].ToString();
                    if (storedpass == pass)
                    {
                        // MessageBox.Show("LogIn successful");
                        //try
                        //{
                        if (reader["role"].ToString() == "Customer")
                        {
                            // Admin a = new Admin();
                            //if (a.UserActivision(userName) == false)//user is activated
                            //{
                            new Homepage().Show();
                            this.Hide();
                            reader.Close();
                            //setting userID explicitly??
                            // LogInTableMembers mem = new LogInTableMembers();
                            //mem.SetThisUserID(name);


                            /*else
                            {
                                MessageBox.Show("User is not yet activated by any Admins"); reader.Close();
                            }*/
                        }
                        else if (reader["role"].ToString() == "Admin")
                        {
                            new Admin_Dashboard().Show();
                            this.Hide();
                            reader.Close();
                        }

                        else if (reader["role"].ToString() == "Employee")
                        {
                            new Add_Products_Form().Show();
                            this.Hide();
                            reader.Close();
                        }
                        //}
                        //catch (Exception ex)
                        //   {
                        //       MessageBox.Show(ex.Message);
                        //   }
                        reader.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid password");
                        reader.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Invalid name");
                    reader.Close();
                }

                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}
                //}
            }

        }
    }
}

