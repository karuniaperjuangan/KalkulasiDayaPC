
namespace PSUCalculator
{
    partial class CekProfil
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
            this.txtProfile = new System.Windows.Forms.ComboBox();
            this.dBComputerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.computerDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.computerDBDataSet = new PSUCalculator.ComputerDBDataSet();
            this.lblOwner = new System.Windows.Forms.Label();
            this.dBComputerTableAdapter = new PSUCalculator.ComputerDBDataSetTableAdapters.DBComputerTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMotherboard = new System.Windows.Forms.Label();
            this.lblGPU = new System.Windows.Forms.Label();
            this.lblCPU = new System.Windows.Forms.Label();
            this.lblRAM = new System.Windows.Forms.Label();
            this.lblDrive = new System.Windows.Forms.Label();
            this.lblOwnerName = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnLoadProfile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dBComputerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProfile
            // 
            this.txtProfile.DataSource = this.dBComputerBindingSource;
            this.txtProfile.DisplayMember = "OwnerName";
            this.txtProfile.FormattingEnabled = true;
            this.txtProfile.Location = new System.Drawing.Point(23, 31);
            this.txtProfile.Name = "txtProfile";
            this.txtProfile.Size = new System.Drawing.Size(183, 21);
            this.txtProfile.TabIndex = 0;
            this.txtProfile.ValueMember = "Id";
            this.txtProfile.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dBComputerBindingSource
            // 
            this.dBComputerBindingSource.DataMember = "DBComputer";
            this.dBComputerBindingSource.DataSource = this.computerDBDataSetBindingSource;
            // 
            // computerDBDataSetBindingSource
            // 
            this.computerDBDataSetBindingSource.DataSource = this.computerDBDataSet;
            this.computerDBDataSetBindingSource.Position = 0;
            // 
            // computerDBDataSet
            // 
            this.computerDBDataSet.DataSetName = "ComputerDBDataSet";
            this.computerDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Location = new System.Drawing.Point(20, 9);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(61, 13);
            this.lblOwner.TabIndex = 45;
            this.lblOwner.Text = "Nama Profil";
            // 
            // dBComputerTableAdapter
            // 
            this.dBComputerTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Nama :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Ukuran Motherboard :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Nama GPU :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Nama CPU :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Besar RAM :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Jumlah SSD/HDD :";
            // 
            // lblMotherboard
            // 
            this.lblMotherboard.AutoSize = true;
            this.lblMotherboard.Location = new System.Drawing.Point(138, 97);
            this.lblMotherboard.Name = "lblMotherboard";
            this.lblMotherboard.Size = new System.Drawing.Size(13, 13);
            this.lblMotherboard.TabIndex = 52;
            this.lblMotherboard.Text = "_";
            // 
            // lblGPU
            // 
            this.lblGPU.AutoSize = true;
            this.lblGPU.Location = new System.Drawing.Point(138, 125);
            this.lblGPU.Name = "lblGPU";
            this.lblGPU.Size = new System.Drawing.Size(13, 13);
            this.lblGPU.TabIndex = 53;
            this.lblGPU.Text = "_";
            this.lblGPU.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Location = new System.Drawing.Point(138, 154);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(13, 13);
            this.lblCPU.TabIndex = 54;
            this.lblCPU.Text = "_";
            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.Location = new System.Drawing.Point(138, 182);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(13, 13);
            this.lblRAM.TabIndex = 55;
            this.lblRAM.Text = "_";
            // 
            // lblDrive
            // 
            this.lblDrive.AutoSize = true;
            this.lblDrive.Location = new System.Drawing.Point(138, 211);
            this.lblDrive.Name = "lblDrive";
            this.lblDrive.Size = new System.Drawing.Size(13, 13);
            this.lblDrive.TabIndex = 56;
            this.lblDrive.Text = "_";
            // 
            // lblOwnerName
            // 
            this.lblOwnerName.AutoSize = true;
            this.lblOwnerName.Location = new System.Drawing.Point(138, 70);
            this.lblOwnerName.Name = "lblOwnerName";
            this.lblOwnerName.Size = new System.Drawing.Size(13, 13);
            this.lblOwnerName.TabIndex = 57;
            this.lblOwnerName.Text = "_";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(215, 264);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 58;
            this.btnDelete.Text = "Hapus";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnLoadProfile
            // 
            this.btnLoadProfile.Location = new System.Drawing.Point(12, 264);
            this.btnLoadProfile.Name = "btnLoadProfile";
            this.btnLoadProfile.Size = new System.Drawing.Size(75, 23);
            this.btnLoadProfile.TabIndex = 59;
            this.btnLoadProfile.Text = "Ambil Profil";
            this.btnLoadProfile.UseVisualStyleBackColor = true;
            this.btnLoadProfile.Click += new System.EventHandler(this.button1_Click);
            // 
            // CekProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 299);
            this.Controls.Add(this.btnLoadProfile);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblOwnerName);
            this.Controls.Add(this.lblDrive);
            this.Controls.Add(this.lblRAM);
            this.Controls.Add(this.lblCPU);
            this.Controls.Add(this.lblGPU);
            this.Controls.Add(this.lblMotherboard);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOwner);
            this.Controls.Add(this.txtProfile);
            this.Name = "CekProfil";
            this.Text = "Cek Profil";
            this.Load += new System.EventHandler(this.CekProfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBComputerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtProfile;
        private System.Windows.Forms.BindingSource computerDBDataSetBindingSource;
        private ComputerDBDataSet computerDBDataSet;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.BindingSource dBComputerBindingSource;
        private ComputerDBDataSetTableAdapters.DBComputerTableAdapter dBComputerTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMotherboard;
        private System.Windows.Forms.Label lblGPU;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.Label lblDrive;
        private System.Windows.Forms.Label lblOwnerName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLoadProfile;
    }
}