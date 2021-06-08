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
    public partial class CekProfil : Form
    {
        public CekProfil()
        {
            InitializeComponent();
        }

        private void CekProfil_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'computerDBDataSet.DBComputer' table. You can move, or remove it, as needed.
            this.dBComputerTableAdapter.Fill(this.computerDBDataSet.DBComputer);

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedProfile;
            if (txtProfile.SelectedValue == null) return;
            int.TryParse(txtProfile.SelectedValue.ToString(), out selectedProfile);
            using (var db = new ComputerDBEntities())
            {

                var query = from profile in db.DBComputer
                            where profile.Id == selectedProfile
                            select profile;

                var item = query.FirstOrDefault();
 
                var GPUquery = from GPU in db.DBGPU
                                   where GPU.Id == item.GPU_Id
                                   select GPU;
                DBGPU gpu = GPUquery.FirstOrDefault();

                var CPUquery = from CPU in db.DBCPU
                                   where CPU.Id == item.CPU_Id
                                   select CPU;

                DBCPU cpu = CPUquery.FirstOrDefault();

                lblOwnerName.Text = item.OwnerName;
                lblMotherboard.Text = item.Motherboard_Size;
                lblGPU.Text = gpu.Name;
                lblCPU.Text = cpu.Name;
                lblRAM.Text = item.RAM_Size.ToString() + " GB";
                lblDrive.Text = item.Drive_Count.ToString();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedComputer;
                if (txtProfile.SelectedValue == null) return;
                int.TryParse(txtProfile.SelectedValue.ToString(), out selectedComputer);

                using (var db = new ComputerDBEntities())
                {
                    var query = from Computer in db.DBComputer
                                where Computer.Id == selectedComputer
                                select Computer;

                    foreach (var item in query)
                    {
                        db.DBComputer.Remove(item);
                    }
                    db.SaveChanges();
                    MessageBox.Show("Profil Sukses Dihapus");
                    Close();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Gagal menghapus profil.");
            }
        }

        private void button1_Click(object sender, EventArgs e) //AmbilProfil
        {
            try
            {
                int selectedComputer;
                if (txtProfile.SelectedValue == null) return;
                int.TryParse(txtProfile.SelectedValue.ToString(), out selectedComputer);

                using (var db = new ComputerDBEntities())
                {
                    var item = (from Computer in db.DBComputer
                                where Computer.Id == selectedComputer
                                select Computer).FirstOrDefault();

                    Form1 FormWithPreset = StaticStatus.ActiveMainForm;
                    FormWithPreset.SetPreset(item);
                    Close();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Failed to select");
            }
        }
    }
}
