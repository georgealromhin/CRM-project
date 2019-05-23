using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoosterCRM
{
    public partial class AddEditTaskForm : Form
    {
        DatabaseEntities db;
        public AddEditTaskForm(task obj)
        {
            InitializeComponent();
            db = new DatabaseEntities();
            if (obj == null)
            {
                tasksBindingSource.DataSource = new task();
                db.tasks.Add(tasksBindingSource.Current as task);
                this.Text = "Add New Task";
            }
            else
            {
                tasksBindingSource.DataSource = obj;
                db.tasks.Attach(tasksBindingSource.Current as task);
                this.Text = "Edit Task";
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddEditTaskForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSetTasks.tasks' table. You can move, or remove it, as needed.
            this.tasksTableAdapter.Fill(this.databaseDataSetTasks.tasks);

        }

        private void AddEditTaskForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(taskTxt.Text))
                {
                    MessageBox.Show("Please, Enter Your Task!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    taskTxt.Focus();
                    e.Cancel = true;
                    return;
                }
                db.SaveChanges();
                e.Cancel = false;
            }
            e.Cancel = false;
        }
    }
}
