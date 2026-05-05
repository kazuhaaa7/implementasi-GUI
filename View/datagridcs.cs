using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace winfrom1
{
    public partial class datagridcs : Form
    {
        List<Mahasiswa> listMahasiswa = new List<Mahasiswa>();
        public datagridcs()
        {
            InitializeComponent();
            Mahasiswa tegar = new Mahasiswa();
            tegar.Nim = "C31241696";
            tegar.Nama = "TEGAR RAMADHAN ARIEF WIJAYA";
            tegar.Alamat = "JL. OTISTA";
            tegar.TglLahir = new DateOnly(2005, 10, 7);
            tegar.ProgramStudi = "PRODUKSI TERNAK";
            tegar.UKT = 3500000;
            tegar.isActive = true;

            listMahasiswa.Add(tegar);//sv data
            dataGridView1.DataSource = listMahasiswa;


        }

        private void datagridcs_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTmbh_Click(object sender, EventArgs e)
        {
            using (FormEntrData2 addData = new FormEntrData2())
            {
                if (addData.ShowDialog() == DialogResult.OK)
                {
                    Mahasiswa newMahasiswa = addData.GetMahasiswa();
                    listMahasiswa.Add(newMahasiswa);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = listMahasiswa;

                    addData.Close();
                }
            }
        }


    }
}
