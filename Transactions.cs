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
    public partial class Transactions : Form
    {
        DBConnect dbcon = new DBConnect();
        SqlConnection connection = new SqlConnection();
        SqlCommand command;
        SqlDataReader reader;
        string query;
        Menu menu;
        public Transactions(Menu mn)
        {
            InitializeComponent();
            connection = new SqlConnection(dbcon.myConnection());
            menu = mn;
            picDClose.BringToFront();
            picWClose.BringToFront();
            picTClose.BringToFront();
            picDClose.Visible = false;
            timer1.Enabled = true;
        }
        //themes
        #region manageAccountTheme
        private void manageAccountThemeIndigo()
        {
            pnlTransactions.BackColor = Color.Indigo;
            btnCheck.BackColor = Color.Indigo;
            btnDeposit.BackColor = Color.Indigo;
            btnWithdrawal.BackColor = Color.Indigo;
            btnTransfer.BackColor = Color.Indigo;
            btnFrom.BackColor = Color.Indigo;
            btnTo.BackColor = Color.Indigo;
            lblHeader.ForeColor = Color.Indigo;
            lblCurrentBal.ForeColor = Color.Indigo;
            lblBalance.ForeColor = Color.Orange;        
        }
        private void manageAccountThemePurple()
        {
            pnlTransactions.BackColor = Color.Purple;
            btnCheck.BackColor = Color.Purple;
            btnDeposit.BackColor = Color.Purple;
            btnWithdrawal.BackColor = Color.Purple;
            btnTransfer.BackColor = Color.Purple;
            btnFrom.BackColor = Color.Purple;
            btnTo.BackColor = Color.Purple;
            lblHeader.ForeColor = Color.Purple;
            lblCurrentBal.ForeColor = Color.Purple;
            lblBalance.ForeColor = Color.Orange;
        }
        private void manageAccountThemeCrimson()
        {
            pnlTransactions.BackColor = Color.Crimson;
            btnCheck.BackColor = Color.Crimson;
            btnDeposit.BackColor = Color.Crimson;
            btnWithdrawal.BackColor = Color.Crimson;
            btnTransfer.BackColor = Color.Crimson;
            btnFrom.BackColor = Color.Crimson;
            btnTo.BackColor = Color.Crimson;
            lblHeader.ForeColor = Color.Crimson;
            lblCurrentBal.ForeColor = Color.Crimson;
            lblBalance.ForeColor = Color.Orange;
           
        }
        private void manageAccountThemeDefault()
        {
            pnlTransactions.BackColor = Color.FromArgb(16, 108, 10);
            btnCheck.BackColor = Color.FromArgb(16, 108, 10);
            btnDeposit.BackColor = Color.FromArgb(16, 108, 10);
            btnWithdrawal.BackColor = Color.FromArgb(16, 108, 10);
            btnTransfer.BackColor = Color.FromArgb(16, 108, 10);
            btnFrom.BackColor = Color.FromArgb(16, 108, 10);
            btnTo.BackColor = Color.FromArgb(16, 108, 10);
            lblHeader.ForeColor = Color.FromArgb(16, 108, 10);
            lblCurrentBal.ForeColor = Color.Orange;
            lblBalance.ForeColor = Color.FromArgb(16, 108, 10);
          
        }
        #endregion manageAccountTheme
        private void Transactions_Load(object sender, EventArgs e)
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
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        #region checkingBalance
        double balance;
        private void checkBalance()
        {
            try
            {
                /*===========CHECKING ACCOUNT BALANCE ===================
                ==================================================*/
                query = " SELECT * FROM  tbAccount WHERE id LIKE '"+txtCBAccountNo.Text+"'";
                command = new SqlCommand(query, connection);
                if(connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                    reader = command.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        lblBalance.Text = " ghc " + reader["balance"].ToString();
                        balance = Convert.ToDouble(reader["balance"].ToString());

                        lblCBMsg.Visible = true;
                        picCBClose.Visible = true;
                        picCBClose.BringToFront();
                        lblCBMsg.Text = "account number of " + txtCBAccountNo.Text + " found! Account holder " + reader["name"].ToString()+" ";
                        lblCBMsg.ForeColor = Color.FromArgb(16, 108, 10);
                    }
                    else
                    {
                        lblCBMsg.Visible = true;
                        picCBClose.Visible = true;
                        picCBClose.BringToFront();
                        lblCBMsg.Text = "account number of " + txtCBAccountNo.Text + " not found!";
                        lblCBMsg.ForeColor = Color.FromArgb(158, 10, 5);
                    }
                    reader.Close();
                    connection.Close();    
                }
            }
            catch (Exception ex)
            {
                lblCBMsg.Visible = true;
                picCBClose.Visible = true;
                picCBClose.BringToFront();
                lblCBMsg.Text = ex.Message;
                lblCBMsg.ForeColor = Color.FromArgb(158, 10, 5);
            }
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            /*===========VALIDATION===================
                ==================================================*/
            if (txtCBAccountNo.Text == string.Empty)
            {
                lblCBMsg.Visible = true;
                picCBClose.Visible = true;
                picCBClose.BringToFront();
                lblCBMsg.Text = "please enter the account number to proceed...";
                lblCBMsg.ForeColor = Color.FromArgb(158, 10, 5);
                lblBalance.Text = "";
                txtCBAccountNo.Focus();
                return;
            }
            else
            {
                checkBalance();
                txtCBAccountNo.Text = "";
            }
        }

        private void picCBClose_Click(object sender, EventArgs e)
        {
            lblCBMsg.Visible = false;
            picCBClose.Visible = false;
            lblBalance.Text = "";
        }
        #endregion checkingBalance

        #region depositingMoney

        private void getNewBalance()
        {
            try
            {
                query = " SELECT * FROM  tbAccount WHERE id LIKE '" + txtDAccountNo.Text + "'";
                command = new SqlCommand(query, connection);
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                    reader = command.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        balance =  Convert.ToDouble(reader["balance"].ToString());
                    }
                    reader.Close();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                lblCBMsg.Visible = true;
                picCBClose.Visible = true;
                picCBClose.BringToFront();
                lblCBMsg.Text = ex.Message;
                lblCBMsg.ForeColor = Color.FromArgb(158, 10, 5);
            }
        } 
        private void depositMoney()
        {
            query = " INSERT INTO tbTransaction(name,date,amount, time, accountno)VALUES(@name,@date,@amount, @time, @accountno) ";
            command = new SqlCommand(query,connection);
            command.Parameters.AddWithValue("@name", btnDeposit.Text);
            command.Parameters.AddWithValue("@date", DateTime.Now.ToShortDateString());
            command.Parameters.AddWithValue("@amount", Convert.ToDouble(txtDAmount.Text));
            command.Parameters.AddWithValue("@time", lblTime.Text);
            command.Parameters.AddWithValue("@accountno", txtDAccountNo.Text);

            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            /*   validations   */
            if(txtDAccountNo.Text == string.Empty)
            {
                lblDMsg.Visible = true;
                picDClose.Visible = true;
                picDClose.BringToFront();
                lblDMsg.Text = "please provide account number!";
                lblDMsg.ForeColor = Color.FromArgb(158, 10, 5);
                txtDAccountNo.Focus();
                return;
            }
            if(txtDAmount.Text == string.Empty)
            {
                lblDMsg.Visible = true;
                picDClose.Visible = true;
                picDClose.BringToFront();
                lblDMsg.Text = "enter amount to proceed...";
                lblDMsg.ForeColor = Color.FromArgb(158, 10, 5);
                txtDAmount.Focus();
                return;
            }
            else
            {
                try
                {
                    int i = 0;
                    query = "SELECT * FROM tbAccount WHERE id LIKE '" + txtDAccountNo.Text + "'";
                    command = new SqlCommand(query, connection);
                    connection.Open();
                    Int32 count = Convert.ToInt32(command.ExecuteScalar());
                    connection.Close();
                    if (count > i)
                    {
                        getNewBalance();
                        double newBalance = balance + Convert.ToDouble(txtDAmount.Text);
                        query = "UPDATE tbAccount SET balance=@balance WHERE id=@id";
                        command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@balance", Convert.ToDouble(newBalance).ToString());
                        command.Parameters.AddWithValue("@id", txtDAccountNo.Text);
                        if (connection.State == System.Data.ConnectionState.Closed)
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();

                            depositMoney();

                            lblDMsg.Visible = true;
                            picDClose.Visible = true;
                            picDClose.BringToFront();
                            lblDMsg.Text = "deposit made successfully!";
                            lblDMsg.ForeColor = Color.FromArgb(16, 108, 10);
                            txtDAccountNo.Clear();
                            txtDAmount.Clear();
                        }


                    }
                    else
                    {
                        lblDMsg.Visible = true;
                        picDClose.Visible = true;
                        picDClose.BringToFront();
                        lblDMsg.Text = "account not found!";
                        lblDMsg.ForeColor = Color.FromArgb(158, 10, 5);
                    }
                }
                catch (Exception ex)
                {
                    lblDMsg.Visible = true;
                    picDClose.Visible = true;
                    picDClose.BringToFront();
                    lblDMsg.Text = ex.Message;
                    lblDMsg.ForeColor = Color.FromArgb(158, 10, 5);
                }
            }
        }
      

        private void picDClose_Click(object sender, EventArgs e)
        {
            lblDMsg.Visible = false;
            picDClose.Visible = false;
        }
        #endregion depositingMoney

        #region  Withdrawal
        double _balance;
        private void btnWithdrawal_Click(object sender, EventArgs e)
        {
            try
            {
                /*   validations   */
                if (txtWAccountNo.Text == string.Empty)
                {
                    lblWMsg.Visible = true;
                    picWClose.Visible = true;
                    picWClose.BringToFront();
                    lblWMsg.Text = "enter account number to continue...";
                    lblWMsg.ForeColor = Color.FromArgb(158, 10, 5);
                    txtWAccountNo.Focus();
                    return;
                } 
                if(txtWAmount.Text == string.Empty)
                {
                    lblWMsg.Visible = true;
                    picWClose.Visible = true;
                    picWClose.BringToFront();
                    lblWMsg.Text = "enter amount to continue...";
                    lblWMsg.ForeColor = Color.FromArgb(158, 10, 5);
                    txtWAmount.Focus();
                    return;
                }
                else
                { 
                    /* checking if account already exist */
                    int i = 0;                 
                    query = " SELECT * FROM tbAccount WHERE id LIKE '" + txtWAccountNo.Text + "' ";
                    command = new SqlCommand(query, connection);
                    connection.Open();
                    Int32 count = Convert.ToInt32(command.ExecuteScalar());
                    connection.Close();
                    if (count > i)
                    {
                        /* getting the current balance from databse */
                        query = " SELECT * FROM  tbAccount WHERE id LIKE '" + txtWAccountNo.Text + "'";
                        command = new SqlCommand(query, connection);
                        if (connection.State == System.Data.ConnectionState.Closed)
                        {
                            connection.Open();
                            reader = command.ExecuteReader();
                            reader.Read();
                            if (reader.HasRows)
                            {
                                _balance = Convert.ToDouble(reader["balance"].ToString());
                            }
                            reader.Close();
                            connection.Close();
                        }
                        /* checking the amount entered if it is grether that the balance left */
                        if (Convert.ToDouble(txtWAmount.Text) > _balance)
                        {
                            lblWMsg.Visible = true;
                            picWClose.Visible = true;
                            picWClose.BringToFront();
                            lblWMsg.Text = "insufficient balance! current balance is "+_balance+"";
                            lblWMsg.ForeColor = Color.FromArgb(158, 10, 5);
                            return;
                        } 
                        if (Convert.ToDouble(txtWAmount.Text) == _balance)
                        {
                            lblWMsg.Visible = true;
                            picWClose.Visible = true;
                            picWClose.BringToFront();
                            lblWMsg.Text = "warning! you cannot empty your account.";
                            lblWMsg.ForeColor = Color.FromArgb(158, 10, 5);
                            return;
                        }
                        else
                        {
                            /* performing withdrawal operation */
                            double _currentBal = _balance - Convert.ToDouble(txtWAmount.Text);

                            //updating account table
                            query = "UPDATE tbAccount SET balance=@balance WHERE id=@id";
                            command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@id", txtWAccountNo.Text);
                            command.Parameters.AddWithValue("@balance", _currentBal);
                            if (connection.State == System.Data.ConnectionState.Closed)
                            {
                                connection.Open();
                                command.ExecuteNonQuery();
                                connection.Close();
                            }

                            //inserting data
                            query = " INSERT INTO tbTransaction(name,date,amount, time, accountno)VALUES(@name,@date,@amount, @time, @accountno) ";
                            command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@name", btnWithdrawal.Text);
                            command.Parameters.AddWithValue("@date", DateTime.Now.ToShortDateString());
                            command.Parameters.AddWithValue("@amount", Convert.ToDouble(txtWAmount.Text));
                            command.Parameters.AddWithValue("@time", lblTime.Text);
                            command.Parameters.AddWithValue("@accountno", txtWAccountNo.Text);
                            if (connection.State == System.Data.ConnectionState.Closed)
                            {
                                connection.Open();
                                command.ExecuteNonQuery();
                                connection.Close();

                                lblWMsg.Visible = true;
                                picWClose.Visible = true;
                                picWClose.BringToFront();
                                lblWMsg.Text = "withdrawal made successfully";
                                lblWMsg.ForeColor = Color.FromArgb(16, 108, 10);
                                txtWAccountNo.Clear();
                                txtWAmount.Clear();
                            }
                        }                       
                    }
                    else
                    {
                        lblWMsg.Visible = true;
                        picWClose.Visible = true;
                        picWClose.BringToFront();
                        lblWMsg.Text = "sorry! account not found!";
                        lblWMsg.ForeColor = Color.FromArgb(158, 10, 5);
                    }
                }
            }
            catch (Exception ex)
            {
                lblWMsg.Visible = true;
                picWClose.Visible = true;
                picWClose.BringToFront();
                lblWMsg.Text = ex.Message;
                lblWMsg.ForeColor = Color.FromArgb(158, 10, 5);
            }
        }
        private void picWClose_Click(object sender, EventArgs e)
        {
            lblWMsg.Visible = false;
            picWClose.Visible = false;
        }
        #endregion Withdrawal

        #region transferMoney
        private void btnFrom_Click(object sender, EventArgs e)
        {
            /*   validation   */
            if (txtFrom.Text == string.Empty)
            {
                lblTMsg.Visible = true;
                picTClose.Visible = true;
                picTClose.BringToFront();
                lblTMsg.Text = "please enter account number!";
                lblTMsg.ForeColor = Color.FromArgb(158, 10, 5);
                txtFrom.Focus();
                return;
            }
            else
            {
                /*   verifying if account exist   */
                int i = 0;
                query = " SELECT * FROM tbAccount WHERE id LIKE '" + txtFrom.Text + "' ";
                command = new SqlCommand(query, connection);
                connection.Open();
                Int32 count = Convert.ToInt32(command.ExecuteScalar());
                connection.Close();
                if (count > i)
                {
                    lblTMsg.Visible = true;
                    picTClose.Visible = true;
                    picTClose.BringToFront();
                    lblTMsg.Text = "account found! please verify reciever's account to procced..";
                    lblTMsg.ForeColor = Color.FromArgb(15, 108, 10);
                }
                else
                {
                    lblTMsg.Visible = true;
                    picTClose.Visible = true;
                    picTClose.BringToFront();
                    lblTMsg.Text = "account not found!";
                    lblTMsg.ForeColor = Color.FromArgb(158, 10, 5);
                }
            }
        }

        private void btnTo_Click(object sender, EventArgs e)
        {
            /*   validation   */
            if (txtTo.Text == string.Empty)
            {
                lblTMsg.Visible = true;
                picTClose.Visible = true;
                picTClose.BringToFront();
                lblTMsg.Text = "please enter account number!";
                lblTMsg.ForeColor = Color.FromArgb(158, 10, 5);
                if(txtFrom.Text == string.Empty){txtFrom.Focus();}
                else { txtTo.Focus(); }
                return;
            }
            if (txtFrom.Text == txtTo.Text)
            {
                lblTMsg.Visible = true;
                picTClose.Visible = true;
                picTClose.BringToFront();
                lblTMsg.Text = "soory! you CANNOT transfer money to the same account! make a deposit instead";
                lblTMsg.ForeColor = Color.FromArgb(158, 10, 5);
                return;
            }
            else
            {
                /*   verifying if account exist   */
                int i = 0;
                query = " SELECT * FROM tbAccount WHERE id LIKE '" + txtTo.Text + "' ";
                command = new SqlCommand(query, connection);
                connection.Open();
                Int32 count = Convert.ToInt32(command.ExecuteScalar());
                connection.Close();
                if (count > i)
                {
                    lblTMsg.Visible = true;
                    picTClose.Visible = true;
                    picTClose.BringToFront();
                    lblTMsg.Text = "account found! proceed to transfer money";
                    lblTMsg.ForeColor = Color.FromArgb(15, 108, 10);
                }
                else
                {
                    lblTMsg.Visible = true;
                    picTClose.Visible = true;
                    picTClose.BringToFront();
                    lblTMsg.Text = "account not found!";
                    lblTMsg.ForeColor = Color.FromArgb(158, 10, 5);
                }
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            try
            {
                //validations
                if (txtFrom.Text == string.Empty)
                {
                    lblTMsg.Visible = true;
                    picTClose.Visible = true;
                    picTClose.BringToFront();
                    lblTMsg.Text = "please enter account number!";
                    lblTMsg.ForeColor = Color.FromArgb(158, 10, 5);
                    txtFrom.Focus();
                    return;
                }
                if (txtTo.Text == string.Empty)
                {
                    lblTMsg.Visible = true;
                    picTClose.Visible = true;
                    picTClose.BringToFront();
                    lblTMsg.Text = "please enter account number!";
                    lblTMsg.ForeColor = Color.FromArgb(158, 10, 5);
                    if (txtFrom.Text == string.Empty) { txtFrom.Focus(); }
                    else { txtTo.Focus(); }
                    return;
                }
                else
                {
                    /* getting the current balance from databse */
                    query = " SELECT * FROM  tbAccount WHERE id LIKE '" + txtFrom.Text + "'";
                    command = new SqlCommand(query, connection);
                    if (connection.State == System.Data.ConnectionState.Closed)
                    {
                        connection.Open();
                        reader = command.ExecuteReader();
                        reader.Read();
                        if (reader.HasRows)
                        {
                            _balance = Convert.ToDouble(reader["balance"].ToString());
                        }
                        reader.Close();
                        connection.Close();
                    }
                    /* checking the amount entered if it is grether that the balance left */
                    if (Convert.ToDouble(txtTAmount.Text) > _balance)
                    {
                        lblTMsg.Visible = true;
                        picTClose.Visible = true;
                        picTClose.BringToFront();
                        lblTMsg.Text = "insufficient balance! current balance is " + _balance + "";
                        lblTMsg.ForeColor = Color.FromArgb(158, 10, 5);
                        return;
                    }
                    if (Convert.ToDouble(txtTAmount.Text) == _balance)
                    {
                        lblTMsg.Visible = true;
                        picTClose.Visible = true;
                        picTClose.BringToFront();
                        lblTMsg.Text = "warning! you cannot empty your account. Bal  " + _balance + "";
                        lblTMsg.ForeColor = Color.FromArgb(158, 10, 5);
                        return;
                    }
                    else
                    {
                        //transfering 
                        double _transfer = _balance - Convert.ToDouble(txtTAmount.Text);

                        //updating account table
                        query = "UPDATE tbAccount SET balance=@balance WHERE id=@id";
                        command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@id", txtFrom.Text);
                        command.Parameters.AddWithValue("@balance", Convert.ToDouble(_transfer).ToString());
                        if (connection.State == System.Data.ConnectionState.Closed)
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();
                        }

                        //receiving
                        dbcon.executeQuery("UPDATE tbAccount SET balance+='"+Convert.ToDouble(txtTAmount.Text).ToString()+"' WHERE id='"+txtTo.Text+"'");

                        //inserting data into database
                        query = "INSERT INTO tbTransfer([from],[to],amount,date,time)VALUES(@from,@to,@amount,@date,@time)";
                        command = new SqlCommand(query,connection);
                        command.Parameters.AddWithValue("@from", txtFrom.Text);
                        command.Parameters.AddWithValue("@to", txtTo.Text);
                        command.Parameters.AddWithValue("@amount", txtTAmount.Text);
                        command.Parameters.AddWithValue("@date", DateTime.Now.ToShortDateString());
                        command.Parameters.AddWithValue("@time", lblTime.Text);

                        if(connection.State == System.Data.ConnectionState.Closed)
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();

                            lblTMsg.Visible = true;
                            picTClose.Visible = true;
                            picTClose.BringToFront();
                            lblTMsg.Text = "money transferred successfully!";
                            lblTMsg.ForeColor = Color.FromArgb(15, 108, 10);
                            txtFrom.Clear();
                            txtTo.Clear();
                            txtTAmount.Clear();
                        }
                    }
                }
        }
            catch (Exception ex)
            {
                lblTMsg.Visible = true;
                picTClose.Visible = true;
                picTClose.BringToFront();
                lblTMsg.Text = ex.Message;
                lblTMsg.ForeColor = Color.FromArgb(158, 10, 5);
            }
}
        private void picTClose_Click(object sender, EventArgs e)
        {
            lblTMsg.Visible = false;
            picTClose.Visible = false;
            txtFrom.Clear();
            txtTo.Clear();
            txtTAmount.Clear();
        }
        #endregion transferMoney

    }
}
