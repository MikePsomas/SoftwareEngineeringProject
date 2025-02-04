using System;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void BtLogin_Click(object sender, EventArgs e)
        {


            DBConnectionClass.getInstanceOfDBConnection().LoginDB(tbUsername.Text, tbPassword.Text);
            this.Hide();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtForgotPassword_Click(object sender, EventArgs e)
        {
            var ForgotPassoword = new ForgotPassoword();
            ForgotPassoword.Show();
            this.Hide();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtExit_Click(object sender, EventArgs e)
        {
            this.Close();


        }

        private void btRegister_Click(object sender, EventArgs e)
        {



        }




        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // this code just shows and hides the password **
            if(checkBox1.Checked)
            {
                tbPassword.UseSystemPasswordChar = true;
            }
            else
            {
                tbPassword.UseSystemPasswordChar = false;
            }
        }
    }
}
