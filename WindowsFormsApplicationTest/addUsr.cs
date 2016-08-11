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
    public partial class addUsr : Form
    {
        public addUsr()
        {
            InitializeComponent();
        }

        private void addUsr_Load(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            //loginForm.con
            SqlCommand cmd = loginForm.con.CreateCommand();
            cmd.CommandText = "CREATE LOGIN " + usrBox.Text + " WITH PASSWORD = '" + passBox.Text + ";";

            try
            {

                cmd.ExecuteNonQuery();
                usrBox.Text = "good";


            }
            catch (Exception)
            {
                Console.Write("Query unsuccessful");
            }
        }

        private void roleBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
