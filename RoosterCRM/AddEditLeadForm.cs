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
    public partial class AddEditLeadForm : Form
    {
        DatabaseEntities db;
        public AddEditLeadForm(lead obj)
        {
            InitializeComponent();
            db = new DatabaseEntities();
            if (obj == null)
            {
                leadsBindingSource.DataSource = new lead();
                db.leads.Add(leadsBindingSource.Current as lead);
                this.Text = "Add New Lead";
            }
            else
            {
                leadsBindingSource.DataSource = obj;
                db.leads.Attach(leadsBindingSource.Current as lead);
                this.Text = "Edit Lead";
            }
        }

        private void AddEditLeadForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet1.leads' table. You can move, or remove it, as needed.
            this.leadsTableAdapter.Fill(this.databaseDataSet1.leads);

        }
        // number of employees textbox takes only numbers
        private void numEmpTxt_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(numEmpTxt.Text, "[^0-9]"))
            {
                numEmpTxt.Text = "0";
            }
        }

        private void AddEditLeadForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(fnameTxt.Text))
                {
                    MessageBox.Show("Please, Enter Your Lead Name!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fnameTxt.Focus();
                    e.Cancel = true;
                    return;
                }
                db.SaveChanges();
                e.Cancel = false;
            }
            e.Cancel = false;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
