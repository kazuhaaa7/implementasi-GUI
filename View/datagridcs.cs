namespace winfrom1
{
    public partial class datagridcs : Form
    {
        //List<Mahasiswa> listMahasiswa = new List<Mahasiswa>();
        Models.MhsContextcs mhsContex;
        public datagridcs()
        {
            InitializeComponent();
            //Mahasiswa tegar = new Mahasiswa();
            //tegar.Nim = "C31241696";
            //tegar.Nama = "TEGAR RAMADHAN ARIEF WIJAYA";
            //tegar.Alamat = "JL. OTISTA";
            //tegar.TglLahir = new DateOnly(2005, 10, 7);
            //tegar.ProgramStudi = "PRODUKSI TERNAK";
            //tegar.UKT = 3500000;
            //tegar.isActive = true;

            //listMahasiswa.Add(tegar);//sv data
            //dataGridView1.DataSource = listMahasiswa;

            mhsContex = new Models.MhsContextcs();// membuat instance dengan tipe data mhsContex



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
                    //Mahasiswa newMahasiswa = addData.GetMahasiswa();//impelementasi 2
                    //listMahasiswa.Add(newMahasiswa);
                    //dataGridView1.DataSource = null;
                    //dataGridView1.DataSource = listMahasiswa;

                    Models.Mhs newMahasigma = addData.GetMahasiswa();
                    //mhsContex.daftarMhs.Add(newMahasigma);
                    mhsContex.Insert(newMahasigma);

                    //menampilkan daftar mahasiswa on grid view
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = mhsContex.daftarMhs;

                    addData.Close();
                }
            }
        }


    }
}
