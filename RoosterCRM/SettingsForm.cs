using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoosterCRM
{
    public partial class SettingsForm : Form
    {
        DatabaseEntities db;
        public SettingsForm()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.logoicon32x32;
            db = new DatabaseEntities();
            try
            {
                company comp = db.companies.Single(x => x.company_id == 1);
                compNameTxt.Text = comp.company_name;
                logoImg.Image = ConverBinaryToImage(comp.data);
            }
            catch { }
        }


        string filename;
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        private Image ConverBinaryToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (DatabaseEntities db = new DatabaseEntities())
                {
                    company comp = new company()
                    {
                        company_id = 1,
                        company_name = compNameTxt.Text,
                        file_name = filename,
                        data = ConvertImageToBinary(logoImg.Image)
                    };
                    int numRows =  db.companies.Count();
                    if (numRows > 0)
                    {
                        //db.companies.Attach(comp); Not Working for some reason
                        db.Entry(comp).State = EntityState.Modified;
                        db.SaveChanges();
                        Application.Restart();
                    }
                    else
                    {
                        db.companies.Add(comp);
                        db.SaveChanges();
                    }
   
                   // MessageBox.Show("Saved Succefully");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSetCompany.company' table. You can move, or remove it, as needed.
            this.companyTableAdapter.Fill(this.databaseDataSetCompany.company);

        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        filename = ofd.FileName;
                        imgPathLabel.Text = filename;
                        logoImg.Image = Image.FromFile(filename);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AboutBox1 abox = new AboutBox1();
            abox.ShowDialog();
        }
    }
}
