using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class DBConnectionClass
    {


        //private object of the class itself
        private static DBConnectionClass _instance;

        //connection string
        private string connStr;
        //the sring logintype stores the login type from the database
        string loginType;
        string accountType;
        string currentAccountUsername = "", currentAccountPassword = "";

        //connection to the DB
        private SqlConnection connToDB;

        /// <summary>
        /// constructor
        /// </summary>
        private DBConnectionClass()
        {
            connStr = Properties.Settings.Default.DBConnection_String;

        }

        
         
        public static DBConnectionClass getInstanceOfDBConnection()
        {
            // create the object only if it doesn't exist  
            if (_instance == null)
                _instance = new DBConnectionClass();
            return _instance;
        }

        /**
         * Returns a data set built based on the query sent as parameter
         */



        /**
         * Method that saves data into the database
         */
        // this method allows the administrator to create an account and it is saved in the database
        public void CreateAccount(string username, string password, string accountType, string email)
        {
            using (SqlConnection connToDB = new SqlConnection(connStr))
            {
                //This line of code helps in the encrption of the inputed password, the method encrypt from passwordSecurity class encrypt the password ans pass it to the encriptedpassword string
                string encriptedpassword = PasswordSecurity.Encrypt(password.ToString());
                //open connection
                connToDB.Open();
                // Add the parameters and set their values
                SqlCommand sqlCommand = new SqlCommand("loginADD2", connToDB);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@username", username.Trim());
                sqlCommand.Parameters.AddWithValue("@password", encriptedpassword.Trim());
                sqlCommand.Parameters.AddWithValue("@Account_Type", accountType.Trim());
                sqlCommand.Parameters.AddWithValue("@Email", email.Trim());

                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Registration Successfull");
                connToDB.Close();
                //connection close
            }

        }
        //method to add client in the database 
        public void Addclient(string max_risk, string Class, string country, string region, string firstName, string lastName, string phone)
        {
            //sql query 
            string insertSql = "INSERT INTO client (maximum_risk, class, country,region,first_name,lastname,phone) VALUES (@max_risk, @Class, @country,@region,@firstname,@lastname,@phone)";

            using (SqlConnection connToDB = new SqlConnection(connStr))
            {
                //connetion open
                connToDB.Open();
                using (SqlCommand command = new SqlCommand(insertSql, connToDB))
                {
                    // Add the parameters and set their values
                    command.Parameters.Add("@max_risk", SqlDbType.VarChar).Value = max_risk;
                    command.Parameters.Add("@Class", SqlDbType.VarChar).Value = Class;
                    command.Parameters.Add("@country", SqlDbType.VarChar).Value = country;
                    command.Parameters.Add("@region", SqlDbType.VarChar).Value = region;
                    command.Parameters.Add("@firstname", SqlDbType.VarChar).Value = firstName;
                    command.Parameters.Add("@lastname", SqlDbType.VarChar).Value = lastName;
                    command.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;



                    // Execute the INSERT statement
                    command.ExecuteNonQuery();
                    connToDB.Close();
                    //connection close
                    MessageBox.Show("Client has been added");
                }
            }






        }


        // login method 
        public void LoginDB(string usernametxt, string password)
        {

            //the if statement is checking if the username or password is empty and prompt the user to try again
            if (usernametxt.Equals("") || password.Equals(""))
            {
                MessageBox.Show("Username or Password cannot be empty");
                LoginPage loginPage = new LoginPage();
                loginPage.Show();

            }
            else
            {

                string DBPassword = "";
                using (SqlConnection connToDB = new SqlConnection(connStr))
                {


                    bool userExist = false;
                    //open connection
                    connToDB.Open();
                    // the string query is checking if username from user exists in the database 
                    String querry = "SELECT * FROM Login WHERE Username = '" + usernametxt + "'";


                    SqlCommand sqlcommand = new SqlCommand(querry, connToDB);


                    //set the sqlCommand's properties
                    SqlDataReader sqlDataReader = sqlcommand.ExecuteReader();
                    if (sqlDataReader.Read())
                    {

                        DBPassword = sqlDataReader.GetString(2);  //get the user password from db if the user name is exist in that. 
                        loginType = sqlDataReader.GetString(3);  // gets the the login type from the database 
                        userExist = true; // the bool value returns true if the IF statement code is executed 

                    }
                    connToDB.Close(); // database connection closed 



                    if (userExist)  //if record exis in db , it will return true, otherwise it will return false 
                    {


                        //the if statement is call the method decrypt for the decryption of the password in the database and compare it with the user input 
                        if (PasswordSecurity.Decrypt(DBPassword).Equals(password))
                        {
                            // the if statements check the type of login so the user can be redirected to the appropriate page
                            if (loginType.Trim().Equals("creator"))
                            {
                                CreatorDashboard creatorDashboard = new CreatorDashboard();
                                creatorDashboard.Show();
                            }


                            else if (loginType.Trim().Equals("RM"))
                            {
                                RmDashboard rmDashboard = new RmDashboard();
                                rmDashboard.Show();
                            }
                            else if (loginType.Trim().Equals("IT"))
                            {
                                IT_Dashboard iT_Dashboard = new IT_Dashboard();
                                iT_Dashboard.Show();
                            }

                            else
                            {

                                MessageBox.Show("Invalid Login details");
                                LoginPage loginPage = new LoginPage();
                                loginPage.Show();
                            }
                        }
                        else
                        {




                            MessageBox.Show("Invalid Login details"); // message to show user if the login credentials are not correct 
                            LoginPage loginPage = new LoginPage();
                            loginPage.Show();

                        }
                    }
                }
                currentAccountUsername = usernametxt;
                currentAccountPassword = DBPassword;


            }

        }











        public void CreateIdea(string Author, string ideaTitle, string ideaAbstract, string countryAvailability, string regionalAvailability, string currencyType, string ideaType, string publishDate, string expireDate, string insertIdea, string MinorSector, string MajorSector, string Riskrating)
        {
            try
            {
                using (SqlConnection connToDB = new SqlConnection(connStr))
                {
                    connToDB.Open();
                    //set the sqlCommand's properties
                    string querry = "INSERT INTO Idea (Risk_rating,Abstract,Country_availability,Regional_availability,Currency_type,Idea_type,Publish_date,Expire_date,Idea_title,Idea_document,Author,Minor_sector,Major_sector,AssignedTo)Values(@Riskrating,@ideaAbstract,@countryAvailability,@regionalAvailability,@currencyType,@ideaType,@publishDate,@expireDate,@ideaTitle,@insertIdea,@Author,@MinorSector,@MajorSector,@AssignedTo)";
                    SqlCommand sqlcommand = new SqlCommand(querry, connToDB);
                    // Add the parameters and set their values
                    sqlcommand.Parameters.Add("@Riskrating", SqlDbType.VarChar).Value = Riskrating;
                    sqlcommand.Parameters.Add("@ideaAbstract", SqlDbType.VarChar).Value = ideaAbstract;
                    sqlcommand.Parameters.Add("@countryAvailability", SqlDbType.VarChar).Value = countryAvailability;
                    sqlcommand.Parameters.Add("@regionalAvailability", SqlDbType.VarChar).Value = regionalAvailability;
                    sqlcommand.Parameters.Add("@currencyType", SqlDbType.VarChar).Value = currencyType;
                    sqlcommand.Parameters.Add("@ideaType", SqlDbType.VarChar).Value = ideaType;
                    sqlcommand.Parameters.Add("@publishDate", SqlDbType.VarChar).Value = publishDate;
                    sqlcommand.Parameters.Add("@expireDate", SqlDbType.VarChar).Value = expireDate;
                    sqlcommand.Parameters.Add("@ideaTitle", SqlDbType.VarChar).Value = ideaTitle;
                    sqlcommand.Parameters.Add("@insertIdea", SqlDbType.VarChar).Value = insertIdea;
                    sqlcommand.Parameters.Add("@Author", SqlDbType.VarChar).Value = Author;
                    sqlcommand.Parameters.Add("@MinorSector", SqlDbType.VarChar).Value = MinorSector;
                    sqlcommand.Parameters.Add("@MajorSector", SqlDbType.VarChar).Value = MajorSector;
                    sqlcommand.Parameters.Add("@AssignedTo", SqlDbType.VarChar).Value = "";


                    sqlcommand.ExecuteNonQuery();
                    //connection closed
                    connToDB.Close();
                    MessageBox.Show("Wow your idea has been saved successfully");
                    CreatorDashboard creatorDashboard = new CreatorDashboard();
                    creatorDashboard.Show();




                }

            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong check your input and try again");
            }
        }
    
                //Method for admin to change password 
                public void AdminChangePassword(string username, string password, string confirmPassword)
                {
                    //the if statement checks if the password and the comfirm password is equal 
                    if (password.Equals(confirmPassword))
                    {
                        using (SqlConnection connToDB = new SqlConnection(connStr))
                        {

                            bool accountExist = false;
                            //open connection
                            connToDB.Open();
                            //the sql query checks if the username exists in the database
                            String querry = "SELECT * FROM Login WHERE Username = '" + username + "'";

                            SqlCommand sqlcommand = new SqlCommand(querry, connToDB);

                            //set the sqlCommand's properties
                            SqlDataReader sqlDataReader = sqlcommand.ExecuteReader();
                            //the if statement is executed if the username exist in the database 
                            if (sqlDataReader.Read())
                            {
                                accountExist = true;

                            }
                            else
                            {
                                MessageBox.Show("This username cannot be found in the database");
                            }
                            sqlDataReader.Close();
                            if (accountExist)
                            {
                                string encrptedPassword = PasswordSecurity.Encrypt(password);//password get from user is encrypted and passed to string encryptedpassword 
                                SqlCommand sqlCommand1 = new SqlCommand("UPDATE [dbo].[LOGIN] SET [password] = '" + encrptedPassword + "' WHERE USERNAME= '" + username + "'", connToDB);
                                sqlCommand1.ExecuteNonQuery();
                                connToDB.Close();
                                MessageBox.Show("Password has been changed Successfully");
                            }

                        }

                    }
                    else
                    {
                        MessageBox.Show("Password and confirm password must be equal");
                        return;
                    }


                }
                public void UserChangePassword(string oldpassword, string newpassword, string confirmPassword)
                {
                    string username = GetCurrentUsername();
                    // fetches the current account username in use to use in future code
                    if (newpassword.Equals(confirmPassword))
                    {
                        using (SqlConnection connToDB = new SqlConnection(connStr))
                        {


                            //open connection
                            connToDB.Open();
                            String query = "SELECT * FROM Login WHERE Username = '" + username + "'";

                            if (oldpassword == currentAccountPassword)
                            {
                                SqlCommand sqlcommand = new SqlCommand(query, connToDB);

                                //set the SQLCommand's properties
                                SqlDataReader sqlDataReader = sqlcommand.ExecuteReader();

                                string encrptedPassword = PasswordSecurity.Encrypt(confirmPassword);
                                SqlCommand sqlCommand1 = new SqlCommand("UPDATE [dbo].[LOGIN] SET [password] = '" + encrptedPassword + "' WHERE USERNAME= '" + username + "'", connToDB);
                                sqlCommand1.ExecuteNonQuery();
                                connToDB.Close();
                                MessageBox.Show("Password has been changed Successfully");
                            }
                            else if (oldpassword != currentAccountPassword)
                            {
                                MessageBox.Show("The password submitted doesn't match please try again.");
                                // This else if helps with debugging as there are only 2 states accepted with anything else being an error of sorts.
                            }
                            else
                            {
                                MessageBox.Show("An error was encountered when trying to update the password.");
                            }

                        }

                    }
                    else
                    {
                        MessageBox.Show("The new passowrd mus be the same in both boxes.");
                        return;
                    }


                }
                public bool ForgotPasswordBE(string resetCode, string username, string newPassword, string confirmNewPassword)
                {
                    //The only real difference between this function and the last is that it somewhat gives the user admin control providing they have the appropriate reset code

                    if (resetCode == "RESET")
                    {
                        AdminChangePassword(username, newPassword, confirmNewPassword);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("You have not entered the correct reset code please try again.");
                        return false;
                    }
                }
                private string GetCurrentUsername()
                {
                    return currentAccountUsername;
                }
                private string GetCurrentPassword()
                {
                    return currentAccountPassword;
                }
                // this method allows admin to delete account in the database 
                public void DeleteAccount(string username, string Accounttype)
                {
                    using (SqlConnection connToDB = new SqlConnection(connStr))
                    {

                        bool accountExist = false;
                        //open connection
                        connToDB.Open();
                        String querry1 = "SELECT * FROM Login WHERE Username = '" + username + "'";
                        String querry2 = "DELETE FROM Login WHERE Username = '" + username + "'";

                        SqlCommand sqlcommand = new SqlCommand(querry1, connToDB);
                        SqlDataReader sqlDataReader = sqlcommand.ExecuteReader();
                        if (sqlDataReader.Read())
                        {

                            accountType = sqlDataReader.GetString(3);

                            accountExist = true;

                        }
                        else
                        {
                            MessageBox.Show("Invalid Account details");
                        }
                        sqlDataReader.Close();
                        if (accountExist)  //if record exists in db , it will return true, otherwise it will return false 
                        {
                            if (Accounttype.Equals(accountType.Trim()))
                            {
                                SqlCommand sqlcommand1 = new SqlCommand(querry2, connToDB);
                                sqlcommand1.Parameters.AddWithValue("@Username", username);
                                sqlcommand1.ExecuteNonQuery();
                                MessageBox.Show("Record has been deleted");
                            }
                            else
                            {
                                MessageBox.Show("Invalid Account details");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Invalid Account details");
                        }
                        connToDB.Close();
                    }
                }
                public DataTable Viewclient()
                {
                    DataTable dtViewclient = new DataTable();
                    //created a connectionstring
                    //linked the connectionString with the data source
                    //this button created just to show the View ideas to the creator
                    using (SqlConnection connToDB = new SqlConnection(connStr))
                    {

                        string query = "Select * from Client";
                        SqlCommand sqlCommand = new SqlCommand(query, connToDB);
                        connToDB.Open();
                        // create data adapter
                        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                        dtViewclient.Load(sqlDataReader);
                        //this will query our database and return the result to our database table
                        connToDB.Close();

                    }

                    return dtViewclient;
                }
                public DataTable ViewIdea()
                {
                    DataTable dtViewIdea = new DataTable();
                    //created a connectionstring
                    //linked the connectionString with the data source
                    //this button created just to show the View ideas to the creator
                    using (SqlConnection connToDB = new SqlConnection(connStr))
                    {

                        string query = "Select * from Idea";
                        SqlCommand sqlCommand = new SqlCommand(query, connToDB);
                        connToDB.Open();
                        // create data adapter
                        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                        dtViewIdea.Load(sqlDataReader);
                        //this will query our database and return the result to our database table
                        connToDB.Close();

                    }

                    return dtViewIdea;
                }

                public bool AssignIdeaBE(string clientusername, string ideaname)
                {

                 bool clientExist = false, ideaExist = false;
                 string assignedTo = "";                
                    using (SqlConnection connToDB = new SqlConnection(connStr))
                    {

                        //open connection
                        connToDB.Open();
                        //the sql query checks if the username exists in the database
                        String querry = "SELECT * FROM Login WHERE Username = '" + clientusername + "'";

                        SqlCommand sqlcommandclient = new SqlCommand(querry, connToDB);

                        //set the sqlCommand's properties
                        SqlDataReader sqlDataReader = sqlcommandclient.ExecuteReader();
                        //the if statement is executed if the client username exists in the database 
                        if (sqlDataReader.Read())
                        {
                            clientExist = true;

                        }
                        else
                        {
                            MessageBox.Show("This client cannot be found in the database");
                            return false;
                        }
                        querry = "SELECT * FROM IdeaTable WHERE Idea_title = '" + ideaname + "'";
                        SqlCommand sqlcommandidea = new SqlCommand(querry, connToDB);
                        //set the sqlCommand's properties
                        SqlDataReader sqlDataReader2 = sqlcommandidea.ExecuteReader();
                        //the if statement is executed if the idea name exists in the database 
                        if (sqlDataReader2.Read())
                        {
                            ideaExist = true;
                            if(ideaExist)
                            {
                                querry = "SELECT IdeaTable.AssignedTo FROM IdeaTable WHERE Idea_title = '" + ideaname + "'";
                                SqlCommand sqlcommandassignedto = new SqlCommand(querry, connToDB);
                                SqlDataReader sqlDataReader3 = sqlcommandassignedto.ExecuteReader();
                                assignedTo = sqlcommandassignedto.ExecuteReader().ToString();
                              // Placeholder code that should get the column that holds the Assigned To variable that then puts in this variable to use later
                            }

                        }
                        else
                        {
                            MessageBox.Show("This idea cannot be found in the database");
                            return false;
                        }
                        sqlDataReader2.Close();
                        // Both validations being confirmed now update the database
                        if (ideaExist && clientExist && assignedTo != "")
                        {
                            SqlCommand sqlCommand1 = new SqlCommand("UPDATE [dbo].[IdeaTable] SET [AssignedTo] = '" + clientusername + "' WHERE Idea_title= '" + ideaname + "'", connToDB);
                            sqlCommand1.ExecuteNonQuery();
                }
                        else
                        {
                            // This option should be impossible but is here for testing
                            MessageBox.Show("An error occured...");
                            return false;
                        }
                            return true;
                    }

                }


            }
        }
    
