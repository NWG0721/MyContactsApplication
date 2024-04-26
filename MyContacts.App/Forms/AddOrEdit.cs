using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MyContacts.Data.Context;
using MyContacts.Data;
using System.Threading;


namespace MyContacts.App
{
    public partial class AddOrEdit : Form
    {
        private string destFilePath = "none";
        ContactsUnit db;
        frmMain main = new frmMain();
        public AddOrEdit(int index)
        {
            InitializeComponent();
            this.index = index;

        }
        public int index;
        private void AddOrEdit_Load(object sender, EventArgs e)
        {
            if (index != 0)
            {
                db = new ContactsUnit();

                var table = db.ContactsRepository.SelectById(index);
                txtName.Text = table.Person_FullName;
                txtPhone.Text = table.Person_Phone;
                txtEmail.Text = table.Person_Email;
                txtAddress.Text = table.Person_Address;
                picPersonPicture.ImageLocation = table.Person_Picture;
                db.Dispose();
            }
        }

        private void wiLBiTRoundedPictureBox21_Click(object sender, EventArgs e)
        {
            string appPath = Application.StartupPath;
            string dir = appPath + @"\Images";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            string fileName = openFileDialog1.FileName;
            openFileDialog1.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.img";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
                string imageName = Guid.NewGuid().ToString() + Path.GetExtension(fileName);
                destFilePath = Path.Combine(dir, imageName);
                if (!File.Exists(destFilePath))
                {
                    File.Copy(fileName, destFilePath);
                }

                picPersonPicture.Image = Image.FromFile(destFilePath);
            }
            else
            {
                picPersonPicture.Image = global::MyContacts.App.Properties.Resources.icons8_trollface_96_1_;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        //private void btnOk_Click(object sender, EventArgs e)
        //{

        //    Contact contact = new Contact()
        //    {
        //        Person_FullName = txtName.Text,
        //        Person_Phone = txtPhone.Text,
        //        Person_Email = txtEmail.Text,
        //        Person_Address = txtAddress.Text,
        //        Person_Picture = destFilePath
        //    };
        //    switch (index)
        //    {
        //        case (0):
        //            db.ContactsRepository.Insert(contact);
        //            break;
        //        default:
        //            db.ContactsRepository.Update(contact);
        //            break;
        //    }
        //    db.ContactsRepository.Save();
        //    Thread.Sleep(1000);
        //    this.Close();

        //}
        private void btnOk_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact()
            {
                Person_FullName = txtName.Text,
                Person_Phone = txtPhone.Text,
                Person_Email = txtEmail.Text,
                Person_Address = txtAddress.Text,
                Person_Picture = destFilePath
            };

            try
            {
                if (index == 0)
                {
                    db = new ContactsUnit();
                    db.ContactsRepository.Insert(contact);
                    db.ContactsRepository.Save();

                }
                else
                {
                    db = new ContactsUnit();

                    contact.Person_ID = index;
                    db.ContactsRepository.Update(contact);
                    db.ContactsRepository.Save();
                }
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                // Handle the exception and provide a user-friendly error message
                MessageBox.Show("Error saving contact: " + ex.Message, "Error");
            }
        }
    }
}
