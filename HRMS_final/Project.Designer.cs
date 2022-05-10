namespace HRMS_final
{
    partial class Project
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
            this.projectDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deadline = new System.Windows.Forms.DateTimePicker();
            this.description = new System.Windows.Forms.RichTextBox();
            this.employee = new System.Windows.Forms.ComboBox();
            this.position = new System.Windows.Forms.ComboBox();
            this.positionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hR_management_finalDataSet = new HRMS_final.HR_management_finalDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.positionTableAdapter = new HRMS_final.HR_management_finalDataSetTableAdapters.positionTableAdapter();
            this.employeeDataSet = new HRMS_final.HR_management_finalDataSet();
            this.project_name = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hR_management_finalDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // projectDataGridView
            // 
            this.projectDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.projectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.projectDataGridView.Location = new System.Drawing.Point(0, 234);
            this.projectDataGridView.Name = "projectDataGridView";
            this.projectDataGridView.Size = new System.Drawing.Size(800, 216);
            this.projectDataGridView.TabIndex = 0;
            this.projectDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.projectTasksCellClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.deadline);
            this.panel1.Controls.Add(this.description);
            this.panel1.Controls.Add(this.employee);
            this.panel1.Controls.Add(this.position);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 234);
            this.panel1.TabIndex = 1;
            // 
            // deadline
            // 
            this.deadline.Location = new System.Drawing.Point(409, 155);
            this.deadline.Name = "deadline";
            this.deadline.Size = new System.Drawing.Size(200, 20);
            this.deadline.TabIndex = 7;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(115, 107);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(183, 99);
            this.description.TabIndex = 6;
            this.description.Text = "";
            // 
            // employee
            // 
            this.employee.FormattingEnabled = true;
            this.employee.Location = new System.Drawing.Point(463, 102);
            this.employee.Name = "employee";
            this.employee.Size = new System.Drawing.Size(146, 21);
            this.employee.TabIndex = 5;
            // 
            // position
            // 
            this.position.DataSource = this.positionBindingSource;
            this.position.DisplayMember = "position_name";
            this.position.FormattingEnabled = true;
            this.position.Location = new System.Drawing.Point(463, 57);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(146, 21);
            this.position.TabIndex = 4;
            this.position.ValueMember = "id";
            this.position.SelectedIndexChanged += new System.EventHandler(this.position_SelectedIndexChanged);
            // 
            // positionBindingSource
            // 
            this.positionBindingSource.DataMember = "position";
            this.positionBindingSource.DataSource = this.hR_management_finalDataSet;
            // 
            // hR_management_finalDataSet
            // 
            this.hR_management_finalDataSet.DataSetName = "HR_management_finalDataSet";
            this.hR_management_finalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.delete);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(633, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(165, 232);
            this.panel2.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(42, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 36);
            this.button3.TabIndex = 2;
            this.button3.Text = "Очистить поля";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.clear);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(42, 93);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(90, 36);
            this.delete.TabIndex = 2;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.deleteClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(115, 61);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(126, 20);
            this.name.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Работник";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Должность работника";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Крайний срок";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Описание задачи";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-3, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(278, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "*Нажмите на строку, чтобы выбрать ее для удаления";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название задачи";
            // 
            // positionTableAdapter
            // 
            this.positionTableAdapter.ClearBeforeFill = true;
            // 
            // employeeDataSet
            // 
            this.employeeDataSet.DataSetName = "HR_management_finalDataSet";
            this.employeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // project_name
            // 
            this.project_name.AutoSize = true;
            this.project_name.Font = new System.Drawing.Font("Mongolian Baiti", 16.25F);
            this.project_name.Location = new System.Drawing.Point(255, 9);
            this.project_name.Name = "project_name";
            this.project_name.Size = new System.Drawing.Size(126, 24);
            this.project_name.TabIndex = 8;
            this.project_name.Text = "Project name";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.project_name);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(633, 41);
            this.panel3.TabIndex = 9;
            // 
            // Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.projectDataGridView);
            this.Name = "Project";
            this.Text = "Project";
            this.Load += new System.EventHandler(this.Project_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hR_management_finalDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView projectDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox position;
        private System.Windows.Forms.ComboBox employee;
        private System.Windows.Forms.RichTextBox description;
        private System.Windows.Forms.DateTimePicker deadline;
        private HR_management_finalDataSet hR_management_finalDataSet;
        private System.Windows.Forms.BindingSource positionBindingSource;
        private HR_management_finalDataSetTableAdapters.positionTableAdapter positionTableAdapter;
        private HR_management_finalDataSet employeeDataSet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label project_name;
        private System.Windows.Forms.Panel panel3;
    }
}