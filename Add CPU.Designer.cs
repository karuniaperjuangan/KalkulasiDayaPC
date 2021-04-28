
namespace PSUCalculator
{
    partial class Add_CPU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_CPU));
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.txtNewTDP = new System.Windows.Forms.TextBox();
            this.txtNewClock = new System.Windows.Forms.TextBox();
            this.lblNewName = new System.Windows.Forms.Label();
            this.lblTDPNew = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExecute = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNewName
            // 
            this.txtNewName.Location = new System.Drawing.Point(110, 32);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(194, 20);
            this.txtNewName.TabIndex = 0;
            // 
            // txtNewTDP
            // 
            this.txtNewTDP.Location = new System.Drawing.Point(110, 67);
            this.txtNewTDP.Name = "txtNewTDP";
            this.txtNewTDP.Size = new System.Drawing.Size(194, 20);
            this.txtNewTDP.TabIndex = 1;
            // 
            // txtNewClock
            // 
            this.txtNewClock.Location = new System.Drawing.Point(110, 101);
            this.txtNewClock.Name = "txtNewClock";
            this.txtNewClock.Size = new System.Drawing.Size(194, 20);
            this.txtNewClock.TabIndex = 2;
            // 
            // lblNewName
            // 
            this.lblNewName.AutoSize = true;
            this.lblNewName.Location = new System.Drawing.Point(38, 35);
            this.lblNewName.Name = "lblNewName";
            this.lblNewName.Size = new System.Drawing.Size(66, 13);
            this.lblNewName.TabIndex = 3;
            this.lblNewName.Text = "Nama CPU :";
            // 
            // lblTDPNew
            // 
            this.lblTDPNew.AutoSize = true;
            this.lblTDPNew.Location = new System.Drawing.Point(44, 70);
            this.lblTDPNew.Name = "lblTDPNew";
            this.lblTDPNew.Size = new System.Drawing.Size(60, 13);
            this.lblTDPNew.TabIndex = 4;
            this.lblTDPNew.Text = "TDP CPU :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Base Clock CPU :";
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(110, 144);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 6;
            this.btnExecute.Text = "Tambah";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(229, 144);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Batal";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Add_CPU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 203);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTDPNew);
            this.Controls.Add(this.lblNewName);
            this.Controls.Add(this.txtNewClock);
            this.Controls.Add(this.txtNewTDP);
            this.Controls.Add(this.txtNewName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_CPU";
            this.Text = "Tambahkan CPU";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.TextBox txtNewTDP;
        private System.Windows.Forms.TextBox txtNewClock;
        private System.Windows.Forms.Label lblNewName;
        private System.Windows.Forms.Label lblTDPNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Button btnCancel;
    }
}