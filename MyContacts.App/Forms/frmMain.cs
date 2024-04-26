using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyContacts.App.Forms;
using MyContacts.Data;
using MyContacts.Data.Context;
using WiLBiT;

namespace MyContacts.App
{
    public partial class frmMain : Form
    {
        //
        //For moving form
        //
        [DllImport("user32.dll")]
        private static extern int ReleaseCapture();
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        private const int WM_SYSCOMMAND = 0x112;
        private const int SC_MOVE = 0xF010;

        int height = Screen.PrimaryScreen.Bounds.Height;
        int width = Screen.PrimaryScreen.Bounds.Width;

        public void Header_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_SYSCOMMAND, SC_MOVE | 0x2, 0);
            }
        }
        //
        //For moving form
        //


        public int index = 0;

        public frmMain()
        {
            InitializeComponent();
        }



        ContactsUnit db = new ContactsUnit();

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddOrEdit add = new AddOrEdit(0);
            if (add.ShowDialog() == DialogResult.OK)
            {
                SelectMethod();
            }
        }

        private void wiLBiTRoundedPictureBox1_Click(object sender, EventArgs e)
        {
            SelectMethod();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Hide();
            SelectMethod();
            this.Show();
        }

        private void SelectMethod()
        {
            panBody.Controls.Clear();
            db.ContactsRepository.Save();
            var contacts = db.ContactsRepository.Selecet();
            foreach (var contact in contacts)
            {
                MemberGen(contact.Person_ID, contact.Person_FullName, contact.Person_Phone, contact.Person_Picture);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (index != 0)
            {
                AddOrEdit edit = new AddOrEdit(index);
                edit.index = index;
                if (edit.ShowDialog() == DialogResult.OK)
                {
                    SelectMethod();
                    index = 0;
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var result = db.ContactsRepository.SelecetByFillter(txtSearch.Text);

            panBody.Controls.Clear();
            int i = 1;
            foreach (var contact in result)
            {
                MemberGen(i, contact.Person_FullName, contact.Person_Phone, contact.Person_Picture);
                i++;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Visible = !txtSearch.Visible;
        }

        //private WiLBiTPanel panNow;
        //private WiLBiTPanel panLast;

        //public void panPerson_Click(object sender, EventArgs e)
        //{
        //    panNow = sender as WiLBiTPanel;
        //    panLast = new WiLBiTPanel();
        //    panLast.BorderColor = Color.Cyan;
        //    string selectedRowName = panNow.Name;
        //    //int index = int. Parse(selectedRowName.Remove(0, 7));
        //    string indexS = (selectedRowName.Remove(0, 9));
        //    panNow.BorderColor = Color.Red;
        //    panLast = panNow;
        //    MessageBox.Show(indexS.ToString());
        //}
        private WiLBiTPanel panNow;

        public void panPerson_Click(object sender, EventArgs e)
        {


        }


        private int GetIndexFromPanelName(string name)

        {

            string prefix = "panPerson";

            if (name.StartsWith(prefix))

            {

                string indexStr = name.Substring(prefix.Length);

                if (int.TryParse(indexStr, out int index))

                {

                    return index;

                }

            }

            return -1;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (index != 0)
            {
                if (MessageBox.Show("Do you want to delete " + db.ContactsRepository.SelectById(index).Person_FullName + "??", "RealyNig..", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.ContactsRepository.DeleteByRow(index);
                    db.ContactsRepository.Save();
                    SelectMethod();
                    index = 0;
                }

            }
        }




        frmInfo info;
        private void panPerson_MouseClick(object sender, MouseEventArgs e)
        {
            WiLBiTPanel panel = sender as WiLBiTPanel;
            index = GetIndexFromPanelName(panel.Name);
            if (e.Button == MouseButtons.Right)
            {
                info = new frmInfo(db.ContactsRepository.SelectById(index).Person_Email, db.ContactsRepository.SelectById(index).Person_Address);
                info.Close();
                info = new frmInfo(db.ContactsRepository.SelectById(index).Person_Email, db.ContactsRepository.SelectById(index).Person_Address);
                info.Show();
            }
            if (e.Button == MouseButtons.Left)
            {
                if (panel != null)

                {
                    if (index >= 0)

                    {

                        if (panNow != null)

                        {

                            panNow.BorderColor = Color.Cyan;

                        }

                        panel.BorderColor = Color.Red;

                        panNow = panel;

                        //MessageBox.Show(index.ToString());

                    }

                }
            }
        }
    }
}
