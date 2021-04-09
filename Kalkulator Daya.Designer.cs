
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
            this.btnAddMobo = new System.Windows.Forms.Button();
            this.lblMotherboard = new System.Windows.Forms.Label();
            this.boxMoboSize = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProcName = new System.Windows.Forms.TextBox();
            this.btnAddProcessor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProcClock = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProcTDP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGPUTDP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGPUClock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddGPU = new System.Windows.Forms.Button();
            this.txtGPUName = new System.Windows.Forms.TextBox();
            this.lblRAM = new System.Windows.Forms.Label();
            this.btnAddRAM = new System.Windows.Forms.Button();
            this.txtRAMSize = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDriveSlot = new System.Windows.Forms.TextBox();
            this.btnAddDrive = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddMobo
            // 
            this.btnAddMobo.Location = new System.Drawing.Point(171, 51);
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
            this.lblMotherboard.Location = new System.Drawing.Point(27, 27);
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
            "Micro ATX",
            "Mini ITX",
            "ATX",
            "XLATX"});
            this.boxMoboSize.Location = new System.Drawing.Point(30, 53);
            this.boxMoboSize.Name = "boxMoboSize";
            this.boxMoboSize.Size = new System.Drawing.Size(121, 21);
            this.boxMoboSize.TabIndex = 2;
            this.boxMoboSize.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Apa Prosesor/CPUmu?";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtProcName
            // 
            this.txtProcName.Location = new System.Drawing.Point(30, 117);
            this.txtProcName.Name = "txtProcName";
            this.txtProcName.Size = new System.Drawing.Size(121, 20);
            this.txtProcName.TabIndex = 4;
            // 
            // btnAddProcessor
            // 
            this.btnAddProcessor.Location = new System.Drawing.Point(369, 115);
            this.btnAddProcessor.Name = "btnAddProcessor";
            this.btnAddProcessor.Size = new System.Drawing.Size(75, 23);
            this.btnAddProcessor.TabIndex = 5;
            this.btnAddProcessor.Text = "Tambahkan";
            this.btnAddProcessor.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Baseclocknya? (GHz)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtProcClock
            // 
            this.txtProcClock.Location = new System.Drawing.Point(287, 118);
            this.txtProcClock.Name = "txtProcClock";
            this.txtProcClock.Size = new System.Drawing.Size(75, 20);
            this.txtProcClock.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Apa GPU mu?";
            // 
            // txtProcTDP
            // 
            this.txtProcTDP.Location = new System.Drawing.Point(157, 117);
            this.txtProcTDP.Name = "txtProcTDP";
            this.txtProcTDP.Size = new System.Drawing.Size(121, 20);
            this.txtProcTDP.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Berapa TDP-nya? (Watt)";
            // 
            // txtGPUTDP
            // 
            this.txtGPUTDP.Location = new System.Drawing.Point(157, 181);
            this.txtGPUTDP.Name = "txtGPUTDP";
            this.txtGPUTDP.Size = new System.Drawing.Size(121, 20);
            this.txtGPUTDP.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Berapa TDP-nya? (Watt)";
            // 
            // txtGPUClock
            // 
            this.txtGPUClock.Location = new System.Drawing.Point(287, 182);
            this.txtGPUClock.Name = "txtGPUClock";
            this.txtGPUClock.Size = new System.Drawing.Size(75, 20);
            this.txtGPUClock.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Baseclocknya? (GHz)";
            // 
            // btnAddGPU
            // 
            this.btnAddGPU.Location = new System.Drawing.Point(369, 179);
            this.btnAddGPU.Name = "btnAddGPU";
            this.btnAddGPU.Size = new System.Drawing.Size(75, 23);
            this.btnAddGPU.TabIndex = 12;
            this.btnAddGPU.Text = "Tambahkan";
            this.btnAddGPU.UseVisualStyleBackColor = true;
            // 
            // txtGPUName
            // 
            this.txtGPUName.Location = new System.Drawing.Point(30, 181);
            this.txtGPUName.Name = "txtGPUName";
            this.txtGPUName.Size = new System.Drawing.Size(121, 20);
            this.txtGPUName.TabIndex = 11;
            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.Location = new System.Drawing.Point(27, 217);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(99, 13);
            this.lblRAM.TabIndex = 17;
            this.lblRAM.Text = "Ukuran RAM? (GB)";
            this.lblRAM.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnAddRAM
            // 
            this.btnAddRAM.Location = new System.Drawing.Point(171, 241);
            this.btnAddRAM.Name = "btnAddRAM";
            this.btnAddRAM.Size = new System.Drawing.Size(75, 23);
            this.btnAddRAM.TabIndex = 19;
            this.btnAddRAM.Text = "Tambahkan";
            this.btnAddRAM.UseVisualStyleBackColor = true;
            // 
            // txtRAMSize
            // 
            this.txtRAMSize.Location = new System.Drawing.Point(30, 243);
            this.txtRAMSize.Name = "txtRAMSize";
            this.txtRAMSize.Size = new System.Drawing.Size(121, 20);
            this.txtRAMSize.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Jumlah Slot HDD dan SSD yang terpakai?";
            // 
            // txtDriveSlot
            // 
            this.txtDriveSlot.Location = new System.Drawing.Point(30, 316);
            this.txtDriveSlot.Name = "txtDriveSlot";
            this.txtDriveSlot.Size = new System.Drawing.Size(121, 20);
            this.txtDriveSlot.TabIndex = 21;
            // 
            // btnAddDrive
            // 
            this.btnAddDrive.Location = new System.Drawing.Point(171, 314);
            this.btnAddDrive.Name = "btnAddDrive";
            this.btnAddDrive.Size = new System.Drawing.Size(75, 23);
            this.btnAddDrive.TabIndex = 22;
            this.btnAddDrive.Text = "Tambahkan";
            this.btnAddDrive.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(436, 394);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(166, 51);
            this.button4.TabIndex = 23;
            this.button4.Text = "Hitung";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 369);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(207, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Jumlah Slot HDD dan SSD yang terpakai?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 457);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnAddDrive);
            this.Controls.Add(this.txtDriveSlot);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAddRAM);
            this.Controls.Add(this.txtRAMSize);
            this.Controls.Add(this.lblRAM);
            this.Controls.Add(this.txtGPUTDP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGPUClock);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAddGPU);
            this.Controls.Add(this.txtGPUName);
            this.Controls.Add(this.txtProcTDP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProcClock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddProcessor);
            this.Controls.Add(this.txtProcName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxMoboSize);
            this.Controls.Add(this.lblMotherboard);
            this.Controls.Add(this.btnAddMobo);
            this.Name = "Form1";
            this.Text = "Penghitung Daya PC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddMobo;
        private System.Windows.Forms.Label lblMotherboard;
        private System.Windows.Forms.ComboBox boxMoboSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProcName;
        private System.Windows.Forms.Button btnAddProcessor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProcClock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProcTDP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGPUTDP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGPUClock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddGPU;
        private System.Windows.Forms.TextBox txtGPUName;
        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.Button btnAddRAM;
        private System.Windows.Forms.TextBox txtRAMSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDriveSlot;
        private System.Windows.Forms.Button btnAddDrive;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label8;
    }
}

