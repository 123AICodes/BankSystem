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
    public partial class AdminTable : Form
    {
        DBConnect dbcon = new DBConnect();
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader reader;
        string query;

        Menu menu;
        public AdminTable(Menu mn)
        {
            InitializeComponent();
            connection = new SqlConnection(dbcon.myConnection());
            fetchData();
            timer1.Enabled = true;
            menu = mn;
            txtPassword.UseSystemPasswordChar = true;
            btnUpdate.Visible = false;
        }
        //themes
        #region manageAccountTheme
        private void manageAccountThemeIndigo()
        {
            pnlAdmin.BackColor = Color.Indigo;
            btnAdd.BackColor = Color.Indigo;
            btnUpdate.BackColor = Color.Indigo;
            btnSearch.BackColor = Color.Indigo;
            lblHeader.ForeColor = Color.Indigo;
            btnClose.BackColor = Color.Indigo;
            dgvAgent.ColumnHeadersDefaultCellStyle.BackColor = Color.Indigo;
            dgvAgent.AlternatingRowsDefaultCellStyle.BackColor = Color.Indigo;
        }
        private void manageAccountThemePurple()
        {
            pnlAdmin.BackColor = Color.Purple;
            btnAdd.BackColor = Color.Purple;
            btnUpdate.BackColor = Color.Purple;
            btnSearch.BackColor = Color.Purple;
            lblHeader.ForeColor = Color.Purple;
            btnClose.BackColor = Color.Purple;

            dgvAgent.ColumnHeadersDefaultCellStyle.BackColor = Color.Purple;
            dgvAgent.AlternatingRowsDefaultCellStyle.BackColor = Color.Purple;
        }
        private void manageAccountThemeCrimson()
        {
            pnlAdmin.BackColor = Color.Crimson;
            btnAdd.BackColor = Color.Crimson;
            btnUpdate.BackColor = Color.Crimson;
            btnSearch.BackColor = Color.Crimson;
            lblHeader.ForeColor = Color.Crimson;
            btnClose.BackColor = Color.Crimson;

            dgvAgent.ColumnHeadersDefaultCellStyle.BackColor = Color.Crimson;
            dgvAgent.AlternatingRowsDefaultCellStyle.BackColor = Color.Crimson;
        }
        private void manageAccountThemeDefault()
        {
            pnlAdmin.BackColor = Color.FromArgb(16, 108, 10);
            btnAdd.BackColor = Color.FromArgb(16, 108, 10);
            btnUpdate.BackColor = Color.FromArgb(16, 108, 10);
            btnSearch.BackColor = Color.FromArgb(16, 108, 10);
            lblHeader.ForeColor = Color.FromArgb(16, 108, 10);
            btnClose.BackColor = Color.FromArgb(16, 108, 10);
            dgvAgent.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(16, 108, 10);
            dgvAgent.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(16, 108, 10);
        }
        #endregion manageAccountTheme
        private void AdminTable_Load(object sender, EventArgs e)
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
        public void fetchData()
        {
            try
            {
                int i = 0;
                dgvAgent.Rows.Clear();
                query = "SELECT * FROM AgentTbl WHERE CONCAT(name,phone, address) LIKE '%" + txtSearch.Text + "%'  ORDER BY name DESC";
                command = new SqlCommand(query, connection);
                connection.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    i++;
                    dgvAgent.Rows.Add(i, reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString());
                }
                reader.Close();
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            fetchData();
        }
        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            fetchData();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
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
            if (txtPassword.Text == string.Empty)
            {
                ckbHide.SendToBack();
                ckbShow.SendToBack();
            }
            else { ckbShow.BringToFront(); }
        }
        private void dgvAgent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAdd.Visible = false;
            btnUpdate.Visible = true;
            try
            {
                lblID.Text = dgvAgent.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtName.Text = dgvAgent.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtUsername.Text = dgvAgent.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtPassword.Text = dgvAgent.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtPhone.Text = dgvAgent.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtAddress.Text = dgvAgent.Rows[e.RowIndex].Cells[6].Value.ToString();
                cmbRole.Text = dgvAgent.Rows[e.RowIndex].Cells[7].Value.ToString();

                lblMsg.Visible = false;

                if(cmbRole.SelectedIndex == 1)
                {
                    txtPassword.ReadOnly = true;
                    txtPassword.BackColor = Color.White;
                    ckbShow.Visible = false;
                    ckbHide.Visible = false;
                }
                else
                {
                    ckbShow.Visible = true;
                    ckbHide.Visible = true;
                }

                string colName = dgvAgent.Columns[e.ColumnIndex].Name;
                if (colName == "Delete")
                {
                    if (MessageBox.Show("Are you sure you want delete this " + dgvAgent.Rows[e.RowIndex].Cells[7].Value.ToString() + "?", "Bank Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        dbcon.executeQuery(" DELETE FROM AgentTbl WHERE id LIKE '" + lblID.Text + "' ");
                        lblMsg.Visible = true;
                        lblMsg.Text = "" + cmbRole.Text + " deleted successfully!";
                        lblMsg.ForeColor = Color.FromArgb(15, 168, 10);

                        fetchData();
                        clearFields();
                    }
                }
            }
            catch (Exception ex)
            {
                lblMsg.Visible = true;
                picAClose.Visible = true;
                picAClose.BringToFront();
                lblMsg.Text = ex.Message;
                lblMsg.ForeColor = Color.FromArgb(158, 10, 5);
            }
        }
        public void clearFields()
        {
            txtName.Clear();
            txtUsername.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtPassword.Clear();
            lblID.Text = "";
            cmbRole.SelectedIndex = -1;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == string.Empty || txtUsername.Text == string.Empty || txtPassword.Text == string.Empty || txtPhone.Text == string.Empty || txtAddress.Text == string.Empty || cmbRole.Text == "")
                {
                    lblMsg.Visible = true;
                    picAClose.Visible = true;
                    picAClose.BringToFront();
                    lblMsg.Text = "please complete the empty fields!";
                    lblMsg.ForeColor = Color.FromArgb(158, 10, 5);
                    return;
                }
                else
                {
                    int i = 0;
                    query = "SELECT * FROM AgentTbl WHERE name='" + txtName.Text + "' OR username='" + txtUsername.Text + "'";
                    command = new SqlCommand(query, connection);
                    connection.Open();
                    Int32 count = Convert.ToInt32(command.ExecuteScalar());
                    connection.Close();
                    if (count > i)
                    {
                        lblMsg.Visible = true;
                        picAClose.Visible = true;
                        picAClose.BringToFront();
                        lblMsg.Text = "sorry " + cmbRole.Text + " already exist. update instead!";
                        lblMsg.ForeColor = Color.FromArgb(158, 10, 5);
                        return;
                    }
                    else
                    {
                        query = " INSERT INTO AgentTbl(name, username, password, phone, address, role)VALUES(@name, @username, @password, @phone, @address,@role) ";
                        command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@name", txtName.Text);
                        command.Parameters.AddWithValue("@username", txtUsername.Text);
                        command.Parameters.AddWithValue("@password", txtPassword.Text);
                        command.Parameters.AddWithValue("@phone", txtPhone.Text);
                        command.Parameters.AddWithValue("@address", txtAddress.Text);
                        command.Parameters.AddWithValue("@role", cmbRole.Text);

                        if (connection.State == System.Data.ConnectionState.Closed)
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();

                            lblMsg.Visible = true;
                            picAClose.Visible = true;
                            picAClose.BringToFront();
                            lblMsg.Text = "new " + cmbRole.Text + " added successfully!";
                            lblMsg.ForeColor = Color.FromArgb(15, 168, 10);

                            clearFields();
                            fetchData();
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                lblMsg.Visible = true;
                picAClose.Visible = true;
                picAClose.BringToFront();
                lblMsg.Text = ex.Message;
                lblMsg.ForeColor = Color.FromArgb(158, 10, 5);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == string.Empty || txtUsername.Text == string.Empty || txtPassword.Text == string.Empty || txtPhone.Text == string.Empty || txtAddress.Text == string.Empty || cmbRole.Text == "")
                {
                    lblMsg.Visible = true;
                    picAClose.Visible = true;
                    picAClose.BringToFront();
                    lblMsg.Text = "please fill in the empty spaces to continue...";
                    lblMsg.ForeColor = Color.FromArgb(158, 10, 5);
                    return;
                }
                else
                {
                    query = " UPDATE AgentTbl SET name=@name, username=@username, password=@password, phone=@phone, address=@address, role=@role WHERE id LIKE '" + lblID.Text + "'";
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@name", txtName.Text);
                    command.Parameters.AddWithValue("@username", txtUsername.Text);
                    command.Parameters.AddWithValue("@password", txtPassword.Text);
                    command.Parameters.AddWithValue("@phone", txtPhone.Text);
                    command.Parameters.AddWithValue("@address", txtAddress.Text);
                    command.Parameters.AddWithValue("@role", cmbRole.Text);


                    if (connection.State == System.Data.ConnectionState.Closed)
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();

                        lblMsg.Visible = true;
                        picAClose.Visible = true;
                        picAClose.BringToFront();
                        lblMsg.Text = "" + cmbRole.Text + " updated successfully!";
                        lblMsg.ForeColor = Color.FromArgb(15, 168, 10);

                        clearFields();
                        fetchData();
                    }

                }
            }
            catch (Exception ex)
            {
                lblMsg.Visible = true;
                picAClose.Visible = true;
                picAClose.BringToFront();
                lblMsg.Text = ex.Message;
                lblMsg.ForeColor = Color.FromArgb(158, 10, 5);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblMsg.Visible = false;
            picAClose.Visible = false;
            clearFields();

            btnAdd.Visible = true;
            btnUpdate.Visible = false;
        }

        private void picAClose_Click(object sender, EventArgs e)
        {
            lblMsg.Visible = false;
            picAClose.Visible = false;
            btnUpdate.Visible = false;
            btnAdd.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.Show();
        }
    }
}
