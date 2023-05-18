
namespace BankManagementSystem
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.picMin = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picSClose = new System.Windows.Forms.PictureBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.pnlSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSettings
            // 
            this.pnlSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(108)))), ((int)(((byte)(10)))));
            this.pnlSettings.Controls.Add(this.pictureBox3);
            this.pnlSettings.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSettings.Location = new System.Drawing.Point(0, 0);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(53, 345);
            this.pnlSettings.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(6, 12);
            this.pictureBox3.MaximumSize = new System.Drawing.Size(34, 34);
            this.pictureBox3.MinimumSize = new System.Drawing.Size(34, 34);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(109, 141);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(397, 30);
            this.txtId.TabIndex = 3;
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(108)))), ((int)(((byte)(10)))));
            this.btnChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChange.FlatAppearance.BorderSize = 0;
            this.btnChange.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(24)))));
            this.btnChange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(24)))));
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.ForeColor = System.Drawing.Color.White;
            this.btnChange.Location = new System.Drawing.Point(386, 260);
            this.btnChange.MaximumSize = new System.Drawing.Size(120, 40);
            this.btnChange.MinimumSize = new System.Drawing.Size(120, 40);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(120, 40);
            this.btnChange.TabIndex = 4;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Account Id";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Century Schoolbook", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(108)))), ((int)(((byte)(10)))));
            this.lblHeader.Location = new System.Drawing.Point(229, 16);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(112, 28);
            this.lblHeader.TabIndex = 5;
            this.lblHeader.Text = "Settings";
            // 
            // picMin
            // 
            this.picMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMin.Image = ((System.Drawing.Image)(resources.GetObject("picMin.Image")));
            this.picMin.Location = new System.Drawing.Point(508, 1);
            this.picMin.MaximumSize = new System.Drawing.Size(24, 24);
            this.picMin.MinimumSize = new System.Drawing.Size(24, 24);
            this.picMin.Name = "picMin";
            this.picMin.Size = new System.Drawing.Size(24, 24);
            this.picMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMin.TabIndex = 6;
            this.picMin.TabStop = false;
            this.picMin.Click += new System.EventHandler(this.picMin_Click);
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
            this.picClose.Location = new System.Drawing.Point(534, 1);
            this.picClose.MaximumSize = new System.Drawing.Size(24, 24);
            this.picClose.MinimumSize = new System.Drawing.Size(24, 24);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(24, 24);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 7;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // picSClose
            // 
            this.picSClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picSClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSClose.Image = ((System.Drawing.Image)(resources.GetObject("picSClose.Image")));
            this.picSClose.Location = new System.Drawing.Point(535, 50);
            this.picSClose.MaximumSize = new System.Drawing.Size(20, 20);
            this.picSClose.MinimumSize = new System.Drawing.Size(20, 20);
            this.picSClose.Name = "picSClose";
            this.picSClose.Size = new System.Drawing.Size(20, 20);
            this.picSClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSClose.TabIndex = 21;
            this.picSClose.TabStop = false;
            this.picSClose.Visible = false;
            this.picSClose.Click += new System.EventHandler(this.picSClose_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Location = new System.Drawing.Point(59, 48);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(499, 29);
            this.lblMsg.TabIndex = 20;
            this.lblMsg.Text = "Message";
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMsg.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "New Password";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(109, 210);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(397, 30);
            this.txtPass.TabIndex = 3;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 345);
            this.Controls.Add(this.picSClose);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.picMin);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlSettings);
            this.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximumSize = new System.Drawing.Size(560, 345);
            this.MinimumSize = new System.Drawing.Size(560, 345);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.pnlSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btnChange;
        public System.Windows.Forms.Panel pnlSettings;
        public System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.TextBox txtId;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblHeader;
        public System.Windows.Forms.PictureBox picMin;
        public System.Windows.Forms.PictureBox picClose;
        public System.Windows.Forms.PictureBox picSClose;
        public System.Windows.Forms.Label lblMsg;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtPass;
    }
}