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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public static SqlConnection con;

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=" + passField.Text + ";Persist Security Info=True;User ID=" + usrTextBox.Text + ";Initial Catalog=NotebookOutlet;Data Source=ASPIRE-E15");

            try
            {
                con.Open();
                statusLabel.Text = "Connection Established";
                CustomerForm cf = new CustomerForm();
                //this.Hide();
                cf.Show();
                AdminForm af = new AdminForm();
                af.Show();
            }
            catch (Exception)
            {
                statusLabel.Text = "Connection Unsuccessful";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO Customer (first_name, last_name, phone, email) VALUES ('" + fnameBox.Text + "','" + lnBox.Text + "','" + phoneBox.Text + "','" + emailBox.Text + "');";
            try
            {
                cmd.ExecuteNonQuery();
                statusLabel.Text = "Record added";

                fnameBox.Text = "";
                lnBox.Text = "";
                phoneBox.Text = "";
                emailBox.Text = "";
            }
            catch (Exception)
            {
                statusLabel.Text = "Query unsuccessful";
            }
        }

        private void ipBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
