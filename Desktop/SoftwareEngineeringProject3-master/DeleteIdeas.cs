using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class DeleteIdeas : Form
    {


        public DeleteIdeas()
        {
            InitializeComponent();
        }

        private void Delete_Ideas_Load(object sender, EventArgs e)
        {

        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            //created a back button so the user can go back to the CreatorDashboard if he wants
            //close(); is just for closing the old panel
            //show(); just for going back to the CreatorDashboard
            this.Close();
            CreatorDashboard back1 = new CreatorDashboard();
            back1.Show();



        }

        private void ExitButton_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {

            //created a connectionstring
            //linked the connection string with the data
            // give the user the choice to delete the idea with just a click
            //You need to go to setting and put your own data source value :)
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\mixal\OneDrive\Υπολογιστής\SaveMyProgramming\SoftwareEngineeringProject3\DatabaseApp.mdf; Integrated Security = True");
            con.Open();
            SqlCommand c = new SqlCommand("select * from Login", con);
            SqlDataAdapter d = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            d.Fill(dt);
            dgv.DataSource = dt;
            con.Close();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mixal\OneDrive\Υπολογιστής\SaveMyProgramming\SoftwareEngineeringProject3\DatabaseApp.mdf;Integrated Security=True");
            string prodid = Convert.ToString(dgv.Rows[e.RowIndex].Cells["Account_type"].Value);
            con.Open();
            SqlCommand command = new SqlCommand("delete Login where Account_type='" + prodid + "'", con);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully deleted!");

        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }
    }
}
