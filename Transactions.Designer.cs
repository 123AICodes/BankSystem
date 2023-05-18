
namespace BankManagementSystem
{
    partial class Transactions
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transactions));
            this.pnlTransactions = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.picMin = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.txtCBAccountNo = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.gpbCheckBalance = new System.Windows.Forms.GroupBox();
            this.lblCurrentBal = new System.Windows.Forms.Label();
            this.picCBClose = new System.Windows.Forms.PictureBox();
            this.lblCBMsg = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.gpbWithdrawal = new System.Windows.Forms.GroupBox();
            this.picWClose = new System.Windows.Forms.PictureBox();
            this.lblWMsg = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtWAmount = new System.Windows.Forms.TextBox();
            this.btnWithdrawal = new System.Windows.Forms.Button();
            this.txtWAccountNo = new System.Windows.Forms.TextBox();
            this.gpbTransferMoney = new System.Windows.Forms.GroupBox();
            this.picTClose = new System.Windows.Forms.PictureBox();
            this.lblTMsg = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.txtTAmount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.btnTo = new System.Windows.Forms.Button();
            this.btnFrom = new System.Windows.Forms.Button();
            this.gpbDeposit = new System.Windows.Forms.GroupBox();
            this.picDClose = new System.Windows.Forms.PictureBox();
            this.lblDMsg = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDAmount = new System.Windows.Forms.TextBox();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.txtDAccountNo = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.gpbCheckBalance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCBClose)).BeginInit();
            this.gpbWithdrawal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWClose)).BeginInit();
            this.gpbTransferMoney.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTClose)).BeginInit();
            this.gpbDeposit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTransactions
            // 
            this.pnlTransactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(108)))), ((int)(((byte)(10)))));
            this.pnlTransactions.Controls.Add(this.pictureBox2);
            this.pnlTransactions.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTransactions.Location = new System.Drawing.Point(0, 0);
            this.pnlTransactions.Name = "pnlTransactions";
            this.pnlTransactions.Size = new System.Drawing.Size(52, 580);
            this.pnlTransactions.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(5, 12);
            this.pictureBox2.MaximumSize = new System.Drawing.Size(40, 40);
            this.pictureBox2.MinimumSize = new System.Drawing.Size(40, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Century Schoolbook", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(108)))), ((int)(((byte)(10)))));
            this.lblHeader.Location = new System.Drawing.Point(371, 12);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(248, 28);
            this.lblHeader.TabIndex = 9;
            this.lblHeader.Text = "Transactions Form";
            // 
            // picMin
            // 
            this.picMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMin.Image = ((System.Drawing.Image)(resources.GetObject("picMin.Image")));
            this.picMin.Location = new System.Drawing.Point(934, 4);
            this.picMin.MaximumSize = new System.Drawing.Size(24, 24);
            this.picMin.MinimumSize = new System.Drawing.Size(24, 24);
            this.picMin.Name = "picMin";
            this.picMin.Size = new System.Drawing.Size(24, 24);
            this.picMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMin.TabIndex = 10;
            this.picMin.TabStop = false;
            this.picMin.Click += new System.EventHandler(this.picMin_Click);
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
            this.picClose.Location = new System.Drawing.Point(960, 4);
            this.picClose.MaximumSize = new System.Drawing.Size(24, 24);
            this.picClose.MinimumSize = new System.Drawing.Size(24, 24);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(24, 24);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 11;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // txtCBAccountNo
            // 
            this.txtCBAccountNo.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCBAccountNo.ForeColor = System.Drawing.Color.Black;
            this.txtCBAccountNo.Location = new System.Drawing.Point(140, 72);
            this.txtCBAccountNo.Name = "txtCBAccountNo";
            this.txtCBAccountNo.Size = new System.Drawing.Size(169, 30);
            this.txtCBAccountNo.TabIndex = 14;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(108)))), ((int)(((byte)(10)))));
            this.btnCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheck.FlatAppearance.BorderSize = 0;
            this.btnCheck.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(24)))));
            this.btnCheck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(24)))));
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.ForeColor = System.Drawing.Color.White;
            this.btnCheck.Location = new System.Drawing.Point(322, 64);
            this.btnCheck.MaximumSize = new System.Drawing.Size(120, 40);
            this.btnCheck.MinimumSize = new System.Drawing.Size(120, 40);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(120, 40);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // gpbCheckBalance
            // 
            this.gpbCheckBalance.Controls.Add(this.lblCurrentBal);
            this.gpbCheckBalance.Controls.Add(this.picCBClose);
            this.gpbCheckBalance.Controls.Add(this.lblCBMsg);
            this.gpbCheckBalance.Controls.Add(this.label2);
            this.gpbCheckBalance.Controls.Add(this.btnCheck);
            this.gpbCheckBalance.Controls.Add(this.lblBalance);
            this.gpbCheckBalance.Controls.Add(this.txtCBAccountNo);
            this.gpbCheckBalance.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCheckBalance.ForeColor = System.Drawing.Color.Orange;
            this.gpbCheckBalance.Location = new System.Drawing.Point(91, 45);
            this.gpbCheckBalance.Name = "gpbCheckBalance";
            this.gpbCheckBalance.Size = new System.Drawing.Size(857, 116);
            this.gpbCheckBalance.TabIndex = 8;
            this.gpbCheckBalance.TabStop = false;
            this.gpbCheckBalance.Text = "Check Balance";
            // 
            // lblCurrentBal
            // 
            this.lblCurrentBal.AutoSize = true;
            this.lblCurrentBal.Font = new System.Drawing.Font("Century Schoolbook", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentBal.ForeColor = System.Drawing.Color.Orange;
            this.lblCurrentBal.Location = new System.Drawing.Point(637, 51);
            this.lblCurrentBal.Name = "lblCurrentBal";
            this.lblCurrentBal.Size = new System.Drawing.Size(163, 23);
            this.lblCurrentBal.TabIndex = 17;
            this.lblCurrentBal.Text = "Current Balance";
            // 
            // picCBClose
            // 
            this.picCBClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picCBClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCBClose.Image = ((System.Drawing.Image)(resources.GetObject("picCBClose.Image")));
            this.picCBClose.Location = new System.Drawing.Point(834, 28);
            this.picCBClose.MaximumSize = new System.Drawing.Size(20, 20);
            this.picCBClose.MinimumSize = new System.Drawing.Size(20, 20);
            this.picCBClose.Name = "picCBClose";
            this.picCBClose.Size = new System.Drawing.Size(20, 20);
            this.picCBClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCBClose.TabIndex = 19;
            this.picCBClose.TabStop = false;
            this.picCBClose.Visible = false;
            this.picCBClose.Click += new System.EventHandler(this.picCBClose_Click);
            // 
            // lblCBMsg
            // 
            this.lblCBMsg.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCBMsg.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCBMsg.ForeColor = System.Drawing.Color.Red;
            this.lblCBMsg.Location = new System.Drawing.Point(3, 23);
            this.lblCBMsg.Name = "lblCBMsg";
            this.lblCBMsg.Size = new System.Drawing.Size(851, 29);
            this.lblCBMsg.TabIndex = 18;
            this.lblCBMsg.Text = "Message";
            this.lblCBMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCBMsg.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(22, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 26);
            this.label2.TabIndex = 15;
            this.label2.Text = "Account No :";
            // 
            // lblBalance
            // 
            this.lblBalance.Font = new System.Drawing.Font("Century Schoolbook", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(108)))), ((int)(((byte)(10)))));
            this.lblBalance.Location = new System.Drawing.Point(625, 79);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(171, 28);
            this.lblBalance.TabIndex = 9;
            this.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gpbWithdrawal
            // 
            this.gpbWithdrawal.Controls.Add(this.picWClose);
            this.gpbWithdrawal.Controls.Add(this.lblWMsg);
            this.gpbWithdrawal.Controls.Add(this.label7);
            this.gpbWithdrawal.Controls.Add(this.label6);
            this.gpbWithdrawal.Controls.Add(this.txtWAmount);
            this.gpbWithdrawal.Controls.Add(this.btnWithdrawal);
            this.gpbWithdrawal.Controls.Add(this.txtWAccountNo);
            this.gpbWithdrawal.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbWithdrawal.ForeColor = System.Drawing.Color.Orange;
            this.gpbWithdrawal.Location = new System.Drawing.Point(547, 171);
            this.gpbWithdrawal.Name = "gpbWithdrawal";
            this.gpbWithdrawal.Size = new System.Drawing.Size(400, 215);
            this.gpbWithdrawal.TabIndex = 8;
            this.gpbWithdrawal.TabStop = false;
            this.gpbWithdrawal.Text = "Withdrawal";
            // 
            // picWClose
            // 
            this.picWClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picWClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picWClose.Image = ((System.Drawing.Image)(resources.GetObject("picWClose.Image")));
            this.picWClose.Location = new System.Drawing.Point(375, 27);
            this.picWClose.MaximumSize = new System.Drawing.Size(20, 20);
            this.picWClose.MinimumSize = new System.Drawing.Size(20, 20);
            this.picWClose.Name = "picWClose";
            this.picWClose.Size = new System.Drawing.Size(20, 20);
            this.picWClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWClose.TabIndex = 17;
            this.picWClose.TabStop = false;
            this.picWClose.Visible = false;
            this.picWClose.Click += new System.EventHandler(this.picWClose_Click);
            // 
            // lblWMsg
            // 
            this.lblWMsg.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblWMsg.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWMsg.ForeColor = System.Drawing.Color.Red;
            this.lblWMsg.Location = new System.Drawing.Point(3, 23);
            this.lblWMsg.Name = "lblWMsg";
            this.lblWMsg.Size = new System.Drawing.Size(394, 28);
            this.lblWMsg.TabIndex = 16;
            this.lblWMsg.Text = "Message";
            this.lblWMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblWMsg.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(41, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 26);
            this.label7.TabIndex = 15;
            this.label7.Text = "Amount :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(13, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 26);
            this.label6.TabIndex = 15;
            this.label6.Text = "Account No :";
            // 
            // txtWAmount
            // 
            this.txtWAmount.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWAmount.ForeColor = System.Drawing.Color.Black;
            this.txtWAmount.Location = new System.Drawing.Point(131, 112);
            this.txtWAmount.Name = "txtWAmount";
            this.txtWAmount.Size = new System.Drawing.Size(249, 30);
            this.txtWAmount.TabIndex = 14;
            // 
            // btnWithdrawal
            // 
            this.btnWithdrawal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(108)))), ((int)(((byte)(10)))));
            this.btnWithdrawal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWithdrawal.FlatAppearance.BorderSize = 0;
            this.btnWithdrawal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(24)))));
            this.btnWithdrawal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(24)))));
            this.btnWithdrawal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWithdrawal.ForeColor = System.Drawing.Color.White;
            this.btnWithdrawal.Location = new System.Drawing.Point(132, 156);
            this.btnWithdrawal.MinimumSize = new System.Drawing.Size(167, 40);
            this.btnWithdrawal.Name = "btnWithdrawal";
            this.btnWithdrawal.Size = new System.Drawing.Size(248, 40);
            this.btnWithdrawal.TabIndex = 2;
            this.btnWithdrawal.Text = "Withdraw";
            this.btnWithdrawal.UseVisualStyleBackColor = false;
            this.btnWithdrawal.Click += new System.EventHandler(this.btnWithdrawal_Click);
            // 
            // txtWAccountNo
            // 
            this.txtWAccountNo.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWAccountNo.ForeColor = System.Drawing.Color.Black;
            this.txtWAccountNo.Location = new System.Drawing.Point(131, 74);
            this.txtWAccountNo.Name = "txtWAccountNo";
            this.txtWAccountNo.Size = new System.Drawing.Size(249, 30);
            this.txtWAccountNo.TabIndex = 14;
            // 
            // gpbTransferMoney
            // 
            this.gpbTransferMoney.Controls.Add(this.btnTo);
            this.gpbTransferMoney.Controls.Add(this.btnFrom);
            this.gpbTransferMoney.Controls.Add(this.picTClose);
            this.gpbTransferMoney.Controls.Add(this.lblTMsg);
            this.gpbTransferMoney.Controls.Add(this.label14);
            this.gpbTransferMoney.Controls.Add(this.label13);
            this.gpbTransferMoney.Controls.Add(this.btnTransfer);
            this.gpbTransferMoney.Controls.Add(this.txtTAmount);
            this.gpbTransferMoney.Controls.Add(this.label11);
            this.gpbTransferMoney.Controls.Add(this.txtTo);
            this.gpbTransferMoney.Controls.Add(this.txtFrom);
            this.gpbTransferMoney.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbTransferMoney.ForeColor = System.Drawing.Color.Orange;
            this.gpbTransferMoney.Location = new System.Drawing.Point(91, 392);
            this.gpbTransferMoney.Name = "gpbTransferMoney";
            this.gpbTransferMoney.Size = new System.Drawing.Size(857, 169);
            this.gpbTransferMoney.TabIndex = 8;
            this.gpbTransferMoney.TabStop = false;
            this.gpbTransferMoney.Text = "Transfer Money";
            // 
            // picTClose
            // 
            this.picTClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picTClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picTClose.Image = ((System.Drawing.Image)(resources.GetObject("picTClose.Image")));
            this.picTClose.Location = new System.Drawing.Point(836, 26);
            this.picTClose.MaximumSize = new System.Drawing.Size(20, 20);
            this.picTClose.MinimumSize = new System.Drawing.Size(20, 20);
            this.picTClose.Name = "picTClose";
            this.picTClose.Size = new System.Drawing.Size(20, 20);
            this.picTClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTClose.TabIndex = 20;
            this.picTClose.TabStop = false;
            this.picTClose.Visible = false;
            this.picTClose.Click += new System.EventHandler(this.picTClose_Click);
            // 
            // lblTMsg
            // 
            this.lblTMsg.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTMsg.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTMsg.ForeColor = System.Drawing.Color.Red;
            this.lblTMsg.Location = new System.Drawing.Point(3, 23);
            this.lblTMsg.Name = "lblTMsg";
            this.lblTMsg.Size = new System.Drawing.Size(851, 29);
            this.lblTMsg.TabIndex = 19;
            this.lblTMsg.Text = "Message";
            this.lblTMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTMsg.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(485, 67);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 26);
            this.label14.TabIndex = 15;
            this.label14.Text = "Amount :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(83, 112);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 26);
            this.label13.TabIndex = 15;
            this.label13.Text = "To :";
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(108)))), ((int)(((byte)(10)))));
            this.btnTransfer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransfer.FlatAppearance.BorderSize = 0;
            this.btnTransfer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(24)))));
            this.btnTransfer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(24)))));
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.ForeColor = System.Drawing.Color.White;
            this.btnTransfer.Location = new System.Drawing.Point(571, 112);
            this.btnTransfer.MinimumSize = new System.Drawing.Size(167, 40);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(272, 40);
            this.btnTransfer.TabIndex = 2;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // txtTAmount
            // 
            this.txtTAmount.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTAmount.ForeColor = System.Drawing.Color.Black;
            this.txtTAmount.Location = new System.Drawing.Point(571, 63);
            this.txtTAmount.Name = "txtTAmount";
            this.txtTAmount.Size = new System.Drawing.Size(272, 30);
            this.txtTAmount.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(62, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 26);
            this.label11.TabIndex = 15;
            this.label11.Text = "From :";
            // 
            // txtTo
            // 
            this.txtTo.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTo.ForeColor = System.Drawing.Color.Black;
            this.txtTo.Location = new System.Drawing.Point(131, 113);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(271, 30);
            this.txtTo.TabIndex = 14;
            // 
            // txtFrom
            // 
            this.txtFrom.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrom.ForeColor = System.Drawing.Color.Black;
            this.txtFrom.Location = new System.Drawing.Point(131, 72);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(271, 30);
            this.txtFrom.TabIndex = 14;
            // 
            // btnTo
            // 
            this.btnTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(108)))), ((int)(((byte)(10)))));
            this.btnTo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTo.BackgroundImage")));
            this.btnTo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTo.FlatAppearance.BorderSize = 0;
            this.btnTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTo.Location = new System.Drawing.Point(399, 113);
            this.btnTo.MaximumSize = new System.Drawing.Size(30, 30);
            this.btnTo.MinimumSize = new System.Drawing.Size(30, 30);
            this.btnTo.Name = "btnTo";
            this.btnTo.Size = new System.Drawing.Size(30, 30);
            this.btnTo.TabIndex = 34;
            this.btnTo.UseVisualStyleBackColor = false;
            this.btnTo.Click += new System.EventHandler(this.btnTo_Click);
            // 
            // btnFrom
            // 
            this.btnFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(108)))), ((int)(((byte)(10)))));
            this.btnFrom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFrom.BackgroundImage")));
            this.btnFrom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFrom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFrom.FlatAppearance.BorderSize = 0;
            this.btnFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrom.Location = new System.Drawing.Point(399, 72);
            this.btnFrom.MaximumSize = new System.Drawing.Size(30, 30);
            this.btnFrom.MinimumSize = new System.Drawing.Size(30, 30);
            this.btnFrom.Name = "btnFrom";
            this.btnFrom.Size = new System.Drawing.Size(30, 30);
            this.btnFrom.TabIndex = 34;
            this.btnFrom.UseVisualStyleBackColor = false;
            this.btnFrom.Click += new System.EventHandler(this.btnFrom_Click);
            // 
            // gpbDeposit
            // 
            this.gpbDeposit.Controls.Add(this.picDClose);
            this.gpbDeposit.Controls.Add(this.lblDMsg);
            this.gpbDeposit.Controls.Add(this.label8);
            this.gpbDeposit.Controls.Add(this.label9);
            this.gpbDeposit.Controls.Add(this.txtDAmount);
            this.gpbDeposit.Controls.Add(this.btnDeposit);
            this.gpbDeposit.Controls.Add(this.txtDAccountNo);
            this.gpbDeposit.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDeposit.ForeColor = System.Drawing.Color.Orange;
            this.gpbDeposit.Location = new System.Drawing.Point(91, 171);
            this.gpbDeposit.Name = "gpbDeposit";
            this.gpbDeposit.Size = new System.Drawing.Size(426, 215);
            this.gpbDeposit.TabIndex = 17;
            this.gpbDeposit.TabStop = false;
            this.gpbDeposit.Text = "Deposit";
            // 
            // picDClose
            // 
            this.picDClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picDClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDClose.Image = ((System.Drawing.Image)(resources.GetObject("picDClose.Image")));
            this.picDClose.Location = new System.Drawing.Point(399, 27);
            this.picDClose.MaximumSize = new System.Drawing.Size(20, 20);
            this.picDClose.MinimumSize = new System.Drawing.Size(20, 20);
            this.picDClose.Name = "picDClose";
            this.picDClose.Size = new System.Drawing.Size(20, 20);
            this.picDClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDClose.TabIndex = 18;
            this.picDClose.TabStop = false;
            this.picDClose.Click += new System.EventHandler(this.picDClose_Click);
            // 
            // lblDMsg
            // 
            this.lblDMsg.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDMsg.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDMsg.ForeColor = System.Drawing.Color.Red;
            this.lblDMsg.Location = new System.Drawing.Point(3, 23);
            this.lblDMsg.Name = "lblDMsg";
            this.lblDMsg.Size = new System.Drawing.Size(420, 28);
            this.lblDMsg.TabIndex = 16;
            this.lblDMsg.Text = "Message";
            this.lblDMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDMsg.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(54, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 26);
            this.label8.TabIndex = 15;
            this.label8.Text = "Amount :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(26, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 26);
            this.label9.TabIndex = 15;
            this.label9.Text = "Account No :";
            // 
            // txtDAmount
            // 
            this.txtDAmount.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDAmount.ForeColor = System.Drawing.Color.Black;
            this.txtDAmount.Location = new System.Drawing.Point(140, 117);
            this.txtDAmount.Name = "txtDAmount";
            this.txtDAmount.Size = new System.Drawing.Size(272, 30);
            this.txtDAmount.TabIndex = 14;
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(108)))), ((int)(((byte)(10)))));
            this.btnDeposit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeposit.FlatAppearance.BorderSize = 0;
            this.btnDeposit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(24)))));
            this.btnDeposit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(24)))));
            this.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeposit.ForeColor = System.Drawing.Color.White;
            this.btnDeposit.Location = new System.Drawing.Point(140, 156);
            this.btnDeposit.MinimumSize = new System.Drawing.Size(167, 40);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(272, 40);
            this.btnDeposit.TabIndex = 2;
            this.btnDeposit.Text = "Deposit ";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // txtDAccountNo
            // 
            this.txtDAccountNo.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDAccountNo.ForeColor = System.Drawing.Color.Black;
            this.txtDAccountNo.Location = new System.Drawing.Point(140, 74);
            this.txtDAccountNo.Name = "txtDAccountNo";
            this.txtDAccountNo.Size = new System.Drawing.Size(272, 30);
            this.txtDAccountNo.TabIndex = 14;
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Century Schoolbook", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Black;
            this.lblTime.Location = new System.Drawing.Point(58, 3);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(237, 28);
            this.lblTime.TabIndex = 18;
            this.lblTime.Text = "HH : MM : SS T";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 580);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.gpbDeposit);
            this.Controls.Add(this.gpbWithdrawal);
            this.Controls.Add(this.gpbTransferMoney);
            this.Controls.Add(this.gpbCheckBalance);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.picMin);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.pnlTransactions);
            this.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximumSize = new System.Drawing.Size(985, 580);
            this.MinimumSize = new System.Drawing.Size(985, 580);
            this.Name = "Transactions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transactions";
            this.Load += new System.EventHandler(this.Transactions_Load);
            this.pnlTransactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.gpbCheckBalance.ResumeLayout(false);
            this.gpbCheckBalance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCBClose)).EndInit();
            this.gpbWithdrawal.ResumeLayout(false);
            this.gpbWithdrawal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWClose)).EndInit();
            this.gpbTransferMoney.ResumeLayout(false);
            this.gpbTransferMoney.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTClose)).EndInit();
            this.gpbDeposit.ResumeLayout(false);
            this.gpbDeposit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picMin;
        private System.Windows.Forms.PictureBox picClose;
        public System.Windows.Forms.TextBox txtCBAccountNo;
        public System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtWAmount;
        public System.Windows.Forms.Button btnWithdrawal;
        public System.Windows.Forms.TextBox txtWAccountNo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.Button btnTransfer;
        public System.Windows.Forms.TextBox txtTAmount;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtTo;
        public System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label lblWMsg;
        private System.Windows.Forms.Label lblDMsg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtDAmount;
        public System.Windows.Forms.Button btnDeposit;
        public System.Windows.Forms.TextBox txtDAccountNo;
        private System.Windows.Forms.PictureBox picCBClose;
        private System.Windows.Forms.Label lblCBMsg;
        private System.Windows.Forms.PictureBox picWClose;
        private System.Windows.Forms.PictureBox picDClose;
        private System.Windows.Forms.PictureBox picTClose;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label lblHeader;
        public System.Windows.Forms.Panel pnlTransactions;
        public System.Windows.Forms.GroupBox gpbCheckBalance;
        public System.Windows.Forms.GroupBox gpbWithdrawal;
        public System.Windows.Forms.GroupBox gpbTransferMoney;
        public System.Windows.Forms.GroupBox gpbDeposit;
        public System.Windows.Forms.Label lblTMsg;
        public System.Windows.Forms.Label lblCurrentBal;
        public System.Windows.Forms.Label lblBalance;
        public System.Windows.Forms.Button btnTo;
        public System.Windows.Forms.Button btnFrom;
    }
}