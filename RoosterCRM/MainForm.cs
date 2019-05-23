using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using RoosterCRM.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using iTextSharp.text;
using iTextSharp.text.pdf;
using DGVPrinterHelper;
using System.IO;

/// <summary>
/// 
/// </summary>
namespace RoosterCRM
{
    public partial class MainForm : Form
    {
        DatabaseEntities db;
        // active panel 
        Panel ActivePanel = new Panel();

        public MainForm()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.logoicon32x32;
            db = new DatabaseEntities();
            contactsBindingSource.DataSource = db.contacts.ToList();
            leadsBindingSource.DataSource = db.leads.ToList();
            eventsBindingSource.DataSource = db.events.ToList();
            tasksBindingSource.DataSource = db.tasks.ToList();

            splitContainer10.SplitterWidth = 20;
            splitContainer11.SplitterWidth = 20;
            splitContainer4.SplitterWidth = 20;
            splitContainer5.SplitterWidth = 20;
            splitContainer6.SplitterWidth = 20;

            todaysEventsDVG.LostFocus += TodaysEventsDVG_LostFocus;

        }

        private void TodaysEventsDVG_LostFocus(object sender, EventArgs e)
        {
            todaysEventsDVG.ClearSelection();
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            if (sideMenuPanel.Width == 50)
            {
                sideMenuPanel.Width = 200;
            }
            else
            {
                sideMenuPanel.Width = 50;
            }
        }
        /// Change Color and Image of slide Panel Buttons
        private Button lastButton = null;
        private System.Drawing.Image lastImage = null;
        private void checkPanel(object sender, System.Drawing.Image imgB, System.Drawing.Image imgW)
        {
            // Change the background color and image of the button that was clicked
            Button current = (Button)sender;
            current.BackColor = Color.White;
            current.ForeColor = Color.FromArgb(26, 32, 40);
            current.Image = imgB;

            // Revert the background color and image of the previously-colored button, if any
            if (lastButton != null)
            {
                lastButton.BackColor = Color.FromArgb(26, 32, 40);
                lastButton.ForeColor = Color.White;
                lastButton.Image = lastImage;
            }
            // Update the previously-colored button
            lastButton = current;
            lastImage = imgW;
        }
        private System.Drawing.Image ConverBinaryToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return System.Drawing.Image.FromStream(ms);
            }
        }
        // Slide Menu Buttons click Event
        private void dashboardBtn_Click(object sender, EventArgs e){
            checkPanel(sender, Properties.Resources._dashboard_black, Properties.Resources._dashboard);
            ActivePanel.Visible = false;
            ActivePanel = dashboardPanel;
            ActivePanel.Visible = true;
        }
        private void contactsBtn_Click(object sender, EventArgs e){
            checkPanel(sender, Properties.Resources._contact_black, Properties.Resources._contacts);
            ActivePanel.Visible = false;
            ActivePanel = contactsPanel;
            ActivePanel.Visible = true;
        }
        private void leadsBtn_Click(object sender, EventArgs e){
            checkPanel(sender, Properties.Resources._leads_black, Properties.Resources._leads);
            ActivePanel.Visible = false;
            ActivePanel = leadsPanel;
            ActivePanel.Visible = true;
        }
        private void eventsBtn_Click(object sender, EventArgs e){
            checkPanel(sender, Properties.Resources._events_black, Properties.Resources._events);
            ActivePanel.Visible = false;
            ActivePanel = eventsPanel;
            ActivePanel.Visible = true;
        }
        private void tasksBtn_Click(object sender, EventArgs e){
            checkPanel(sender, Properties.Resources._tasks_black, Properties.Resources._tasks);
            ActivePanel.Visible = false;
            ActivePanel = tasksPanel;
            ActivePanel.Visible = true;
        }
        private void reportsBtn_Click(object sender, EventArgs e){
            checkPanel(sender, Properties.Resources._reports_black, Properties.Resources._reports);
            ActivePanel.Visible = false;
            ActivePanel = reportsPanel;
            ActivePanel.Visible = true;
        }

        // DASHBOARD DATA
        private void todaysEventDVG_data(){ string dateStr = DateTime.Now.ToShortDateString(); eventsBindingSource1.DataSource = db.events.Where(x => x.start_date.Contains(dateStr)).ToList(); }
        private void newLeadsDVG_data(){ leadsBindingSource1.DataSource = db.leads.Where(x => x.lead_status.Contains("New")).ToList(); }
        private void CountLeads(){ leadsCountLabel.Text = db.leads.Count().ToString(); }
        private void CountContacts(){ contactsCountLabel.Text = db.contacts.Count().ToString(); }
        private void CountEvents(){ eventsCountLabel.Text = db.events.Count().ToString(); }
        private void CountTasks(){ tasksCountLabel.Text = db.tasks.Count().ToString(); }

        private void companyImageAndName()
        {
            try
            {
                company comp = db.companies.Single(x => x.company_id == 1);
                companyNameLabel.Text = comp.company_name;
                imgLogo.Image = ConverBinaryToImage(comp.data);
            }
            catch { }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // dashboardBtn.PerformClick();   // dashboardPanel.BringToFront();
            ActivePanel = dashboardPanel;
            ActivePanel.Visible = true;
            loadCharts();
            todaysEventDVG_data();
            newLeadsDVG_data();
            CountLeads(); CountContacts(); CountEvents(); CountTasks();
            datetimeTimer.Start();
            companyImageAndName();

            // TODO: This line of code loads data into the 'databaseDataSet4.leads' table. You can move, or remove it, as needed.
            this.leadsTableAdapter1.Fill(this.databaseDataSet4.leads);
            // TODO: This line of code loads data into the 'databaseDataSet3.events' table. You can move, or remove it, as needed.
            this.eventsTableAdapter1.Fill(this.databaseDataSet3.events);
            // TODO: This line of code loads data into the 'databaseDataSetTasks.tasks' table. You can move, or remove it, as needed.
            this.tasksTableAdapter.Fill(this.databaseDataSetTasks.tasks);
            // TODO: This line of code loads data into the 'databaseDataSet2.events' table. You can move, or remove it, as needed.
            this.eventsTableAdapter.Fill(this.databaseDataSet2.events);
            // TODO: This line of code loads data into the 'databaseDataSet1.leads' table. You can move, or remove it, as needed.
            this.leadsTableAdapter.Fill(this.databaseDataSet1.leads);
            // TODO: This line of code loads data into the 'databaseDataSet.contacts' table. You can move, or remove it, as needed.
            this.contactsTableAdapter.Fill(this.databaseDataSet.contacts);
        }

        // Contacts Buttons Click Event
        private void addCntBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (AddEditContactForm aeContFrm = new AddEditContactForm(null))
                {
                    if (aeContFrm.ShowDialog() == DialogResult.OK)
                    {
                        contactsBindingSource.DataSource = db.contacts.ToList();
                        CountContacts();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        private void editCntBtn_Click(object sender, EventArgs e){
            try
            {
                if (contactsBindingSource.Current == null)
                    return;
                using (AddEditContactForm aeContFrm = new AddEditContactForm(contactsBindingSource.Current as contact))
                {
                    if (aeContFrm.ShowDialog() == DialogResult.OK)
                    {
                        contactsBindingSource.DataSource = db.contacts.ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        private void delCntBtn_Click(object sender, EventArgs e){ try{ if (contactsBindingSource.Current != null){ if (MessageBox.Show("Are you sure you want to delete this Contact?", "Delete Contact?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){ db.contacts.Remove(contactsBindingSource.Current as contact); contactsBindingSource.RemoveCurrent(); db.SaveChanges(); CountContacts(); } } }catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel,MessageBoxIcon.Error); } }
        private void viewCntBtn_Click(object sender, EventArgs e){ viewDataGridView(contactDVG); }
        private void excelCntBtn_Click(object sender, EventArgs e){ exportToExcel(contactDVG, "Contacts"); }
        private void pdfCntBtn_Click(object sender, EventArgs e){ exportToPdf(contactDVG, "Contacts"); }
        private void printCntTable_Click(object sender, EventArgs e){ printDataGrid(contactDVG, "Contact"); }
        private void contactDVG_SelectionChanged(object sender, EventArgs e){ if (contactDVG.SelectedRows.Count > 0){ delCntBtn.Enabled = true; editCntBtn.Enabled = true; }else{ delCntBtn.Enabled = false; editCntBtn.Enabled = false; } }
        //Leads Buttons Click Event
        private void addLeadBtn_Click(object sender, EventArgs e){ try{ using (AddEditLeadForm aeLeadFrm = new AddEditLeadForm(null)){ if (aeLeadFrm.ShowDialog() == DialogResult.OK){ leadsBindingSource.DataSource = db.leads.ToList(); } } leadChartsUpdate(); CountLeads(); newLeadsDVG_data(); } catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error); } }
        private void editLeadBtn_Click(object sender, EventArgs e){ try{ if (leadsBindingSource.Current == null){ return; } using (AddEditLeadForm aeLeadFrm = new AddEditLeadForm(leadsBindingSource.Current as lead)){ if (aeLeadFrm.ShowDialog() == DialogResult.OK){ leadsBindingSource.DataSource = db.leads.ToList(); } } leadChartsUpdate(); newLeadsDVG_data(); } catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error); } }
        private void delLeadBtn_Click(object sender, EventArgs e){ try{ if (leadsBindingSource.Current != null){ if (MessageBox.Show("Are you sure you want to delete this Lead?", "Delete Lead?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){ db.leads.Remove(leadsBindingSource.Current as lead); leadsBindingSource.RemoveCurrent(); db.SaveChanges(); CountLeads(); newLeadsDVG_data(); leadChartsUpdate(); } } } catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error); } }
        private void previewLeadBtn_Click(object sender, EventArgs e){ viewDataGridView(leadsDVG); }
        private void excelLeadBtn_Click(object sender, EventArgs e){ exportToExcel(leadsDVG, "Leads"); }
        private void pdfLeadBtn_Click(object sender, EventArgs e){ exportToPdf(leadsDVG, "Leads"); }
        private void printLeadBtn_Click(object sender, EventArgs e){ printDataGrid(leadsDVG, "Leads"); }
        private void leadsDVG_SelectionChanged(object sender, EventArgs e) { if (leadsDVG.SelectedRows.Count > 0) { delLeadBtn.Enabled = true; editLeadBtn.Enabled = true; } else { delLeadBtn.Enabled = false; editLeadBtn.Enabled = false; } }
        //Events Buttons Click Event
        private void addEventBtn_Click(object sender, EventArgs e){ try{ using (AddEditEventForm aeEventFrm = new AddEditEventForm(null)){ if (aeEventFrm.ShowDialog() == DialogResult.OK){ eventsBindingSource.DataSource = db.events.ToList(); } } eventChartsUpdate(); CountEvents(); todaysEventDVG_data();  } catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error); } }
        private void editEventBtn_Click(object sender, EventArgs e){ try{ if (eventsBindingSource.Current == null){ return; } using (AddEditEventForm aeEventFrm = new AddEditEventForm(eventsBindingSource.Current as @event)) { if (aeEventFrm.ShowDialog() == DialogResult.OK){ eventsBindingSource.DataSource = db.events.ToList(); } } eventChartsUpdate(); todaysEventDVG_data(); } catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error); } }
        private void delEventBtn_Click(object sender, EventArgs e){ try{ if (eventsBindingSource.Current != null){ if (MessageBox.Show("Are you sure you want to delete this Event?", "Delete Event?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){ db.events.Remove(eventsBindingSource.Current as @event); eventsBindingSource.RemoveCurrent(); db.SaveChanges(); CountEvents(); todaysEventDVG_data(); eventChartsUpdate(); } } }catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error); }}
        private void viewEventBtn_Click(object sender, EventArgs e){ viewDataGridView(eventsDVG); }
        private void excelEventBtn_Click(object sender, EventArgs e){ exportToExcel(eventsDVG, "Events"); }
        private void pdfEventBtn_Click(object sender, EventArgs e){ exportToPdf(eventsDVG, "Events"); }
        private void printEventBtn_Click(object sender, EventArgs e){ printDataGrid(eventsDVG, "Events"); }
        private void eventsDVG_SelectionChanged(object sender, EventArgs e) { if (eventsDVG.SelectedRows.Count > 0) { delEventBtn.Enabled = true; editEventBtn.Enabled = true; } else { delEventBtn.Enabled = false; editEventBtn.Enabled = false; } }
        //Tasks Buttons Click Event
        private void addTaskBtn_Click(object sender, EventArgs e){ try{ using (AddEditTaskForm aeTaskFrm = new AddEditTaskForm(null)){ if (aeTaskFrm.ShowDialog() == DialogResult.OK){ tasksBindingSource.DataSource = db.tasks.ToList(); CountTasks(); } } }catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error); } }
        private void editTaskBtn_Click(object sender, EventArgs e){ try{ if (tasksBindingSource.Current == null){ return; }using (AddEditTaskForm aeTaskFrm = new AddEditTaskForm(tasksBindingSource.Current as task)){ if (aeTaskFrm.ShowDialog() == DialogResult.OK){ tasksBindingSource.DataSource = db.tasks.ToList(); } } }catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error); } }
        private void delTaskBtn_Click(object sender, EventArgs e){ try{ if (tasksBindingSource.Current != null){ if (MessageBox.Show("Are you sure you want to delete this Task?", "Delete Task?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){ db.tasks.Remove(tasksBindingSource.Current as task); tasksBindingSource.RemoveCurrent(); db.SaveChanges(); CountTasks(); } } }catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error); } }
        private void viewTaskBtn_Click(object sender, EventArgs e){ viewDataGridView(tasksDVG); }
        private void excelTaskBtn_Click(object sender, EventArgs e){ exportToExcel(tasksDVG, "Tasks"); }
        private void pdfTaskBtn_Click(object sender, EventArgs e){ exportToPdf(tasksDVG, "Tasks"); }
        private void printTaskBtn_Click(object sender, EventArgs e){ printDataGrid(tasksDVG, "Tasks"); }
        private void tasksDVG_SelectionChanged(object sender, EventArgs e) { if (tasksDVG.SelectedRows.Count > 0) { delTaskBtn.Enabled = true; editTaskBtn.Enabled = true; } else { delTaskBtn.Enabled = false; editTaskBtn.Enabled = false; } }


        private void leadChartsUpdate()
        {
            //__________________update Lead status chart after insert and Update______________
            countNewLead.Value = db.leads.Where(o => o.lead_status == "New").Count();
            countAssignedLead.Value = db.leads.Where(o => o.lead_status == "Assigned").Count();
            countInProcessLead.Value = db.leads.Where(o => o.lead_status == "In Process").Count();
            countConvertedLead.Value = db.leads.Where(o => o.lead_status == "Converted").Count();
            countRecycledLead.Value = db.leads.Where(o => o.lead_status == "Recycled").Count();
            countOtherLead.Value = db.leads.Where(o => o.lead_status == "Other").Count();
            //__________________update Lead Source chart after insert and Update______________
            countCallLead.Value = db.leads.Where(o => o.lead_source == "Call").Count();
            countCustomerLead.Value = db.leads.Where(o => o.lead_source == "Customer").Count();
            countEmployeeLead.Value = db.leads.Where(o => o.lead_source == "Employee").Count();
            countPartnerLead.Value = db.leads.Where(o => o.lead_source == "Partner").Count();
            countConfrenceLead.Value = db.leads.Where(o => o.lead_source == "Confrence").Count();
            countTradeLead.Value = db.leads.Where(o => o.lead_source == "Trade").Count();
            countWebsiteLead.Value = db.leads.Where(o => o.lead_source == "Website").Count();
            countEmailLead.Value = db.leads.Where(o => o.lead_source == "Email").Count();
            countOtherSourceLead.Value = db.leads.Where(o => o.lead_source == "Other").Count();
            Properties.Settings.Default.Save(); //Save Changes
        }
        private void eventChartsUpdate()
        {
            countPlannedEvent.Value = db.events.Where(o => o.status == "Planned").Count();
            countHeldEvent.Value = db.events.Where(o => o.status == "Held").Count();
            countNotHeldEvent.Value = db.events.Where(o => o.status == "Not Held").Count();
            countOtherEvent.Value = db.events.Where(o => o.status == "Other").Count();

            countCallEvent.Value = db.events.Where(o => o.type == "Call").Count();
            countConferenceEvent.Value = db.events.Where(o => o.type == "Conference").Count();
            countMeetingEvent.Value = db.events.Where(o => o.type == "Meeting").Count();
            countSocialEvent.Value = db.events.Where(o => o.type == "Social").Count();
            countFundraisingEvent.Value = db.events.Where(o => o.type == "Fundraising").Count();
            countOtherTypeEvent.Value = db.events.Where(o => o.type == "Other").Count();
            Properties.Settings.Default.Save(); //Save Changes
        }

        /// <summary>
        /// Print data grid view
        /// </summary>
        /// <param name="dvg"></param>
        private void printDataGrid(DataGridView dvg, string tableName)
        {
            try
            {
                if (dvg.Rows.Count > 0)
                {
                    DGVPrinter printer = new DGVPrinter();
                    printer.Title = tableName;
                    printer.SubTitle = string.Format("Date: " + DateTime.Now.Date.ToString("MM.dd.yyyy"));
                    printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                    printer.PageNumbers = true;
                    printer.PageNumberInHeader = false;
                    printer.PorportionalColumns = true;
                    printer.HeaderCellAlignment = StringAlignment.Near;
                    printer.FooterSpacing = 15;
                    printer.printDocument.DefaultPageSettings.Landscape = true;
                    printer.PrintDataGridView(dvg);
                }
                else { MessageBox.Show(tableName+" Table is Empty!", "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error); }

        }
        /// <summary>
        /// Export to PDF
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="filename"></param>
        private void exportToPdf(DataGridView dgv, string filename)
        {
            try
            {
                BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
                PdfPTable pdfTable = new PdfPTable(dgv.Columns.Count);
                float[] miscWidthPosit = new float[] { 1000f, 200f };
                pdfTable.DefaultCell.Padding = 1;
                pdfTable.WidthPercentage = 100;
                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                pdfTable.DefaultCell.BorderWidth = 1;
                pdfTable.SpacingBefore = 10;
                iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
                // data header
                foreach (DataGridViewColumn column in dgv.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    pdfTable.AddCell(cell);
                }

                // data rows
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {

                        if (cell.Value == null)
                        {
                            pdfTable.AddCell(new Phrase(" ", text));
                        }
                        else
                        {
                            pdfTable.AddCell(new Phrase(cell.Value.ToString(), text));
                        }

                    }

                }
                var savefiledialoge = new SaveFileDialog();
                savefiledialoge.FileName = filename;
                savefiledialoge.DefaultExt = ".pdf";
                if (savefiledialoge.ShowDialog() == DialogResult.OK)
                {

                    using (FileStream stream = new FileStream(savefiledialoge.FileName, FileMode.Create))
                    {
                        Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                        PdfWriter.GetInstance(pdfdoc, stream);
                        pdfdoc.Open();
                        pdfdoc.Add(pdfTable);
                        pdfdoc.Close();
                        stream.Close();
                        MessageBox.Show("PDF Exported successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error); }

        }
        /// <summary>
        /// Print View DataGridView
        /// </summary>
        /// <param name="dvg"></param>
        Bitmap bm;
        private void viewDataGridView(DataGridView dvg)
        {
            try
            {
                if (dvg.Rows.Count > 0)
                {
                    int height = dvg.Height;
                    dvg.Height = dvg.RowCount * dvg.RowTemplate.Height * 2;
                    bm = new Bitmap(dvg.Width, dvg.Height);
                    dvg.DrawToBitmap(bm, new System.Drawing.Rectangle(0, 0, dvg.Width, dvg.Height));
                    dvg.Height = height;
                    printPreviewDialog1.ShowDialog();
                }
                else { MessageBox.Show("Table is Empty!", "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error); }

        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bm, 0, 0);
        }
        //_____________________SEARCH_______________________________________________
        private void searchCntTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Filter Data
                contactsBindingSource.DataSource = db.contacts.Local.Where(x => x.fname.Contains(searchCntTxt.Text) || x.lname.Contains(searchCntTxt.Text) || x.mname.Contains(searchCntTxt.Text) || x.email.Contains(searchCntTxt.Text) || x.phone.Contains(searchCntTxt.Text) || x.mobile.Contains(searchCntTxt.Text));
                // Remove Filter if empty
                if (String.IsNullOrEmpty(searchCntTxt.Text))
                {
                    contactsBindingSource.DataSource = db.contacts.ToList();
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void searchCntTxt_KeyPress(object sender, KeyPressEventArgs e){}

        private void searchLeadTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Filter Data
                leadsBindingSource.DataSource = db.leads.Local.Where(x => x.fname.Contains(searchLeadTxt.Text) || x.lname.Contains(searchLeadTxt.Text) || x.mname.Contains(searchLeadTxt.Text) || x.email.Contains(searchLeadTxt.Text) || x.lead_source.Contains(searchLeadTxt.Text) || x.lead_status.Contains(searchLeadTxt.Text));
                // Remove Filter if empty
                if (String.IsNullOrEmpty(searchLeadTxt.Text))
                {
                    leadsBindingSource.DataSource = db.leads.ToList();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void searchEventTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Filter Data
                eventsBindingSource.DataSource = db.events.Local.Where(x => x.topic.Contains(searchEventTxt.Text));
                // Remove Filter if empty
                if (String.IsNullOrEmpty(searchEventTxt.Text))
                {
                    eventsBindingSource.DataSource = db.events.ToList();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void searchTaskTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Filter Data
                tasksBindingSource.DataSource = db.tasks.Local.Where(x => x.task_name.Contains(searchTaskTxt.Text) || x.status.Contains(searchTaskTxt.Text) || x.refer_type.Contains(searchTaskTxt.Text));
                // Remove Filter if empty
                if (String.IsNullOrEmpty(searchTaskTxt.Text))
                {
                    tasksBindingSource.DataSource = db.tasks.ToList();
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //_____________________SEARCH End_______________________________________________
        // 
        private void tasksCard_Click(object sender, EventArgs e){ CountTasks(); }
        private void eventsCard_Click(object sender, EventArgs e){ CountEvents(); }
        private void contactsCard_Click(object sender, EventArgs e){ CountContacts(); }
        private void newLeadsCard_Click(object sender, EventArgs e){ CountLeads(); }

        // Load Charts
        private ObservableValue countNewLead, countAssignedLead, countInProcessLead, countConvertedLead, countRecycledLead, countOtherLead,
           countCallLead, countCustomerLead, countEmployeeLead, countPartnerLead, countConfrenceLead, countTradeLead, countWebsiteLead, countEmailLead, countOtherSourceLead
           , countPlannedEvent, countHeldEvent, countNotHeldEvent, countOtherEvent,
           countCallEvent, countConferenceEvent, countMeetingEvent, countSocialEvent, countFundraisingEvent, countOtherTypeEvent;

        private void mailCntBtn_Click(object sender, EventArgs e)
        {
            MailForm mFrm = new MailForm();
            mFrm.ShowDialog();
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            SettingsForm settingsFrm = new SettingsForm();
            settingsFrm.ShowDialog();
            companyImageAndName();
        }

        private void datetimeTimer_Tick(object sender, EventArgs e)
        {
            dtLabel.Text = DateTime.Now.ToString();
        }

        private void loadCharts()
        {
            //_________________________________________________________________________________________
            countNewLead = new ObservableValue(db.leads.Where(o => o.lead_status == "New").Count());
            countAssignedLead = new ObservableValue(db.leads.Where(o => o.lead_status == "Assigned").Count());
            countInProcessLead = new ObservableValue(db.leads.Where(o => o.lead_status == "In Process").Count());
            countConvertedLead = new ObservableValue(db.leads.Where(o => o.lead_status == "Converted").Count());
            countRecycledLead = new ObservableValue(db.leads.Where(o => o.lead_status == "Recycled").Count());
            countOtherLead = new ObservableValue(db.leads.Where(o => o.lead_status == "Other").Count());
            leadStatusChart.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Total",
                    Values = new ChartValues<ObservableValue> { countNewLead, countAssignedLead, countInProcessLead, countConvertedLead, countRecycledLead, countOtherLead }
                }
            };

            leadStatusChart.AxisX.Add(new Axis
            {
                Title = "Lead Status",
                Labels = new[] { "New", "Assigned", "In Process", "Converted", "Recycled", "Other" }//,
                                                                                                    // Separator = DefaultAxes.CleanSeparator
            });

            leadStatusChart.AxisY.Add(new Axis
            {
                Title = "",
                LabelFormatter = value => value.ToString("N")
            });

            //_________________________________________________________________________________________
            Func<ChartPoint, string> labelPoint = chartPoint =>
                string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            countCallLead = new ObservableValue(db.leads.Where(o => o.lead_source == "Call").Count());
            countCustomerLead = new ObservableValue(db.leads.Where(o => o.lead_source == "Customer").Count());
            countEmployeeLead = new ObservableValue(db.leads.Where(o => o.lead_source == "Employee").Count());
            countPartnerLead = new ObservableValue(db.leads.Where(o => o.lead_source == "Partner").Count());
            countConfrenceLead = new ObservableValue(db.leads.Where(o => o.lead_source == "Confrence").Count());
            countTradeLead = new ObservableValue(db.leads.Where(o => o.lead_source == "Trade").Count());
            countWebsiteLead = new ObservableValue(db.leads.Where(o => o.lead_source == "Website").Count());
            countEmailLead = new ObservableValue(db.leads.Where(o => o.lead_source == "Email").Count());
            countOtherSourceLead = new ObservableValue(db.leads.Where(o => o.lead_source == "Other").Count());

            leadSourceChart.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Call",
                    Values = new ChartValues<ObservableValue> {countCallLead},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Customer",
                    Values = new ChartValues<ObservableValue> {countCustomerLead},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Employee",
                    Values = new ChartValues<ObservableValue> {countEmployeeLead},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Partner",
                    Values = new ChartValues<ObservableValue> {countPartnerLead},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Confrence",
                    Values = new ChartValues<ObservableValue> {countConfrenceLead},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Trade",
                    Values = new ChartValues<ObservableValue> {countTradeLead},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Website",
                    Values = new ChartValues<ObservableValue> {countWebsiteLead},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Email",
                    Values = new ChartValues<ObservableValue> {countEmailLead},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Other",
                    Values = new ChartValues<ObservableValue> {countOtherSourceLead},
                    DataLabels = true,
                    LabelPoint = labelPoint
                }
            };

            leadSourceChart.LegendLocation = LegendLocation.Bottom;
            //_________________________________________________________________________________________
            Func<ChartPoint, string> labelPoint1 = chartPoint =>
                string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            countPlannedEvent = new ObservableValue(db.events.Where(o => o.status == "Planned").Count());
            countHeldEvent = new ObservableValue(db.events.Where(o => o.status == "Held").Count());
            countNotHeldEvent = new ObservableValue(db.events.Where(o => o.status == "Not Held").Count());
            countOtherEvent = new ObservableValue(db.events.Where(o => o.status == "Other").Count());
            eventStatusChart.InnerRadius = 100;
            eventStatusChart.LegendLocation = LegendLocation.Right;
            eventStatusChart.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Planned",
                    Values = new ChartValues<ObservableValue> {countPlannedEvent},
                    DataLabels = true,
                    LabelPoint = labelPoint1
                },
                new PieSeries
                {
                    Title = "Held",
                    Values = new ChartValues<ObservableValue> {countHeldEvent},
                    DataLabels = true,
                    LabelPoint = labelPoint1
                },
                new PieSeries
                {
                    Title = "Not Held",
                    Values = new ChartValues<ObservableValue> {countNotHeldEvent},
                    DataLabels = true,
                    LabelPoint = labelPoint1
                },
                new PieSeries
                {
                    Title = "Other",
                    Values = new ChartValues<ObservableValue> {countOtherEvent},
                    DataLabels = true,
                    LabelPoint = labelPoint1
                }
            };

            leadSourceChart.LegendLocation = LegendLocation.Bottom;
            //_________________________________________________________________________________________
            countCallEvent = new ObservableValue(db.events.Where(o => o.type == "Call").Count());
            countConferenceEvent = new ObservableValue(db.events.Where(o => o.type == "Conference").Count());
            countMeetingEvent = new ObservableValue(db.events.Where(o => o.type == "Meeting").Count());
            countSocialEvent = new ObservableValue(db.events.Where(o => o.type == "Social").Count());
            countFundraisingEvent = new ObservableValue(db.events.Where(o => o.type == "Fundraising").Count());
            countOtherTypeEvent = new ObservableValue(db.events.Where(o => o.type == "Other").Count());
            eventsTypeChart.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Events Type",
                    Values = new ChartValues<ObservableValue> { countCallEvent, countConferenceEvent, countMeetingEvent, countSocialEvent, countFundraisingEvent , countOtherTypeEvent}
                }
            };

            eventsTypeChart.AxisX.Add(new Axis
            {
                Title = "Events Type",
                Labels = new[] { "Call", "Conference", "Meeting", "Social", "Fundraising", "Other" }
            });

            eventsTypeChart.AxisY.Add(new Axis
            {
                Title = "",
                LabelFormatter = value => value.ToString("N")
            });

            eventsTypeChart.LegendLocation = LegendLocation.Right;
            //_________________________________________________________________________________________
        }

        /// <summary>
        /// Export to Excel
        /// </summary>
        /// <param name="dvg"></param>
        /// <param name="fileName"></param>
        private void exportToExcel(DataGridView dvg, string fileName)
        {
            try
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Excel WorkSheet";
                for (int i = 1; i < dvg.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dvg.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dvg.Rows.Count; i++)
                {
                    for (int j = 0; j < dvg.Columns.Count; j++)
                    {
                        // charck if cell is empty
                        if (dvg.Rows[i].Cells[j].Value == DBNull.Value || dvg.Rows[i].Cells[j].Value == null)
                        {
                            dvg.Rows[i].Cells[j].Value = " ";
                        }
                        else
                        {
                            worksheet.Cells[i + 2, j + 1] = dvg.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                }

                var sfd = new SaveFileDialog();
                sfd.FileName = fileName;
                sfd.DefaultExt = ".xlsx";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(sfd.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                   MessageBox.Show("Excel Exported successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                app.Quit();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }
    }
}
