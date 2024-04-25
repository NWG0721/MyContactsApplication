namespace MyContacts.App
{
    partial class frmMain
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
            this.panHeader = new System.Windows.Forms.Panel();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.picLogo = new WiLBiT.WiLBiTRoundedPictureBox();
            this.btnExit = new AltoControls.AltoButton();
            this.lblHeaderMyContacts = new System.Windows.Forms.Label();
            this.Animator = new WiLBiT.WiLBiTAnimations();
            this.SplitHeadAndBody = new System.Windows.Forms.Splitter();
            this.panFooter = new WiLBiT.WiLBiTGradientPanel();
            this.btnUpdate = new AltoControls.AltoButton();
            this.btnSearch = new AltoControls.AltoButton();
            this.btnDelete = new AltoControls.AltoButton();
            this.btnAdd = new AltoControls.AltoButton();
            this.txtSearch = new AltoControls.AltoTextBox();
            this.panBody = new System.Windows.Forms.Panel();
            this.panPerson1 = new WiLBiT.WiLBiTPanel();
            this.lblPerson1Phone = new System.Windows.Forms.Label();
            this.splitPerson1Phone = new System.Windows.Forms.Splitter();
            this.lblPerson1 = new System.Windows.Forms.Label();
            this.spiltPerson1 = new System.Windows.Forms.Splitter();
            this.picPerson1 = new WiLBiT.WiLBiTRoundedPictureBox2();
            this.panHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panFooter.SuspendLayout();
            this.panBody.SuspendLayout();
            this.panPerson1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPerson1)).BeginInit();
            this.SuspendLayout();
            // 
            // panHeader
            // 
            this.panHeader.Controls.Add(this.dgvUsers);
            this.panHeader.Controls.Add(this.picLogo);
            this.panHeader.Controls.Add(this.btnExit);
            this.panHeader.Controls.Add(this.lblHeaderMyContacts);
            this.panHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHeader.Location = new System.Drawing.Point(0, 0);
            this.panHeader.Name = "panHeader";
            this.panHeader.Size = new System.Drawing.Size(400, 57);
            this.panHeader.TabIndex = 0;
            this.panHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(206, 6);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.Size = new System.Drawing.Size(137, 44);
            this.dgvUsers.TabIndex = 1;
            this.dgvUsers.Visible = false;
            // 
            // picLogo
            // 
            this.picLogo.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.picLogo.BorderColor = System.Drawing.Color.Red;
            this.picLogo.BorderColor2 = System.Drawing.Color.Black;
            this.picLogo.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.picLogo.BorderSize = 2;
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.picLogo.GradientAngle = 50F;
            this.picLogo.Image = global::MyContacts.App.Properties.Resources.icons8_trollface_96_1_;
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(50, 50);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 3;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.wiLBiTRoundedPictureBox1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Active1 = System.Drawing.Color.Red;
            this.btnExit.Active2 = System.Drawing.Color.Red;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.Font = new System.Drawing.Font("Motley Forces", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Cyan;
            this.btnExit.Inactive1 = System.Drawing.Color.Transparent;
            this.btnExit.Inactive2 = System.Drawing.Color.Transparent;
            this.btnExit.Location = new System.Drawing.Point(343, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Radius = 27;
            this.btnExit.Size = new System.Drawing.Size(57, 57);
            this.btnExit.Stroke = true;
            this.btnExit.StrokeColor = System.Drawing.Color.Red;
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "X";
            this.btnExit.Transparency = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblHeaderMyContacts
            // 
            this.lblHeaderMyContacts.AutoSize = true;
            this.lblHeaderMyContacts.Font = new System.Drawing.Font("Motley Forces", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderMyContacts.ForeColor = System.Drawing.Color.Red;
            this.lblHeaderMyContacts.Location = new System.Drawing.Point(50, 8);
            this.lblHeaderMyContacts.Name = "lblHeaderMyContacts";
            this.lblHeaderMyContacts.Size = new System.Drawing.Size(158, 39);
            this.lblHeaderMyContacts.TabIndex = 0;
            this.lblHeaderMyContacts.Text = "My Contacts";
            // 
            // SplitHeadAndBody
            // 
            this.SplitHeadAndBody.BackColor = System.Drawing.Color.Red;
            this.SplitHeadAndBody.Dock = System.Windows.Forms.DockStyle.Top;
            this.SplitHeadAndBody.Location = new System.Drawing.Point(0, 57);
            this.SplitHeadAndBody.Name = "SplitHeadAndBody";
            this.SplitHeadAndBody.Size = new System.Drawing.Size(400, 1);
            this.SplitHeadAndBody.TabIndex = 1;
            this.SplitHeadAndBody.TabStop = false;
            // 
            // panFooter
            // 
            this.panFooter.BackColor = System.Drawing.Color.Black;
            this.panFooter.BackColor2 = System.Drawing.Color.Black;
            this.panFooter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panFooter.BorderColor = System.Drawing.Color.OrangeRed;
            this.panFooter.BorderRadius = 0;
            this.panFooter.BorderSize = 0;
            this.panFooter.Controls.Add(this.btnUpdate);
            this.panFooter.Controls.Add(this.btnSearch);
            this.panFooter.Controls.Add(this.btnDelete);
            this.panFooter.Controls.Add(this.btnAdd);
            this.panFooter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panFooter.ForeColor = System.Drawing.Color.White;
            this.panFooter.Location = new System.Drawing.Point(0, 672);
            this.panFooter.Name = "panFooter";
            this.panFooter.Size = new System.Drawing.Size(400, 69);
            this.panFooter.TabIndex = 2;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Active1 = System.Drawing.Color.Black;
            this.btnUpdate.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnUpdate.Font = new System.Drawing.Font("Motley Forces", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Cyan;
            this.btnUpdate.Inactive1 = System.Drawing.Color.Black;
            this.btnUpdate.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUpdate.Location = new System.Drawing.Point(200, 0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Radius = 27;
            this.btnUpdate.Size = new System.Drawing.Size(100, 69);
            this.btnUpdate.Stroke = true;
            this.btnUpdate.StrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "E";
            this.btnUpdate.Transparency = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Active1 = System.Drawing.Color.Black;
            this.btnSearch.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSearch.Font = new System.Drawing.Font("Motley Forces", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Magenta;
            this.btnSearch.Inactive1 = System.Drawing.Color.Transparent;
            this.btnSearch.Inactive2 = System.Drawing.Color.Lime;
            this.btnSearch.Location = new System.Drawing.Point(100, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Radius = 27;
            this.btnSearch.Size = new System.Drawing.Size(100, 69);
            this.btnSearch.Stroke = true;
            this.btnSearch.StrokeColor = System.Drawing.Color.Lime;
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "S";
            this.btnSearch.Transparency = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Active1 = System.Drawing.Color.Black;
            this.btnDelete.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDelete.Font = new System.Drawing.Font("Motley Forces", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Blue;
            this.btnDelete.Inactive1 = System.Drawing.Color.Black;
            this.btnDelete.Inactive2 = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(300, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Radius = 27;
            this.btnDelete.Size = new System.Drawing.Size(100, 69);
            this.btnDelete.Stroke = true;
            this.btnDelete.StrokeColor = System.Drawing.Color.Red;
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "D";
            this.btnDelete.Transparency = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Active1 = System.Drawing.Color.Black;
            this.btnAdd.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdd.Font = new System.Drawing.Font("Motley Forces", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Red;
            this.btnAdd.Inactive1 = System.Drawing.Color.Black;
            this.btnAdd.Inactive2 = System.Drawing.Color.Blue;
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Radius = 27;
            this.btnAdd.Size = new System.Drawing.Size(100, 69);
            this.btnAdd.Stroke = true;
            this.btnAdd.StrokeColor = System.Drawing.Color.Cyan;
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "A";
            this.btnAdd.Transparency = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.Br = System.Drawing.Color.White;
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSearch.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtSearch.Location = new System.Drawing.Point(0, 58);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(400, 57);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.Visible = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // panBody
            // 
            this.panBody.AutoScroll = true;
            this.panBody.BackColor = System.Drawing.Color.Transparent;
            this.panBody.Controls.Add(this.panPerson1);
            this.panBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panBody.Location = new System.Drawing.Point(0, 115);
            this.panBody.Name = "panBody";
            this.panBody.Size = new System.Drawing.Size(400, 557);
            this.panBody.TabIndex = 10;
            // 
            // panPerson1
            // 
            this.panPerson1.BackColor = System.Drawing.Color.Transparent;
            this.panPerson1.BorderColor = System.Drawing.Color.Cyan;
            this.panPerson1.BorderRadius = 0;
            this.panPerson1.BorderSize = 1;
            this.panPerson1.Controls.Add(this.lblPerson1Phone);
            this.panPerson1.Controls.Add(this.splitPerson1Phone);
            this.panPerson1.Controls.Add(this.lblPerson1);
            this.panPerson1.Controls.Add(this.spiltPerson1);
            this.panPerson1.Controls.Add(this.picPerson1);
            this.panPerson1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panPerson1.ForeColor = System.Drawing.Color.White;
            this.panPerson1.Location = new System.Drawing.Point(0, 0);
            this.panPerson1.Name = "panPerson1";
            this.panPerson1.Size = new System.Drawing.Size(400, 84);
            this.panPerson1.TabIndex = 0;
            this.panPerson1.Click += new System.EventHandler(this.panPerson1_Click);
            // 
            // lblPerson1Phone
            // 
            this.lblPerson1Phone.AutoSize = true;
            this.lblPerson1Phone.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblPerson1Phone.Font = new System.Drawing.Font("Motley Forces", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerson1Phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblPerson1Phone.Location = new System.Drawing.Point(176, 30);
            this.lblPerson1Phone.Name = "lblPerson1Phone";
            this.lblPerson1Phone.Size = new System.Drawing.Size(154, 39);
            this.lblPerson1Phone.TabIndex = 9;
            this.lblPerson1Phone.Text = "09123456789";
            // 
            // splitPerson1Phone
            // 
            this.splitPerson1Phone.BackColor = System.Drawing.Color.Black;
            this.splitPerson1Phone.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitPerson1Phone.Location = new System.Drawing.Point(176, 15);
            this.splitPerson1Phone.Name = "splitPerson1Phone";
            this.splitPerson1Phone.Size = new System.Drawing.Size(224, 15);
            this.splitPerson1Phone.TabIndex = 8;
            this.splitPerson1Phone.TabStop = false;
            // 
            // lblPerson1
            // 
            this.lblPerson1.AutoSize = true;
            this.lblPerson1.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblPerson1.Font = new System.Drawing.Font("Motley Forces", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerson1.ForeColor = System.Drawing.Color.Silver;
            this.lblPerson1.Location = new System.Drawing.Point(72, 15);
            this.lblPerson1.Name = "lblPerson1";
            this.lblPerson1.Size = new System.Drawing.Size(104, 39);
            this.lblPerson1.TabIndex = 7;
            this.lblPerson1.Text = "Person1";
            // 
            // spiltPerson1
            // 
            this.spiltPerson1.BackColor = System.Drawing.Color.Black;
            this.spiltPerson1.Dock = System.Windows.Forms.DockStyle.Top;
            this.spiltPerson1.Location = new System.Drawing.Point(72, 0);
            this.spiltPerson1.Name = "spiltPerson1";
            this.spiltPerson1.Size = new System.Drawing.Size(328, 15);
            this.spiltPerson1.TabIndex = 6;
            this.spiltPerson1.TabStop = false;
            // 
            // picPerson1
            // 
            this.picPerson1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.picPerson1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.picPerson1.BorderColor2 = System.Drawing.Color.HotPink;
            this.picPerson1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.picPerson1.BorderSize = 2;
            this.picPerson1.Dock = System.Windows.Forms.DockStyle.Left;
            this.picPerson1.GradientAngle = 50F;
            this.picPerson1.Location = new System.Drawing.Point(0, 0);
            this.picPerson1.Name = "picPerson1";
            this.picPerson1.Size = new System.Drawing.Size(72, 72);
            this.picPerson1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPerson1.TabIndex = 5;
            this.picPerson1.TabStop = false;
            // 
            // frmApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(400, 741);
            this.Controls.Add(this.panBody);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panFooter);
            this.Controls.Add(this.SplitHeadAndBody);
            this.Controls.Add(this.panHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmApplication";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panHeader.ResumeLayout(false);
            this.panHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panFooter.ResumeLayout(false);
            this.panBody.ResumeLayout(false);
            this.panPerson1.ResumeLayout(false);
            this.panPerson1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPerson1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panHeader;
        private System.Windows.Forms.Label lblHeaderMyContacts;
        private WiLBiT.WiLBiTAnimations Animator;
        private System.Windows.Forms.Splitter SplitHeadAndBody;
        private AltoControls.AltoButton btnExit;
        private WiLBiT.WiLBiTRoundedPictureBox picLogo;
        private WiLBiT.WiLBiTGradientPanel panFooter;
        private AltoControls.AltoButton btnDelete;
        private AltoControls.AltoButton btnAdd;
        private AltoControls.AltoButton btnUpdate;
        private AltoControls.AltoButton btnSearch;
        private System.Windows.Forms.DataGridView dgvUsers;
        private AltoControls.AltoTextBox txtSearch;
        private System.Windows.Forms.Panel panBody;
        private WiLBiT.WiLBiTPanel panPerson1;
        private System.Windows.Forms.Label lblPerson1Phone;
        private System.Windows.Forms.Splitter splitPerson1Phone;
        private System.Windows.Forms.Label lblPerson1;
        private System.Windows.Forms.Splitter spiltPerson1;
        private WiLBiT.WiLBiTRoundedPictureBox2 picPerson1;
    }
}

