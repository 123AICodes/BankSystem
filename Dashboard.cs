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
    public partial class Dashboard : Form
    {
        DBConnect dbcon = new DBConnect();
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
       
        Menu menu;
        public Dashboard(Menu mn)
        {
            InitializeComponent();
            connection = new SqlConnection(dbcon.myConnection());
            menu = mn;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
        //themes
        #region manageAccountTheme
        private void manageAccountThemeIndigo()
        {
            pnlAdminCol.BackColor = Color.Indigo;
            pnlAccountCol.BackColor = Color.Indigo;
            pnlDepositCol.BackColor = Color.Indigo;
            pnlDAmountCol.BackColor = Color.Indigo;
            pnlWAmountCol.BackColor = Color.Indigo;
            pnlWithwralCol.BackColor = Color.Indigo;
            pnlDashboard.BackColor = Color.Indigo;

            lblHeader.ForeColor = Color.Indigo;
            btnClose1.BackColor = Color.Indigo;
        }
        private void manageAccountThemePurple()
        {
            pnlAdminCol.BackColor = Color.Purple;
            pnlAccountCol.BackColor = Color.Purple;
            pnlDepositCol.BackColor = Color.Purple;
            pnlDAmountCol.BackColor = Color.Purple;
            pnlWithwralCol.BackColor = Color.Purple;
            pnlWAmountCol.BackColor = Color.Purple;
            pnlDashboard.BackColor = Color.Purple;
           
            lblHeader.ForeColor = Color.Purple;
            btnClose1.BackColor = Color.Purple;

         
        }
        private void manageAccountThemeCrimson()
        {
            pnlAdminCol.BackColor = Color.Crimson;
            pnlAccountCol.BackColor = Color.Crimson;
            pnlDepositCol.BackColor = Color.Crimson;
            pnlDAmountCol.BackColor = Color.Crimson;
            pnlWithwralCol.BackColor = Color.Crimson;
            pnlWAmountCol.BackColor = Color.Crimson;
            pnlDashboard.BackColor = Color.Crimson;
          
            lblHeader.ForeColor = Color.Crimson;
            btnClose1.BackColor = Color.Crimson;

          
        }
        private void manageAccountThemeDefault()
        {
            pnlAdminCol.BackColor = Color.FromArgb(16, 108, 10);
            pnlAccountCol.BackColor = Color.FromArgb(16, 108, 10);
            pnlDepositCol.BackColor = Color.FromArgb(16, 108, 10);
            pnlDAmountCol.BackColor = Color.FromArgb(16, 108, 10);
            pnlWithwralCol.BackColor = Color.FromArgb(16, 108, 10);
            pnlWAmountCol.BackColor = Color.FromArgb(16, 108, 10);
            pnlDashboard.BackColor = Color.FromArgb(16, 108, 10);
           
            lblHeader.ForeColor = Color.FromArgb(16, 108, 10);
            btnClose1.BackColor = Color.FromArgb(16, 108, 10);
           
        }
        #endregion manageAccountTheme

        private void Dashboard_Load(object sender, EventArgs e)
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

            lblAccount.Text = dbcon.ExtractData("select isnull(count(*),0) from tbAccount").ToString();
            lblAdmin.Text = dbcon.ExtractData("select isnull(count(role),0) from AgentTbl where role like 'Admin' ").ToString();

            lblDeposit.Text = dbcon.ExtractData("select isnull(count(amount),0) from tbTransaction where name like 'Deposit' ").ToString();
            lblWithdrawals.Text = dbcon.ExtractData("select isnull(count(amount),0) from tbTransaction where name like 'Withdraw' ").ToString();

            lblDAmount.Text = dbcon.ExtractData("select isnull(sum(amount),0) from tbTransaction where name like 'Deposit' ").ToString("#,##0.00");
            
            lblWAmount.Text = dbcon.ExtractData("select isnull(sum(amount),0) from tbTransaction where name like 'Withdraw' ").ToString("#,##0.00");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.Show();
        }

       
    }
}
