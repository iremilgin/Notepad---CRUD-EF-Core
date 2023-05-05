using ErdincHocaCozumAss15.Models;
using ErdincHocaCozumAss15.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErdincHocaCozumAss15
{
    public partial class Main : Form
    {
        public Main(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        int userId;
        NoteRepository noteRepository;
        private void Main_Load(object sender, EventArgs e)
        {
            noteRepository = new NoteRepository();
            List<Note> notes = noteRepository.GetNotesByUserId(userId);
            lboxNotlar.ValueMember = "Id";
            lboxNotlar.DisplayMember = "Title";
            lboxNotlar.DataSource = notes;
            ResetForm();
        }

        private void lboxNotlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboxNotlar.SelectedIndex != -1)
            {
                int noteId = (int)lboxNotlar.SelectedValue;
                Note note = noteRepository.GetById(noteId);
                txtBaslik.Text = note.Title;
                txtIcerik.Text = note.Content;
                btnNotSil.Enabled = true;
            }
            else
            {

                ResetForm();

            }

        }
        private void btnYeniNot_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            lboxNotlar.SelectedIndex = -1;
            txtBaslik.Clear();
            txtIcerik.Clear();
            btnNotSil.Enabled = false;
        }

        private void btnNotSil_Click(object sender, EventArgs e)
        {
            if (lboxNotlar.SelectedIndex != -1)
            {
                DialogResult result = MessageBox.Show("Silme işlemini onaylıyor musunuz?", "SilmeOnayı", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {

                    int noteId = (int)lboxNotlar.SelectedValue;
                    bool isDeleted = noteRepository.Delete(noteId);
                    if (isDeleted)
                    {
                        MessageBox.Show("Başarıyla silindi.");
                        ResetForm();
                        lboxNotlar.DataSource = noteRepository.GetNotesByUserId(userId);
                        }
                    else
                    {
                        MessageBox.Show("Silinemedi.");
                    }

                }

            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //Var olan bir notu günceller.
            if(lboxNotlar.SelectedIndex != -1)
            {
                int noteId = (int)lboxNotlar.SelectedValue;
                Note note = noteRepository.GetById(noteId);
                note.Title = txtBaslik.Text;
                note.Content = txtIcerik.Text;
                bool isUpdated = noteRepository.Update(note);
                if (isUpdated)
                {

                    MessageBox.Show("Başarıyla güncellendi");
                    lboxNotlar.DataSource = noteRepository.GetNotesByUserId(userId);
                    ResetForm();

                }
                else
                {
                    MessageBox.Show("Güncellenemedi");
                }
            }
            else
            {
                //Yeni not ekler.
                Note note = new Note();
                note.UserId = userId;
                note.Title = txtBaslik.Text;
                note.Content = txtIcerik.Text;
                bool isAdded = noteRepository.Add(note);
                if(isAdded)
                {
                    MessageBox.Show("Başarıyla eklendi");
                    lboxNotlar.DataSource = noteRepository.GetNotesByUserId(userId);
                    ResetForm();
                }
                else
                {
                    MessageBox.Show("Eklenemedi");
                }
            }
        }

        private void llblSifreDegis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PasswordChange passwordChange = new(userId);
            passwordChange.ShowDialog();
        }
    }
}
