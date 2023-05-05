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
    public partial class AdminScreen : Form
    {
        public AdminScreen()
        {
            InitializeComponent();
        }

        UserRepository userRepository;
        private void AdminScreen_Load(object sender, EventArgs e)
        {

        }

        private void FillListView()
        {
            userRepository = new UserRepository();
            lvKullanicilar.Items.Clear();
            List<User> users= userRepository.GetAll();
            foreach (User user in users)
            {
                ListViewItem lvi = new();
                lvi.Text = user.FirstName;
                lvi.SubItems.Add(user.LastName);
                lvi.SubItems.Add(user.UserName);
                lvi.SubItems.Add(user.IsActive ? "Aktif" : "Pasif");
                lvi.Tag = user;
                lvKullanicilar.Items.Add(lvi);
            }
        }

        private void btnAktifPasif_Click(object sender, EventArgs e)
        {
            if(lvKullanicilar.SelectedItems.Count > 0)
            {
                User user = (User)lvKullanicilar.FocusedItem.Tag;
                if(user.IsActive)
                {
                    user.IsActive = false;
                }
                else
                {
                    user.IsActive = true;
                }

                bool isUpdated = userRepository.Update(user);
                if(isUpdated) 
                {
                    MessageBox.Show("Kullanıcı Güncellendi");
                    FillListView();
                }
                else
                {
                    MessageBox.Show("Kullanıcı güncellenirken beklenmeyen birhata oluştu");
                }

            }
        }
    }
}
