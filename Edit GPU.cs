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
    public partial class Edit_GPU : Form
    {
        public Edit_GPU()
        {
            InitializeComponent();
        }

        private void Edit_GPU_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'computerDBDataSet.DBGPU' table. You can move, or remove it, as needed.
            this.dBGPUTableAdapter.Fill(this.computerDBDataSet.DBGPU);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            if (txtGPUName.Text == "" || txtNewClock.Text == "" || txtNewTDP.Text == "") MessageBox.Show("Silahkan Lengkapi Data Prosesor");
            else
            {
                try
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
                            item.TDP = Convert.ToInt32(txtNewTDP.Text);
                            item.base_clock = Convert.ToInt32(txtNewClock.Text);
                        }
                        db.SaveChanges();
                        MessageBox.Show("GPU Sukses Diubah");
                        Close();
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("TDP & Clock harus berupa angka bulat");
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
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
                        db.DBGPU.Remove(item);
                    }
                    db.SaveChanges();
                    MessageBox.Show("Gagal menghapus, GPU dimiliki oleh suatu profil.");
                    Close();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Gagal");
            }
        }

        private void txtGPUName_SelectedIndexChanged(object sender, EventArgs e)
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
                    txtNewTDP.Text = item.TDP.ToString();
                    txtNewClock.Text = item.base_clock.ToString();
                }
            }

        }
    }
}
