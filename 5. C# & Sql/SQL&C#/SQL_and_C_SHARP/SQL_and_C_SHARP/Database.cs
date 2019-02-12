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
    public  partial class Database : Form
    {
        SqlCommand scmd = new SqlCommand();
        SqlDataAdapter sda = new SqlDataAdapter();
        String sql, connetionSrting;
        SqlConnection cs = new SqlConnection();
        DataTable dt = new DataTable();




        public static int UpdateID, DeleteID;


        public Database()
        {
            InitializeComponent();
            DisplayData();
        }
        // gride viwe

        //Display Data in DataGridView  

        public void DisplayData()
        {
            connetionSrting = @"Server=.;Database=TT;Trusted_Connection=True;";
            cs = new SqlConnection(connetionSrting);
            cs.Open();
            DataTable dt = new DataTable();
            sda = new SqlDataAdapter("select * from Registrering ", cs);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            cs.Close();
        }

        private void Database_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.show();
        }


        // insert button
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            Insert insert = new Insert();
            insert.Show();
        }

        // update 
        private void textBoxUpdateID_TextChanged(object sender, EventArgs e)
        {
            if (textBoxUpdateID.Text == "") // if the user dont give a value then the data cant be found there for the button will not be avaleble 
            {
                buttonUpdate.Enabled = false;
            }
            else
            {
                buttonUpdate.Enabled = true; // if the user give a value in the textbox the the button will be enable to click 
            }

        }

        // update button
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            
            UpdateID = int.Parse(textBoxUpdateID.Text);// containing the update ID user type so it can be use to fatch data in the next page 
            Update update = new Update();
            update.Show();

        }
        // refresh button
        private void buttonRefresh_Click_1(object sender, EventArgs e)
        {
            DisplayData();    // when the user click the refesh button it will refresh the gride viwe due to the fact that it runs the methode I creat  earlire 
        }

        // commands for delete data 
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteID = int.Parse(textBoxDeleteID.Text); // Contain the delete ID 
            connetionSrting = @"Server=.;Database=TT;Trusted_Connection=True;"; // connecting to the database 
            cs = new SqlConnection(connetionSrting);
            cs.Open();
            sql = "delete Registrering where ID =" + DeleteID +""; //  sql delete comand 
            scmd = new SqlCommand(sql, cs);
            sda.DeleteCommand = new SqlCommand(sql,cs); // specifying that I'm using the sql delete comand 
            sda.DeleteCommand.ExecuteNonQuery();// executing the comand 
            scmd.Dispose(); // getting rid the uded command to close the connection 
            cs.Close();

            DisplayData(); // methode will refresh the data base 

             
        }


        private void textBoxDeleteID_TextChanged(object sender, EventArgs e)
        {
            // if the user dont specify the dele ID the button for delete wont be avaleble to press
            if (textBoxDeleteID.Text == "")
            {
                buttonDelete.Enabled = false;
            }
            else
            {
                buttonDelete.Enabled = true;
            }
        }



    }
}
