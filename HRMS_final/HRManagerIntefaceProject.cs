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
    public partial class HRManagerIntefaceProject : Form
    {
        public int selectedId = -1;
        public bool canBeUpdated = false;
        public HRManagerIntefaceProject()
        {
            InitializeComponent();
        }

        public static int project_id = -1;
        public static string project_name = "Project name";

        private void HRManagerIntefaceProject_Load(object sender, EventArgs e)
        {
            LoadProjectsTable();
        }

        private void LoadProjectsTable()
        {
            try { 
                OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\22119\source\repos\HRMS_final\HRMS_final\HR_management_final.accdb";
                conn.Open();

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT [projects].[id], [projects].[project_name], [projects].[description], [projects].[deadline]" +
                    "FROM [projects]";

                OleDbDataAdapter da = new OleDbDataAdapter(cmd.CommandText, conn);

                DataTable dt = new DataTable();

                //OleDbDataReader reader = cmd.ExecuteReader();

                //dt.Load(reader);



                da.Fill(dt);

                projectsTable.DataSource = dt;
                projectsTable.AutoResizeColumns();
                projectsTable.ReadOnly = true;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form next = new HRManagerInterfaceEmployee();
            this.Hide();
            next.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ProjectsTableCellClick(object sender, DataGridViewCellEventArgs e)
        {
            project_id = int.Parse(projectsTable[0, e.RowIndex].Value.ToString());
            project_name = projectsTable[1, e.RowIndex].Value.ToString();
            Form next = new Project();
            next.ShowDialog();
        }

        private void ProjectsTableCellSelect(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedId = int.Parse(projectsTable[0, e.RowIndex].Value.ToString());
                this.name.Text = projectsTable[1, e.RowIndex].Value.ToString();
                this.description.Text = projectsTable[2, e.RowIndex].Value.ToString();
                string[] date = projectsTable[3, e.RowIndex].Value.ToString().Split('.');
                canBeUpdated = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void INSERT_Click(object sender, EventArgs e)
        {
            //INSERT
            try
            {


                OleDbConnection idConn = new OleDbConnection();
                idConn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\22119\source\repos\HRMS_final\HRMS_final\HR_management_final.accdb";
                OleDbCommand idCom = new OleDbCommand();

                idCom.Connection = idConn;
                idConn.Open();
                idCom.CommandText = "SELECT id FROM projects";
                OleDbDataReader reader = idCom.ExecuteReader();

                List<int> id = new List<int>();


                while (reader.Read())
                {
                    id.Add(reader.GetInt32(0));
                }

                idCom.Dispose();
                idConn.Close();


                OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\22119\source\repos\HRMS_final\HRMS_final\HR_management_final.accdb";
                conn.Open();

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO [projects] values(@id, @name, @description, @deadline, @completion_time)";

                cmd.Parameters.AddWithValue("@id", id.Max() + 1);
                cmd.Parameters.AddWithValue("@name", this.name.Text);
                cmd.Parameters.AddWithValue("@desctiprion", this.description.Text);
                cmd.Parameters.AddWithValue("@deadline", this.deadline.Value.ToString("dd.MM.yyyy"));
                cmd.Parameters.AddWithValue("@completion_time", DateTime.Today.ToString("dd.MM.yyyy"));


                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Запись успешно добавлена");
                Clear();

                LoadProjectsTable();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            //UPDAte

            if (canBeUpdated)
            {

                try
                {
                    OleDbConnection conn = new OleDbConnection();
                    conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\22119\source\repos\HRMS_final\HRMS_final\HR_management_final.accdb";
                    conn.Open();

                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "UPDATE [projects] SET [projects].[project_name]=@name, [projects].[description]=@description, [projects].[deadline]=@deadline, [projects].[completion_time]=@completion_time WHERE [projects].[id]=@id";

                    
                    cmd.Parameters.AddWithValue("@name", this.name.Text);
                    cmd.Parameters.AddWithValue("@description", this.description.Text);
                    cmd.Parameters.AddWithValue("@deadline", this.deadline.Value.ToString("dd.MM.yyyy"));
                    cmd.Parameters.AddWithValue("@completion_time", DateTime.Today.ToString("dd.MM.yyyy"));
                    cmd.Parameters.AddWithValue("@id", selectedId);

                    cmd.ExecuteNonQuery();
                    conn.Close();
                    LoadProjectsTable();
                    canBeUpdated = false;

                    MessageBox.Show("Запись успешно обновлена!");
                    Clear();
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } else
            {
                MessageBox.Show("Сначала необходимо выбрать ячейку!");
            }
        }

        private void RESET_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            this.name.Text = "";
            this.description.Text = "";
            this.deadline.Value = DateTime.Today;
            canBeUpdated = false;
            selectedId = -1;
        }
    }
}
