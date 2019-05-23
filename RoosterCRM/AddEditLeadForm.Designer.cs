namespace RoosterCRM
{
    partial class AddEditLeadForm
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
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fnameTxt = new System.Windows.Forms.TextBox();
            this.leadsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet1 = new RoosterCRM.DatabaseDataSet1();
            this.label2 = new System.Windows.Forms.Label();
            this.lnameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mnameTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.salesPersonTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.depTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.compTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.indTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.revenueTxt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.desTxt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.refferedTxt = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.websiteTxt = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.mobileTxt = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.addressTxt1 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.addressTxt2 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.otherTxt = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.leadsTableAdapter = new RoosterCRM.DatabaseDataSet1TableAdapters.leadsTableAdapter();
            this.lSourceCB = new System.Windows.Forms.ComboBox();
            this.lStatusCB = new System.Windows.Forms.ComboBox();
            this.numEmpTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.leadsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(184, 26);
            this.label11.TabIndex = 24;
            this.label11.Text = "General Information";
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(12, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(730, 2);
            this.label10.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "First Name";
            // 
            // fnameTxt
            // 
            this.fnameTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leadsBindingSource, "fname", true));
            this.fnameTxt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameTxt.Location = new System.Drawing.Point(136, 44);
            this.fnameTxt.Name = "fnameTxt";
            this.fnameTxt.Size = new System.Drawing.Size(200, 27);
            this.fnameTxt.TabIndex = 0;
            // 
            // leadsBindingSource
            // 
            this.leadsBindingSource.DataMember = "leads";
            this.leadsBindingSource.DataSource = this.databaseDataSet1;
            // 
            // databaseDataSet1
            // 
            this.databaseDataSet1.DataSetName = "DatabaseDataSet1";
            this.databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "Last Name";
            // 
            // lnameTxt
            // 
            this.lnameTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leadsBindingSource, "lname", true));
            this.lnameTxt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameTxt.Location = new System.Drawing.Point(136, 77);
            this.lnameTxt.Name = "lnameTxt";
            this.lnameTxt.Size = new System.Drawing.Size(200, 27);
            this.lnameTxt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 19);
            this.label3.TabIndex = 28;
            this.label3.Text = "Middle Name";
            // 
            // mnameTxt
            // 
            this.mnameTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leadsBindingSource, "mname", true));
            this.mnameTxt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnameTxt.Location = new System.Drawing.Point(136, 110);
            this.mnameTxt.Name = "mnameTxt";
            this.mnameTxt.Size = new System.Drawing.Size(200, 27);
            this.mnameTxt.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 19);
            this.label4.TabIndex = 30;
            this.label4.Text = "Sales Person";
            // 
            // salesPersonTxt
            // 
            this.salesPersonTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leadsBindingSource, "sales_person", true));
            this.salesPersonTxt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesPersonTxt.Location = new System.Drawing.Point(136, 143);
            this.salesPersonTxt.Name = "salesPersonTxt";
            this.salesPersonTxt.Size = new System.Drawing.Size(200, 27);
            this.salesPersonTxt.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 19);
            this.label5.TabIndex = 32;
            this.label5.Text = "Department";
            // 
            // depTxt
            // 
            this.depTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leadsBindingSource, "dep", true));
            this.depTxt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depTxt.Location = new System.Drawing.Point(136, 176);
            this.depTxt.Name = "depTxt";
            this.depTxt.Size = new System.Drawing.Size(200, 27);
            this.depTxt.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 34;
            this.label6.Text = "Compnay";
            // 
            // compTxt
            // 
            this.compTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leadsBindingSource, "comp", true));
            this.compTxt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compTxt.Location = new System.Drawing.Point(136, 209);
            this.compTxt.Name = "compTxt";
            this.compTxt.Size = new System.Drawing.Size(200, 27);
            this.compTxt.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 19);
            this.label7.TabIndex = 36;
            this.label7.Text = "Industry";
            // 
            // indTxt
            // 
            this.indTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leadsBindingSource, "industry", true));
            this.indTxt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indTxt.Location = new System.Drawing.Point(136, 242);
            this.indTxt.Name = "indTxt";
            this.indTxt.Size = new System.Drawing.Size(200, 27);
            this.indTxt.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(389, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 19);
            this.label8.TabIndex = 38;
            this.label8.Text = "Lead Source";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(389, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 19);
            this.label9.TabIndex = 40;
            this.label9.Text = "Lead Status";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(389, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 19);
            this.label12.TabIndex = 42;
            this.label12.Text = "№ of Employees";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(389, 146);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 19);
            this.label13.TabIndex = 44;
            this.label13.Text = "Revenue";
            // 
            // revenueTxt
            // 
            this.revenueTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leadsBindingSource, "revenue", true));
            this.revenueTxt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revenueTxt.Location = new System.Drawing.Point(512, 143);
            this.revenueTxt.Name = "revenueTxt";
            this.revenueTxt.Size = new System.Drawing.Size(200, 27);
            this.revenueTxt.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(389, 179);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 19);
            this.label14.TabIndex = 46;
            this.label14.Text = "Description";
            // 
            // desTxt
            // 
            this.desTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leadsBindingSource, "des", true));
            this.desTxt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desTxt.Location = new System.Drawing.Point(512, 176);
            this.desTxt.Multiline = true;
            this.desTxt.Name = "desTxt";
            this.desTxt.Size = new System.Drawing.Size(200, 60);
            this.desTxt.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(389, 245);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 19);
            this.label15.TabIndex = 48;
            this.label15.Text = "Reffered By";
            // 
            // refferedTxt
            // 
            this.refferedTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leadsBindingSource, "referred", true));
            this.refferedTxt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refferedTxt.Location = new System.Drawing.Point(512, 242);
            this.refferedTxt.Name = "refferedTxt";
            this.refferedTxt.Size = new System.Drawing.Size(200, 27);
            this.refferedTxt.TabIndex = 12;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(12, 295);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(184, 26);
            this.label16.TabIndex = 50;
            this.label16.Text = "Contact Information";
            // 
            // label17
            // 
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Location = new System.Drawing.Point(12, 321);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(730, 2);
            this.label17.TabIndex = 49;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(13, 438);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 19);
            this.label18.TabIndex = 58;
            this.label18.Text = "Website";
            // 
            // websiteTxt
            // 
            this.websiteTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leadsBindingSource, "website", true));
            this.websiteTxt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.websiteTxt.Location = new System.Drawing.Point(136, 435);
            this.websiteTxt.Name = "websiteTxt";
            this.websiteTxt.Size = new System.Drawing.Size(200, 27);
            this.websiteTxt.TabIndex = 16;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(13, 405);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 19);
            this.label19.TabIndex = 56;
            this.label19.Text = "Phone";
            // 
            // phoneTxt
            // 
            this.phoneTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leadsBindingSource, "phone", true));
            this.phoneTxt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTxt.Location = new System.Drawing.Point(136, 402);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(200, 27);
            this.phoneTxt.TabIndex = 15;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(13, 372);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(54, 19);
            this.label20.TabIndex = 54;
            this.label20.Text = "Mobile";
            // 
            // mobileTxt
            // 
            this.mobileTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leadsBindingSource, "mobile", true));
            this.mobileTxt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileTxt.Location = new System.Drawing.Point(136, 369);
            this.mobileTxt.Name = "mobileTxt";
            this.mobileTxt.Size = new System.Drawing.Size(200, 27);
            this.mobileTxt.TabIndex = 14;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(13, 339);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(45, 19);
            this.label21.TabIndex = 52;
            this.label21.Text = "Email";
            // 
            // emailTxt
            // 
            this.emailTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leadsBindingSource, "email", true));
            this.emailTxt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxt.Location = new System.Drawing.Point(136, 336);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(200, 27);
            this.emailTxt.TabIndex = 13;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(389, 339);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(73, 19);
            this.label22.TabIndex = 60;
            this.label22.Text = "Address 1";
            // 
            // addressTxt1
            // 
            this.addressTxt1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leadsBindingSource, "address1", true));
            this.addressTxt1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTxt1.Location = new System.Drawing.Point(512, 336);
            this.addressTxt1.Multiline = true;
            this.addressTxt1.Name = "addressTxt1";
            this.addressTxt1.Size = new System.Drawing.Size(200, 60);
            this.addressTxt1.TabIndex = 17;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(389, 405);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(73, 19);
            this.label23.TabIndex = 62;
            this.label23.Text = "Address 2";
            // 
            // addressTxt2
            // 
            this.addressTxt2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leadsBindingSource, "address2", true));
            this.addressTxt2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTxt2.Location = new System.Drawing.Point(512, 402);
            this.addressTxt2.Multiline = true;
            this.addressTxt2.Name = "addressTxt2";
            this.addressTxt2.Size = new System.Drawing.Size(200, 60);
            this.addressTxt2.TabIndex = 18;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(12, 476);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(206, 26);
            this.label24.TabIndex = 64;
            this.label24.Text = "Additional Information";
            // 
            // label25
            // 
            this.label25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label25.Location = new System.Drawing.Point(12, 502);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(730, 2);
            this.label25.TabIndex = 63;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(7, 522);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(125, 19);
            this.label26.TabIndex = 66;
            this.label26.Text = "Other Information";
            // 
            // otherTxt
            // 
            this.otherTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leadsBindingSource, "other", true));
            this.otherTxt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherTxt.Location = new System.Drawing.Point(136, 519);
            this.otherTxt.Multiline = true;
            this.otherTxt.Name = "otherTxt";
            this.otherTxt.Size = new System.Drawing.Size(200, 60);
            this.otherTxt.TabIndex = 19;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(536, 599);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(100, 34);
            this.cancelBtn.TabIndex = 21;
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
            this.saveBtn.Location = new System.Drawing.Point(642, 599);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(100, 34);
            this.saveBtn.TabIndex = 20;
            this.saveBtn.Text = "&SAVE";
            this.saveBtn.UseVisualStyleBackColor = false;
            // 
            // leadsTableAdapter
            // 
            this.leadsTableAdapter.ClearBeforeFill = true;
            // 
            // lSourceCB
            // 
            this.lSourceCB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leadsBindingSource, "lead_source", true));
            this.lSourceCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lSourceCB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSourceCB.FormattingEnabled = true;
            this.lSourceCB.Items.AddRange(new object[] {
            "",
            "Call",
            "Customer",
            "Employee",
            "Partner",
            "Confrence",
            "Trade",
            "Website",
            "Email",
            "Other"});
            this.lSourceCB.Location = new System.Drawing.Point(512, 44);
            this.lSourceCB.Name = "lSourceCB";
            this.lSourceCB.Size = new System.Drawing.Size(200, 27);
            this.lSourceCB.TabIndex = 7;
            // 
            // lStatusCB
            // 
            this.lStatusCB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leadsBindingSource, "lead_status", true));
            this.lStatusCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lStatusCB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lStatusCB.FormattingEnabled = true;
            this.lStatusCB.Items.AddRange(new object[] {
            "",
            "New",
            "Assigned",
            "In Process",
            "Converted",
            "Recycled",
            "Other"});
            this.lStatusCB.Location = new System.Drawing.Point(512, 80);
            this.lStatusCB.Name = "lStatusCB";
            this.lStatusCB.Size = new System.Drawing.Size(200, 27);
            this.lStatusCB.TabIndex = 8;
            // 
            // numEmpTxt
            // 
            this.numEmpTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.leadsBindingSource, "no_empl", true));
            this.numEmpTxt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numEmpTxt.Location = new System.Drawing.Point(512, 113);
            this.numEmpTxt.Name = "numEmpTxt";
            this.numEmpTxt.Size = new System.Drawing.Size(200, 27);
            this.numEmpTxt.TabIndex = 9;
            this.numEmpTxt.TextChanged += new System.EventHandler(this.numEmpTxt_TextChanged);
            // 
            // AddEditLeadForm
            // 
            this.AcceptButton = this.saveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(754, 645);
            this.Controls.Add(this.numEmpTxt);
            this.Controls.Add(this.lStatusCB);
            this.Controls.Add(this.lSourceCB);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.otherTxt);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.addressTxt2);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.addressTxt1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.websiteTxt);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.phoneTxt);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.mobileTxt);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.refferedTxt);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.desTxt);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.revenueTxt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.indTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.compTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.depTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.salesPersonTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mnameTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lnameTxt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fnameTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditLeadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddEditLeadForm_FormClosing);
            this.Load += new System.EventHandler(this.AddEditLeadForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.leadsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fnameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lnameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mnameTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox salesPersonTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox depTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox compTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox indTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox revenueTxt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox desTxt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox refferedTxt;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox websiteTxt;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox mobileTxt;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox addressTxt1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox addressTxt2;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox otherTxt;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private DatabaseDataSet1 databaseDataSet1;
        private System.Windows.Forms.BindingSource leadsBindingSource;
        private DatabaseDataSet1TableAdapters.leadsTableAdapter leadsTableAdapter;
        private System.Windows.Forms.ComboBox lSourceCB;
        private System.Windows.Forms.ComboBox lStatusCB;
        private System.Windows.Forms.TextBox numEmpTxt;
    }
}