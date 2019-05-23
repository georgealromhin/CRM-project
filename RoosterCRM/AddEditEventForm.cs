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
    public partial class AddEditEventForm : Form
    {
        DatabaseEntities db;
        public AddEditEventForm(@event obj)
        {
            InitializeComponent();
            db = new DatabaseEntities();
            if (obj == null)
            {
                eventsBindingSource.DataSource = new @event();
                db.events.Add(eventsBindingSource.Current as @event);
                this.Text = "Add New Event";
            }
            else
            {
                eventsBindingSource.DataSource = obj;
                db.events.Attach(eventsBindingSource.Current as @event);
                this.Text = "Edit Event";
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddEditEventForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet2.events' table. You can move, or remove it, as needed.
            this.eventsTableAdapter.Fill(this.databaseDataSet2.events);

        }

        private void AddEditEventForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(topicTxt.Text))
                {
                    MessageBox.Show("Please, Enter Your Event Topic!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    topicTxt.Focus();
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
