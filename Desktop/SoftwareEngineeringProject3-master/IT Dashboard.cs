using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class IT_Dashboard : Form
    {
        public IT_Dashboard()
        {
            InitializeComponent();
            pnChangepassword.Hide();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateAccount createAccount = new CreateAccount();
            createAccount.Show();
        }

        private void IT_Dashboard_Load(object sender, EventArgs e)
        {
            
        }

        private void btCreatePassword_Click(object sender, EventArgs e)
        {
            pnChangepassword.Show();
        }

        private void bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            DBConnectionClass.getInstanceOfDBConnection().AdminChangePassword(tbUsername.Text, tbPassword.Text, tbConPassword.Text);
        }

        private void bt_Remove_account_Click(object sender, EventArgs e)
        {
            RemoveAccount removeAccount = new RemoveAccount();
            removeAccount.Show();
            //pnChangepassword.Hide();
            //pnRemove_account.Show();

        }

        
        private void btBack_Click(object sender, EventArgs e)
        {
            pnChangepassword.Hide();
            
        }

        private void btR_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
          
        }
    }
}
