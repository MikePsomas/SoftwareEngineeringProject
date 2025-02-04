using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Text;
using System.Data.Sql;






namespace WindowsFormsApp1
{
    public partial class NewIdeas : Form
    {
      
       
        public NewIdeas()
        {
            InitializeComponent();
        }
        //open connection with sql server
        //and save the input in the Database that is called NewIdea
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\mixal\OneDrive\Υπολογιστής\SoftwareEngineeringProject3\DataBase.mdf; Integrated Security = True; ");
        SqlCommand cmd;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //created a back button so the user can go back to the CreatorDashboard if he wants
            //close(); is just for closing the old panel
            //show(); just for going back to the CreatorDashboard
            this.Close();
            CreatorDashboard back6 = new CreatorDashboard();
            back6.Show();




        }




        private void button1_Click(object sender, EventArgs e)
        {
            DBConnectionClass.getInstanceOfDBConnection().CreateIdea(TxtAuthor.Text, TxtIdeaTitle.Text, TxtAbstract.Text, TxtCountry.Text, TxtRegion.Text, TxtCurrency.Text, TxtIdealType.Text, tbPublishDate.Text, tbExpireDate.Text, TxtInsertIdea.Text, TxtMinor.Text, TxtMajor.Text,cbRiskrating.Text);

       







          //  con.Open();
          // cmd = new SqlCommand(@"INSERT INTO NewIdea values ('" + this.TxtIdeaTitle.Text + "','" + this.TxtAuthor.Text + "','" + this.TxtMajor.Text + "','" + this.TxtMinor.Text + "','" + this.TxtAbstract.Text + "','" + this.TxtCountry.Text + "','" + this.TxtRegion.Text + "','" + this.TxtCurrency.Text + "','" + this.TxtPusblishDate.Text + "','" + this.TxtExpireDate.Text + "','" + this.TxtIdealType.Text + "','" + this.TxtInsertIdea.Text + "',)", con);
          
          
            
          // MessageBox.Show("New Idea was created");
          //  con.Close();
                
            
           


           

        }

        private void NewIdeas_Load(object sender, EventArgs e)
        {

        }

        private void TxtPusblishDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TxtExpireDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }

}

