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
using MyContacts.Data;
using MyContacts.Data.Context;

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
            AddOrEdit aoe = new AddOrEdit();

            aoe.Show();
        }

        private void wiLBiTRoundedPictureBox1_Click(object sender, EventArgs e)
        {
            SelectMethod();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            SelectMethod();
        }

        private void SelectMethod()
        {
            panBody.Controls.Clear();
            var contacts = db.ContactsRepository.Selecet();
            int i = 1;
            foreach (var contact in contacts)
            {
                //MemberGen(i,contact.Person_FullName,contact.Person_Phone,contact.Person_Picture);
                i++;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            AddOrEdit aoe = new AddOrEdit();

            aoe.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
           var result = db.ContactsRepository.SelecetByFillter(txtSearch.Text);

            panBody.Controls.Clear();
            int i = 1;
            foreach (var contact in result)
            {
                //MemberGen(i, contact.Person_FullName, contact.Person_Phone, contact.Person_Picture);
                i++;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Visible = !txtSearch.Visible;
        }

        private void panPerson1_Click(object sender, EventArgs e)
        {

        }
    }
}
