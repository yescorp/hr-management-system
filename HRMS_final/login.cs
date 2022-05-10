using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace HRMS_final
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\22119\source\repos\HRMS_final\HRMS_final\HR_management_final.accdb";
                conn.Open();

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT [username], [password] FROM [users]";

                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.GetString(0) == this.username.Text && reader.GetString(1) == this.password.Text)
                    {
                        Form manager = new HRManagerInterfaceEmployee();
                        this.Hide();
                        manager.ShowDialog();

                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Such users doesn't exist. Try to contact your system administrator or HR Manager");
        }

        private void login_Load(object sender, EventArgs e)
        {
            
        }
    }
}
