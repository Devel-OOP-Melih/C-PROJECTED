using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    public partial class FormLogIN : Form
    {
        FormBooks formBooks;
        public FormLogIN()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=\SQLEXPRESS;Initial Catalog=Db_MTAL_Kutuphane;Integrated Security=True;");
       
        private void buttonGiris_Click(object sender, EventArgs e)
        {
            string sifre = "";
            if ((textBoxKullanici.Text == "") || (textBoxSifre.Text == ""))
            {
                MessageBox.Show("KULLANICI ADI VEYA ÞÝFRENÝZ HATALI!!");
                return;
            }
            try
            {
                baglanti.Open();
                SqlCommand sqlkomut = new SqlCommand("SELECT Sifre FROM TableLibraryAdmin's WHERE KullaniciAdi = @p1" , baglanti);
                sqlkomut.Parameters.AddWithValue("@p1",textBoxKullanici.Text);
                SqlDataReader sqlDataReader = sqlkomut.ExecuteReader();
                 
                while (sqlDataReader.Read())
                {
                   sifre = sqlDataReader[0].ToString();
                }

                if (sifre == textBoxSifre.Text)
                {
                    formBooks = new FormBooks();
                    this.Hide();
                    formBooks.Show();
                }
                else
                {
                    MessageBox.Show("Kullanýcý Adý veya Þifre hatalý !");
                    textBoxKullanici.Text = "";
                    textBoxSifre.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Baðlantý hatasý! " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }
    }
}
