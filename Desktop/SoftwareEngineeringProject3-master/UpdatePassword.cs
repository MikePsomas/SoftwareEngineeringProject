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
    public partial class UpdatePassword : Form
    {
        public UpdatePassword()
        {
            InitializeComponent();
        }

        private void BtUpdatePassword_Click(object sender, EventArgs e)
        {
            DBConnectionClass.getInstanceOfDBConnection().UserChangePassword(TbOldPassword.Text, TbNewPassword.Text, TbNewPasswordConfirm.Text);
            this.Hide();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
           //if else statement with bool
            bool RmDashboard = true;
            bool CreatorDashboard = false;


            if (RmDashboard == true)
            {
                this.Close();
                RmDashboard btnGoBack = new RmDashboard();
                btnGoBack.Show();
            }
            else if (CreatorDashboard == false)
            {

                

                 this.Close();
                CreatorDashboard back = new CreatorDashboard();
                back.Show();



            }
            

        }

        private void UpdatePassword_Load(object sender, EventArgs e)
        {

        }
    }
}
