using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSUCalculator
{
    public partial class Form1 : Form
    {
        public Komputer currentKomputer = new Komputer();

        public Form1()
        {
            InitializeComponent();
            if(StaticStatus.ActiveMainForm != null)
            {
                StaticStatus.ActiveMainForm.Hide();
            }
            
            StaticStatus.ActiveMainForm = this;
        }

        public void SetPreset(DBComputer item)
        {
            using(var db = new ComputerDBEntities())
            {
                EventArgs args = new EventArgs();
                boxMoboSize.Text = item.Motherboard_Size;
                button1_Click(item, args); //btnAddMobo
                txtProcName.Text = (from CPU in db.DBCPU
                                   where CPU.Id == item.CPU_Id
                                   select CPU).FirstOrDefault().Name;
                txtProcName_SelectedIndexChanged(item, args);
                btnAddProcessor_Click(item, args);
                txtGPUName.Text = (from GPU in db.DBGPU
                                   where GPU.Id == item.GPU_Id
                                   select GPU).FirstOrDefault().Name;
                comboBox1_SelectedIndexChanged(item, args); //txtGPUName
                btnAddGPU_Click(item, args);
                txtRAMSize.Text = item.RAM_Size.ToString();
                btnAddRAM_Click(item, args);
                txtDriveSlot.Text = item.Drive_Count.ToString();
                btnAddDrive_Click(item, args);
                txtOwnerName.Text = item.OwnerName;
            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'computerDBDataSet.DBCPU' table. You can move, or remove it, as needed.
            this.dBCPUTableAdapter.Fill(this.computerDBDataSet.DBCPU);
            // TODO: This line of code loads data into the 'computerDBDataSet.DBGPU' table. You can move, or remove it, as needed.
            this.dBGPUTableAdapter.Fill(this.computerDBDataSet.DBGPU);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (boxMoboSize.Text.Equals("Micro-ATX"))
            {
                currentKomputer.MotherboardPC = new MicroATX("Motherboard PC") as Motherboard;
            }
            if (boxMoboSize.Text.Equals("Mini-ITX"))
            {
                currentKomputer.MotherboardPC = new MiniITX("Motherboard PC") as Motherboard;
            }
            if (boxMoboSize.Text.Equals("ATX"))
            {
                currentKomputer.MotherboardPC = new ATX("Motherboard PC") as Motherboard;
            }
            if (boxMoboSize.Text.Equals("XLATX"))
            {
                currentKomputer.MotherboardPC = new XLATX("Motherboard PC") as Motherboard;
            }
            if(!(sender is DBComputer)) //Do not show if it is called from Preset
            {
                if(currentKomputer.MotherboardPC == null)
                {
                    MessageBox.Show("Gagal menambahkan. Silahkan coba lagi");
                }
                else MessageBox.Show(currentKomputer.MotherboardPC.name + " Berhasil Ditambahkan");
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnAddProcessor_Click(object sender, EventArgs e)
        {
            if (txtProcName.Text == "" || txtProcClock.Text == "" || txtProcTDP.Text == "") MessageBox.Show("Silahkan Lengkapi Data Prosesor");
            else
            {
                try
                {
                    currentKomputer.ProcessorPC = new CPU(txtProcName.Text);
                    currentKomputer.ProcessorPC.TDP = Convert.ToDouble(txtProcTDP.Text);
                    currentKomputer.ProcessorPC.base_clock = Convert.ToDouble(txtProcClock.Text);
                    btnOCPro.Enabled = true;
                    if (!(sender is DBComputer)) //Do not show if it is called from Preset
                    {
                        MessageBox.Show("Prosesor "+ currentKomputer.ProcessorPC.name + " Berhasil Ditambahkan");
                    }
                }
                catch(Exception)
                {
                    MessageBox.Show("TDP & Clock harus berupa Angka");
                }
            }
        }

        private void btnAddGPU_Click(object sender, EventArgs e)
        {
            if (txtGPUName.Text == "" || txtGPUClock.Text == "" || txtGPUTDP.Text == "") MessageBox.Show("Silahkan Lengkapi Data GPU");
            else
            {
                try
                {
                    currentKomputer.GraphicsPC = new GPU(txtGPUName.Text);
                    currentKomputer.GraphicsPC.TDP = Convert.ToDouble(txtGPUTDP.Text);
                    currentKomputer.GraphicsPC.base_clock = Convert.ToDouble(txtGPUClock.Text);
                    btnOCGPU.Enabled = true;
                    if (!(sender is DBComputer)) //Do not show if it is called from Preset
                    {
                        MessageBox.Show("GPU " + currentKomputer.GraphicsPC.name + " Berhasil Ditambahkan");
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("TDP & Clock harus berupa Angka");
                }
            }
        }

        private void txtRAMSize_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddRAM_Click(object sender, EventArgs e)
        {
            if (txtRAMSize.Text == "") MessageBox.Show("Silahkan Masukkan Ukuran RAM");
            else
            {
                try
                {
                    currentKomputer.RAMPC = new RAM("RAM Komputer");
                    currentKomputer.RAMPC.memory_size = Int32.Parse(txtRAMSize.Text);
                    if (!(sender is DBComputer)) //Do not show if it is called from Preset
                    {
                        MessageBox.Show("RAM "+currentKomputer.RAMPC.memory_size.ToString()+" GB berhasil ditambahkan");
                    }
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Ukuran RAM harus berupa angka bulat");
                }
            }
        }

        private void btnAddDrive_Click(object sender, EventArgs e)
        {
            if (txtDriveSlot.Text == "") MessageBox.Show("Silahkan Masukkan Jumlah HDD dan/atau SSD yang digunakan");
            else
            {
                try
                {
                    currentKomputer.DrivePC = new Drive("RAM Komputer");
                    currentKomputer.DrivePC.drive_count = Int32.Parse(txtDriveSlot.Text);
                    if (!(sender is DBComputer)) //Do not show if it is called from Preset
                    {
                        MessageBox.Show("SSD/HDD sejumlah "+ currentKomputer.DrivePC.drive_count.ToString() +" berhasil ditambahkan");
                    }
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Jumlah SSD dan/atau HDD harus berupa angka bulat");
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void boxPSURating_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSetPSU_Click(object sender, EventArgs e)
        {
            if(boxPSURating.Text == "Bronze")
            {
                currentKomputer.efficiencyPSU = 0.82;
            }
            else if (boxPSURating.Text == "Silver")
            {
                currentKomputer.efficiencyPSU = 0.85;
            }
            else if (boxPSURating.Text == "Gold")
            {
                currentKomputer.efficiencyPSU = 0.87;
            }
            else if (boxPSURating.Text == "Platinum")
            {
                currentKomputer.efficiencyPSU = 0.89;
            }
            else if (boxPSURating.Text == "Titanium")
            {
                currentKomputer.efficiencyPSU = 0.94;
            }
            else
            {
                MessageBox.Show("Masukkan Rating yang valid");
                return;
            }
            double shownEfficiency = currentKomputer.efficiencyPSU * 100;
            string output = string.Format("Efisiensi PSU Sekarang adalah {0}%", shownEfficiency);
            MessageBox.Show(output);
        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try 
            { 
                double computerPower = currentKomputer.PurePower();
                double expectedBill = PowerFormula.MonthlyPLNBill(currentKomputer);
                int PSURecommendation = PowerFormula.PSURecommendedPower(currentKomputer);
                string OutputMessage = string.Format("Daya yang digunakan oleh PC adalah {0} Watt.\nUntuk penggunaan sekitar {1} jam sehari, tagihan bulanan yang harus dibayarkan sebesar Rp{2}.\nRekomendasi Daya PSU adalah {3}W", computerPower.ToString(), currentKomputer.dailyUsage.ToString(), expectedBill.ToString(), PSURecommendation.ToString());
                MessageBox.Show(OutputMessage);
            }
            catch(Exception)
            {
                MessageBox.Show("Pastikan semua komponen sudah ditambahkan");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSetDailyUsage_Click(object sender, EventArgs e)
        {
            if (txtDailyUsage.Text == "") MessageBox.Show("Silahkan Masukkan Jam Penggunaan Harian");
            else
            {
                try
                {
                    currentKomputer.dailyUsage = Convert.ToDouble(txtDailyUsage.Text);
                    MessageBox.Show("Penggunaan komputer berhasil diatur " + currentKomputer.dailyUsage.ToString() + " jam sehari");
                }
                catch (Exception)
                {
                    MessageBox.Show("Jam harus berupa angka");
                }
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnOCPro_Click(object sender, EventArgs e)
        {
            if (txtProBoostClock.Text == "") MessageBox.Show("Silahkan Masukkan Clock OC/UC");
            else
            {
                try
                {
                    double boostClock = Convert.ToDouble(txtProBoostClock.Text);
                    currentKomputer.ProcessorPC.ChangeFrequency(boostClock);
                    MessageBox.Show("Clock Processor berhasil diubah dari base clock");
                }
                catch (Exception)
                {
                    MessageBox.Show("Clock harus berupa angka");
                }
            }
        }

        private void btnOCGPU_Click(object sender, EventArgs e)
        {
            if (txtGPUBoostClock.Text == "") MessageBox.Show("Silahkan Masukkan Clock OC/UC");
            else
            {
                try
                {
                    double boostClock = Convert.ToDouble(txtGPUBoostClock.Text);
                    currentKomputer.GraphicsPC.ChangeFrequency(boostClock);
                    MessageBox.Show("Clock Processor berhasil diubah dari base clock");
                }
                catch (Exception)
                {
                    MessageBox.Show("Clock harus berupa angka");
                }
            }
        }

        private void txtGPUName_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int selectedGPU;
            if (txtGPUName.SelectedValue == null) return;
            int.TryParse(txtGPUName.SelectedValue.ToString(), out selectedGPU);
            using (var db = new ComputerDBEntities())
            {

                var query = from GPU in db.DBGPU
                            where GPU.Id == selectedGPU
                            select GPU;

                foreach (var item in query)
                {
                    txtGPUTDP.Text = item.TDP.ToString();
                    txtGPUClock.Text = item.base_clock.ToString();
                }
            }

        }

        private void txtProcName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedCPU;
            if (txtProcName.SelectedValue == null) return;
            int.TryParse(txtProcName.SelectedValue.ToString(),out selectedCPU);
           using(var db = new ComputerDBEntities())
            {
                
                 var query = from procie in db.DBCPU
                            where procie.Id == selectedCPU
                            select procie;

                foreach(var item in query)
                {
                    txtProcTDP.Text = item.TDP.ToString();
                    txtProcClock.Text = item.base_clock.ToString();
                }  
            }

        }

        private void txtProcTDP_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var EditCPU = new Edit_CPU();
            EditCPU.Show();
        }

        private void lblAddProc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var AddCPU = new Add_CPU();
            AddCPU.Show();
        }

        private void lblReset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var Resetted = new Form1();
            Resetted.Show();
            Hide();
        }

        private void lblAddGPU_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var AddGPU = new Add_GPU();
            AddGPU.Show();
        }

        private void lblEditGPU_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var EditGPU = new Edit_GPU();
            EditGPU.Show();
        }

        private void btnSaveProfile_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedCPU, selectedGPU;
                if (txtProcName.SelectedValue == null) return;
                int.TryParse(txtProcName.SelectedValue.ToString(), out selectedCPU);
                if (txtGPUName.SelectedValue == null) return;
                int.TryParse(txtGPUName.SelectedValue.ToString(), out selectedGPU);

                using (var db = new ComputerDBEntities())
                {
                    DBComputer newComputer = new DBComputer()
                    {
                        OwnerName = txtOwnerName.Text,
                        Motherboard_Size = currentKomputer.MotherboardPC.Size,
                        GPU_Id = selectedGPU,
                        CPU_Id = selectedCPU,
                        RAM_Size = currentKomputer.RAMPC.memory_size,
                        Drive_Count = currentKomputer.DrivePC.drive_count
                    };
                    db.DBComputer.Add(newComputer);
                    db.SaveChanges();
                    MessageBox.Show("Profil sukses disimpan");
                }
            }
            catch
            {
                MessageBox.Show("Gagal Menambahkan");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var CekProfil = new CekProfil();
            CekProfil.Show();
        }

        private void txtOwnerName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
