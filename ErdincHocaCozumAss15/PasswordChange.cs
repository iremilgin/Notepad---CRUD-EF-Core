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
    public partial class PasswordChange : Form
    {
        public PasswordChange(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            userRepository = new UserRepository();
        }

        int userId;
        UserRepository userRepository;
        private void btnSifreDegis_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSifre.Text) || string.IsNullOrWhiteSpace(txtYeniSifre.Text) || string.IsNullOrWhiteSpace(txtYeniSifreTekrar.Text))
            {
                MessageBox.Show("Alanlar boş geçilemez.");
            }
            else
            {
                if (txtYeniSifre.Text != txtYeniSifreTekrar.Text)
                {

                    MessageBox.Show("Şifreler Uyuşmuyor");
                }
                else
                {
                    User user = userRepository.GetById(userId);
                    if (user.Password == txtSifre.Text)
                    {
                        user.Password = txtYeniSifre.Text;
                        bool isUpdated = userRepository.Update(user);
                        if (isUpdated)
                        {
                            MessageBox.Show("Güncellendi");
                            this.Close();

                        }
                        else
                        {
                            MessageBox.Show("Güncellenemedi");
                        }
                    }

                    else
                    {
                        MessageBox.Show("Eski şifreyi yanlış girdiniz.");
                    }
                }
            }
        }
    }
}
