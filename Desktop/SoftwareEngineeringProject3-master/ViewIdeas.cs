using System;
using System.Data;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class View_Ideas : Form
    {


        public View_Ideas()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void View_Ideas_Load(object sender, EventArgs e)
        {




        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            // the method of viewIdea from DBConnectionClass has been passed to the data view grid  
            dgv1.DataSource = DBConnectionClass.getInstanceOfDBConnection().ViewIdea();

            //created a connectionstring
            //linked the connectionString with the data source
            //this button created just to show the View ideas to the creator
            /*string connectionString;
            System.Data.SqlClient.SqlConnection cnn;
            connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\mixal\OneDrive\Υπολογιστής\SoftwareEngineeringProject3\DataBase.mdf; Integrated Security = True;";
            cnn = new System.Data.SqlClient.SqlConnection(connectionString);
            string query = "select * from Login";
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(query, cnn);
            //open connections
            cnn.Open();
            // create data adapter
            System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            // this will query our database and return the result to our database table
            da.Fill(dataTable);
            dgv1.DataSource = dataTable;
            //close connections
            cnn.Close();*/






        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //created a back button so the user can go back to the RmDashboard if he wants
            //close(); is just for closing the panel
            //show(); just for going back to the RmDashboard
            this.Close();
            RmDashboard back = new RmDashboard();
            back.Show();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //just a simple messagebox to inform that we have Assign the idea 
            MessageBox.Show("Your Idea Has Been Assign :) ");



        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
