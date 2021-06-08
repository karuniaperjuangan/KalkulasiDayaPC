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
    public partial class Add_GPU : Form
    {
        public Add_GPU()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            if (txtNewName.Text == "" || txtNewClock.Text == "" || txtNewTDP.Text == "") MessageBox.Show("Silahkan Lengkapi Data Prosesor");
            else
            {


                try
                {
                    using (var db = new ComputerDBEntities())
                    {
                        DBGPU newGPU = new DBGPU()
                        {
                            Name = txtNewName.Text,
                            base_clock = Convert.ToInt32(txtNewClock.Text),
                            TDP = Convert.ToInt32(txtNewTDP.Text)
                        };
                        db.DBGPU.Add(newGPU);
                        db.SaveChanges();
                        MessageBox.Show("GPU Sukses Ditambahkan");
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

        private void Add_GPU_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
