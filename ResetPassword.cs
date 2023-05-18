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
    public partial class ResetPassword : Form
    {
        DBConnect dbcon = new DBConnect();
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        string query;
        Agents agents;
        public ResetPassword(Agents ag)
        {
            InitializeComponent();
            connection = new SqlConnection(dbcon.myConnection());
            agents = ag;
            lblRole.Text = agents.lblRole.Text;
        }

        private void picMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose1_Click(object sender, EventArgs e)
        {
            this.Hide();
            agents.Show();
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
                    query = "SELECT * FROM AgentTbl WHERE id LIKE '" + txtId.Text + "' AND role like 'Agent' ";
                    command = new SqlCommand(query, connection);
                    connection.Open();
                    Int32 count = Convert.ToInt32(command.ExecuteScalar());
                    connection.Close();
                    if (count > i)
                    {
                        //updating password
                        dbcon.executeQuery("UPDATE AgentTbl SET password='" + txtPass.Text + "' WHERE id LIKE '" + txtId.Text + "' AND role like 'Agent' ");
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

        private void picSClose_Click(object sender, EventArgs e)
        {
            lblMsg.Visible = false;
            picSClose.Visible = false;
        }
    }
}
