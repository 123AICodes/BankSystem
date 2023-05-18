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
    public partial class AddAccount : Form
    {
        DBConnect dbcon = new DBConnect();
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader reader;
        string query;
        Menu menu;
        public AddAccount(Menu mn)
        {
            InitializeComponent();
            connection = new SqlConnection(dbcon.myConnection());
            fetchData();
            btnUpdate.Visible = false;
            menu = mn;

        }
        //themes
        #region manageAccountTheme
        private void manageAccountThemeIndigo()
        {  
            PnlAddAccount.BackColor = Color.Indigo;
            btnCreate.BackColor = Color.Indigo;
            btnUpdate.BackColor = Color.Indigo;
            btnSearch.BackColor = Color.Indigo;
            lblHeader.ForeColor = Color.Indigo;
            dgvAccount.ColumnHeadersDefaultCellStyle.BackColor = Color.Indigo;
            dgvAccount.AlternatingRowsDefaultCellStyle.BackColor = Color.Indigo;
        }
        private void manageAccountThemePurple()
        {  
            PnlAddAccount.BackColor = Color.Purple;
            btnCreate.BackColor = Color.Purple;
            btnUpdate.BackColor = Color.Purple;
            btnSearch.BackColor = Color.Purple;
            lblHeader.ForeColor = Color.Purple;
            dgvAccount.ColumnHeadersDefaultCellStyle.BackColor = Color.Purple;
            dgvAccount.AlternatingRowsDefaultCellStyle.BackColor = Color.Purple;
        }
        private void manageAccountThemeCrimson()
        {  
            PnlAddAccount.BackColor = Color.Crimson;
            btnCreate.BackColor = Color.Crimson;
            btnUpdate.BackColor = Color.Crimson;
            btnSearch.BackColor = Color.Crimson;
            lblHeader.ForeColor = Color.Crimson;
            dgvAccount.ColumnHeadersDefaultCellStyle.BackColor = Color.Crimson;
            dgvAccount.AlternatingRowsDefaultCellStyle.BackColor = Color.Crimson;
        }
        private void manageAccountThemeDefault()
        {  
            PnlAddAccount.BackColor = Color.FromArgb(16,108,10);
            btnCreate.BackColor = Color.FromArgb(16, 108, 10);
            btnUpdate.BackColor = Color.FromArgb(16, 108, 10);
            btnSearch.BackColor = Color.FromArgb(16, 108, 10);
            lblHeader.ForeColor = Color.FromArgb(16, 108, 10);
            dgvAccount.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(16, 108, 10);
            dgvAccount.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(16, 108, 10);
        }
        #endregion manageAccountTheme
        private void AddAccount_Load(object sender, EventArgs e)
        {
            if(menu.cmbTheme.SelectedIndex == 0)
            {
                manageAccountThemeIndigo();
            }
            else if(menu.cmbTheme.SelectedIndex == 1)
            {
                manageAccountThemePurple();
            } 
            else if(menu.cmbTheme.SelectedIndex == 2)
            {
                manageAccountThemeCrimson();
            }
            else if(menu.cmbTheme.SelectedIndex == 3)
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

        public void fetchData()
        {
            try
            {
                int i = 0;
                dgvAccount.Rows.Clear();
                query = "SELECT * FROM tbAccount WHERE CONCAT(name,phone, address, education, gender) LIKE '%" + txtSearch.Text + "%' ORDER BY name DESC";
                command = new SqlCommand(query, connection);
                connection.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    i++;
                    dgvAccount.Rows.Add(i, reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString());
                }
                reader.Close();
                connection.Close();

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
            lblID.Text = "";
            txtName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtOccupation.Clear();
            cmbEduction.SelectedIndex = -1;
            cmbGender.SelectedIndex = -1;
            txtIncome.Clear();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == string.Empty || txtPhone.Text == string.Empty || txtAddress.Text == string.Empty || txtOccupation.Text == string.Empty || cmbEduction.Text == "" || cmbGender.Text == "" || txtIncome.Text == string.Empty)
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
                    query = " SELECT * FROM tbAccount WHERE name LIKE '"+txtName.Text+"'";
                    command = new SqlCommand(query,connection);
                    connection.Open();
                    Int32 count = Convert.ToInt32(command.ExecuteScalar());
                    connection.Close();
                    if(count > i)
                    {
                        lblMsg.Visible = true;
                        picAClose.Visible = true;
                        picAClose.BringToFront();
                        lblMsg.Text = "name already exist!";
                        lblMsg.ForeColor = Color.FromArgb(158, 10, 5);
                        return;
                    }
                    else
                    {
                        query = " INSERT INTO tbAccount(name, phone, address, occupation, education, gender, income)VALUES(@name, @phone, @address, @occupation, @education, @gender, @income) ";
                        command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@name", txtName.Text);
                        command.Parameters.AddWithValue("@phone", txtPhone.Text);
                        command.Parameters.AddWithValue("@address", txtAddress.Text);
                        command.Parameters.AddWithValue("@occupation", txtOccupation.Text);
                        command.Parameters.AddWithValue("@education", cmbEduction.Text);
                        command.Parameters.AddWithValue("@gender", cmbGender.Text);
                        command.Parameters.AddWithValue("@income", txtIncome.Text);
                        command.Parameters.AddWithValue("@balance", 0);

                        if (connection.State == System.Data.ConnectionState.Closed)
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();

                            lblMsg.Visible = true;
                            picAClose.Visible = true;
                            picAClose.BringToFront();
                            lblMsg.Text = "new account created successfully!";
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
                if (txtName.Text == string.Empty || txtPhone.Text == string.Empty || txtAddress.Text == string.Empty || txtOccupation.Text == string.Empty || cmbEduction.Text == "" || cmbGender.Text == "" || txtIncome.Text == string.Empty)
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
                    query = " UPDATE tbAccount SET name=@name, phone=@phone, address=@address, occupation=@occupation, education=@education, gender=@gender, income=@income WHERE id LIKE '" + lblID.Text + "'";
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@name", txtName.Text);
                    command.Parameters.AddWithValue("@phone", txtPhone.Text);
                    command.Parameters.AddWithValue("@address", txtAddress.Text);
                    command.Parameters.AddWithValue("@occupation", txtOccupation.Text);
                    command.Parameters.AddWithValue("@education", cmbEduction.Text);
                    command.Parameters.AddWithValue("@gender", cmbGender.Text);
                    command.Parameters.AddWithValue("@income", txtIncome.Text);
                    command.Parameters.AddWithValue("@balance", 0);

                    if (connection.State == System.Data.ConnectionState.Closed)
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();

                        lblMsg.Visible = true;
                        picAClose.Visible = true;
                        picAClose.BringToFront();
                        lblMsg.Text = "account updated successfully!";
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            fetchData();
        }

        private void dgvAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnCreate.Visible = false;
            btnUpdate.Visible = true;
            try
            {
                lblID.Text = dgvAccount.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtName.Text = dgvAccount.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtPhone.Text = dgvAccount.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtAddress.Text = dgvAccount.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtOccupation.Text = dgvAccount.Rows[e.RowIndex].Cells[5].Value.ToString();
                cmbEduction.Text = dgvAccount.Rows[e.RowIndex].Cells[6].Value.ToString();
                cmbGender.Text = dgvAccount.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtIncome.Text = dgvAccount.Rows[e.RowIndex].Cells[8].Value.ToString();
                lblBalance.Text = dgvAccount.Rows[e.RowIndex].Cells[9].Value.ToString();

                lblMsg.Visible = false;

                string colName = dgvAccount.Columns[e.ColumnIndex].Name;
                if(colName == "Delete")
                {
                    if(MessageBox.Show("Are you sure you want delete this account?", "Bank Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        dbcon.executeQuery(" DELETE FROM tbAccount WHERE id LIKE '"+lblID.Text+"' ");
                        lblMsg.Visible = true;
                        picAClose.Visible = true;
                        picAClose.BringToFront();
                        lblMsg.Text = "account deleted successfully!";
                        lblMsg.ForeColor = Color.FromArgb(15, 168, 10);

                        fetchData();
                        clearFields();
                    }
                }
            }
            catch (Exception ex)
            {
                lblMsg.Visible = true;
                lblMsg.Text = ex.Message;
                picAClose.Visible = true;
                picAClose.BringToFront();
                lblMsg.ForeColor = Color.FromArgb(158, 10, 5);
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            lblMsg.Visible = false;
            picAClose.Visible = false;
            clearFields();

            btnCreate.Visible = true;
            btnUpdate.Visible = false;
        }

        private void picAClose_Click(object sender, EventArgs e)
        {
            lblMsg.Visible = false;
            picAClose.Visible = false;
            btnUpdate.Visible = false;
            btnCreate.Visible = true;
        }
    }
}
