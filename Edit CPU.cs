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
    public partial class Edit_CPU : Form
    {
        public Edit_CPU()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Edit_CPU_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'computerDBDataSet.DBCPU' table. You can move, or remove it, as needed.
            this.dBCPUTableAdapter.Fill(this.computerDBDataSet.DBCPU);

        }

        private void txtProcName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedCPU;
            if (txtProcName.SelectedValue == null) return;
            int.TryParse(txtProcName.SelectedValue.ToString(), out selectedCPU);
            using (var db = new ComputerDBEntities())
            {

                var query = from procie in db.DBCPU
                            where procie.Id == selectedCPU
                            select procie;

                foreach (var item in query)
                {
                    txtNewTDP.Text = item.TDP.ToString();
                    txtNewClock.Text = item.base_clock.ToString();
                }
            }

        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            if (txtProcName.Text == "" || txtNewClock.Text == "" || txtNewTDP.Text == "") MessageBox.Show("Silahkan Lengkapi Data Prosesor");
            else
            {
                try
                {
                    int selectedCPU;
                    if (txtProcName.SelectedValue == null) return;
                    int.TryParse(txtProcName.SelectedValue.ToString(), out selectedCPU);
 
                    using (var db = new ComputerDBEntities())
                    {
                        var query = from procie in db.DBCPU
                                    where procie.Id == selectedCPU
                                    select procie;

                        foreach (var item in query)
                        {
                            item.TDP = Convert.ToInt32(txtNewTDP.Text);
                            item.base_clock = Convert.ToInt32(txtNewClock.Text);
                        }
                        db.SaveChanges();
                        MessageBox.Show("CPU Sukses Diubah");
                        Close();
                    }
                    /* currentKomputer.ProcessorPC = new CPU(txtProcName.Text);
                    currentKomputer.ProcessorPC.TDP = Convert.ToDouble(txtProcTDP.Text);
                    currentKomputer.ProcessorPC.base_clock = Convert.ToDouble(txtProcClock.Text);
                    btnOCPro.Enabled = true;
                    MessageBox.Show("Prosesor " + currentKomputer.ProcessorPC.name + " Berhasil Ditambahkan"); */

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
                int selectedCPU;
                if (txtProcName.SelectedValue == null) return;
                int.TryParse(txtProcName.SelectedValue.ToString(), out selectedCPU);

                using (var db = new ComputerDBEntities())
                {
                    var query = from procie in db.DBCPU
                                where procie.Id == selectedCPU
                                select procie;

                    foreach (var item in query)
                    {
                        db.DBCPU.Remove(item);
                    }
                    db.SaveChanges();
                    MessageBox.Show("CPU Sukses Dihapus");
                    Close();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Gagal");
            }
        }
    }
}
