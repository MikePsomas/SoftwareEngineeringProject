using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class RmDashboard : Form
    {
        public RmDashboard()
        {
            InitializeComponent();
        }

        private void NewIdeas_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void ViewIdeas_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Click(object sender, EventArgs e)
        {

        }

        private void NewIdeas_Click_1(object sender, EventArgs e)
        {
         
            var view_Ideas = new View_Ideas();
            view_Ideas.Show();
            this.Hide();

        }

        private void Dashboard_Click_1(object sender, EventArgs e)
        {
            BtNewIdeas.Visible = true;
            BtAssignIdeas.Visible = true;
            BtClientsProfile.Visible = true;
            BtAddClient.Visible = true;
            BtUpdatePassword.Visible = true;





        }

        private void RmDashboard_Load(object sender, EventArgs e)
        {


        }

        private void AssignIdeas_Click(object sender, EventArgs e)
        {

            var Assign = new View_Ideas();
            Assign.Show();
            this.Hide();


        }

        private void ClientsProfile_Click(object sender, EventArgs e)

        {
            var viewClientsProfile = new ShowInfo();
            viewClientsProfile.Show();
            this.Hide();


        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void BtAddClient_Click(object sender, EventArgs e)
        {
            var AddClients = new AddClient();
            AddClients.Show();
            this.Hide();


        }

        private void BtUpdatePassword_Click(object sender, EventArgs e)
        {
            var UpdatePassword = new UpdatePassword();
            UpdatePassword.Show();
            this.Hide();
        }
    }
}
