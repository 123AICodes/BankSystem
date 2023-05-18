
namespace BankManagementSystem
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.pnlMainPanel = new System.Windows.Forms.Panel();
            this.picSClose = new System.Windows.Forms.PictureBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.cmbTheme = new System.Windows.Forms.ComboBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnAgent = new System.Windows.Forms.Button();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picMin = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnlMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMainPanel
            // 
            this.pnlMainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(108)))), ((int)(((byte)(10)))));
            this.pnlMainPanel.Controls.Add(this.btnDashboard);
            this.pnlMainPanel.Controls.Add(this.picSClose);
            this.pnlMainPanel.Controls.Add(this.btnApply);
            this.pnlMainPanel.Controls.Add(this.lblMsg);
            this.pnlMainPanel.Controls.Add(this.cmbTheme);
            this.pnlMainPanel.Controls.Add(this.lblRole);
            this.pnlMainPanel.Controls.Add(this.btnAdmin);
            this.pnlMainPanel.Controls.Add(this.btnSettings);
            this.pnlMainPanel.Controls.Add(this.btnAgent);
            this.pnlMainPanel.Controls.Add(this.btnTransaction);
            this.pnlMainPanel.Controls.Add(this.btnAccount);
            this.pnlMainPanel.Controls.Add(this.label2);
            this.pnlMainPanel.Controls.Add(this.picLogo);
            this.pnlMainPanel.Controls.Add(this.picMin);
            this.pnlMainPanel.Controls.Add(this.picClose);
            this.pnlMainPanel.Location = new System.Drawing.Point(12, 12);
            this.pnlMainPanel.Name = "pnlMainPanel";
            this.pnlMainPanel.Size = new System.Drawing.Size(536, 461);
            this.pnlMainPanel.TabIndex = 0;
            // 
            // picSClose
            // 
            this.picSClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picSClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSClose.Image = ((System.Drawing.Image)(resources.GetObject("picSClose.Image")));
            this.picSClose.Location = new System.Drawing.Point(501, 327);
            this.picSClose.MaximumSize = new System.Drawing.Size(20, 20);
            this.picSClose.MinimumSize = new System.Drawing.Size(20, 20);
            this.picSClose.Name = "picSClose";
            this.picSClose.Size = new System.Drawing.Size(20, 20);
            this.picSClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSClose.TabIndex = 22;
            this.picSClose.TabStop = false;
            this.picSClose.Visible = false;
            this.picSClose.Click += new System.EventHandler(this.picSClose_Click);
            // 
            // btnApply
            // 
            this.btnApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApply.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(108)))), ((int)(((byte)(10)))));
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnApply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Image = ((System.Drawing.Image)(resources.GetObject("btnApply.Image")));
            this.btnApply.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnApply.Location = new System.Drawing.Point(13, 398);
            this.btnApply.MaximumSize = new System.Drawing.Size(510, 40);
            this.btnApply.MinimumSize = new System.Drawing.Size(510, 40);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(510, 40);
            this.btnApply.TabIndex = 15;
            this.btnApply.Text = "Apply Theme";
            this.btnApply.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click_1);
            // 
            // lblMsg
            // 
            this.lblMsg.Location = new System.Drawing.Point(18, 322);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(505, 26);
            this.lblMsg.TabIndex = 12;
            this.lblMsg.Text = "Select Theme";
            // 
            // cmbTheme
            // 
            this.cmbTheme.BackColor = System.Drawing.Color.White;
            this.cmbTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTheme.FormattingEnabled = true;
            this.cmbTheme.Items.AddRange(new object[] {
            " Indigo",
            "Purple",
            "Crimson",
            "Default"});
            this.cmbTheme.Location = new System.Drawing.Point(13, 352);
            this.cmbTheme.Name = "cmbTheme";
            this.cmbTheme.Size = new System.Drawing.Size(510, 34);
            this.cmbTheme.TabIndex = 13;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(79, -3);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(46, 28);
            this.lblRole.TabIndex = 11;
            this.lblRole.Text = "Role";
            this.lblRole.Visible = false;
            // 
            // btnAdmin
            // 
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(108)))), ((int)(((byte)(10)))));
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmin.Image")));
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.Location = new System.Drawing.Point(204, 15);
            this.btnAdmin.MaximumSize = new System.Drawing.Size(510, 40);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(97, 40);
            this.btnAdmin.TabIndex = 10;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(108)))), ((int)(((byte)(10)))));
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(13, 266);
            this.btnSettings.MaximumSize = new System.Drawing.Size(510, 40);
            this.btnSettings.MinimumSize = new System.Drawing.Size(510, 40);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(510, 40);
            this.btnSettings.TabIndex = 9;
            this.btnSettings.Text = "Password Settings";
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnAgent
            // 
            this.btnAgent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(108)))), ((int)(((byte)(10)))));
            this.btnAgent.FlatAppearance.BorderSize = 0;
            this.btnAgent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnAgent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnAgent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgent.Image = ((System.Drawing.Image)(resources.GetObject("btnAgent.Image")));
            this.btnAgent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgent.Location = new System.Drawing.Point(13, 208);
            this.btnAgent.MaximumSize = new System.Drawing.Size(510, 40);
            this.btnAgent.MinimumSize = new System.Drawing.Size(510, 40);
            this.btnAgent.Name = "btnAgent";
            this.btnAgent.Size = new System.Drawing.Size(510, 40);
            this.btnAgent.TabIndex = 8;
            this.btnAgent.Text = "Manage Agents";
            this.btnAgent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgent.UseVisualStyleBackColor = true;
            this.btnAgent.Click += new System.EventHandler(this.btnAgent_Click);
            // 
            // btnTransaction
            // 
            this.btnTransaction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransaction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(108)))), ((int)(((byte)(10)))));
            this.btnTransaction.FlatAppearance.BorderSize = 0;
            this.btnTransaction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnTransaction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaction.Image = ((System.Drawing.Image)(resources.GetObject("btnTransaction.Image")));
            this.btnTransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransaction.Location = new System.Drawing.Point(13, 150);
            this.btnTransaction.MaximumSize = new System.Drawing.Size(510, 40);
            this.btnTransaction.MinimumSize = new System.Drawing.Size(510, 40);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(510, 40);
            this.btnTransaction.TabIndex = 7;
            this.btnTransaction.Text = "Manage Transactions";
            this.btnTransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTransaction.UseVisualStyleBackColor = true;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(108)))), ((int)(((byte)(10)))));
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnAccount.Image")));
            this.btnAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.Location = new System.Drawing.Point(13, 92);
            this.btnAccount.MaximumSize = new System.Drawing.Size(510, 40);
            this.btnAccount.MinimumSize = new System.Drawing.Size(510, 40);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(510, 40);
            this.btnAccount.TabIndex = 6;
            this.btnAccount.Text = "Manage Accounts";
            this.btnAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Main Menu";
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(13, 15);
            this.picLogo.MaximumSize = new System.Drawing.Size(60, 60);
            this.picLogo.MinimumSize = new System.Drawing.Size(60, 60);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(60, 60);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 3;
            this.picLogo.TabStop = false;
            // 
            // picMin
            // 
            this.picMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMin.Image = ((System.Drawing.Image)(resources.GetObject("picMin.Image")));
            this.picMin.Location = new System.Drawing.Point(470, 15);
            this.picMin.MaximumSize = new System.Drawing.Size(24, 24);
            this.picMin.MinimumSize = new System.Drawing.Size(24, 24);
            this.picMin.Name = "picMin";
            this.picMin.Size = new System.Drawing.Size(24, 24);
            this.picMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMin.TabIndex = 1;
            this.picMin.TabStop = false;
            this.picMin.Click += new System.EventHandler(this.picMin_Click);
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
            this.picClose.Location = new System.Drawing.Point(500, 15);
            this.picClose.MaximumSize = new System.Drawing.Size(24, 24);
            this.picClose.MinimumSize = new System.Drawing.Size(24, 24);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(24, 24);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 2;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(108)))), ((int)(((byte)(10)))));
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(307, 15);
            this.btnDashboard.MaximumSize = new System.Drawing.Size(510, 40);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(143, 40);
            this.btnDashboard.TabIndex = 23;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(212)))), ((int)(((byte)(188)))));
            this.ClientSize = new System.Drawing.Size(560, 485);
            this.Controls.Add(this.pnlMainPanel);
            this.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximumSize = new System.Drawing.Size(560, 485);
            this.MinimumSize = new System.Drawing.Size(560, 485);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.TopMost = true;
            this.pnlMainPanel.ResumeLayout(false);
            this.pnlMainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picMin;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnAgent;
        private System.Windows.Forms.Button btnTransaction;
        public System.Windows.Forms.Panel pnlMainPanel;
        private System.Windows.Forms.Button btnAdmin;
        public System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label lblMsg;
        public System.Windows.Forms.ComboBox cmbTheme;
        private System.Windows.Forms.PictureBox picSClose;
        private System.Windows.Forms.Button btnDashboard;
    }
}