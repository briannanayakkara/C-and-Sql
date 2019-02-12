using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SQL_and_C_SHARP
{
    public partial class Form1 : Form
    {
        //display 
        public Form1()
        {
            InitializeComponent();
        }

        string usernmae = "admin", password = "password";

        // First form to connect to the server
        private void buttonConnector_Click(object sender, EventArgs e) // when click the button
        {

            // making a connection string
            string connetionSrting;
            // using the VS class to contain the string 
            SqlConnection cs;
            // containing the connection string to the string 
            connetionSrting = @"Server=.;Database=TT;Trusted_Connection=True;";
            // the connectiongsting will be taken as a value of the class of sql connection under "cn"
            cs = new SqlConnection(connetionSrting);
            cs.Open();// opening connection
            
            cs.Close();// closing connection
            // using the database class 
            Database database = new Database(); 
            database.Show(); // opening the data base 
            this.Hide();//hide the running form

        }

        // opening the current form (creating a methode for use this in other forms)
        public void show()

        {
            this.Show();
            
        }
        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        // when clicking the button 2 (find data button) run this code 
        private void button2_Click(object sender, EventArgs e)
        {
            FindData fd = new FindData();
            fd.Show();// open the FindData form 
            this.Hide();//hiding this form 
        }



        // set password to admin login button
        private void Password_TextChanged(object sender, EventArgs e)
        {
            
            textBoxPassword.PasswordChar = '*';//making text type to password 
            if (textBoxPassword.Text != password && textBoxUsername.Text != usernmae)
            {
                button1.Enabled = false; // the login button will be unabe to click if the password or username dosent match 
            }
            if (textBoxPassword.Text == password && textBoxUsername.Text == usernmae)
            {
                button1.Enabled = true;
            }
        }

    }
}
