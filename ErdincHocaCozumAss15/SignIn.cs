using ErdincHocaCozumAss15.Models;
using ErdincHocaCozumAss15.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErdincHocaCozumAss15
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
            
        }

        UserRepository userRepository;
        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtAd.Text) || string.IsNullOrWhiteSpace(txtSoyad.Text) || string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) || string.IsNullOrWhiteSpace(txtSifre.Text) || string.IsNullOrWhiteSpace(txtSifreTekrar.Text))
            {
                MessageBox.Show("Alanlar boş geçilemez.");
                return;
            }

            if(txtSifreTekrar.Text != txtSifre.Text)
            {
                MessageBox.Show("Şifreler uyuşmuyor");
            }
            else
            {

                userRepository = new UserRepository();
                User user = userRepository.GetByUserName(txtKullaniciAdi.Text);

                if(user != null)
                {
                    MessageBox.Show("Bu isimde kullanıcı mevcuttur");
                }
                else
                {
                    user = new User();
                    user.FirstName = txtAd.Text;
                    user.LastName = txtSoyad.Text;
                    user.UserName = txtKullaniciAdi.Text;
                    user.Password = txtSifre.Text;
                    user.UserType = Enum.UserType.Standart;

                    bool isAdded = userRepository.Add(user);
                    if(isAdded)
                    {
                        MessageBox.Show("Kaydınız Başarıyla gerçekleştirildi");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Kaydolurken bir hata oluştu.");
                    }
                }
            }



        }
    }
}
