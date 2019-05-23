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
    public partial class AddEditContactForm : Form
    {
        DatabaseEntities db;
        public AddEditContactForm(contact obj)
        {
            InitializeComponent();
            db = new DatabaseEntities();
            if (obj == null)
            {
                contactsBindingSource.DataSource = new contact();
                db.contacts.Add(contactsBindingSource.Current as contact);
                this.Text = "Add New Contact";
            }
            else
            {
                contactsBindingSource.DataSource = obj;
                db.contacts.Attach(contactsBindingSource.Current as contact);
                this.Text = "Edit Contact";
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddEditContactForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.contacts' table. You can move, or remove it, as needed.
            this.contactsTableAdapter.Fill(this.databaseDataSet.contacts);

        }

        private void AddEditContactForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(fnameTxt.Text))
                {
                    MessageBox.Show("Please, Enter Your Contact Name!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fnameTxt.Focus();
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
