namespace MyContacts.App
{
    partial class AddOrEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtName = new AltoControls.AltoTextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new AltoControls.AltoTextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new AltoControls.AltoTextBox();
            this.txtAddress = new WiLBiT.WiLBiTTextBox();
            this.picPersonPicture = new WiLBiT.WiLBiTRoundedPictureBox2();
            this.btnOk = new AltoControls.AltoButton();
            this.btnCancel = new AltoControls.AltoButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picPersonPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Transparent;
            this.txtName.Br = System.Drawing.Color.White;
            this.txtName.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.txtName.ForeColor = System.Drawing.Color.DimGray;
            this.txtName.Location = new System.Drawing.Point(104, 8);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(135, 33);
            this.txtName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Motley Forces", 18F);
            this.lblName.Location = new System.Drawing.Point(8, 6);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(86, 39);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.Font = new System.Drawing.Font("Motley Forces", 18F);
            this.lblPhone.Location = new System.Drawing.Point(8, 45);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(96, 39);
            this.lblPhone.TabIndex = 1;
            this.lblPhone.Text = "phone:";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.Transparent;
            this.txtPhone.Br = System.Drawing.Color.White;
            this.txtPhone.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.txtPhone.ForeColor = System.Drawing.Color.DimGray;
            this.txtPhone.Location = new System.Drawing.Point(104, 48);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(135, 33);
            this.txtPhone.TabIndex = 2;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Motley Forces", 18F);
            this.lblAddress.Location = new System.Drawing.Point(12, 123);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(117, 39);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Address:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Motley Forces", 18F);
            this.lblEmail.Location = new System.Drawing.Point(8, 84);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(93, 39);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "E-Mail:";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.Br = System.Drawing.Color.White;
            this.txtEmail.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.txtEmail.ForeColor = System.Drawing.Color.DimGray;
            this.txtEmail.Location = new System.Drawing.Point(104, 87);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(135, 33);
            this.txtEmail.TabIndex = 3;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.SystemColors.Window;
            this.txtAddress.BorderColor = System.Drawing.Color.Transparent;
            this.txtAddress.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtAddress.BorderRadius = 15;
            this.txtAddress.BorderSize = 2;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAddress.Location = new System.Drawing.Point(13, 166);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtAddress.PasswordChar = false;
            this.txtAddress.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAddress.PlaceholderText = "";
            this.txtAddress.Size = new System.Drawing.Size(250, 108);
            this.txtAddress.TabIndex = 6;
            this.txtAddress.Texts = "";
            this.txtAddress.UnderlinedStyle = false;
            // 
            // picPersonPicture
            // 
            this.picPersonPicture.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.picPersonPicture.BorderColor = System.Drawing.Color.Red;
            this.picPersonPicture.BorderColor2 = System.Drawing.Color.Blue;
            this.picPersonPicture.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.picPersonPicture.BorderSize = 2;
            this.picPersonPicture.ErrorImage = null;
            this.picPersonPicture.GradientAngle = 50F;
            this.picPersonPicture.Image = global::MyContacts.App.Properties.Resources.icons8_trollface_96_1_;
            this.picPersonPicture.InitialImage = null;
            this.picPersonPicture.Location = new System.Drawing.Point(4, 281);
            this.picPersonPicture.Name = "picPersonPicture";
            this.picPersonPicture.Size = new System.Drawing.Size(100, 100);
            this.picPersonPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPersonPicture.TabIndex = 7;
            this.picPersonPicture.TabStop = false;
            this.picPersonPicture.Click += new System.EventHandler(this.wiLBiTRoundedPictureBox21_Click);
            // 
            // btnOk
            // 
            this.btnOk.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOk.Active2 = System.Drawing.Color.Lime;
            this.btnOk.BackColor = System.Drawing.Color.Transparent;
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Font = new System.Drawing.Font("Motley Forces", 18F);
            this.btnOk.ForeColor = System.Drawing.Color.Magenta;
            this.btnOk.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOk.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOk.Location = new System.Drawing.Point(121, 349);
            this.btnOk.Name = "btnOk";
            this.btnOk.Radius = 15;
            this.btnOk.Size = new System.Drawing.Size(142, 42);
            this.btnOk.Stroke = true;
            this.btnOk.StrokeColor = System.Drawing.Color.Lime;
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "Ok";
            this.btnOk.Transparency = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.Active2 = System.Drawing.Color.Red;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCancel.Font = new System.Drawing.Font("Motley Forces", 18F);
            this.btnCancel.ForeColor = System.Drawing.Color.Cyan;
            this.btnCancel.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.Location = new System.Drawing.Point(123, 301);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Radius = 15;
            this.btnCancel.Size = new System.Drawing.Size(142, 42);
            this.btnCancel.Stroke = true;
            this.btnCancel.StrokeColor = System.Drawing.Color.Red;
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Transparency = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AddOrEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(277, 403);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.picPersonPicture);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddOrEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddOrEdit";
            this.Load += new System.EventHandler(this.AddOrEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPersonPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AltoControls.AltoTextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblEmail;
        private AltoControls.AltoTextBox txtEmail;
        private AltoControls.AltoTextBox txtPhone;
        private WiLBiT.WiLBiTTextBox txtAddress;
        private WiLBiT.WiLBiTRoundedPictureBox2 picPersonPicture;
        private AltoControls.AltoButton btnOk;
        private AltoControls.AltoButton btnCancel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}