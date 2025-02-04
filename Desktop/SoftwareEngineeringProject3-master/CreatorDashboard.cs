using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CreatorDashboard : Form
    {
        public CreatorDashboard()
        {
            InitializeComponent();


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //I've made the Buttons to be visible = false; so when the user press the Dasboard button
            // he can see all the other buttons/options he has.

            BtnCreateNewIdeas.Visible = true;
            BtnViewIdeas.Visible = true;
            BtnDeleteIdeas.Visible = true;
            BtUpdatePassword.Visible = true;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void CreateNewIdeas_Click(object sender, EventArgs e)
        {
            // just created a variable so when the user wants to go to create a new idea he just press the button and transfers there
            //.show(); is just for showing the new panel that we want to send/show to the user
            //this.hide is just for hiding the old windows form panel
            var NewCreate = new NewIdeas();
            NewCreate.Show();
            this.Hide();




        }

        private void ViewIdeas_Click(object sender, EventArgs e)
        {
            // just created a variable so when the user wants to go to view ideas he just press the button and transfers there
            //.show(); is just for showing the new panel that we want to send/show to the user
            //this.hide is just for hiding the old windows form panel
            var ViewIdeas = new View_Ideas();
            ViewIdeas.Show();
            this.Hide();






        }

        private void DeleteIdeas_Click(object sender, EventArgs e)
        {
            // just created a variable so when the user wants to go to delete ideas he just press the button and transfers there
            //.show(); is just for showing the new panel that we want to send/show to the user
            //this.hide is just for hiding the old windows form panel
            var del = new DeleteIdeas();
            del.Show();
            this.Hide();


        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtUpdatePassword_Click(object sender, EventArgs e)
        {
            var UpdatePassword = new UpdatePassword();
            UpdatePassword.Show();
            this.Hide();
        }
    }
}
