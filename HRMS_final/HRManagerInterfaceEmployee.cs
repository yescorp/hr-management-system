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
    public partial class HRManagerInterfaceEmployee : Form
    {
        private int updateId;
        private Dictionary<string, int> departments;
        private Dictionary<string, int> positions;
        private bool canBeUpdated = false;

        public HRManagerInterfaceEmployee()
        {
            InitializeComponent();
        }

        private void HRManagerInterface_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hR_management_finalDataSet.department". При необходимости она может быть перемещена или удалена.
            this.departmentTableAdapter.Fill(this.hR_management_finalDataSet.department);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hR_management_finalDataSet.position". При необходимости она может быть перемещена или удалена.
            this.positionTableAdapter.Fill(this.hR_management_finalDataSet.position);

            GetEmployeeTable();


            //add departments
            OleDbConnection departmentConn = new OleDbConnection();
            departmentConn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\22119\source\repos\HRMS_final\HRMS_final\HR_management_final.accdb";
            departmentConn.Open();

            OleDbCommand departmentCmd = new OleDbCommand();
            departmentCmd.Connection = departmentConn;
            departmentCmd.CommandText = "SELECT * FROM [department]";

            OleDbDataReader departmentReader = departmentCmd.ExecuteReader();

            departments = new Dictionary<string, int>();

            while (departmentReader.Read())
            {
                departments.Add(departmentReader.GetString(1), departmentReader.GetInt32(0));
            }

            departmentConn.Close();

            //add positions
            OleDbConnection positionConn = new OleDbConnection();
            positionConn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\22119\source\repos\HRMS_final\HRMS_final\HR_management_final.accdb";
            positionConn.Open();

            OleDbCommand positionCmd = new OleDbCommand();
            positionCmd.Connection = positionConn;
            positionCmd.CommandText = "SELECT * FROM [position]";

            OleDbDataReader positionReader = positionCmd.ExecuteReader();

            positions = new Dictionary<string, int>();

            while (positionReader.Read())
            {
                positions.Add(positionReader.GetString(1), positionReader.GetInt32(0));
            }

            positionConn.Close();
            clear();

        }

        private void GetEmployeeTable()
        {
            try
            {
                OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\22119\source\repos\HRMS_final\HRMS_final\HR_management_final.accdb";
                conn.Open();

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"SELECT [employee].[id], [employee].[first_name], [employee].[last_name], [employee].[age], [employee].[IIN], [position].[position_name], [department].[department_name] from (([employee] LEFT JOIN [position] ON [employee].[position_id]=[position].[id]) LEFT JOIN [department] ON [employee].[department_id]=[department].[id])";

                OleDbDataAdapter da = new OleDbDataAdapter(cmd.CommandText, conn);

                DataTable dt = new DataTable();

                //OleDbDataReader reader = cmd.ExecuteReader();

                //dt.Load(reader);

                

                da.Fill(dt);

                employeeTable.DataSource = dt;
                employeeTable.AutoResizeColumns();
                employeeTable.ReadOnly = true;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //INSERT
            try
            {

                if (!isValid())
                {
                    MessageBox.Show("Некоторые поля не заполнены или заполнены неправильно");
                    return;
                }

                OleDbConnection idConn = new OleDbConnection();
                idConn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\22119\source\repos\HRMS_final\HRMS_final\HR_management_final.accdb";
                OleDbCommand idCom = new OleDbCommand();

                idCom.Connection = idConn;
                idConn.Open();
                idCom.CommandText = "SELECT id FROM employee";
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
                cmd.CommandText = "INSERT INTO employee values(@id, @name, @surname, @age, @iin, @department_id, @position_id);";

                cmd.Parameters.AddWithValue("@id", id.Max() + 1);
                cmd.Parameters.AddWithValue("@name", this.name.Text);
                cmd.Parameters.AddWithValue("@surname", this.surname.Text);
                cmd.Parameters.AddWithValue("@age", this.age.Text);
                cmd.Parameters.AddWithValue("@iin", this.iin.Text);
                cmd.Parameters.AddWithValue("@department_id", departments[this.department.Text]);
                cmd.Parameters.AddWithValue("@position_id", positions[this.position.Text]);

                cmd.ExecuteNonQuery();

                conn.Close();

                this.name.Text = "";
                this.surname.Text = "";
                this.age.Text = "";
                this.iin.Text = "";
                this.position.Text = "";
                this.department.Text = "";

                MessageBox.Show("Новая запись была успешно добавлена!");
                GetEmployeeTable();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form next = new HRManagerIntefaceProject();
            this.Hide();
            next.ShowDialog();
            this.Close();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        public bool isValid()
        {
            if (this.name != null && this.name.Text != "" && this.surname.Text != "" && this.surname != null && this.age.Text != "" && this.age != null && this.iin.Text != "" && this.iin != null && this.position.Text != "" && this.department.Text != "")
            {
                return true;
            } else
            {
                return int.TryParse(this.age.Text, out int age);
            }
        }

        public void clear()
        {
            this.name.Text = "";
            this.surname.Text = "";
            this.age.Text = "";
            this.iin.Text = "";
            this.position.Text = "";
            this.department.Text = "";
            canBeUpdated = false;
            updateId = -1;
        }

        private void employeeTableCellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                updateId = int.Parse(employeeTable[0, e.RowIndex].Value.ToString());
                this.name.Text = employeeTable[1, e.RowIndex].Value.ToString();
                this.surname.Text = employeeTable[2, e.RowIndex].Value.ToString();
                this.age.Text = employeeTable[3, e.RowIndex].Value.ToString();
                this.iin.Text = employeeTable[4, e.RowIndex].Value.ToString();
                this.position.Text = employeeTable[5, e.RowIndex].Value.ToString();
                this.department.Text = employeeTable[6, e.RowIndex].Value.ToString();

                canBeUpdated = true;
            }
            catch (Exception ex)
            {

            }
        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            //update

            if (!canBeUpdated)
            {
                MessageBox.Show("Необходимо выбрать строку из таблицы, чтобы обновить соответствущую запись");
                return;
            } else
            {
                if (!isValid())
                {
                    MessageBox.Show("Некоторые поля не заполнены или заполнены неправильно");
                    return;
                }
                try
                {
                    OleDbConnection conn = new OleDbConnection();
                    conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\22119\source\repos\HRMS_final\HRMS_final\HR_management_final.accdb";
                    conn.Open();

                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "UPDATE [employee] SET [employee].[first_name]=@name, [employee].[last_name]=@surname, [employee].[age]=@age, [employee].[iin]=@iin, [employee].[position_id]=@position, [employee].[department_id]=@department WHERE [employee].[id]=@id";

                    cmd.Parameters.AddWithValue("@name", this.name.Text);
                    cmd.Parameters.AddWithValue("@surname", this.surname.Text);
                    cmd.Parameters.AddWithValue("@age", this.age.Text);
                    cmd.Parameters.AddWithValue("@iin", this.iin.Text);
                    cmd.Parameters.AddWithValue("@position_id", positions[this.position.Text]);
                    cmd.Parameters.AddWithValue("@department_id", departments[this.department.Text]);
                    cmd.Parameters.AddWithValue("@id", updateId);

                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Запись успешно обновлена!");
                    clear();
                    updateId = -1;
                    canBeUpdated = false;

                    GetEmployeeTable();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Проверьте правильно ли заполнены поля.");
                }
            }
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            //delete

            if (!canBeUpdated)
            {
                MessageBox.Show("Необходимо выбрать строку, которую вы желаете удалить");
            } else
            {
                try
                {
                    OleDbConnection conn = new OleDbConnection();
                    conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\22119\source\repos\HRMS_final\HRMS_final\HR_management_final.accdb";
                    conn.Open();

                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "DELETE * FROM employee WHERE [employee].[id]=@id";
                    cmd.Parameters.AddWithValue("@id", updateId);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Запись была успешно удалена из таблицы");
                    GetEmployeeTable();
                    clear();

                } catch(Exception ex)
                {
                    MessageBox.Show("Что-то пошло не так");
                }
            }
        }
    }
}
