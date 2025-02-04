using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            // created a back button so the user can go back to the IT DASHBOARD if he wants
            //close(); is just for closing the old panel
            //show(); just for going back to the RmDashboard
            this.Close();
            IT_Dashboard Back2 = new IT_Dashboard();
            Back2.Show();
        }

        private void lbUsername_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {

        }

        private void btcreateUser_Click(object sender, EventArgs e)
        {
            DBConnectionClass.getInstanceOfDBConnection().CreateAccount(tbUsername.Text, tbPassword.Text, cbAccountType.Text, tbEmail.Text);
        }
    }
}
