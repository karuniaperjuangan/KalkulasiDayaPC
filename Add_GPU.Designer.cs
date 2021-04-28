
namespace PSUCalculator
{
    partial class Add_GPU
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExecute = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTDPNew = new System.Windows.Forms.Label();
            this.lblNewName = new System.Windows.Forms.Label();
            this.txtNewClock = new System.Windows.Forms.TextBox();
            this.txtNewTDP = new System.Windows.Forms.TextBox();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(224, 140);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Batal";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(105, 140);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 14;
            this.btnExecute.Text = "Tambah";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Base Clock GPU :";
            // 
            // lblTDPNew
            // 
            this.lblTDPNew.AutoSize = true;
            this.lblTDPNew.Location = new System.Drawing.Point(39, 66);
            this.lblTDPNew.Name = "lblTDPNew";
            this.lblTDPNew.Size = new System.Drawing.Size(61, 13);
            this.lblTDPNew.TabIndex = 12;
            this.lblTDPNew.Text = "TDP GPU :";
            // 
            // lblNewName
            // 
            this.lblNewName.AutoSize = true;
            this.lblNewName.Location = new System.Drawing.Point(33, 31);
            this.lblNewName.Name = "lblNewName";
            this.lblNewName.Size = new System.Drawing.Size(67, 13);
            this.lblNewName.TabIndex = 11;
            this.lblNewName.Text = "Nama GPU :";
            // 
            // txtNewClock
            // 
            this.txtNewClock.Location = new System.Drawing.Point(105, 97);
            this.txtNewClock.Name = "txtNewClock";
            this.txtNewClock.Size = new System.Drawing.Size(194, 20);
            this.txtNewClock.TabIndex = 10;
            // 
            // txtNewTDP
            // 
            this.txtNewTDP.Location = new System.Drawing.Point(105, 63);
            this.txtNewTDP.Name = "txtNewTDP";
            this.txtNewTDP.Size = new System.Drawing.Size(194, 20);
            this.txtNewTDP.TabIndex = 9;
            // 
            // txtNewName
            // 
            this.txtNewName.Location = new System.Drawing.Point(105, 28);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(194, 20);
            this.txtNewName.TabIndex = 8;
            // 
            // Add_GPU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 206);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTDPNew);
            this.Controls.Add(this.lblNewName);
            this.Controls.Add(this.txtNewClock);
            this.Controls.Add(this.txtNewTDP);
            this.Controls.Add(this.txtNewName);
            this.Name = "Add_GPU";
            this.Text = "Add_GPU";
            this.Load += new System.EventHandler(this.Add_GPU_Load);
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
        private System.Windows.Forms.TextBox txtNewName;
    }
}