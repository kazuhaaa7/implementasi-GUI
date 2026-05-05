//implementasi 2
namespace winfrom1.ViewPraktikPbo
{
    public partial class FormDashboard : Form
    {
        private string username;
        private List<User> listUser;
        public FormDashboard(string username)
        {
            InitializeComponent();
            this.username = username;
            label1Dashboard.Text += $"  {this.username}";

            DgUser.AutoGenerateColumns = true;


            listUser = new List<User>(generateData());
            DgUser.DataSource = listUser;
            MessageBox.Show($"Jumlah data: {listUser.Count} ", "warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public List<User> generateData()
        {
            listUser = new List<User>();
            for (int i = 1; i <= 5; i++)
            {
                User user1 = new User($"fia {i}", 20, "Lumajang");
                listUser.Add(user1);
            }
            return listUser;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
