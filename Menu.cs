using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagementSystem
{
    public partial class Menu : Form
    {
        Login login;

        public Menu(Login lg)
        {
            InitializeComponent();
            login = lg;        
        }

        public Menu()
        {
        }

        private void picMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddAccount addAccount = new AddAccount(this);
            addAccount.Show();
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transactions transactions = new Transactions(this);
            transactions.Show();
        }

        private void btnAgent_Click(object sender, EventArgs e)
        {
            this.Hide();
            Agents agents = new Agents(this);
            agents.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings settings = new Settings(this);
            settings.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminTable admin = new AdminTable(this);
            admin.Show();
        }
      
        private void btnApply_Click_1(object sender, EventArgs e)
        {
            if (cmbTheme.Text == "")
            {
                lblMsg.Text = "please select theme to continue...";
                lblMsg.ForeColor = Color.FromArgb(200,200,200);
                picSClose.Visible = true;
                picSClose.BringToFront();
                cmbTheme.Focus();
            }
            if (cmbTheme.SelectedIndex == 0)
            {
                pnlMainPanel.BackColor = Color.Indigo;
                lblMsg.Text = "theme applied successfully";
                lblMsg.ForeColor = Color.FromArgb(200, 200, 200);
                picSClose.Visible = true;
                picSClose.BringToFront();
            }
            else if (cmbTheme.SelectedIndex == 1)
            {
                pnlMainPanel.BackColor = Color.Purple;
                lblMsg.Text = "theme applied successfully";
                lblMsg.ForeColor = Color.FromArgb(200, 200, 200);
                picSClose.Visible = true;
                picSClose.BringToFront();
            }
            else if (cmbTheme.SelectedIndex == 2)
            {
                pnlMainPanel.BackColor = Color.Crimson;
                lblMsg.Text = "theme applied successfully";
                lblMsg.ForeColor = Color.FromArgb(200, 200, 200);
                picSClose.Visible = true;
                picSClose.BringToFront();
            }
            else if (cmbTheme.SelectedIndex == 3)
            {
                pnlMainPanel.BackColor = Color.FromArgb(16, 108, 10);
                lblMsg.Text = "theme applied successfully";
                lblMsg.ForeColor = Color.FromArgb(200, 200, 200);
                picSClose.Visible = true;
                picSClose.BringToFront();
            }
        }

        private void picSClose_Click(object sender, EventArgs e)
        {
            picSClose.Visible = false;
            lblMsg.ForeColor = Color.White;
            lblMsg.Text = "Select Theme";
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard(this);
            dashboard.Show();
        }
    }
}
