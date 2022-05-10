namespace HRMS_final
{
    partial class HRManagerIntefaceProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HRManagerIntefaceProject));
            this.panel4 = new System.Windows.Forms.Panel();
            this.description = new System.Windows.Forms.RichTextBox();
            this.deadline = new System.Windows.Forms.DateTimePicker();
            this.name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.RESET = new System.Windows.Forms.Button();
            this.DELETE = new System.Windows.Forms.Button();
            this.UPDATE = new System.Windows.Forms.Button();
            this.INSERT = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.projectsTable = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.description);
            this.panel4.Controls.Add(this.deadline);
            this.panel4.Controls.Add(this.name);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 35);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(642, 240);
            this.panel4.TabIndex = 3;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(134, 71);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(475, 142);
            this.description.TabIndex = 3;
            this.description.Text = "";
            // 
            // deadline
            // 
            this.deadline.Location = new System.Drawing.Point(419, 26);
            this.deadline.Name = "deadline";
            this.deadline.Size = new System.Drawing.Size(190, 20);
            this.deadline.TabIndex = 2;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(134, 26);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(189, 20);
            this.name.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Deadline";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Project description";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 275);
            this.panel1.TabIndex = 3;
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
            this.panel3.Size = new System.Drawing.Size(158, 240);
            this.panel3.TabIndex = 2;
            // 
            // RESET
            // 
            this.RESET.Location = new System.Drawing.Point(28, 195);
            this.RESET.Name = "RESET";
            this.RESET.Size = new System.Drawing.Size(103, 39);
            this.RESET.TabIndex = 1;
            this.RESET.Text = "Очистить поля";
            this.RESET.UseVisualStyleBackColor = true;
            this.RESET.Click += new System.EventHandler(this.RESET_Click);
            // 
            // DELETE
            // 
            this.DELETE.Location = new System.Drawing.Point(28, 129);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(103, 39);
            this.DELETE.TabIndex = 1;
            this.DELETE.Text = "Удалить";
            this.DELETE.UseVisualStyleBackColor = true;
            // 
            // UPDATE
            // 
            this.UPDATE.Location = new System.Drawing.Point(28, 64);
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Size = new System.Drawing.Size(103, 39);
            this.UPDATE.TabIndex = 1;
            this.UPDATE.Text = "Обновить";
            this.UPDATE.UseVisualStyleBackColor = true;
            this.UPDATE.Click += new System.EventHandler(this.UPDATE_Click);
            // 
            // INSERT
            // 
            this.INSERT.Location = new System.Drawing.Point(28, 6);
            this.INSERT.Name = "INSERT";
            this.INSERT.Size = new System.Drawing.Size(103, 39);
            this.INSERT.TabIndex = 1;
            this.INSERT.Text = "Добавить";
            this.INSERT.UseVisualStyleBackColor = true;
            this.INSERT.Click += new System.EventHandler(this.INSERT_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.label5);
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
            this.button2.TabIndex = 4;
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
            this.button1.TabIndex = 3;
            this.button1.Text = "Сотрудники";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // projectsTable
            // 
            this.projectsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.projectsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectsTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.projectsTable.Location = new System.Drawing.Point(0, 275);
            this.projectsTable.Name = "projectsTable";
            this.projectsTable.Size = new System.Drawing.Size(800, 175);
            this.projectsTable.TabIndex = 2;
            this.projectsTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProjectsTableCellSelect);
            this.projectsTable.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProjectsTableCellClick);
            this.projectsTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProjectsTableCellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(464, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "*Нажмите один раз, чтобы выбрать, два раза - чтобы открыть окно управления задача" +
    "ми";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(365, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 30);
            this.label5.TabIndex = 5;
            this.label5.Text = "Проекты";
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.button3.Location = new System.Drawing.Point(710, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 33);
            this.button3.TabIndex = 6;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // HRManagerIntefaceProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.projectsTable);
            this.Name = "HRManagerIntefaceProject";
            this.Text = "HRManagerIntefaceProjects";
            this.Load += new System.EventHandler(this.HRManagerIntefaceProject_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button RESET;
        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.Button UPDATE;
        private System.Windows.Forms.Button INSERT;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView projectsTable;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker deadline;
        private System.Windows.Forms.RichTextBox description;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
    }
}