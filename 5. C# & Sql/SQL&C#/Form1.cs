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
        // laver admin username og password
        string usernmae = "admin", password = "password";

        // Første formular til forbindelse til serveren
        private void buttonConnector_Click(object sender, EventArgs e) // when click the button
        {

            // oprettelse af en forbindelsesstreng
            string connetionSrting;
            // bruger VS klassen til at indeholde strengen
            SqlConnection cs;
            // indeholdende forbindelsesstrengen til strengen
            connetionSrting = @"Server=.;Database=TT;Trusted_Connection=True;";
            // connectiongsting vil blive taget som en værdi af klassen SQL-forbindelse under "cn"...
            cs = new SqlConnection(connetionSrting);
            cs.Open();// åbning forbindelse

            cs.Close();//lukkeforbindelse
            // bruger databaseklassen
            Database database = new Database(); 
            database.Show(); // Åbning af databasen 
            this.Hide();// skjul løbende formular

        }

        // Åbning af den nuværende formular (skaber en metode til brug i andre former)
        public void show()

        {
            this.Show();
            
        }
        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        // Når man klikker på knappen 2 (find dataknap), kør denne kode
        private void button2_Click(object sender, EventArgs e)
        {
            FindData fd = new FindData();
            fd.Show();// Åbn FindData-formen
            this.Hide();// gemmer denne formular
        }



        // Indstil adgangskode til admin login-knap
        private void Password_TextChanged(object sender, EventArgs e)
        {
            
            textBoxPassword.PasswordChar = '*';//gør teksttype til password 
            if (textBoxPassword.Text != password && textBoxUsername.Text != usernmae)
            {
                button1.Enabled = false; // login-knappen vil ikke kunne klikke, hvis adgangskoden eller brugernavnet ikke stemmer overens
            }
            if (textBoxPassword.Text == password && textBoxUsername.Text == usernmae)
            {
                button1.Enabled = true;
            }
        }

    }
}
