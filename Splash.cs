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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void picMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value < 100)
            {
                progressBar1.Value += 1;
                lblProgress.Text = progressBar1.Value.ToString() + "%";
            }
            else
            {
                timer1.Enabled = false;
                this.Hide();
                Login login = new Login();
                login.Show();
            }
        }
    }
}
