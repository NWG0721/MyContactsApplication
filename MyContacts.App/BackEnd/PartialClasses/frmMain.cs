using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WiLBiT;

namespace MyContacts.App
{
    public partial class frmMain
    {
        private void MemberGen(int index, string name, string phone, string picture)
        {
            WiLBiTPanel mainPanel = new WiLBiT.WiLBiTPanel();

            System.Windows.Forms.Label lblPersonPhone = new System.Windows.Forms.Label();

            System.Windows.Forms.Splitter splitPersonPhone = new System.Windows.Forms.Splitter();

            System.Windows.Forms.Label lblPerson = new System.Windows.Forms.Label();

            System.Windows.Forms.Splitter spiltPerson = new System.Windows.Forms.Splitter();

            WiLBiT.WiLBiTRoundedPictureBox2 picPerson = new WiLBiT.WiLBiTRoundedPictureBox2();


            mainPanel.BackColor = System.Drawing.Color.Transparent;
            mainPanel.BorderColor = System.Drawing.Color.Cyan;
            mainPanel.BorderRadius = 0;
            mainPanel.BorderSize = 1;
            mainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            mainPanel.ForeColor = System.Drawing.Color.White;
            mainPanel.Location = new System.Drawing.Point(0, 74);
            mainPanel.Name = "panPerson" + index;
            mainPanel.Size = new System.Drawing.Size(400, 73);
            mainPanel.TabIndex = 0;



            lblPersonPhone.AutoSize = true;
            lblPersonPhone.Dock = System.Windows.Forms.DockStyle.Left;
            lblPersonPhone.Font = new System.Drawing.Font("Motley Forces", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPersonPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            lblPersonPhone.Location = new System.Drawing.Point(176, 30);
            lblPersonPhone.Name = "lblPerson" + index + "Phone";
            lblPersonPhone.Size = new System.Drawing.Size(154, 39);
            lblPersonPhone.TabIndex = 9;
            lblPersonPhone.Text = phone;



            splitPersonPhone.BackColor = System.Drawing.Color.Black;
            splitPersonPhone.Dock = System.Windows.Forms.DockStyle.Top;
            splitPersonPhone.Location = new System.Drawing.Point(176, 15);
            splitPersonPhone.Name = "splitPerson" + index + "Phone";
            splitPersonPhone.Size = new System.Drawing.Size(224, 15);
            splitPersonPhone.TabIndex = 8;
            splitPersonPhone.TabStop = false;



            lblPerson.AutoSize = true;
            lblPerson.Dock = System.Windows.Forms.DockStyle.Left;
            lblPerson.Font = new System.Drawing.Font("Motley Forces", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPerson.ForeColor = System.Drawing.Color.Silver;
            lblPerson.Location = new System.Drawing.Point(72, 15);
            lblPerson.Name = "lblPerson" + index;
            lblPerson.Size = new System.Drawing.Size(104, 39);
            lblPerson.TabIndex = 7;
            lblPerson.Text = name;



            spiltPerson.BackColor = System.Drawing.Color.Black;
            spiltPerson.Dock = System.Windows.Forms.DockStyle.Top;
            spiltPerson.Location = new System.Drawing.Point(72, 0);
            spiltPerson.Name = "spiltPerson" + index;
            spiltPerson.Size = new System.Drawing.Size(328, 15);
            spiltPerson.TabIndex = 6;
            spiltPerson.TabStop = false;



            picPerson.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            picPerson.BorderColor = System.Drawing.Color.RoyalBlue;
            picPerson.BorderColor2 = System.Drawing.Color.HotPink;
            picPerson.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            picPerson.BorderSize = 2;
            picPerson.Dock = System.Windows.Forms.DockStyle.Left;
            picPerson.GradientAngle = 50F;
            picPerson.Location = new System.Drawing.Point(0, 0);
            picPerson.Name = "picPerson" + index;
            picPerson.Size = new System.Drawing.Size(72, 72);
            picPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picPerson.TabIndex = 5;
            picPerson.TabStop = false;
            if (picture == "none")
            {
                picPerson.Image = global::MyContacts.App.Properties.Resources.icons8_trollface_96_1_;
            }
            else
            {
                picPerson.ImageLocation = picture;
            }


            panBody.Controls.Add(mainPanel);
            mainPanel.Controls.Add(lblPersonPhone);
            mainPanel.Controls.Add(splitPersonPhone);
            mainPanel.Controls.Add(lblPerson);
            mainPanel.Controls.Add(spiltPerson);
            mainPanel.Controls.Add(picPerson);
        }
    }
}
