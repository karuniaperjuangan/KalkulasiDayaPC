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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (boxMoboSize.Text.Equals("Micro ATX"))
            {
                currentKomputer.MotherboardPC = new MicroATX("Motherboard PC") as Motherboard;
            }
            if (boxMoboSize.Text.Equals("Mini ITX"))
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
            if(currentKomputer.MotherboardPC == null)
            {
                MessageBox.Show("Gagal menambahkan. Silahkan coba lagi");
            }
            else MessageBox.Show(currentKomputer.MotherboardPC.name + " Berhasil Ditambahkan");
            
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
                    MessageBox.Show("Prosesor "+ currentKomputer.ProcessorPC.name + " Berhasil Ditambahkan");

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
                    MessageBox.Show("GPU " + currentKomputer.GraphicsPC.name + " Berhasil Ditambahkan");

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
                    MessageBox.Show("RAM "+currentKomputer.RAMPC.memory_size.ToString()+" GB berhasil ditambahkan");
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
                    MessageBox.Show("SSD/HDD sejumlah "+ currentKomputer.DrivePC.drive_count.ToString() +" berhasil ditambahkan");
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
            double computerPower = currentKomputer.PurePower();
            double expectedBill = PowerFormula.MonthlyPLNBill(currentKomputer);
            int PSURecommendation = PowerFormula.PSURecommendedPower(currentKomputer);
            string OutputMessage = string.Format("Daya yang digunakan oleh PC adalah {0} Watt.\nUntuk penggunaan sekitar {1} jam sehari, tagihan bulanan yang harus dibayarkan sebesar Rp{2}.\nRekomendasi Daya PSU adalah {3}W", computerPower.ToString(), currentKomputer.dailyUsage.ToString(), expectedBill.ToString(), PSURecommendation.ToString());
            MessageBox.Show(OutputMessage);
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
    }
}
