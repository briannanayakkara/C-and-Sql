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

        // Vis data i DataGridView

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
            if (textBoxUpdateID.Text == "") // Hvis brugeren ikke giver en værdi, kan dataene ikke findes, da knappen ikke er tilgængelig
            {
                buttonUpdate.Enabled = false;
            }
            else
            {
                buttonUpdate.Enabled = true; // Hvis brugeren giver en værdi i tekstboksen, vil knappen blive aktiveret for at klikke
            }

        }

        // update button
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            
            UpdateID = int.Parse(textBoxUpdateID.Text);// indeholdende brugertype for opdaterings-id, så det kan bruges til at hente data på den næste side 
            Update update = new Update();
            update.Show();

        }
        // refresh button
        private void buttonRefresh_Click_1(object sender, EventArgs e)
        {
            DisplayData();    // Når brugeren klikker på opdateringsknappen, opdateres den gridview, fordi den kører den metode, jeg opretter tidligere
        }

        // commands for delete data 
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteID = int.Parse(textBoxDeleteID.Text); // Indeholder slette-id'et
            connetionSrting = @"Server=.;Database=TT;Trusted_Connection=True;"; // forbinder til databasen
            cs = new SqlConnection(connetionSrting);
            cs.Open();
            sql = "delete Registrering where ID =" + DeleteID +""; //  sql slette kommando
            scmd = new SqlCommand(sql, cs);
            sda.DeleteCommand = new SqlCommand(sql,cs); //angiver, at jeg bruger kommandoen SQL-sletning
            sda.DeleteCommand.ExecuteNonQuery();// udfører kommandoen
            scmd.Dispose(); // at fjerne den anvendte kommando for at lukke forbindelsen
            cs.Close();

            DisplayData(); //metode vil opdatere databasen


        }


        private void textBoxDeleteID_TextChanged(object sender, EventArgs e)
        {
            // Hvis brugeren ikke angiver dele-ID'et, vil knappen til sletning ikke være tilgængelig for at trykke på
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
