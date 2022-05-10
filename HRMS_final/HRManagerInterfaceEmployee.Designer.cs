namespace HRMS_final
{
    partial class HRManagerInterfaceEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HRManagerInterfaceEmployee));
            this.employeeTable = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.department = new System.Windows.Forms.ComboBox();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hRmanagementfinalDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hR_management_finalDataSet = new HRMS_final.HR_management_finalDataSet();
            this.position = new System.Windows.Forms.ComboBox();
            this.positionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iin = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.surname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.RESET = new System.Windows.Forms.Button();
            this.DELETE = new System.Windows.Forms.Button();
            this.UPDATE = new System.Windows.Forms.Button();
            this.INSERT = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.positionTableAdapter = new HRMS_final.HR_management_finalDataSetTableAdapters.positionTableAdapter();
            this.departmentTableAdapter = new HRMS_final.HR_management_finalDataSetTableAdapters.departmentTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRmanagementfinalDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hR_management_finalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeTable
            // 
            this.employeeTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employeeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.employeeTable.Location = new System.Drawing.Point(0, 276);
            this.employeeTable.Name = "employeeTable";
            this.employeeTable.Size = new System.Drawing.Size(800, 174);
            this.employeeTable.TabIndex = 0;
            this.employeeTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeTableCellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 276);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.department);
            this.panel4.Controls.Add(this.position);
            this.panel4.Controls.Add(this.iin);
            this.panel4.Controls.Add(this.age);
            this.panel4.Controls.Add(this.name);
            this.panel4.Controls.Add(this.surname);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 35);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(642, 241);
            this.panel4.TabIndex = 3;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label7.Location = new System.Drawing.Point(0, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(394, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "*Нажмите на любую строку таблицы, чтобы заполнить поля этими данными";
            // 
            // department
            // 
            this.department.DataSource = this.departmentBindingSource;
            this.department.DisplayMember = "department_name";
            this.department.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.department.FormattingEnabled = true;
            this.department.Location = new System.Drawing.Point(442, 131);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(166, 21);
            this.department.TabIndex = 3;
            this.department.ValueMember = "department_name";
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "department";
            this.departmentBindingSource.DataSource = this.hRmanagementfinalDataSetBindingSource;
            // 
            // hRmanagementfinalDataSetBindingSource
            // 
            this.hRmanagementfinalDataSetBindingSource.DataSource = this.hR_management_finalDataSet;
            this.hRmanagementfinalDataSetBindingSource.Position = 0;
            // 
            // hR_management_finalDataSet
            // 
            this.hR_management_finalDataSet.DataSetName = "HR_management_finalDataSet";
            this.hR_management_finalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // position
            // 
            this.position.DataSource = this.positionBindingSource;
            this.position.DisplayMember = "position_name";
            this.position.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.position.FormattingEnabled = true;
            this.position.Location = new System.Drawing.Point(442, 30);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(166, 21);
            this.position.TabIndex = 2;
            this.position.ValueMember = "position_name";
            // 
            // positionBindingSource
            // 
            this.positionBindingSource.DataMember = "position";
            this.positionBindingSource.DataSource = this.hR_management_finalDataSet;
            // 
            // iin
            // 
            this.iin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.iin.Location = new System.Drawing.Point(119, 176);
            this.iin.Name = "iin";
            this.iin.Size = new System.Drawing.Size(154, 26);
            this.iin.TabIndex = 1;
            // 
            // age
            // 
            this.age.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.age.Location = new System.Drawing.Point(119, 126);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(154, 26);
            this.age.TabIndex = 1;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.name.Location = new System.Drawing.Point(119, 26);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(154, 26);
            this.name.TabIndex = 1;
            // 
            // surname
            // 
            this.surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.surname.Location = new System.Drawing.Point(119, 76);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(154, 26);
            this.surname.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.Location = new System.Drawing.Point(315, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Департамент";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(315, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Должность";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(25, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "ИИН";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(25, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Возраст";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(25, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.RESET);
            this.panel3.Controls.Add(this.DELETE);
            this.panel3.Controls.Add(this.UPDATE);
            this.panel3.Controls.Add(this.INSERT);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(642, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(158, 241);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // RESET
            // 
            this.RESET.Location = new System.Drawing.Point(28, 195);
            this.RESET.Name = "RESET";
            this.RESET.Size = new System.Drawing.Size(103, 39);
            this.RESET.TabIndex = 1;
            this.RESET.Text = "Очистить поля";
            this.RESET.UseVisualStyleBackColor = true;
            this.RESET.Click += new System.EventHandler(this.button4_Click);
            // 
            // DELETE
            // 
            this.DELETE.Location = new System.Drawing.Point(28, 129);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(103, 39);
            this.DELETE.TabIndex = 1;
            this.DELETE.Text = "Удалить запись";
            this.DELETE.UseVisualStyleBackColor = true;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // UPDATE
            // 
            this.UPDATE.Location = new System.Drawing.Point(28, 64);
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Size = new System.Drawing.Size(103, 39);
            this.UPDATE.TabIndex = 1;
            this.UPDATE.Text = "Обновить запись";
            this.UPDATE.UseVisualStyleBackColor = true;
            this.UPDATE.Click += new System.EventHandler(this.UPDATE_Click);
            // 
            // INSERT
            // 
            this.INSERT.Location = new System.Drawing.Point(28, 6);
            this.INSERT.Name = "INSERT";
            this.INSERT.Size = new System.Drawing.Size(103, 39);
            this.INSERT.TabIndex = 1;
            this.INSERT.Text = "Добавить запись";
            this.INSERT.UseVisualStyleBackColor = true;
            this.INSERT.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 35);
            this.panel2.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.Location = new System.Drawing.Point(75, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "Проекты";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сотрудники";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // positionTableAdapter
            // 
            this.positionTableAdapter.ClearBeforeFill = true;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(352, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 30);
            this.label8.TabIndex = 6;
            this.label8.Text = "Сотрудники";
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Location = new System.Drawing.Point(710, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 33);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // HRManagerInterfaceEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.employeeTable);
            this.Name = "HRManagerInterfaceEmployee";
            this.Text = "HRManagerInterfaceEmployee";
            this.Load += new System.EventHandler(this.HRManagerInterface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRmanagementfinalDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hR_management_finalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView employeeTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button RESET;
        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.Button UPDATE;
        private System.Windows.Forms.Button INSERT;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox position;
        private System.Windows.Forms.ComboBox department;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox iin;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.TextBox name;
        private HR_management_finalDataSet hR_management_finalDataSet;
        private System.Windows.Forms.BindingSource positionBindingSource;
        private HR_management_finalDataSetTableAdapters.positionTableAdapter positionTableAdapter;
        private System.Windows.Forms.BindingSource hRmanagementfinalDataSetBindingSource;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private HR_management_finalDataSetTableAdapters.departmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
    }
}