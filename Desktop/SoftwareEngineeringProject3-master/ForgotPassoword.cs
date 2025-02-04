using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ForgotPassoword : Form
    {
        private bool resetSuccessful = false;
        public ForgotPassoword()
        {
            InitializeComponent();
        }

        private void ForgotPassowrd_Load(object sender, EventArgs e)
        {

        }

        private void btResetPassword_Click(object sender, EventArgs e)
        {
            
           resetSuccessful = DBConnectionClass.getInstanceOfDBConnection().ForgotPasswordBE(tbResetCode.Text, tbUsername.Text, tbNewPassword.Text, tbConfirmNewPassword.Text);
           if(resetSuccessful)
            {
                this.Hide();
                MessageBox.Show("Password reset successful! Returning to login page...");
                var LoginPage = new LoginPage();
                LoginPage.Show();
            }

        }

        private void btRevealResetCode_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usually your email would be use and your code would be sent there, but for the purpose of this program the code is: RESET");
        }
    }
}
