namespace MyContacts.App.Forms
{
    partial class frmInfo
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
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtEmail = new AltoControls.AltoSlidingLabel();
            this.txtAddress = new AltoControls.AltoSlidingLabel();
            this.btnClose = new AltoControls.AltoButton();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Motley Forces", 18F);
            this.lblEmail.Location = new System.Drawing.Point(12, 49);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(89, 39);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email: ";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Motley Forces", 18F);
            this.lblAddress.Location = new System.Drawing.Point(12, 120);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(122, 39);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Address: ";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtEmail.Font = new System.Drawing.Font("Motley Forces", 18F);
            this.txtEmail.Location = new System.Drawing.Point(107, 56);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(156, 47);
            this.txtEmail.Slide = false;
            this.txtEmail.TabIndex = 3;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.Transparent;
            this.txtAddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtAddress.Font = new System.Drawing.Font("Motley Forces", 18F);
            this.txtAddress.Location = new System.Drawing.Point(128, 125);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(156, 47);
            this.txtAddress.Slide = false;
            this.txtAddress.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.Active1 = System.Drawing.Color.Red;
            this.btnClose.Active2 = System.Drawing.Color.Red;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnClose.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Inactive1 = System.Drawing.Color.White;
            this.btnClose.Inactive2 = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(223, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Radius = 10;
            this.btnClose.Size = new System.Drawing.Size(65, 30);
            this.btnClose.Stroke = false;
            this.btnClose.StrokeColor = System.Drawing.Color.Gray;
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.Transparency = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmInfo";
            this.Load += new System.EventHandler(this.frmInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAddress;
        private AltoControls.AltoSlidingLabel txtEmail;
        private AltoControls.AltoSlidingLabel txtAddress;
        private AltoControls.AltoButton btnClose;
    }
}