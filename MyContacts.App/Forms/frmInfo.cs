using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyContacts.App.Forms
{
    public partial class frmInfo : Form
    {
        string eMail;
        string address;
        public frmInfo(string eMail,string address)
        {
            InitializeComponent();
            this.eMail = eMail;
            this.address = address;
        }

        private void frmInfo_Load(object sender, EventArgs e)
        {
            int x = Cursor.Position.X;
            int y = Cursor.Position.Y;
            this.Location = new Point(x, y);
            txtEmail.Text = eMail;
            txtAddress.Text = address;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
