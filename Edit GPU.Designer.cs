
namespace PSUCalculator
{
    partial class Edit_GPU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_GPU));
            this.txtGPUName = new System.Windows.Forms.ComboBox();
            this.dBGPUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.computerDBDataSet = new PSUCalculator.ComputerDBDataSet();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExecute = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTDPNew = new System.Windows.Forms.Label();
            this.lblNewName = new System.Windows.Forms.Label();
            this.txtNewClock = new System.Windows.Forms.TextBox();
            this.txtNewTDP = new System.Windows.Forms.TextBox();
            this.dBGPUTableAdapter = new PSUCalculator.ComputerDBDataSetTableAdapters.DBGPUTableAdapter();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dBGPUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGPUName
            // 
            this.txtGPUName.DataSource = this.dBGPUBindingSource;
            this.txtGPUName.DisplayMember = "Name";
            this.txtGPUName.FormattingEnabled = true;
            this.txtGPUName.Location = new System.Drawing.Point(144, 39);
            this.txtGPUName.Name = "txtGPUName";
            this.txtGPUName.Size = new System.Drawing.Size(309, 21);
            this.txtGPUName.TabIndex = 47;
            this.txtGPUName.ValueMember = "Id";
            this.txtGPUName.SelectedIndexChanged += new System.EventHandler(this.txtGPUName_SelectedIndexChanged);
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
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(378, 151);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 46;
            this.btnCancel.Text = "Batal";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(144, 151);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 45;
            this.btnExecute.Text = "Ubah";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Base Clock GPU :";
            // 
            // lblTDPNew
            // 
            this.lblTDPNew.AutoSize = true;
            this.lblTDPNew.Location = new System.Drawing.Point(72, 77);
            this.lblTDPNew.Name = "lblTDPNew";
            this.lblTDPNew.Size = new System.Drawing.Size(61, 13);
            this.lblTDPNew.TabIndex = 43;
            this.lblTDPNew.Text = "TDP GPU :";
            // 
            // lblNewName
            // 
            this.lblNewName.AutoSize = true;
            this.lblNewName.Location = new System.Drawing.Point(66, 42);
            this.lblNewName.Name = "lblNewName";
            this.lblNewName.Size = new System.Drawing.Size(67, 13);
            this.lblNewName.TabIndex = 42;
            this.lblNewName.Text = "Nama GPU :";
            // 
            // txtNewClock
            // 
            this.txtNewClock.Location = new System.Drawing.Point(138, 108);
            this.txtNewClock.Name = "txtNewClock";
            this.txtNewClock.Size = new System.Drawing.Size(315, 20);
            this.txtNewClock.TabIndex = 41;
            // 
            // txtNewTDP
            // 
            this.txtNewTDP.Location = new System.Drawing.Point(138, 74);
            this.txtNewTDP.Name = "txtNewTDP";
            this.txtNewTDP.Size = new System.Drawing.Size(315, 20);
            this.txtNewTDP.TabIndex = 40;
            // 
            // dBGPUTableAdapter
            // 
            this.dBGPUTableAdapter.ClearBeforeFill = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(258, 151);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 48;
            this.btnDelete.Text = "Hapus";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Edit_GPU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 226);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtGPUName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTDPNew);
            this.Controls.Add(this.lblNewName);
            this.Controls.Add(this.txtNewClock);
            this.Controls.Add(this.txtNewTDP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Edit_GPU";
            this.Text = "Edit GPU";
            this.Load += new System.EventHandler(this.Edit_GPU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBGPUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtGPUName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTDPNew;
        private System.Windows.Forms.Label lblNewName;
        private System.Windows.Forms.TextBox txtNewClock;
        private System.Windows.Forms.TextBox txtNewTDP;
        private ComputerDBDataSet computerDBDataSet;
        private System.Windows.Forms.BindingSource dBGPUBindingSource;
        private ComputerDBDataSetTableAdapters.DBGPUTableAdapter dBGPUTableAdapter;
        private System.Windows.Forms.Button btnDelete;
    }
}