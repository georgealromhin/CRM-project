namespace RoosterCRM
{
    partial class AddEditTaskForm
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
            this.statusCB = new System.Windows.Forms.ComboBox();
            this.tasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSetTasks = new RoosterCRM.DatabaseDataSetTasks();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.taskTxt = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.referTypeCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.referNameTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.priorityTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.desTxt = new System.Windows.Forms.TextBox();
            this.tasksTableAdapter = new RoosterCRM.DatabaseDataSetTasksTableAdapters.tasksTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // statusCB
            // 
            this.statusCB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tasksBindingSource, "status", true));
            this.statusCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusCB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusCB.FormattingEnabled = true;
            this.statusCB.Items.AddRange(new object[] {
            "",
            "Open",
            "Done",
            "Not Done",
            "Other"});
            this.statusCB.Location = new System.Drawing.Point(134, 45);
            this.statusCB.Name = "statusCB";
            this.statusCB.Size = new System.Drawing.Size(200, 27);
            this.statusCB.TabIndex = 1;
            // 
            // tasksBindingSource
            // 
            this.tasksBindingSource.DataMember = "tasks";
            this.tasksBindingSource.DataSource = this.databaseDataSetTasks;
            // 
            // databaseDataSetTasks
            // 
            this.databaseDataSetTasks.DataSetName = "DatabaseDataSetTasks";
            this.databaseDataSetTasks.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 74;
            this.label3.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 19);
            this.label1.TabIndex = 73;
            this.label1.Text = "Task";
            // 
            // taskTxt
            // 
            this.taskTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tasksBindingSource, "task_name", true));
            this.taskTxt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskTxt.Location = new System.Drawing.Point(134, 12);
            this.taskTxt.Name = "taskTxt";
            this.taskTxt.Size = new System.Drawing.Size(200, 27);
            this.taskTxt.TabIndex = 0;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(128, 299);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(100, 34);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.Text = "CANCEL";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(234, 299);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(100, 34);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "&SAVE";
            this.saveBtn.UseVisualStyleBackColor = false;
            // 
            // referTypeCB
            // 
            this.referTypeCB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tasksBindingSource, "refer_type", true));
            this.referTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.referTypeCB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.referTypeCB.FormattingEnabled = true;
            this.referTypeCB.Items.AddRange(new object[] {
            "",
            "Account",
            "Contact",
            "Lead"});
            this.referTypeCB.Location = new System.Drawing.Point(134, 78);
            this.referTypeCB.Name = "referTypeCB";
            this.referTypeCB.Size = new System.Drawing.Size(200, 27);
            this.referTypeCB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 81;
            this.label2.Text = "Refer To Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 19);
            this.label4.TabIndex = 84;
            this.label4.Text = "Refer To Name";
            // 
            // referNameTxt
            // 
            this.referNameTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tasksBindingSource, "refer_name", true));
            this.referNameTxt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.referNameTxt.Location = new System.Drawing.Point(134, 111);
            this.referNameTxt.Name = "referNameTxt";
            this.referNameTxt.Size = new System.Drawing.Size(200, 27);
            this.referNameTxt.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 19);
            this.label5.TabIndex = 86;
            this.label5.Text = "Priority";
            // 
            // priorityTxt
            // 
            this.priorityTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tasksBindingSource, "priority", true));
            this.priorityTxt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priorityTxt.Location = new System.Drawing.Point(134, 144);
            this.priorityTxt.Name = "priorityTxt";
            this.priorityTxt.Size = new System.Drawing.Size(200, 27);
            this.priorityTxt.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 19);
            this.label6.TabIndex = 88;
            this.label6.Text = "Description";
            // 
            // desTxt
            // 
            this.desTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tasksBindingSource, "des", true));
            this.desTxt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desTxt.Location = new System.Drawing.Point(134, 177);
            this.desTxt.Multiline = true;
            this.desTxt.Name = "desTxt";
            this.desTxt.Size = new System.Drawing.Size(200, 93);
            this.desTxt.TabIndex = 5;
            // 
            // tasksTableAdapter
            // 
            this.tasksTableAdapter.ClearBeforeFill = true;
            // 
            // AddEditTaskForm
            // 
            this.AcceptButton = this.saveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(347, 345);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.desTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.priorityTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.referNameTxt);
            this.Controls.Add(this.referTypeCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.statusCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.taskTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditTaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddEditTaskForm_FormClosing);
            this.Load += new System.EventHandler(this.AddEditTaskForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetTasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox statusCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox taskTxt;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.ComboBox referTypeCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox referNameTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox priorityTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox desTxt;
        private DatabaseDataSetTasks databaseDataSetTasks;
        private System.Windows.Forms.BindingSource tasksBindingSource;
        private DatabaseDataSetTasksTableAdapters.tasksTableAdapter tasksTableAdapter;
    }
}