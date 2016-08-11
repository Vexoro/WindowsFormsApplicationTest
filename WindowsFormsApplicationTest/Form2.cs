using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WindowsFormsApplicationTest
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public static bool fieldCheck(TextBox a, TextBox b, TextBox c, TextBox d)
        {
            TextBox[] tbArray = { a, b, c, d };
            foreach (TextBox i in tbArray)
            {
                if (i.Text == "")
                {
                    return false;
                }
            }
            return true;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {

            try
            {
                //loginForm.con.Open();

                SqlCommand cmd = loginForm.con.CreateCommand();
                cmd.CommandText = "INSERT INTO Customer (first_name, last_name, phone, email) VALUES ('" + fnameBox.Text + "','" + lnBox.Text + "','" + phoneBox.Text + "','" + emailBox.Text + "');";
                try
                {
                    if (fieldCheck(fnameBox, lnBox, emailBox, phoneBox))
                    {
                        cmd.ExecuteNonQuery();
                        statusLabel.Text = "Record added";
                        fnameBox.Text = "";
                        lnBox.Text = "";
                        phoneBox.Text = "";
                        emailBox.Text = "";
                    }
                    else
                    {
                        statusLabel.Text = "Missing Field!";
                    }
                    
                    
                }
                catch (Exception)
                {
                    statusLabel.Text = "Query unsuccessful";
                }
            }
            catch (Exception)
            {
                statusLabel.Text = "Connection Unsuccessful";
            }
        }

        private void fnameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lnBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void phoneBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void displayBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
