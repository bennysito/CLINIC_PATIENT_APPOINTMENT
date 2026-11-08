namespace JAMES_CODEV2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPatients = new System.Windows.Forms.TabPage();
            this.dgvPatients = new System.Windows.Forms.DataGridView();
            this.pnlPatInputs = new System.Windows.Forms.Panel();
            this.chkShowInactivePatients = new System.Windows.Forms.CheckBox();
            this.btnPatResetSearch = new System.Windows.Forms.Button();
            this.btnPatSearch = new System.Windows.Forms.Button();
            this.txtPatSearch = new System.Windows.Forms.TextBox();
            this.lblPatSearch = new System.Windows.Forms.Label();
            this.btnPatClear = new System.Windows.Forms.Button();
            this.btnPatUpdate = new System.Windows.Forms.Button();
            this.btnPatInsert = new System.Windows.Forms.Button();
            this.cmbPatStatus = new System.Windows.Forms.ComboBox();
            this.lblPatStatus = new System.Windows.Forms.Label();
            this.txtPatContact = new System.Windows.Forms.TextBox();
            this.lblPatContact = new System.Windows.Forms.Label();
            this.cmbPatSex = new System.Windows.Forms.ComboBox();
            this.lblPatSex = new System.Windows.Forms.Label();
            this.dtpPatBirth = new System.Windows.Forms.DateTimePicker();
            this.lblPatBirth = new System.Windows.Forms.Label();
            this.txtPatName = new System.Windows.Forms.TextBox();
            this.lblPatName = new System.Windows.Forms.Label();
            this.txtPatNo = new System.Windows.Forms.TextBox();
            this.lblPatNo = new System.Windows.Forms.Label();
            this.txtPatId = new System.Windows.Forms.TextBox();
            this.lblPatId = new System.Windows.Forms.Label();
            this.tabDoctors = new System.Windows.Forms.TabPage();
            this.dgvDoctors = new System.Windows.Forms.DataGridView();
            this.pnlDocInputs = new System.Windows.Forms.Panel();
            this.chkShowInactiveDoctors = new System.Windows.Forms.CheckBox();
            this.btnDocClear = new System.Windows.Forms.Button();
            this.btnDocUpdate = new System.Windows.Forms.Button();
            this.btnDocInsert = new System.Windows.Forms.Button();
            this.txtDocSpec = new System.Windows.Forms.TextBox();
            this.lblDocSpec = new System.Windows.Forms.Label();
            this.txtDocName = new System.Windows.Forms.TextBox();
            this.lblDocName = new System.Windows.Forms.Label();
            this.txtDocLicense = new System.Windows.Forms.TextBox();
            this.lblDocLicense = new System.Windows.Forms.Label();
            this.txtDocId = new System.Windows.Forms.TextBox();
            this.lblDocId = new System.Windows.Forms.Label();
            this.tabAppointments = new System.Windows.Forms.TabPage();
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.pnlApptInputs = new System.Windows.Forms.Panel();
            this.btnApptRefresh = new System.Windows.Forms.Button();
            this.btnApptSchedule = new System.Windows.Forms.Button();
            this.dtpApptDateTime = new System.Windows.Forms.DateTimePicker();
            this.lblApptDate = new System.Windows.Forms.Label();
            this.cmbApptDoctor = new System.Windows.Forms.ComboBox();
            this.lblApptDoc = new System.Windows.Forms.Label();
            this.cmbApptPatient = new System.Windows.Forms.ComboBox();
            this.lblApptPat = new System.Windows.Forms.Label();
            this.tabBilling = new System.Windows.Forms.TabPage();
            this.dgvInvoices = new System.Windows.Forms.DataGridView();
            this.pnlBillInputs = new System.Windows.Forms.Panel();
            this.btnInvRefresh = new System.Windows.Forms.Button();
            this.btnInvCreate = new System.Windows.Forms.Button();
            this.cmbInvPayStatus = new System.Windows.Forms.ComboBox();
            this.lblInvStatus = new System.Windows.Forms.Label();
            this.txtInvUnitFee = new System.Windows.Forms.TextBox();
            this.lblInvFee = new System.Windows.Forms.Label();
            this.numInvQty = new System.Windows.Forms.NumericUpDown();
            this.lblInvQty = new System.Windows.Forms.Label();
            this.cmbInvService = new System.Windows.Forms.ComboBox();
            this.lblInvSvc = new System.Windows.Forms.Label();
            this.cmbInvAppt = new System.Windows.Forms.ComboBox();
            this.lblInvAppt = new System.Windows.Forms.Label();
            this.tabReports = new System.Windows.Forms.TabPage();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.pnlRepTop = new System.Windows.Forms.Panel();
            this.btnLoadReport = new System.Windows.Forms.Button();
            this.tabControlMain.SuspendLayout();
            this.tabPatients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            this.pnlPatInputs.SuspendLayout();
            this.tabDoctors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).BeginInit();
            this.pnlDocInputs.SuspendLayout();
            this.tabAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.pnlApptInputs.SuspendLayout();
            this.tabBilling.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            this.pnlBillInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInvQty)).BeginInit();
            this.tabReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.pnlRepTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPatients);
            this.tabControlMain.Controls.Add(this.tabDoctors);
            this.tabControlMain.Controls.Add(this.tabAppointments);
            this.tabControlMain.Controls.Add(this.tabBilling);
            this.tabControlMain.Controls.Add(this.tabReports);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1387, 849);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPatients
            // 
            this.tabPatients.Controls.Add(this.dgvPatients);
            this.tabPatients.Controls.Add(this.pnlPatInputs);
            this.tabPatients.Location = new System.Drawing.Point(4, 25);
            this.tabPatients.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPatients.Name = "tabPatients";
            this.tabPatients.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPatients.Size = new System.Drawing.Size(1379, 820);
            this.tabPatients.TabIndex = 0;
            this.tabPatients.Text = "Patients";
            this.tabPatients.UseVisualStyleBackColor = true;
            // 
            // dgvPatients
            // 
            this.dgvPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPatients.Location = new System.Drawing.Point(4, 250);
            this.dgvPatients.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPatients.Name = "dgvPatients";
            this.dgvPatients.ReadOnly = true;
            this.dgvPatients.RowHeadersWidth = 51;
            this.dgvPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatients.Size = new System.Drawing.Size(1371, 566);
            this.dgvPatients.TabIndex = 1;
            this.dgvPatients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPatients_CellClick);
            // 
            // pnlPatInputs
            // 
            this.pnlPatInputs.Controls.Add(this.chkShowInactivePatients);
            this.pnlPatInputs.Controls.Add(this.btnPatResetSearch);
            this.pnlPatInputs.Controls.Add(this.btnPatSearch);
            this.pnlPatInputs.Controls.Add(this.txtPatSearch);
            this.pnlPatInputs.Controls.Add(this.lblPatSearch);
            this.pnlPatInputs.Controls.Add(this.btnPatClear);
            this.pnlPatInputs.Controls.Add(this.btnPatUpdate);
            this.pnlPatInputs.Controls.Add(this.btnPatInsert);
            this.pnlPatInputs.Controls.Add(this.cmbPatStatus);
            this.pnlPatInputs.Controls.Add(this.lblPatStatus);
            this.pnlPatInputs.Controls.Add(this.txtPatContact);
            this.pnlPatInputs.Controls.Add(this.lblPatContact);
            this.pnlPatInputs.Controls.Add(this.cmbPatSex);
            this.pnlPatInputs.Controls.Add(this.lblPatSex);
            this.pnlPatInputs.Controls.Add(this.dtpPatBirth);
            this.pnlPatInputs.Controls.Add(this.lblPatBirth);
            this.pnlPatInputs.Controls.Add(this.txtPatName);
            this.pnlPatInputs.Controls.Add(this.lblPatName);
            this.pnlPatInputs.Controls.Add(this.txtPatNo);
            this.pnlPatInputs.Controls.Add(this.lblPatNo);
            this.pnlPatInputs.Controls.Add(this.txtPatId);
            this.pnlPatInputs.Controls.Add(this.lblPatId);
            this.pnlPatInputs.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPatInputs.Location = new System.Drawing.Point(4, 4);
            this.pnlPatInputs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlPatInputs.Name = "pnlPatInputs";
            this.pnlPatInputs.Size = new System.Drawing.Size(1371, 246);
            this.pnlPatInputs.TabIndex = 0;
            // 
            // chkShowInactivePatients
            // 
            this.chkShowInactivePatients.AutoSize = true;
            this.chkShowInactivePatients.Location = new System.Drawing.Point(773, 201);
            this.chkShowInactivePatients.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkShowInactivePatients.Name = "chkShowInactivePatients";
            this.chkShowInactivePatients.Size = new System.Drawing.Size(176, 20);
            this.chkShowInactivePatients.TabIndex = 22;
            this.chkShowInactivePatients.Text = "Include Inactive Records";
            this.chkShowInactivePatients.UseVisualStyleBackColor = true;
            this.chkShowInactivePatients.CheckedChanged += new System.EventHandler(this.ChkShowInactivePatients_CheckedChanged);
            // 
            // btnPatResetSearch
            // 
            this.btnPatResetSearch.Location = new System.Drawing.Point(627, 194);
            this.btnPatResetSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPatResetSearch.Name = "btnPatResetSearch";
            this.btnPatResetSearch.Size = new System.Drawing.Size(107, 32);
            this.btnPatResetSearch.TabIndex = 21;
            this.btnPatResetSearch.Text = "Reset";
            this.btnPatResetSearch.UseVisualStyleBackColor = true;
            this.btnPatResetSearch.Click += new System.EventHandler(this.BtnPatResetSearch_Click);
            // 
            // btnPatSearch
            // 
            this.btnPatSearch.Location = new System.Drawing.Point(513, 194);
            this.btnPatSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPatSearch.Name = "btnPatSearch";
            this.btnPatSearch.Size = new System.Drawing.Size(107, 32);
            this.btnPatSearch.TabIndex = 20;
            this.btnPatSearch.Text = "Search";
            this.btnPatSearch.UseVisualStyleBackColor = true;
            this.btnPatSearch.Click += new System.EventHandler(this.BtnPatSearch_Click);
            // 
            // txtPatSearch
            // 
            this.txtPatSearch.Location = new System.Drawing.Point(167, 198);
            this.txtPatSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPatSearch.Name = "txtPatSearch";
            this.txtPatSearch.Size = new System.Drawing.Size(332, 22);
            this.txtPatSearch.TabIndex = 19;
            // 
            // lblPatSearch
            // 
            this.lblPatSearch.AutoSize = true;
            this.lblPatSearch.Location = new System.Drawing.Point(20, 202);
            this.lblPatSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPatSearch.Name = "lblPatSearch";
            this.lblPatSearch.Size = new System.Drawing.Size(108, 16);
            this.lblPatSearch.TabIndex = 18;
            this.lblPatSearch.Text = "Search Keyword:";
            // 
            // btnPatClear
            // 
            this.btnPatClear.Location = new System.Drawing.Point(800, 107);
            this.btnPatClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPatClear.Name = "btnPatClear";
            this.btnPatClear.Size = new System.Drawing.Size(160, 39);
            this.btnPatClear.TabIndex = 17;
            this.btnPatClear.Text = "Clear Fields";
            this.btnPatClear.UseVisualStyleBackColor = true;
            this.btnPatClear.Click += new System.EventHandler(this.BtnPatClear_Click);
            // 
            // btnPatUpdate
            // 
            this.btnPatUpdate.Location = new System.Drawing.Point(800, 60);
            this.btnPatUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPatUpdate.Name = "btnPatUpdate";
            this.btnPatUpdate.Size = new System.Drawing.Size(160, 39);
            this.btnPatUpdate.TabIndex = 15;
            this.btnPatUpdate.Text = "Update";
            this.btnPatUpdate.UseVisualStyleBackColor = true;
            this.btnPatUpdate.Click += new System.EventHandler(this.BtnPatUpdate_Click);
            // 
            // btnPatInsert
            // 
            this.btnPatInsert.Location = new System.Drawing.Point(800, 14);
            this.btnPatInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPatInsert.Name = "btnPatInsert";
            this.btnPatInsert.Size = new System.Drawing.Size(160, 39);
            this.btnPatInsert.TabIndex = 14;
            this.btnPatInsert.Text = "Add Patient";
            this.btnPatInsert.UseVisualStyleBackColor = true;
            this.btnPatInsert.Click += new System.EventHandler(this.BtnPatInsert_Click);
            // 
            // cmbPatStatus
            // 
            this.cmbPatStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPatStatus.FormattingEnabled = true;
            this.cmbPatStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cmbPatStatus.Location = new System.Drawing.Point(547, 89);
            this.cmbPatStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPatStatus.Name = "cmbPatStatus";
            this.cmbPatStatus.Size = new System.Drawing.Size(212, 24);
            this.cmbPatStatus.TabIndex = 13;
            // 
            // lblPatStatus
            // 
            this.lblPatStatus.AutoSize = true;
            this.lblPatStatus.Location = new System.Drawing.Point(400, 92);
            this.lblPatStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPatStatus.Name = "lblPatStatus";
            this.lblPatStatus.Size = new System.Drawing.Size(52, 16);
            this.lblPatStatus.TabIndex = 12;
            this.lblPatStatus.Text = "Status:*";
            // 
            // txtPatContact
            // 
            this.txtPatContact.Location = new System.Drawing.Point(547, 52);
            this.txtPatContact.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPatContact.MaxLength = 11;
            this.txtPatContact.Name = "txtPatContact";
            this.txtPatContact.Size = new System.Drawing.Size(212, 22);
            this.txtPatContact.TabIndex = 11;
            // 
            // lblPatContact
            // 
            this.lblPatContact.AutoSize = true;
            this.lblPatContact.Location = new System.Drawing.Point(400, 55);
            this.lblPatContact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPatContact.Name = "lblPatContact";
            this.lblPatContact.Size = new System.Drawing.Size(108, 16);
            this.lblPatContact.TabIndex = 10;
            this.lblPatContact.Text = "Contact (11-dig):*";
            // 
            // cmbPatSex
            // 
            this.cmbPatSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPatSex.FormattingEnabled = true;
            this.cmbPatSex.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.cmbPatSex.Location = new System.Drawing.Point(547, 15);
            this.cmbPatSex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPatSex.Name = "cmbPatSex";
            this.cmbPatSex.Size = new System.Drawing.Size(212, 24);
            this.cmbPatSex.TabIndex = 9;
            // 
            // lblPatSex
            // 
            this.lblPatSex.AutoSize = true;
            this.lblPatSex.Location = new System.Drawing.Point(400, 18);
            this.lblPatSex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPatSex.Name = "lblPatSex";
            this.lblPatSex.Size = new System.Drawing.Size(38, 16);
            this.lblPatSex.TabIndex = 8;
            this.lblPatSex.Text = "Sex:*";
            // 
            // dtpPatBirth
            // 
            this.dtpPatBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPatBirth.Location = new System.Drawing.Point(147, 126);
            this.dtpPatBirth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpPatBirth.Name = "dtpPatBirth";
            this.dtpPatBirth.Size = new System.Drawing.Size(212, 22);
            this.dtpPatBirth.TabIndex = 7;
            // 
            // lblPatBirth
            // 
            this.lblPatBirth.AutoSize = true;
            this.lblPatBirth.Location = new System.Drawing.Point(20, 129);
            this.lblPatBirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPatBirth.Name = "lblPatBirth";
            this.lblPatBirth.Size = new System.Drawing.Size(73, 16);
            this.lblPatBirth.TabIndex = 6;
            this.lblPatBirth.Text = "Birth Date:*";
            // 
            // txtPatName
            // 
            this.txtPatName.Location = new System.Drawing.Point(147, 89);
            this.txtPatName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPatName.Name = "txtPatName";
            this.txtPatName.Size = new System.Drawing.Size(212, 22);
            this.txtPatName.TabIndex = 5;
            // 
            // lblPatName
            // 
            this.lblPatName.AutoSize = true;
            this.lblPatName.Location = new System.Drawing.Point(20, 92);
            this.lblPatName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPatName.Name = "lblPatName";
            this.lblPatName.Size = new System.Drawing.Size(76, 16);
            this.lblPatName.TabIndex = 4;
            this.lblPatName.Text = "Full Name:*";
            // 
            // txtPatNo
            // 
            this.txtPatNo.Location = new System.Drawing.Point(147, 52);
            this.txtPatNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPatNo.Name = "txtPatNo";
            this.txtPatNo.Size = new System.Drawing.Size(212, 22);
            this.txtPatNo.TabIndex = 3;
            // 
            // lblPatNo
            // 
            this.lblPatNo.AutoSize = true;
            this.lblPatNo.Location = new System.Drawing.Point(20, 55);
            this.lblPatNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPatNo.Name = "lblPatNo";
            this.lblPatNo.Size = new System.Drawing.Size(77, 16);
            this.lblPatNo.TabIndex = 2;
            this.lblPatNo.Text = "Patient No:*";
            // 
            // txtPatId
            // 
            this.txtPatId.BackColor = System.Drawing.Color.LightGray;
            this.txtPatId.Location = new System.Drawing.Point(147, 18);
            this.txtPatId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPatId.Name = "txtPatId";
            this.txtPatId.ReadOnly = true;
            this.txtPatId.Size = new System.Drawing.Size(212, 22);
            this.txtPatId.TabIndex = 1;
            // 
            // lblPatId
            // 
            this.lblPatId.AutoSize = true;
            this.lblPatId.Location = new System.Drawing.Point(20, 18);
            this.lblPatId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPatId.Name = "lblPatId";
            this.lblPatId.Size = new System.Drawing.Size(23, 16);
            this.lblPatId.TabIndex = 0;
            this.lblPatId.Text = "ID:";
            // 
            // tabDoctors
            // 
            this.tabDoctors.Controls.Add(this.dgvDoctors);
            this.tabDoctors.Controls.Add(this.pnlDocInputs);
            this.tabDoctors.Location = new System.Drawing.Point(4, 25);
            this.tabDoctors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabDoctors.Name = "tabDoctors";
            this.tabDoctors.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabDoctors.Size = new System.Drawing.Size(1379, 820);
            this.tabDoctors.TabIndex = 1;
            this.tabDoctors.Text = "Doctors";
            this.tabDoctors.UseVisualStyleBackColor = true;
            // 
            // dgvDoctors
            // 
            this.dgvDoctors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDoctors.Location = new System.Drawing.Point(4, 213);
            this.dgvDoctors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDoctors.Name = "dgvDoctors";
            this.dgvDoctors.ReadOnly = true;
            this.dgvDoctors.RowHeadersWidth = 51;
            this.dgvDoctors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoctors.Size = new System.Drawing.Size(1371, 603);
            this.dgvDoctors.TabIndex = 1;
            this.dgvDoctors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDoctors_CellClick);
            // 
            // pnlDocInputs
            // 
            this.pnlDocInputs.Controls.Add(this.chkShowInactiveDoctors);
            this.pnlDocInputs.Controls.Add(this.btnDocClear);
            this.pnlDocInputs.Controls.Add(this.btnDocUpdate);
            this.pnlDocInputs.Controls.Add(this.btnDocInsert);
            this.pnlDocInputs.Controls.Add(this.txtDocSpec);
            this.pnlDocInputs.Controls.Add(this.lblDocSpec);
            this.pnlDocInputs.Controls.Add(this.txtDocName);
            this.pnlDocInputs.Controls.Add(this.lblDocName);
            this.pnlDocInputs.Controls.Add(this.txtDocLicense);
            this.pnlDocInputs.Controls.Add(this.lblDocLicense);
            this.pnlDocInputs.Controls.Add(this.txtDocId);
            this.pnlDocInputs.Controls.Add(this.lblDocId);
            this.pnlDocInputs.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDocInputs.Location = new System.Drawing.Point(4, 4);
            this.pnlDocInputs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlDocInputs.Name = "pnlDocInputs";
            this.pnlDocInputs.Size = new System.Drawing.Size(1371, 209);
            this.pnlDocInputs.TabIndex = 0;
            // 
            // chkShowInactiveDoctors
            // 
            this.chkShowInactiveDoctors.AutoSize = true;
            this.chkShowInactiveDoctors.Location = new System.Drawing.Point(453, 161);
            this.chkShowInactiveDoctors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkShowInactiveDoctors.Name = "chkShowInactiveDoctors";
            this.chkShowInactiveDoctors.Size = new System.Drawing.Size(176, 20);
            this.chkShowInactiveDoctors.TabIndex = 12;
            this.chkShowInactiveDoctors.Text = "Include Inactive Records";
            this.chkShowInactiveDoctors.UseVisualStyleBackColor = true;
            this.chkShowInactiveDoctors.CheckedChanged += new System.EventHandler(this.ChkShowInactiveDoctors_CheckedChanged);
            // 
            // btnDocClear
            // 
            this.btnDocClear.Location = new System.Drawing.Point(453, 110);
            this.btnDocClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDocClear.Name = "btnDocClear";
            this.btnDocClear.Size = new System.Drawing.Size(160, 39);
            this.btnDocClear.TabIndex = 11;
            this.btnDocClear.Text = "Clear Fields";
            this.btnDocClear.UseVisualStyleBackColor = true;
            this.btnDocClear.Click += new System.EventHandler(this.BtnDocClear_Click);
            // 
            // btnDocUpdate
            // 
            this.btnDocUpdate.Location = new System.Drawing.Point(453, 63);
            this.btnDocUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDocUpdate.Name = "btnDocUpdate";
            this.btnDocUpdate.Size = new System.Drawing.Size(160, 39);
            this.btnDocUpdate.TabIndex = 9;
            this.btnDocUpdate.Text = "Update";
            this.btnDocUpdate.UseVisualStyleBackColor = true;
            this.btnDocUpdate.Click += new System.EventHandler(this.BtnDocUpdate_Click);
            // 
            // btnDocInsert
            // 
            this.btnDocInsert.Location = new System.Drawing.Point(453, 16);
            this.btnDocInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDocInsert.Name = "btnDocInsert";
            this.btnDocInsert.Size = new System.Drawing.Size(160, 39);
            this.btnDocInsert.TabIndex = 8;
            this.btnDocInsert.Text = "Add Doctor";
            this.btnDocInsert.UseVisualStyleBackColor = true;
            this.btnDocInsert.Click += new System.EventHandler(this.BtnDocInsert_Click);
            // 
            // txtDocSpec
            // 
            this.txtDocSpec.Location = new System.Drawing.Point(160, 150);
            this.txtDocSpec.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDocSpec.Name = "txtDocSpec";
            this.txtDocSpec.Size = new System.Drawing.Size(239, 22);
            this.txtDocSpec.TabIndex = 7;
            // 
            // lblDocSpec
            // 
            this.lblDocSpec.AutoSize = true;
            this.lblDocSpec.Location = new System.Drawing.Point(20, 154);
            this.lblDocSpec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDocSpec.Name = "lblDocSpec";
            this.lblDocSpec.Size = new System.Drawing.Size(99, 16);
            this.lblDocSpec.TabIndex = 6;
            this.lblDocSpec.Text = "Specialization:*";
            // 
            // txtDocName
            // 
            this.txtDocName.Location = new System.Drawing.Point(160, 107);
            this.txtDocName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDocName.Name = "txtDocName";
            this.txtDocName.Size = new System.Drawing.Size(239, 22);
            this.txtDocName.TabIndex = 5;
            // 
            // lblDocName
            // 
            this.lblDocName.AutoSize = true;
            this.lblDocName.Location = new System.Drawing.Point(20, 111);
            this.lblDocName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDocName.Name = "lblDocName";
            this.lblDocName.Size = new System.Drawing.Size(76, 16);
            this.lblDocName.TabIndex = 4;
            this.lblDocName.Text = "Full Name:*";
            // 
            // txtDocLicense
            // 
            this.txtDocLicense.Location = new System.Drawing.Point(160, 64);
            this.txtDocLicense.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDocLicense.Name = "txtDocLicense";
            this.txtDocLicense.Size = new System.Drawing.Size(239, 22);
            this.txtDocLicense.TabIndex = 3;
            // 
            // lblDocLicense
            // 
            this.lblDocLicense.AutoSize = true;
            this.lblDocLicense.Location = new System.Drawing.Point(20, 68);
            this.lblDocLicense.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDocLicense.Name = "lblDocLicense";
            this.lblDocLicense.Size = new System.Drawing.Size(83, 16);
            this.lblDocLicense.TabIndex = 2;
            this.lblDocLicense.Text = "License No:*";
            // 
            // txtDocId
            // 
            this.txtDocId.BackColor = System.Drawing.Color.LightGray;
            this.txtDocId.Location = new System.Drawing.Point(160, 21);
            this.txtDocId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDocId.Name = "txtDocId";
            this.txtDocId.ReadOnly = true;
            this.txtDocId.Size = new System.Drawing.Size(239, 22);
            this.txtDocId.TabIndex = 1;
            // 
            // lblDocId
            // 
            this.lblDocId.AutoSize = true;
            this.lblDocId.Location = new System.Drawing.Point(20, 25);
            this.lblDocId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDocId.Name = "lblDocId";
            this.lblDocId.Size = new System.Drawing.Size(66, 16);
            this.lblDocId.TabIndex = 0;
            this.lblDocId.Text = "Doctor ID:";
            // 
            // tabAppointments
            // 
            this.tabAppointments.Controls.Add(this.dgvAppointments);
            this.tabAppointments.Controls.Add(this.pnlApptInputs);
            this.tabAppointments.Location = new System.Drawing.Point(4, 25);
            this.tabAppointments.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabAppointments.Name = "tabAppointments";
            this.tabAppointments.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabAppointments.Size = new System.Drawing.Size(1379, 820);
            this.tabAppointments.TabIndex = 2;
            this.tabAppointments.Text = "Appointments";
            this.tabAppointments.UseVisualStyleBackColor = true;
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAppointments.Location = new System.Drawing.Point(4, 176);
            this.dgvAppointments.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.ReadOnly = true;
            this.dgvAppointments.RowHeadersWidth = 51;
            this.dgvAppointments.Size = new System.Drawing.Size(1371, 640);
            this.dgvAppointments.TabIndex = 1;
            // 
            // pnlApptInputs
            // 
            this.pnlApptInputs.Controls.Add(this.btnApptRefresh);
            this.pnlApptInputs.Controls.Add(this.btnApptSchedule);
            this.pnlApptInputs.Controls.Add(this.dtpApptDateTime);
            this.pnlApptInputs.Controls.Add(this.lblApptDate);
            this.pnlApptInputs.Controls.Add(this.cmbApptDoctor);
            this.pnlApptInputs.Controls.Add(this.lblApptDoc);
            this.pnlApptInputs.Controls.Add(this.cmbApptPatient);
            this.pnlApptInputs.Controls.Add(this.lblApptPat);
            this.pnlApptInputs.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlApptInputs.Location = new System.Drawing.Point(4, 4);
            this.pnlApptInputs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlApptInputs.Name = "pnlApptInputs";
            this.pnlApptInputs.Size = new System.Drawing.Size(1371, 172);
            this.pnlApptInputs.TabIndex = 0;
            // 
            // btnApptRefresh
            // 
            this.btnApptRefresh.Location = new System.Drawing.Point(733, 64);
            this.btnApptRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnApptRefresh.Name = "btnApptRefresh";
            this.btnApptRefresh.Size = new System.Drawing.Size(133, 39);
            this.btnApptRefresh.TabIndex = 7;
            this.btnApptRefresh.Text = "Refresh";
            this.btnApptRefresh.UseVisualStyleBackColor = true;
            this.btnApptRefresh.Click += new System.EventHandler(this.BtnApptRefresh_Click);
            // 
            // btnApptSchedule
            // 
            this.btnApptSchedule.Location = new System.Drawing.Point(480, 64);
            this.btnApptSchedule.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnApptSchedule.Name = "btnApptSchedule";
            this.btnApptSchedule.Size = new System.Drawing.Size(240, 39);
            this.btnApptSchedule.TabIndex = 6;
            this.btnApptSchedule.Text = "Schedule Appointment";
            this.btnApptSchedule.UseVisualStyleBackColor = true;
            this.btnApptSchedule.Click += new System.EventHandler(this.BtnApptSchedule_Click);
            // 
            // dtpApptDateTime
            // 
            this.dtpApptDateTime.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpApptDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpApptDateTime.Location = new System.Drawing.Point(600, 21);
            this.dtpApptDateTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpApptDateTime.Name = "dtpApptDateTime";
            this.dtpApptDateTime.Size = new System.Drawing.Size(265, 22);
            this.dtpApptDateTime.TabIndex = 5;
            // 
            // lblApptDate
            // 
            this.lblApptDate.AutoSize = true;
            this.lblApptDate.Location = new System.Drawing.Point(480, 25);
            this.lblApptDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApptDate.Name = "lblApptDate";
            this.lblApptDate.Size = new System.Drawing.Size(81, 16);
            this.lblApptDate.TabIndex = 4;
            this.lblApptDate.Text = "Date & Time:*";
            // 
            // cmbApptDoctor
            // 
            this.cmbApptDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbApptDoctor.FormattingEnabled = true;
            this.cmbApptDoctor.Location = new System.Drawing.Point(133, 64);
            this.cmbApptDoctor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbApptDoctor.Name = "cmbApptDoctor";
            this.cmbApptDoctor.Size = new System.Drawing.Size(305, 24);
            this.cmbApptDoctor.TabIndex = 3;
            // 
            // lblApptDoc
            // 
            this.lblApptDoc.AutoSize = true;
            this.lblApptDoc.Location = new System.Drawing.Point(20, 68);
            this.lblApptDoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApptDoc.Name = "lblApptDoc";
            this.lblApptDoc.Size = new System.Drawing.Size(55, 16);
            this.lblApptDoc.TabIndex = 2;
            this.lblApptDoc.Text = "Doctor:*";
            // 
            // cmbApptPatient
            // 
            this.cmbApptPatient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbApptPatient.FormattingEnabled = true;
            this.cmbApptPatient.Location = new System.Drawing.Point(133, 21);
            this.cmbApptPatient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbApptPatient.Name = "cmbApptPatient";
            this.cmbApptPatient.Size = new System.Drawing.Size(305, 24);
            this.cmbApptPatient.TabIndex = 1;
            // 
            // lblApptPat
            // 
            this.lblApptPat.AutoSize = true;
            this.lblApptPat.Location = new System.Drawing.Point(20, 25);
            this.lblApptPat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApptPat.Name = "lblApptPat";
            this.lblApptPat.Size = new System.Drawing.Size(56, 16);
            this.lblApptPat.TabIndex = 0;
            this.lblApptPat.Text = "Patient:*";
            // 
            // tabBilling
            // 
            this.tabBilling.Controls.Add(this.dgvInvoices);
            this.tabBilling.Controls.Add(this.pnlBillInputs);
            this.tabBilling.Location = new System.Drawing.Point(4, 25);
            this.tabBilling.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabBilling.Name = "tabBilling";
            this.tabBilling.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabBilling.Size = new System.Drawing.Size(1379, 820);
            this.tabBilling.TabIndex = 3;
            this.tabBilling.Text = "Billing & Invoices";
            this.tabBilling.UseVisualStyleBackColor = true;
            // 
            // dgvInvoices
            // 
            this.dgvInvoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInvoices.Location = new System.Drawing.Point(4, 213);
            this.dgvInvoices.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.ReadOnly = true;
            this.dgvInvoices.RowHeadersWidth = 51;
            this.dgvInvoices.Size = new System.Drawing.Size(1371, 603);
            this.dgvInvoices.TabIndex = 1;
            // 
            // pnlBillInputs
            // 
            this.pnlBillInputs.Controls.Add(this.btnInvRefresh);
            this.pnlBillInputs.Controls.Add(this.btnInvCreate);
            this.pnlBillInputs.Controls.Add(this.cmbInvPayStatus);
            this.pnlBillInputs.Controls.Add(this.lblInvStatus);
            this.pnlBillInputs.Controls.Add(this.txtInvUnitFee);
            this.pnlBillInputs.Controls.Add(this.lblInvFee);
            this.pnlBillInputs.Controls.Add(this.numInvQty);
            this.pnlBillInputs.Controls.Add(this.lblInvQty);
            this.pnlBillInputs.Controls.Add(this.cmbInvService);
            this.pnlBillInputs.Controls.Add(this.lblInvSvc);
            this.pnlBillInputs.Controls.Add(this.cmbInvAppt);
            this.pnlBillInputs.Controls.Add(this.lblInvAppt);
            this.pnlBillInputs.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBillInputs.Location = new System.Drawing.Point(4, 4);
            this.pnlBillInputs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlBillInputs.Name = "pnlBillInputs";
            this.pnlBillInputs.Size = new System.Drawing.Size(1371, 209);
            this.pnlBillInputs.TabIndex = 0;
            // 
            // btnInvRefresh
            // 
            this.btnInvRefresh.Location = new System.Drawing.Point(600, 80);
            this.btnInvRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInvRefresh.Name = "btnInvRefresh";
            this.btnInvRefresh.Size = new System.Drawing.Size(200, 39);
            this.btnInvRefresh.TabIndex = 11;
            this.btnInvRefresh.Text = "Refresh Invoices";
            this.btnInvRefresh.UseVisualStyleBackColor = true;
            this.btnInvRefresh.Click += new System.EventHandler(this.BtnInvRefresh_Click);
            // 
            // btnInvCreate
            // 
            this.btnInvCreate.Location = new System.Drawing.Point(600, 21);
            this.btnInvCreate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInvCreate.Name = "btnInvCreate";
            this.btnInvCreate.Size = new System.Drawing.Size(200, 49);
            this.btnInvCreate.TabIndex = 10;
            this.btnInvCreate.Text = "Generate Invoice";
            this.btnInvCreate.UseVisualStyleBackColor = true;
            this.btnInvCreate.Click += new System.EventHandler(this.BtnInvCreate_Click);
            // 
            // cmbInvPayStatus
            // 
            this.cmbInvPayStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInvPayStatus.FormattingEnabled = true;
            this.cmbInvPayStatus.Items.AddRange(new object[] {
            "Unpaid",
            "Partially Paid",
            "Paid"});
            this.cmbInvPayStatus.Location = new System.Drawing.Point(160, 150);
            this.cmbInvPayStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbInvPayStatus.Name = "cmbInvPayStatus";
            this.cmbInvPayStatus.Size = new System.Drawing.Size(185, 24);
            this.cmbInvPayStatus.TabIndex = 9;
            // 
            // lblInvStatus
            // 
            this.lblInvStatus.AutoSize = true;
            this.lblInvStatus.Location = new System.Drawing.Point(20, 154);
            this.lblInvStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInvStatus.Name = "lblInvStatus";
            this.lblInvStatus.Size = new System.Drawing.Size(79, 16);
            this.lblInvStatus.TabIndex = 8;
            this.lblInvStatus.Text = "Pay Status:*";
            // 
            // txtInvUnitFee
            // 
            this.txtInvUnitFee.Location = new System.Drawing.Point(387, 107);
            this.txtInvUnitFee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInvUnitFee.Name = "txtInvUnitFee";
            this.txtInvUnitFee.Size = new System.Drawing.Size(172, 22);
            this.txtInvUnitFee.TabIndex = 7;
            // 
            // lblInvFee
            // 
            this.lblInvFee.AutoSize = true;
            this.lblInvFee.Location = new System.Drawing.Point(293, 111);
            this.lblInvFee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInvFee.Name = "lblInvFee";
            this.lblInvFee.Size = new System.Drawing.Size(65, 16);
            this.lblInvFee.TabIndex = 6;
            this.lblInvFee.Text = "Unit Fee:*";
            // 
            // numInvQty
            // 
            this.numInvQty.Location = new System.Drawing.Point(160, 107);
            this.numInvQty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numInvQty.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numInvQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numInvQty.Name = "numInvQty";
            this.numInvQty.Size = new System.Drawing.Size(107, 22);
            this.numInvQty.TabIndex = 5;
            this.numInvQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblInvQty
            // 
            this.lblInvQty.AutoSize = true;
            this.lblInvQty.Location = new System.Drawing.Point(20, 111);
            this.lblInvQty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInvQty.Name = "lblInvQty";
            this.lblInvQty.Size = new System.Drawing.Size(63, 16);
            this.lblInvQty.TabIndex = 4;
            this.lblInvQty.Text = "Quantity:*";
            // 
            // cmbInvService
            // 
            this.cmbInvService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInvService.FormattingEnabled = true;
            this.cmbInvService.Location = new System.Drawing.Point(160, 64);
            this.cmbInvService.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbInvService.Name = "cmbInvService";
            this.cmbInvService.Size = new System.Drawing.Size(399, 24);
            this.cmbInvService.TabIndex = 3;
            this.cmbInvService.SelectedIndexChanged += new System.EventHandler(this.CmbInvService_SelectedIndexChanged);
            // 
            // lblInvSvc
            // 
            this.lblInvSvc.AutoSize = true;
            this.lblInvSvc.Location = new System.Drawing.Point(20, 68);
            this.lblInvSvc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInvSvc.Name = "lblInvSvc";
            this.lblInvSvc.Size = new System.Drawing.Size(61, 16);
            this.lblInvSvc.TabIndex = 2;
            this.lblInvSvc.Text = "Service:*";
            // 
            // cmbInvAppt
            // 
            this.cmbInvAppt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInvAppt.FormattingEnabled = true;
            this.cmbInvAppt.Location = new System.Drawing.Point(160, 21);
            this.cmbInvAppt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbInvAppt.Name = "cmbInvAppt";
            this.cmbInvAppt.Size = new System.Drawing.Size(399, 24);
            this.cmbInvAppt.TabIndex = 1;
            // 
            // lblInvAppt
            // 
            this.lblInvAppt.AutoSize = true;
            this.lblInvAppt.Location = new System.Drawing.Point(20, 25);
            this.lblInvAppt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInvAppt.Name = "lblInvAppt";
            this.lblInvAppt.Size = new System.Drawing.Size(90, 16);
            this.lblInvAppt.TabIndex = 0;
            this.lblInvAppt.Text = "Appointment:*";
            // 
            // tabReports
            // 
            this.tabReports.Controls.Add(this.dgvReport);
            this.tabReports.Controls.Add(this.pnlRepTop);
            this.tabReports.Location = new System.Drawing.Point(4, 25);
            this.tabReports.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabReports.Name = "tabReports";
            this.tabReports.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabReports.Size = new System.Drawing.Size(1379, 820);
            this.tabReports.TabIndex = 4;
            this.tabReports.Text = "Appointment Report";
            this.tabReports.UseVisualStyleBackColor = true;
            // 
            // dgvReport
            // 
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReport.Location = new System.Drawing.Point(4, 66);
            this.dgvReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.RowHeadersWidth = 51;
            this.dgvReport.Size = new System.Drawing.Size(1371, 750);
            this.dgvReport.TabIndex = 1;
            // 
            // pnlRepTop
            // 
            this.pnlRepTop.Controls.Add(this.btnLoadReport);
            this.pnlRepTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRepTop.Location = new System.Drawing.Point(4, 4);
            this.pnlRepTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlRepTop.Name = "pnlRepTop";
            this.pnlRepTop.Size = new System.Drawing.Size(1371, 62);
            this.pnlRepTop.TabIndex = 0;
            // 
            // btnLoadReport
            // 
            this.btnLoadReport.Location = new System.Drawing.Point(25, 17);
            this.btnLoadReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLoadReport.Name = "btnLoadReport";
            this.btnLoadReport.Size = new System.Drawing.Size(267, 37);
            this.btnLoadReport.TabIndex = 0;
            this.btnLoadReport.Text = "Generate / Refresh Report";
            this.btnLoadReport.UseVisualStyleBackColor = true;
            this.btnLoadReport.Click += new System.EventHandler(this.BtnLoadReport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 849);
            this.Controls.Add(this.tabControlMain);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clinic Patient Appointment & Billing System";
            this.tabControlMain.ResumeLayout(false);
            this.tabPatients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            this.pnlPatInputs.ResumeLayout(false);
            this.pnlPatInputs.PerformLayout();
            this.tabDoctors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).EndInit();
            this.pnlDocInputs.ResumeLayout(false);
            this.pnlDocInputs.PerformLayout();
            this.tabAppointments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.pnlApptInputs.ResumeLayout(false);
            this.pnlApptInputs.PerformLayout();
            this.tabBilling.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            this.pnlBillInputs.ResumeLayout(false);
            this.pnlBillInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInvQty)).EndInit();
            this.tabReports.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.pnlRepTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPatients;
        private System.Windows.Forms.DataGridView dgvPatients;
        private System.Windows.Forms.Panel pnlPatInputs;
        private System.Windows.Forms.CheckBox chkShowInactivePatients;
        private System.Windows.Forms.Button btnPatResetSearch;
        private System.Windows.Forms.Button btnPatSearch;
        private System.Windows.Forms.TextBox txtPatSearch;
        private System.Windows.Forms.Label lblPatSearch;
        private System.Windows.Forms.Button btnPatClear;
        private System.Windows.Forms.Button btnPatUpdate;
        private System.Windows.Forms.Button btnPatInsert;
        private System.Windows.Forms.ComboBox cmbPatStatus;
        private System.Windows.Forms.Label lblPatStatus;
        private System.Windows.Forms.TextBox txtPatContact;
        private System.Windows.Forms.Label lblPatContact;
        private System.Windows.Forms.ComboBox cmbPatSex;
        private System.Windows.Forms.Label lblPatSex;
        private System.Windows.Forms.DateTimePicker dtpPatBirth;
        private System.Windows.Forms.Label lblPatBirth;
        private System.Windows.Forms.TextBox txtPatName;
        private System.Windows.Forms.Label lblPatName;
        private System.Windows.Forms.TextBox txtPatNo;
        private System.Windows.Forms.Label lblPatNo;
        private System.Windows.Forms.TextBox txtPatId;
        private System.Windows.Forms.Label lblPatId;
        private System.Windows.Forms.TabPage tabDoctors;
        private System.Windows.Forms.DataGridView dgvDoctors;
        private System.Windows.Forms.Panel pnlDocInputs;
        private System.Windows.Forms.CheckBox chkShowInactiveDoctors;
        private System.Windows.Forms.Button btnDocClear;
        private System.Windows.Forms.Button btnDocUpdate;
        private System.Windows.Forms.Button btnDocInsert;
        private System.Windows.Forms.TextBox txtDocSpec;
        private System.Windows.Forms.Label lblDocSpec;
        private System.Windows.Forms.TextBox txtDocName;
        private System.Windows.Forms.Label lblDocName;
        private System.Windows.Forms.TextBox txtDocLicense;
        private System.Windows.Forms.Label lblDocLicense;
        private System.Windows.Forms.TextBox txtDocId;
        private System.Windows.Forms.Label lblDocId;
        private System.Windows.Forms.TabPage tabAppointments;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.Panel pnlApptInputs;
        private System.Windows.Forms.Button btnApptRefresh;
        private System.Windows.Forms.Button btnApptSchedule;
        private System.Windows.Forms.DateTimePicker dtpApptDateTime;
        private System.Windows.Forms.Label lblApptDate;
        private System.Windows.Forms.ComboBox cmbApptDoctor;
        private System.Windows.Forms.Label lblApptDoc;
        private System.Windows.Forms.ComboBox cmbApptPatient;
        private System.Windows.Forms.Label lblApptPat;
        private System.Windows.Forms.TabPage tabBilling;
        private System.Windows.Forms.DataGridView dgvInvoices;
        private System.Windows.Forms.Panel pnlBillInputs;
        private System.Windows.Forms.Button btnInvRefresh;
        private System.Windows.Forms.Button btnInvCreate;
        private System.Windows.Forms.ComboBox cmbInvPayStatus;
        private System.Windows.Forms.Label lblInvStatus;
        private System.Windows.Forms.TextBox txtInvUnitFee;
        private System.Windows.Forms.Label lblInvFee;
        private System.Windows.Forms.NumericUpDown numInvQty;
        private System.Windows.Forms.Label lblInvQty;
        private System.Windows.Forms.ComboBox cmbInvService;
        private System.Windows.Forms.Label lblInvSvc;
        private System.Windows.Forms.ComboBox cmbInvAppt;
        private System.Windows.Forms.Label lblInvAppt;
        private System.Windows.Forms.TabPage tabReports;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Panel pnlRepTop;
        private System.Windows.Forms.Button btnLoadReport;
    }
}