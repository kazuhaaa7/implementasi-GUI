using Npgsql;

namespace winfrom1.Models
{
    internal class m_MhsContextcs
    {
        #region Properties
        public List<m_Mhs> daftarMhs = new List<m_Mhs>();

        #endregion

        public bool Insert(m_Mhs mhs)
        {
            bool isSucces = false;

            //konfigurasi db=> use using supaya ga otomatis ke-close.
            string connectToDb =
            "Server=localhost;" +
            "Port=5432;" +
            "Database=PBOdb;" +
            "Username=postgres;" +
            "Password=postgre7";

            using (NpgsqlConnection conn = new NpgsqlConnection(connectToDb))
            {
                string query = @"INSERT INTO public.student (nama,nim, kd_prodi, ukt, tanggal_lahir, status, alamat)
                                VALUES(:nama,:nim, :kd_prodi, :ukt, :tanggal_lahir, :status, :alamat)";

                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new NpgsqlParameter(":nama", mhs.nama));
                    cmd.Parameters.Add(new NpgsqlParameter(":nim", mhs.nim));
                    cmd.Parameters.Add(new NpgsqlParameter(":kd_prodi", mhs.kdProdi));
                    cmd.Parameters.Add(new NpgsqlParameter(":ukt", mhs.ukt));
                    cmd.Parameters.Add(new NpgsqlParameter(":tanggal_lahir", mhs.tanggalLahir));
                    cmd.Parameters.Add(new NpgsqlParameter(":status", mhs.isActive));
                    cmd.Parameters.Add(new NpgsqlParameter(":alamat", mhs.alamat));

                    cmd.CommandType = System.Data.CommandType.Text;
                    int jumlahdata = cmd.ExecuteNonQuery();

                    if (jumlahdata > 0)
                    {
                        isSucces = true;
                        this.daftarMhs.Add(mhs);
                    }
                }

            }
            return isSucces;
        }
    }
}
