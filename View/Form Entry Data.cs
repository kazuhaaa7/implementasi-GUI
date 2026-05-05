namespace winfrom1
{
    public partial class FormEntrData2 : Form
    {
        public FormEntrData2()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception err)
            {
                Console.WriteLine($"error {err}");
            }
            SetComboBoxProdi();//memnaggil method yg isinya nge-binding data
            //kalo ada cara nge-binding data dan memakai cara tanpa nge-binding data dipakai secara bersamaan, maka akan error. contoh dibawah.
            //Kalau sudah pakai DataSource, jangan pakai Items.Add/Remove/Clear.
            //object[] dataProdi = new object[] { "SISTEM INFORMASI", "INFORMATIKA", "TEKNOLOGI INFORMASI" };
            //cbProdi.Items.AddRange(dataProdi);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbProdi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSv_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }

        private void buttonCnc_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public Mahasiswa GetMahasiswa()
        {
            Mahasiswa newMahasiswa = new Mahasiswa();
            newMahasiswa.Nim = tbNim.Text;
            newMahasiswa.Nama = tbNama.Text;
            newMahasiswa.Alamat = tbAlamat.Text;
            newMahasiswa.TglLahir = DateOnly.Parse(dateTimePicker1.Value.ToShortDateString());
            newMahasiswa.ProgramStudi = ((Prodi)cbProdi.SelectedItem).KdProdi;
            newMahasiswa.UKT = decimal.Parse(nudUKT.Text);
            newMahasiswa.isActive = cbisActive.Checked;


            return newMahasiswa;

        }

        private void tbNim_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormEntrData2_Load(object sender, EventArgs e)
        {

        }
    }
}
