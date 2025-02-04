using System;
using System.Data;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class ShowInfo : Form
    {
        public ShowInfo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Calling The Client");


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dvg1.DataSource = DBConnectionClass.getInstanceOfDBConnection().Viewclient();



        }

        private void ViewIdeas_Load(object sender, EventArgs e)
        {






        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            //created a back button so the user can go back to the RmDashaboard if he wants
            //close(); is just for closing the old panel
            //show(); just for going back to the RmDashboard
            this.Close();
            RmDashboard Back2 = new RmDashboard();
            Back2.Show();




        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btAssignIdea_Click(object sender, EventArgs e)
        {
            var AssignIdeaFE = new AssignIdea();
            AssignIdeaFE.Show();
            this.Hide();
        }
    }
}
