using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
        }

        private void AddClient_Load(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            //created a back button so the user can go back to the RmDashboard if he wants
            //close(); is just for closing the panel
            //show(); just for going back to the RmDashboard
            this.Close();
            RmDashboard back = new RmDashboard();
            back.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBConnectionClass.getInstanceOfDBConnection().Addclient(tbmaxRisk.Text, tbClass.Text, tbCountry.Text, tbRegion.Text, tbFirstname.Text, tbLastname.Text, tbphone.Text);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
