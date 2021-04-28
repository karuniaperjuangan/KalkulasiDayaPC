
namespace PSUCalculator
{
    partial class Edit_CPU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_CPU));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExecute = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTDPNew = new System.Windows.Forms.Label();
            this.lblNewName = new System.Windows.Forms.Label();
            this.txtNewClock = new System.Windows.Forms.TextBox();
            this.txtNewTDP = new System.Windows.Forms.TextBox();
            this.txtProcName = new System.Windows.Forms.ComboBox();
            this.dBCPUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.computerDBDataSet = new PSUCalculator.ComputerDBDataSet();
            this.dBCPUTableAdapter = new PSUCalculator.ComputerDBDataSetTableAdapters.DBCPUTableAdapter();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dBCPUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(341, 150);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Batal";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(101, 150);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 14;
            this.btnExecute.Text = "Ubah";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Base Clock CPU :";
            // 
            // lblTDPNew
            // 
            this.lblTDPNew.AutoSize = true;
            this.lblTDPNew.Location = new System.Drawing.Point(35, 76);
            this.lblTDPNew.Name = "lblTDPNew";
            this.lblTDPNew.Size = new System.Drawing.Size(60, 13);
            this.lblTDPNew.TabIndex = 12;
            this.lblTDPNew.Text = "TDP CPU :";
            // 
            // lblNewName
            // 
            this.lblNewName.AutoSize = true;
            this.lblNewName.Location = new System.Drawing.Point(29, 41);
            this.lblNewName.Name = "lblNewName";
            this.lblNewName.Size = new System.Drawing.Size(66, 13);
            this.lblNewName.TabIndex = 11;
            this.lblNewName.Text = "Nama CPU :";
            // 
            // txtNewClock
            // 
            this.txtNewClock.Location = new System.Drawing.Point(101, 107);
            this.txtNewClock.Name = "txtNewClock";
            this.txtNewClock.Size = new System.Drawing.Size(315, 20);
            this.txtNewClock.TabIndex = 10;
            // 
            // txtNewTDP
            // 
            this.txtNewTDP.Location = new System.Drawing.Point(101, 73);
            this.txtNewTDP.Name = "txtNewTDP";
            this.txtNewTDP.Size = new System.Drawing.Size(315, 20);
            this.txtNewTDP.TabIndex = 9;
            // 
            // txtProcName
            // 
            this.txtProcName.DataSource = this.dBCPUBindingSource;
            this.txtProcName.DisplayMember = "Name";
            this.txtProcName.FormattingEnabled = true;
            this.txtProcName.Location = new System.Drawing.Point(107, 38);
            this.txtProcName.Name = "txtProcName";
            this.txtProcName.Size = new System.Drawing.Size(309, 21);
            this.txtProcName.TabIndex = 39;
            this.txtProcName.ValueMember = "Id";
            this.txtProcName.SelectedIndexChanged += new System.EventHandler(this.txtProcName_SelectedIndexChanged);
            // 
            // dBCPUBindingSource
            // 
            this.dBCPUBindingSource.DataMember = "DBCPU";
            this.dBCPUBindingSource.DataSource = this.computerDBDataSet;
            // 
            // computerDBDataSet
            // 
            this.computerDBDataSet.DataSetName = "ComputerDBDataSet";
            this.computerDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dBCPUTableAdapter
            // 
            this.dBCPUTableAdapter.ClearBeforeFill = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(217, 150);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 40;
            this.btnDelete.Text = "Hapus";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Edit_CPU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 216);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtProcName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTDPNew);
            this.Controls.Add(this.lblNewName);
            this.Controls.Add(this.txtNewClock);
            this.Controls.Add(this.txtNewTDP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Edit_CPU";
            this.Text = "Edit CPU";
            this.Load += new System.EventHandler(this.Edit_CPU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBCPUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTDPNew;
        private System.Windows.Forms.Label lblNewName;
        private System.Windows.Forms.TextBox txtNewClock;
        private System.Windows.Forms.TextBox txtNewTDP;
        private System.Windows.Forms.ComboBox txtProcName;
        private ComputerDBDataSet computerDBDataSet;
        private System.Windows.Forms.BindingSource dBCPUBindingSource;
        private ComputerDBDataSetTableAdapters.DBCPUTableAdapter dBCPUTableAdapter;
        private System.Windows.Forms.Button btnDelete;
    }
}