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


        public AddOrEdit()
        {
            InitializeComponent();
        }

        private void AddOrEdit_Load(object sender, EventArgs e)
        {

        }

        private void wiLBiTRoundedPictureBox21_Click(object sender, EventArgs e)
        {
            string appPath = Application.StartupPath;
            string dir = appPath+@"\Images";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            string fileName = openFileDialog1.FileName;
            openFileDialog1.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.img";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
                destFilePath = Path.Combine(dir, openFileDialog1.SafeFileName);
                if (!File.Exists(destFilePath))
                {
                    File.Copy(fileName, destFilePath);
                }

                wiLBiTRoundedPictureBox21.Image = Image.FromFile(destFilePath);
            }
            else
            {
                wiLBiTRoundedPictureBox21.Image = global::MyContacts.App.Properties.Resources.icons8_trollface_96_1_;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
           
            ContactsUnit db = new ContactsUnit();
            Contact newContact = new Contact()
            {
                Person_FullName = txtName.Text,
                Person_Phone = txtPhone.Text,
                Person_Email = txtEmail.Text,
                Person_Address = txtEmail.Text,
                Person_Picture = destFilePath
            };
            bool getter = db.ContactsRepository.Insert(newContact);
            //MessageBox.Show(getter.ToString());
            db.ContactsRepository.Save();
            db.Dispose();
            Thread.Sleep(1000);
            this.Close();
        }
    }
}
