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
    public partial class Project : Form
    {

        public int selectedId = -1;
        public bool canBeUpdated = false;
        public Project()
        {
            InitializeComponent();
        }

        private void Project_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hR_management_finalDataSet.position". При необходимости она может быть перемещена или удалена.
            this.positionTableAdapter.Fill(this.hR_management_finalDataSet.position);

            this.project_name.Text = HRManagerIntefaceProject.project_name;

            loadTable();   
        }

        private void loadEmployee()
        {
            try
            {
                OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\22119\source\repos\HRMS_final\HRMS_final\HR_management_final.accdb";
                conn.Open();

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT [employee].[first_name], [employee].[id] FROM [employee] WHERE [employee].[position_id]=@position";

                cmd.Parameters.AddWithValue("@position", int.Parse(this.position.SelectedValue.ToString()));

                cmd.Parameters.AddWithValue("@id", HRManagerIntefaceProject.project_id);

                DataTable dt = new DataTable();

                OleDbDataReader reader = cmd.ExecuteReader();

                dt.Load(reader);

                this.employee.DataSource = dt;
                this.employee.ValueMember = "id";
                this.employee.DisplayMember = "first_name";

                this.employee.Update();
                this.employee.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadTable()
        {
            try
            {

                OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\22119\source\repos\HRMS_final\HRMS_final\HR_management_final.accdb";
                conn.Open();

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT [tasks].[id], [tasks].[task_name], [tasks].[description], [tasks].[deadline], [tasks].[completion_time], [employee].[first_name], [employee].[last_name], [position].[position_name]" +
                    "FROM [projects] INNER JOIN (([tasks] INNER JOIN [employee] ON [employee].[id]=[tasks].[employee_id]) INNER JOIN [position] ON [tasks].[position_id]=[position].[id]) ON [tasks].[project_id]=[projects].[id] " +
                    "WHERE [projects].[id]=@id";

                cmd.Parameters.AddWithValue("@id", HRManagerIntefaceProject.project_id);

                DataTable dt = new DataTable();

                OleDbDataReader reader = cmd.ExecuteReader();

                dt.Load(reader);

                projectDataGridView.DataSource = dt;
                projectDataGridView.ReadOnly = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Add
            if (!isValid())
            {
                MessageBox.Show("Не все поля заполнены или заполнены некорректно");
            } else
            {
                try
                {
                    OleDbConnection idConn = new OleDbConnection();
                    idConn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\22119\source\repos\HRMS_final\HRMS_final\HR_management_final.accdb";
                    OleDbCommand idCom = new OleDbCommand();

                    idCom.Connection = idConn;
                    idConn.Open();
                    idCom.CommandText = "SELECT id FROM tasks";
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
                    cmd.CommandText = "INSERT INTO [tasks] values (@id, @name, @description, @deadline, @completion_time, @employee_id, @position_id, @project_id)";
                    if (id.Count == 0) {
                        cmd.Parameters.AddWithValue("@id", 0);
                    } else
                    {
                        cmd.Parameters.AddWithValue("@id", Math.Max(id.Max(), 0) + 1);
                    }
                    cmd.Parameters.AddWithValue("@name", this.name.Text);
                    cmd.Parameters.AddWithValue("@description", this.description.Text);
                    cmd.Parameters.AddWithValue("@deadline", this.deadline.Value.ToString("dd.MM.yyyy"));
                    cmd.Parameters.AddWithValue("@completion_time", DateTime.Today.ToString("dd.MM.yyyy"));
                    cmd.Parameters.AddWithValue("@position_id", int.Parse(this.position.SelectedValue.ToString()));
                    cmd.Parameters.AddWithValue("@employee_id", int.Parse(this.employee.SelectedValue.ToString()));
                    cmd.Parameters.AddWithValue("@project_id", HRManagerIntefaceProject.project_id);

                    cmd.ExecuteNonQuery();
                    conn.Close();
                    loadTable();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public bool isValid()
        {
            if (this.name.Text == "" && this.description.Text == "" && this.employee.Text == "" && this.position.Text == "")
            {
                return false;
            } else
            {
                return true;
            }
        }

        private void position_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadEmployee();
        }

        private void deleteClick(object sender, EventArgs e)
        {
            try
            {
                if (canBeUpdated)
                {
                    OleDbConnection conn = new OleDbConnection();
                    conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\22119\source\repos\HRMS_final\HRMS_final\HR_management_final.accdb";
                    conn.Open();

                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "DELETE * FROM [tasks] WHERE [tasks].[id]=@id";

                    cmd.Parameters.AddWithValue("@id", selectedId);

                    cmd.ExecuteNonQuery();

                    conn.Close();

                    canBeUpdated = false;
                    selectedId = -1;

                    loadTable();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Необходимо выбрать строку, которую желаете удалить");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void projectTasksCellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


                this.name.Text = projectDataGridView[1, e.RowIndex].Value.ToString();
                this.description.Text = projectDataGridView[2, e.RowIndex].Value.ToString();
                this.position.SelectedText = projectDataGridView[7, e.RowIndex].Value.ToString();
                this.employee.SelectedText = projectDataGridView[5, e.RowIndex].Value.ToString();

                selectedId = int.Parse(projectDataGridView[0, e.RowIndex].Value.ToString());
                canBeUpdated = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clear(object sender, EventArgs e)
        {
            this.name.Text = "";
            this.description.Text = "";
            this.position.Text = "";
            this.employee.Text = "";
            selectedId = -1;
            canBeUpdated = false;
        }

        private void Clear()
        {
            this.name.Text = "";
            this.description.Text = "";
            this.position.Text = "";
            this.employee.Text = "";
            selectedId = -1;
            canBeUpdated = false;
        }
    }
}
