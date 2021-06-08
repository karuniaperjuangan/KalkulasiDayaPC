
namespace PSUCalculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAddMobo = new System.Windows.Forms.Button();
            this.lblMotherboard = new System.Windows.Forms.Label();
            this.boxMoboSize = new System.Windows.Forms.ComboBox();
            this.lblProName = new System.Windows.Forms.Label();
            this.btnAddProcessor = new System.Windows.Forms.Button();
            this.lblProClock = new System.Windows.Forms.Label();
            this.txtProcClock = new System.Windows.Forms.TextBox();
            this.lblGPUName = new System.Windows.Forms.Label();
            this.txtProcTDP = new System.Windows.Forms.TextBox();
            this.lblProTDP = new System.Windows.Forms.Label();
            this.txtGPUTDP = new System.Windows.Forms.TextBox();
            this.lblGPUTDP = new System.Windows.Forms.Label();
            this.txtGPUClock = new System.Windows.Forms.TextBox();
            this.lblGPUClock = new System.Windows.Forms.Label();
            this.btnAddGPU = new System.Windows.Forms.Button();
            this.lblRAM = new System.Windows.Forms.Label();
            this.btnAddRAM = new System.Windows.Forms.Button();
            this.txtRAMSize = new System.Windows.Forms.TextBox();
            this.lblDrive = new System.Windows.Forms.Label();
            this.txtDriveSlot = new System.Windows.Forms.TextBox();
            this.btnAddDrive = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.boxPSURating = new System.Windows.Forms.ComboBox();
            this.lblPSURating = new System.Windows.Forms.Label();
            this.lblDailyUsage = new System.Windows.Forms.Label();
            this.txtDailyUsage = new System.Windows.Forms.TextBox();
            this.btnSetPSU = new System.Windows.Forms.Button();
            this.btnSetDailyUsage = new System.Windows.Forms.Button();
            this.lblMain = new System.Windows.Forms.Label();
            this.lblProBoostClock = new System.Windows.Forms.Label();
            this.lblGPUBoostClock = new System.Windows.Forms.Label();
            this.txtProBoostClock = new System.Windows.Forms.TextBox();
            this.txtGPUBoostClock = new System.Windows.Forms.TextBox();
            this.btnOCPro = new System.Windows.Forms.Button();
            this.btnOCGPU = new System.Windows.Forms.Button();
            this.txtGPUName = new System.Windows.Forms.ComboBox();
            this.dBGPUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.computerDBDataSet = new PSUCalculator.ComputerDBDataSet();
            this.dBGPUTableAdapter = new PSUCalculator.ComputerDBDataSetTableAdapters.DBGPUTableAdapter();
            this.txtProcName = new System.Windows.Forms.ComboBox();
            this.dBCPUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBCPUTableAdapter = new PSUCalculator.ComputerDBDataSetTableAdapters.DBCPUTableAdapter();
            this.lblEditProc = new System.Windows.Forms.LinkLabel();
            this.lblEditGPU = new System.Windows.Forms.LinkLabel();
            this.lblAddProc = new System.Windows.Forms.LinkLabel();
            this.lblAddGPU = new System.Windows.Forms.LinkLabel();
            this.lblReset = new System.Windows.Forms.LinkLabel();
            this.lblOwner = new System.Windows.Forms.Label();
            this.txtOwnerName = new System.Windows.Forms.TextBox();
            this.btnSaveProfile = new System.Windows.Forms.Button();
            this.btnProfileCheck = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dBGPUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCPUBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddMobo
            // 
            this.btnAddMobo.Location = new System.Drawing.Point(178, 87);
            this.btnAddMobo.Name = "btnAddMobo";
            this.btnAddMobo.Size = new System.Drawing.Size(75, 23);
            this.btnAddMobo.TabIndex = 0;
            this.btnAddMobo.Text = "Tambahkan";
            this.btnAddMobo.UseVisualStyleBackColor = true;
            this.btnAddMobo.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblMotherboard
            // 
            this.lblMotherboard.AutoSize = true;
            this.lblMotherboard.Location = new System.Drawing.Point(34, 63);
            this.lblMotherboard.Name = "lblMotherboard";
            this.lblMotherboard.Size = new System.Drawing.Size(172, 13);
            this.lblMotherboard.TabIndex = 1;
            this.lblMotherboard.Text = "Masukkan Ukuran Motherboardmu";
            this.lblMotherboard.Click += new System.EventHandler(this.label1_Click);
            // 
            // boxMoboSize
            // 
            this.boxMoboSize.FormattingEnabled = true;
            this.boxMoboSize.Items.AddRange(new object[] {
            "Micro-ATX",
            "Mini-ITX",
            "ATX",
            "XLATX"});
            this.boxMoboSize.Location = new System.Drawing.Point(37, 89);
            this.boxMoboSize.Name = "boxMoboSize";
            this.boxMoboSize.Size = new System.Drawing.Size(121, 21);
            this.boxMoboSize.TabIndex = 2;
            this.boxMoboSize.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblProName
            // 
            this.lblProName.AutoSize = true;
            this.lblProName.Location = new System.Drawing.Point(34, 128);
            this.lblProName.Name = "lblProName";
            this.lblProName.Size = new System.Drawing.Size(117, 13);
            this.lblProName.TabIndex = 3;
            this.lblProName.Text = "Apa Prosesor/CPUmu?";
            this.lblProName.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnAddProcessor
            // 
            this.btnAddProcessor.Location = new System.Drawing.Point(520, 152);
            this.btnAddProcessor.Name = "btnAddProcessor";
            this.btnAddProcessor.Size = new System.Drawing.Size(75, 23);
            this.btnAddProcessor.TabIndex = 5;
            this.btnAddProcessor.Text = "Tambahkan";
            this.btnAddProcessor.UseVisualStyleBackColor = true;
            this.btnAddProcessor.Click += new System.EventHandler(this.btnAddProcessor_Click);
            // 
            // lblProClock
            // 
            this.lblProClock.AutoSize = true;
            this.lblProClock.Location = new System.Drawing.Point(435, 128);
            this.lblProClock.Name = "lblProClock";
            this.lblProClock.Size = new System.Drawing.Size(88, 13);
            this.lblProClock.TabIndex = 6;
            this.lblProClock.Text = "Baseclock (MHz)";
            this.lblProClock.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtProcClock
            // 
            this.txtProcClock.Location = new System.Drawing.Point(438, 155);
            this.txtProcClock.Name = "txtProcClock";
            this.txtProcClock.ReadOnly = true;
            this.txtProcClock.Size = new System.Drawing.Size(75, 20);
            this.txtProcClock.TabIndex = 7;
            // 
            // lblGPUName
            // 
            this.lblGPUName.AutoSize = true;
            this.lblGPUName.Location = new System.Drawing.Point(34, 191);
            this.lblGPUName.Name = "lblGPUName";
            this.lblGPUName.Size = new System.Drawing.Size(75, 13);
            this.lblGPUName.TabIndex = 8;
            this.lblGPUName.Text = "Apa GPU mu?";
            // 
            // txtProcTDP
            // 
            this.txtProcTDP.Location = new System.Drawing.Point(308, 154);
            this.txtProcTDP.Name = "txtProcTDP";
            this.txtProcTDP.ReadOnly = true;
            this.txtProcTDP.Size = new System.Drawing.Size(121, 20);
            this.txtProcTDP.TabIndex = 10;
            this.txtProcTDP.TextChanged += new System.EventHandler(this.txtProcTDP_TextChanged);
            // 
            // lblProTDP
            // 
            this.lblProTDP.AutoSize = true;
            this.lblProTDP.Location = new System.Drawing.Point(305, 128);
            this.lblProTDP.Name = "lblProTDP";
            this.lblProTDP.Size = new System.Drawing.Size(61, 13);
            this.lblProTDP.TabIndex = 9;
            this.lblProTDP.Text = "TDP (Watt)";
            // 
            // txtGPUTDP
            // 
            this.txtGPUTDP.Location = new System.Drawing.Point(308, 218);
            this.txtGPUTDP.Name = "txtGPUTDP";
            this.txtGPUTDP.ReadOnly = true;
            this.txtGPUTDP.Size = new System.Drawing.Size(121, 20);
            this.txtGPUTDP.TabIndex = 16;
            // 
            // lblGPUTDP
            // 
            this.lblGPUTDP.AutoSize = true;
            this.lblGPUTDP.Location = new System.Drawing.Point(305, 192);
            this.lblGPUTDP.Name = "lblGPUTDP";
            this.lblGPUTDP.Size = new System.Drawing.Size(61, 13);
            this.lblGPUTDP.TabIndex = 15;
            this.lblGPUTDP.Text = "TDP (Watt)";
            // 
            // txtGPUClock
            // 
            this.txtGPUClock.Location = new System.Drawing.Point(438, 219);
            this.txtGPUClock.Name = "txtGPUClock";
            this.txtGPUClock.ReadOnly = true;
            this.txtGPUClock.Size = new System.Drawing.Size(75, 20);
            this.txtGPUClock.TabIndex = 14;
            // 
            // lblGPUClock
            // 
            this.lblGPUClock.AutoSize = true;
            this.lblGPUClock.Location = new System.Drawing.Point(435, 192);
            this.lblGPUClock.Name = "lblGPUClock";
            this.lblGPUClock.Size = new System.Drawing.Size(88, 13);
            this.lblGPUClock.TabIndex = 13;
            this.lblGPUClock.Text = "Baseclock (MHz)";
            // 
            // btnAddGPU
            // 
            this.btnAddGPU.Location = new System.Drawing.Point(520, 216);
            this.btnAddGPU.Name = "btnAddGPU";
            this.btnAddGPU.Size = new System.Drawing.Size(75, 23);
            this.btnAddGPU.TabIndex = 12;
            this.btnAddGPU.Text = "Tambahkan";
            this.btnAddGPU.UseVisualStyleBackColor = true;
            this.btnAddGPU.Click += new System.EventHandler(this.btnAddGPU_Click);
            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.Location = new System.Drawing.Point(34, 253);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(99, 13);
            this.lblRAM.TabIndex = 17;
            this.lblRAM.Text = "Ukuran RAM? (GB)";
            this.lblRAM.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnAddRAM
            // 
            this.btnAddRAM.Location = new System.Drawing.Point(178, 277);
            this.btnAddRAM.Name = "btnAddRAM";
            this.btnAddRAM.Size = new System.Drawing.Size(75, 23);
            this.btnAddRAM.TabIndex = 19;
            this.btnAddRAM.Text = "Tambahkan";
            this.btnAddRAM.UseVisualStyleBackColor = true;
            this.btnAddRAM.Click += new System.EventHandler(this.btnAddRAM_Click);
            // 
            // txtRAMSize
            // 
            this.txtRAMSize.Location = new System.Drawing.Point(37, 279);
            this.txtRAMSize.Name = "txtRAMSize";
            this.txtRAMSize.Size = new System.Drawing.Size(121, 20);
            this.txtRAMSize.TabIndex = 18;
            this.txtRAMSize.TextChanged += new System.EventHandler(this.txtRAMSize_TextChanged);
            // 
            // lblDrive
            // 
            this.lblDrive.AutoSize = true;
            this.lblDrive.Location = new System.Drawing.Point(34, 322);
            this.lblDrive.Name = "lblDrive";
            this.lblDrive.Size = new System.Drawing.Size(207, 13);
            this.lblDrive.TabIndex = 20;
            this.lblDrive.Text = "Jumlah Slot HDD dan SSD yang terpakai?";
            // 
            // txtDriveSlot
            // 
            this.txtDriveSlot.Location = new System.Drawing.Point(37, 352);
            this.txtDriveSlot.Name = "txtDriveSlot";
            this.txtDriveSlot.Size = new System.Drawing.Size(121, 20);
            this.txtDriveSlot.TabIndex = 21;
            // 
            // btnAddDrive
            // 
            this.btnAddDrive.Location = new System.Drawing.Point(178, 350);
            this.btnAddDrive.Name = "btnAddDrive";
            this.btnAddDrive.Size = new System.Drawing.Size(75, 23);
            this.btnAddDrive.TabIndex = 22;
            this.btnAddDrive.Text = "Tambahkan";
            this.btnAddDrive.UseVisualStyleBackColor = true;
            this.btnAddDrive.Click += new System.EventHandler(this.btnAddDrive_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(582, 421);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(166, 51);
            this.btnCalculate.TabIndex = 23;
            this.btnCalculate.Text = "Hitung";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.button4_Click);
            // 
            // boxPSURating
            // 
            this.boxPSURating.FormattingEnabled = true;
            this.boxPSURating.Items.AddRange(new object[] {
            "Bronze",
            "Silver",
            "Gold",
            "Platinum",
            "Titanium"});
            this.boxPSURating.Location = new System.Drawing.Point(582, 324);
            this.boxPSURating.Name = "boxPSURating";
            this.boxPSURating.Size = new System.Drawing.Size(121, 21);
            this.boxPSURating.TabIndex = 24;
            this.boxPSURating.SelectedIndexChanged += new System.EventHandler(this.boxPSURating_SelectedIndexChanged);
            // 
            // lblPSURating
            // 
            this.lblPSURating.AutoSize = true;
            this.lblPSURating.Location = new System.Drawing.Point(579, 293);
            this.lblPSURating.Name = "lblPSURating";
            this.lblPSURating.Size = new System.Drawing.Size(146, 26);
            this.lblPSURating.TabIndex = 25;
            this.lblPSURating.Text = "Rating PSU yang diinginkan?\r\n(Untuk Efisiensi)";
            this.lblPSURating.Click += new System.EventHandler(this.label8_Click_1);
            // 
            // lblDailyUsage
            // 
            this.lblDailyUsage.AutoSize = true;
            this.lblDailyUsage.Location = new System.Drawing.Point(579, 360);
            this.lblDailyUsage.Name = "lblDailyUsage";
            this.lblDailyUsage.Size = new System.Drawing.Size(153, 13);
            this.lblDailyUsage.TabIndex = 26;
            this.lblDailyUsage.Text = "Penggunaan Harian PC? (Jam)";
            // 
            // txtDailyUsage
            // 
            this.txtDailyUsage.Location = new System.Drawing.Point(582, 382);
            this.txtDailyUsage.Name = "txtDailyUsage";
            this.txtDailyUsage.Size = new System.Drawing.Size(121, 20);
            this.txtDailyUsage.TabIndex = 27;
            // 
            // btnSetPSU
            // 
            this.btnSetPSU.Location = new System.Drawing.Point(718, 322);
            this.btnSetPSU.Name = "btnSetPSU";
            this.btnSetPSU.Size = new System.Drawing.Size(43, 23);
            this.btnSetPSU.TabIndex = 28;
            this.btnSetPSU.Text = "Set";
            this.btnSetPSU.UseVisualStyleBackColor = true;
            this.btnSetPSU.Click += new System.EventHandler(this.btnSetPSU_Click);
            // 
            // btnSetDailyUsage
            // 
            this.btnSetDailyUsage.Location = new System.Drawing.Point(718, 381);
            this.btnSetDailyUsage.Name = "btnSetDailyUsage";
            this.btnSetDailyUsage.Size = new System.Drawing.Size(43, 23);
            this.btnSetDailyUsage.TabIndex = 29;
            this.btnSetDailyUsage.Text = "Set";
            this.btnSetDailyUsage.UseVisualStyleBackColor = true;
            this.btnSetDailyUsage.Click += new System.EventHandler(this.btnSetDailyUsage_Click);
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.Location = new System.Drawing.Point(34, 26);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(468, 15);
            this.lblMain.TabIndex = 30;
            this.lblMain.Text = "Jangan lupa menekan tombol Tambahkan dan Set sebelum menghitung";
            // 
            // lblProBoostClock
            // 
            this.lblProBoostClock.AutoSize = true;
            this.lblProBoostClock.Location = new System.Drawing.Point(604, 129);
            this.lblProBoostClock.Name = "lblProBoostClock";
            this.lblProBoostClock.Size = new System.Drawing.Size(178, 13);
            this.lblProBoostClock.TabIndex = 31;
            this.lblProBoostClock.Text = "Overclock/Underclock CPU? (MHz)";
            this.lblProBoostClock.Click += new System.EventHandler(this.label11_Click);
            // 
            // lblGPUBoostClock
            // 
            this.lblGPUBoostClock.AutoSize = true;
            this.lblGPUBoostClock.Location = new System.Drawing.Point(604, 192);
            this.lblGPUBoostClock.Name = "lblGPUBoostClock";
            this.lblGPUBoostClock.Size = new System.Drawing.Size(179, 13);
            this.lblGPUBoostClock.TabIndex = 32;
            this.lblGPUBoostClock.Text = "Overclock/Underclock GPU? (MHz)";
            this.lblGPUBoostClock.Click += new System.EventHandler(this.label12_Click);
            // 
            // txtProBoostClock
            // 
            this.txtProBoostClock.Location = new System.Drawing.Point(607, 155);
            this.txtProBoostClock.Name = "txtProBoostClock";
            this.txtProBoostClock.Size = new System.Drawing.Size(113, 20);
            this.txtProBoostClock.TabIndex = 33;
            // 
            // txtGPUBoostClock
            // 
            this.txtGPUBoostClock.Location = new System.Drawing.Point(607, 216);
            this.txtGPUBoostClock.Name = "txtGPUBoostClock";
            this.txtGPUBoostClock.Size = new System.Drawing.Size(113, 20);
            this.txtGPUBoostClock.TabIndex = 34;
            // 
            // btnOCPro
            // 
            this.btnOCPro.Enabled = false;
            this.btnOCPro.Location = new System.Drawing.Point(726, 152);
            this.btnOCPro.Name = "btnOCPro";
            this.btnOCPro.Size = new System.Drawing.Size(50, 23);
            this.btnOCPro.TabIndex = 35;
            this.btnOCPro.Text = "OC/UC";
            this.btnOCPro.UseVisualStyleBackColor = true;
            this.btnOCPro.Click += new System.EventHandler(this.btnOCPro_Click);
            // 
            // btnOCGPU
            // 
            this.btnOCGPU.Enabled = false;
            this.btnOCGPU.Location = new System.Drawing.Point(726, 215);
            this.btnOCGPU.Name = "btnOCGPU";
            this.btnOCGPU.Size = new System.Drawing.Size(50, 23);
            this.btnOCGPU.TabIndex = 36;
            this.btnOCGPU.Text = "OC/UC";
            this.btnOCGPU.UseVisualStyleBackColor = true;
            this.btnOCGPU.Click += new System.EventHandler(this.btnOCGPU_Click);
            // 
            // txtGPUName
            // 
            this.txtGPUName.DataSource = this.dBGPUBindingSource;
            this.txtGPUName.DisplayMember = "Name";
            this.txtGPUName.FormattingEnabled = true;
            this.txtGPUName.Location = new System.Drawing.Point(37, 215);
            this.txtGPUName.Name = "txtGPUName";
            this.txtGPUName.Size = new System.Drawing.Size(254, 21);
            this.txtGPUName.TabIndex = 37;
            this.txtGPUName.ValueMember = "Id";
            this.txtGPUName.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // dBGPUBindingSource
            // 
            this.dBGPUBindingSource.DataMember = "DBGPU";
            this.dBGPUBindingSource.DataSource = this.computerDBDataSet;
            // 
            // computerDBDataSet
            // 
            this.computerDBDataSet.DataSetName = "ComputerDBDataSet";
            this.computerDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dBGPUTableAdapter
            // 
            this.dBGPUTableAdapter.ClearBeforeFill = true;
            // 
            // txtProcName
            // 
            this.txtProcName.DataSource = this.dBCPUBindingSource;
            this.txtProcName.DisplayMember = "Name";
            this.txtProcName.FormattingEnabled = true;
            this.txtProcName.Location = new System.Drawing.Point(37, 153);
            this.txtProcName.Name = "txtProcName";
            this.txtProcName.Size = new System.Drawing.Size(254, 21);
            this.txtProcName.TabIndex = 38;
            this.txtProcName.ValueMember = "Id";
            this.txtProcName.SelectedIndexChanged += new System.EventHandler(this.txtProcName_SelectedIndexChanged);
            // 
            // dBCPUBindingSource
            // 
            this.dBCPUBindingSource.DataMember = "DBCPU";
            this.dBCPUBindingSource.DataSource = this.computerDBDataSet;
            // 
            // dBCPUTableAdapter
            // 
            this.dBCPUTableAdapter.ClearBeforeFill = true;
            // 
            // lblEditProc
            // 
            this.lblEditProc.AutoSize = true;
            this.lblEditProc.Location = new System.Drawing.Point(189, 129);
            this.lblEditProc.Name = "lblEditProc";
            this.lblEditProc.Size = new System.Drawing.Size(25, 13);
            this.lblEditProc.TabIndex = 39;
            this.lblEditProc.TabStop = true;
            this.lblEditProc.Text = "Edit";
            this.lblEditProc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblEditGPU
            // 
            this.lblEditGPU.AutoSize = true;
            this.lblEditGPU.Location = new System.Drawing.Point(147, 192);
            this.lblEditGPU.Name = "lblEditGPU";
            this.lblEditGPU.Size = new System.Drawing.Size(25, 13);
            this.lblEditGPU.TabIndex = 40;
            this.lblEditGPU.TabStop = true;
            this.lblEditGPU.Text = "Edit";
            this.lblEditGPU.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblEditGPU_LinkClicked);
            // 
            // lblAddProc
            // 
            this.lblAddProc.AutoSize = true;
            this.lblAddProc.Location = new System.Drawing.Point(157, 129);
            this.lblAddProc.Name = "lblAddProc";
            this.lblAddProc.Size = new System.Drawing.Size(26, 13);
            this.lblAddProc.TabIndex = 41;
            this.lblAddProc.TabStop = true;
            this.lblAddProc.Text = "Add";
            this.lblAddProc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAddProc_LinkClicked);
            // 
            // lblAddGPU
            // 
            this.lblAddGPU.AutoSize = true;
            this.lblAddGPU.Location = new System.Drawing.Point(115, 191);
            this.lblAddGPU.Name = "lblAddGPU";
            this.lblAddGPU.Size = new System.Drawing.Size(26, 13);
            this.lblAddGPU.TabIndex = 42;
            this.lblAddGPU.TabStop = true;
            this.lblAddGPU.Text = "Add";
            this.lblAddGPU.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAddGPU_LinkClicked);
            // 
            // lblReset
            // 
            this.lblReset.AutoSize = true;
            this.lblReset.Location = new System.Drawing.Point(27, 548);
            this.lblReset.Name = "lblReset";
            this.lblReset.Size = new System.Drawing.Size(346, 13);
            this.lblReset.TabIndex = 43;
            this.lblReset.TabStop = true;
            this.lblReset.Text = "Reset (Lakukan setiap penambahan dan penghapusan CPU atau GPU)";
            this.lblReset.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblReset_LinkClicked);
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Location = new System.Drawing.Point(27, 440);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(61, 13);
            this.lblOwner.TabIndex = 44;
            this.lblOwner.Text = "Nama Profil";
            // 
            // txtOwnerName
            // 
            this.txtOwnerName.Location = new System.Drawing.Point(30, 465);
            this.txtOwnerName.Name = "txtOwnerName";
            this.txtOwnerName.Size = new System.Drawing.Size(121, 20);
            this.txtOwnerName.TabIndex = 45;
            this.txtOwnerName.TextChanged += new System.EventHandler(this.txtOwnerName_TextChanged);
            // 
            // btnSaveProfile
            // 
            this.btnSaveProfile.Location = new System.Drawing.Point(166, 465);
            this.btnSaveProfile.Name = "btnSaveProfile";
            this.btnSaveProfile.Size = new System.Drawing.Size(75, 23);
            this.btnSaveProfile.TabIndex = 46;
            this.btnSaveProfile.Text = "Save PC";
            this.btnSaveProfile.UseVisualStyleBackColor = true;
            this.btnSaveProfile.Click += new System.EventHandler(this.btnSaveProfile_Click);
            // 
            // btnProfileCheck
            // 
            this.btnProfileCheck.Location = new System.Drawing.Point(30, 504);
            this.btnProfileCheck.Name = "btnProfileCheck";
            this.btnProfileCheck.Size = new System.Drawing.Size(75, 23);
            this.btnProfileCheck.TabIndex = 47;
            this.btnProfileCheck.Text = "Lihat Profil";
            this.btnProfileCheck.UseVisualStyleBackColor = true;
            this.btnProfileCheck.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 570);
            this.Controls.Add(this.btnProfileCheck);
            this.Controls.Add(this.btnSaveProfile);
            this.Controls.Add(this.txtOwnerName);
            this.Controls.Add(this.lblOwner);
            this.Controls.Add(this.lblReset);
            this.Controls.Add(this.lblAddGPU);
            this.Controls.Add(this.lblAddProc);
            this.Controls.Add(this.lblEditGPU);
            this.Controls.Add(this.lblEditProc);
            this.Controls.Add(this.txtProcName);
            this.Controls.Add(this.txtGPUName);
            this.Controls.Add(this.btnOCGPU);
            this.Controls.Add(this.btnOCPro);
            this.Controls.Add(this.txtGPUBoostClock);
            this.Controls.Add(this.txtProBoostClock);
            this.Controls.Add(this.lblGPUBoostClock);
            this.Controls.Add(this.lblProBoostClock);
            this.Controls.Add(this.lblMain);
            this.Controls.Add(this.btnSetDailyUsage);
            this.Controls.Add(this.btnSetPSU);
            this.Controls.Add(this.txtDailyUsage);
            this.Controls.Add(this.lblDailyUsage);
            this.Controls.Add(this.lblPSURating);
            this.Controls.Add(this.boxPSURating);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnAddDrive);
            this.Controls.Add(this.txtDriveSlot);
            this.Controls.Add(this.lblDrive);
            this.Controls.Add(this.btnAddRAM);
            this.Controls.Add(this.txtRAMSize);
            this.Controls.Add(this.lblRAM);
            this.Controls.Add(this.txtGPUTDP);
            this.Controls.Add(this.lblGPUTDP);
            this.Controls.Add(this.txtGPUClock);
            this.Controls.Add(this.lblGPUClock);
            this.Controls.Add(this.btnAddGPU);
            this.Controls.Add(this.txtProcTDP);
            this.Controls.Add(this.lblProTDP);
            this.Controls.Add(this.lblGPUName);
            this.Controls.Add(this.txtProcClock);
            this.Controls.Add(this.lblProClock);
            this.Controls.Add(this.btnAddProcessor);
            this.Controls.Add(this.lblProName);
            this.Controls.Add(this.boxMoboSize);
            this.Controls.Add(this.lblMotherboard);
            this.Controls.Add(this.btnAddMobo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Penghitung Daya PC";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBGPUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCPUBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddMobo;
        private System.Windows.Forms.Label lblMotherboard;
        private System.Windows.Forms.ComboBox boxMoboSize;
        private System.Windows.Forms.Label lblProName;
        private System.Windows.Forms.Button btnAddProcessor;
        private System.Windows.Forms.Label lblProClock;
        private System.Windows.Forms.TextBox txtProcClock;
        private System.Windows.Forms.Label lblGPUName;
        private System.Windows.Forms.TextBox txtProcTDP;
        private System.Windows.Forms.Label lblProTDP;
        private System.Windows.Forms.TextBox txtGPUTDP;
        private System.Windows.Forms.Label lblGPUTDP;
        private System.Windows.Forms.TextBox txtGPUClock;
        private System.Windows.Forms.Label lblGPUClock;
        private System.Windows.Forms.Button btnAddGPU;
        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.Button btnAddRAM;
        private System.Windows.Forms.TextBox txtRAMSize;
        private System.Windows.Forms.Label lblDrive;
        private System.Windows.Forms.TextBox txtDriveSlot;
        private System.Windows.Forms.Button btnAddDrive;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ComboBox boxPSURating;
        private System.Windows.Forms.Label lblPSURating;
        private System.Windows.Forms.Label lblDailyUsage;
        private System.Windows.Forms.TextBox txtDailyUsage;
        private System.Windows.Forms.Button btnSetPSU;
        private System.Windows.Forms.Button btnSetDailyUsage;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Label lblProBoostClock;
        private System.Windows.Forms.Label lblGPUBoostClock;
        private System.Windows.Forms.TextBox txtProBoostClock;
        private System.Windows.Forms.TextBox txtGPUBoostClock;
        private System.Windows.Forms.Button btnOCPro;
        private System.Windows.Forms.Button btnOCGPU;
        private System.Windows.Forms.ComboBox txtGPUName;
        private ComputerDBDataSet computerDBDataSet;
        private System.Windows.Forms.BindingSource dBGPUBindingSource;
        private ComputerDBDataSetTableAdapters.DBGPUTableAdapter dBGPUTableAdapter;
        private System.Windows.Forms.ComboBox txtProcName;
        private System.Windows.Forms.BindingSource dBCPUBindingSource;
        private ComputerDBDataSetTableAdapters.DBCPUTableAdapter dBCPUTableAdapter;
        private System.Windows.Forms.LinkLabel lblEditProc;
        private System.Windows.Forms.LinkLabel lblEditGPU;
        private System.Windows.Forms.LinkLabel lblAddProc;
        private System.Windows.Forms.LinkLabel lblAddGPU;
        private System.Windows.Forms.LinkLabel lblReset;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.TextBox txtOwnerName;
        private System.Windows.Forms.Button btnSaveProfile;
        private System.Windows.Forms.Button btnProfileCheck;
    }
}

