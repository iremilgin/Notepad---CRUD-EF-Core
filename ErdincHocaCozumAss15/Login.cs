using ErdincHocaCozumAss15.Models;
using ErdincHocaCozumAss15.Repositories;

namespace ErdincHocaCozumAss15
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        UserRepository userRepository;
        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) || string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("Alanlar boþ geçilemez");
                return;
            }

            userRepository = new UserRepository();
            User user = userRepository.GetByUserName(txtKullaniciAdi.Text.Trim());

            if (user == null)
            {
                MessageBox.Show("Kullanýcý bulunamadý. Kayýtlý deðilseniz aþaðýdaki linke týklayýnýz");
            }
            else if (user.Password != txtSifre.Text)
            {
                MessageBox.Show("Þifre Yanlýþtýr");
            }
            else if (!user.IsActive)
            {
                MessageBox.Show("Admin kaydýnýzý onaylamamýþtýr. Lütfen admin ile iletiþime geçiniz");
            }
            else
            {
                this.Hide();
                switch (user.UserType)
                {
                    case Enum.UserType.Admin:
                        this.Hide();
                        AdminScreen adminScreen = new();
                        adminScreen.Show();
                        this.Show();
                        break;

                    case Enum.UserType.Standart:
                        this.Hide();
                        Main main = new Main(user.Id);
                        main.ShowDialog();
                        this.Show();
                        break;
                }
                this.Show();
            }
        }

        private void llblKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignIn sign = new SignIn();
            sign.ShowDialog();
        }
    }
}