using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
namespace RoosterCRM
{
    public partial class MailForm : Form
    {
        public MailForm()
        {
            InitializeComponent();
        }
        OpenFileDialog odf;
        String fileName = "";
        private void MailForm_Load(object sender, EventArgs e)
        {
          

        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            try
            {
                odf = new OpenFileDialog();
                odf.Filter = "Images(.jpg,.png)|*.png;*.jpg;|Pdf Files|*.pdf";
                if (odf.ShowDialog() == DialogResult.OK)
                {
                    fileName = odf.FileName;
                    filenameLabel.Text = fileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Smpt Client Details
                //gmail >> smtp server : smtp.gmail.com, port : 587 , ssl required
                //yahoo >> smtp server : smtp.mail.yahoo.com, port : 587 , ssl required
                SmtpClient clientDetails = new SmtpClient();
                clientDetails.Port = 587;
                clientDetails.Host = "smtp.gmail.com";
                clientDetails.EnableSsl = checkBoxSSL.Checked;
                clientDetails.DeliveryMethod = SmtpDeliveryMethod.Network;
                clientDetails.UseDefaultCredentials = false;
                clientDetails.Credentials = new NetworkCredential(fromEmailTxt.Text.Trim(), fromPasswordTxt.Text.Trim());

                //Message Details
                MailMessage mailDetails = new MailMessage();
                mailDetails.From = new MailAddress(fromEmailTxt.Text.Trim());
                mailDetails.To.Add(ToEmailTxt.Text.Trim());
                //for multiple recipients
                //mailDetails.To.Add("another recipient email address");
                //for bcc
                //mailDetails.Bcc.Add("bcc email address")
                mailDetails.Subject = subjectTxt.Text.Trim();
                mailDetails.IsBodyHtml = checkBoxHTML.Checked;
                mailDetails.Body = messageTxt.Text.Trim();


                //file attachment
                if (fileName.Length > 0)
                {
                    Attachment attachment = new Attachment(fileName);
                    mailDetails.Attachments.Add(attachment);
                }

                clientDetails.Send(mailDetails);
                MessageBox.Show("Your mail has been sent.");
                fileName = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In order To be able to send mail from this form, you have to provide a gamil email andd password and disable security check in your gmail account," +
                " not the Best way to send Email butt it was added for practice, " +
                "and it is safe to send, we don't collect any information from this software," +
                " it was developed for educational porposes, thank you for using it :) ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
