using winfrom1.ViewPraktikPbo;
//implementasi 1
namespace winfrom1.View
{
    public partial class praktikPbo : Form
    {
        private string username;
        private string password;

        public praktikPbo()
        {
            InitializeComponent();
            username = "rossi";
            password = "rossi123";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BtnLgn_Click(object sender, EventArgs e)
        {
            string userInput = TbUsername.Text;
            string passInput = TbPassword.Text;

            if (userInput == username && passInput == password)
            {
                MessageBox.Show("Login Berhasil", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //ini penambahan data
                FormDashboard frmdashboard = new FormDashboard(userInput);
                frmdashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau Password salah", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void praktikPbo_Load(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            //informasi
            MessageBox.Show("Kamu akan membatalkan proses login \n\n" + "Aplikasi PPMB 2025 akan ditutup.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //konfirmasi
            DialogResult messages = MessageBox.Show("Apakah kamu yakin ingin membatalkan login?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (messages == DialogResult.Yes)
            {
                //Application.Exit();//untuk keluar dri appllikasi
                this.Close();//untuk tutup form ini saja
            }
        }
    }
}
