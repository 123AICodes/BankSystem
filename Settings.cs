using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagementSystem
{
    public partial class Settings : Form
    {
        DBConnect dbcon = new DBConnect();
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        string query;
        Menu menu;
        public Settings(Menu mn)
        {
            InitializeComponent();
            connection = new SqlConnection(dbcon.myConnection());
            menu = mn;
         
        }
        //themes
        #region manageAccountTheme
        private void manageAccountThemeIndigo()
        {
            pnlSettings.BackColor = Color.Indigo;
            btnChange.BackColor = Color.Indigo;
            lblHeader.ForeColor = Color.Indigo;
        }
        private void manageAccountThemePurple()
        {
            pnlSettings.BackColor = Color.Purple;
            btnChange.BackColor = Color.Purple;
            lblHeader.ForeColor = Color.Purple;
        }
        private void manageAccountThemeCrimson()
        {
            pnlSettings.BackColor = Color.Crimson;
            btnChange.BackColor = Color.Crimson;
            lblHeader.ForeColor = Color.Crimson;
        }
        private void manageAccountThemeDefault()
        {
            pnlSettings.BackColor = Color.FromArgb(16, 108, 10);
            btnChange.BackColor = Color.FromArgb(16, 108, 10);
            lblHeader.ForeColor = Color.FromArgb(16, 108, 10);
        }
        #endregion manageAccountTheme
        private void Settings_Load(object sender, EventArgs e)
        {
            if (menu.cmbTheme.SelectedIndex == 0)
            {
                manageAccountThemeIndigo();
            }
            else if (menu.cmbTheme.SelectedIndex == 1)
            {
                manageAccountThemePurple();
            }
            else if (menu.cmbTheme.SelectedIndex == 2)
            {
                manageAccountThemeCrimson();
            }
            else if (menu.cmbTheme.SelectedIndex == 3)
            {
                manageAccountThemeDefault();
            }
        }
        private void picMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.Show();
        }

        private void picSClose_Click(object sender, EventArgs e)
        {
            lblMsg.Visible = false;
            picSClose.Visible = false;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                //validations
                if (txtId.Text == string.Empty)
                {
                    lblMsg.Visible = true;
                    picSClose.Visible = true;
                    picSClose.BringToFront();
                    lblMsg.Text = "enter your account id!";
                    lblMsg.ForeColor = Color.FromArgb(158, 16, 5);
                    txtId.Focus();
                    return;
                }
                if (txtPass.Text == string.Empty)
                {
                    lblMsg.Visible = true;
                    picSClose.Visible = true;
                    picSClose.BringToFront();
                    lblMsg.Text = "enter your account id!";
                    lblMsg.ForeColor = Color.FromArgb(158, 16, 5);
                    txtPass.Focus();
                    return;
                }
                else
                {
                    //checking if account exixt
                    int i = 0;
                    query = "SELECT * FROM AgentTbl WHERE id LIKE '"+txtId.Text+"' AND role like 'Admin' ";
                    command = new SqlCommand(query,connection);
                    connection.Open();
                    Int32 count = Convert.ToInt32(command.ExecuteScalar());
                    connection.Close();
                    if(count > i)
                    {
                        //updating password
                        dbcon.executeQuery("UPDATE AgentTbl SET password='"+txtPass.Text+"' WHERE id LIKE '"+txtId.Text+"' AND role like 'Admin' ");
                        lblMsg.Visible = true;
                        picSClose.Visible = true;
                        picSClose.BringToFront();
                        lblMsg.Text = "password updated successfully!";
                        lblMsg.ForeColor = Color.FromArgb(15, 108, 10);
                        txtId.Clear();
                        txtPass.Clear();
                    }
                    else
                    {
                        lblMsg.Visible = true;
                        picSClose.Visible = true;
                        picSClose.BringToFront();
                        lblMsg.Text = "account not found!";
                        lblMsg.ForeColor = Color.FromArgb(158, 16, 5);
                    }
                    
                }
            }
            catch (Exception ex)
            {
                lblMsg.Visible = true;
                picSClose.Visible = true;
                picSClose.BringToFront();
                lblMsg.Text = ex.Message;
                lblMsg.ForeColor = Color.FromArgb(158, 10, 5);
            }
        }
    }
}
