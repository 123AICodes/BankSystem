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
    public partial class Login : Form
    {
        DBConnect dbcon = new DBConnect();
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader reader;
        string query;
        string title = "Bank Management System";

        public Login()
        {
            InitializeComponent();
            connection = new SqlConnection(dbcon.myConnection());
            txtPassword.UseSystemPasswordChar = true;
        }

        private void picMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close the application?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ckbShow_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            ckbHide.BringToFront();
        }

        private void ckbHide_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            ckbShow.BringToFront();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if(txtPassword.Text == string.Empty)
            {
                ckbHide.SendToBack();
                ckbShow.SendToBack();
            }
            else { ckbShow.BringToFront(); }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                bool admin;
                string _role = "";
                string _name = "";
                if(txtUsername.Text == string.Empty)
                {
                    MessageBox.Show("Username is required", title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsername.Focus();
                    return;
                }
                else if(txtPassword.Text == string.Empty)
                {
                    MessageBox.Show("Password is required", title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Focus();
                    return;
                }
                else
                {
                    Menu mn = new Menu(this);
                    query = "SELECT * FROM AgentTbl WHERE username=@username AND password=@password";
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", txtUsername.Text);
                    command.Parameters.AddWithValue("@password", txtPassword.Text);
                    if(connection.State == System.Data.ConnectionState.Closed)
                    {
                        connection.Open();
                        reader = command.ExecuteReader();
                        reader.Read();
                        if (reader.HasRows)
                        {
                            admin = true;
                            _name = reader["name"].ToString();
                            _role = reader["role"].ToString();
                            mn.lblRole.Text = reader["role"].ToString();
                        }
                        else { admin = false; }
                        reader.Close();
                        connection.Close();

                        if (admin)
                        {
                            if(_role == "Admin")
                            {
                                this.Hide();
                                MessageBox.Show("Wecome " + _name + ". Your Login Successfull", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                mn.Show();
                            }
                            else
                            {
                                this.Hide();
                                MessageBox.Show("Wecome " + _name + ". Your Login Successfull", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Agents agents = new Agents(mn);
                                agents.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Incorrect username OR password", title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to close the application?", title, MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
