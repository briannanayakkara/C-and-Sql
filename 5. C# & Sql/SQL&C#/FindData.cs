using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; // giver adgange til and brug sql klasser 
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_and_C_SHARP
{
    public partial class FindData : Form
    {
        // kalder alle slq klasser man skal brug 
        SqlCommand scmd = new SqlCommand();
        SqlDataAdapter sda = new SqlDataAdapter();
        String connetionSrting,Numplate; // connectionSring er en string for at indhod connection link  
        



        SqlConnection cs = new SqlConnection(); // kalder SQl connecting klasse og navngiver den cs 



        DataTable dt = new DataTable(); // kalder SQl datatable klasse og navngiver den dt 

        public FindData()
        {
            InitializeComponent();
            DisplayData(); // køre methode nå program køre 
        }

        private void FindData_FormClosing(object sender, FormClosingEventArgs e)
        {
            // nå FindData form slukker åbner Form1
            Form1 f1 = new Form1();
            f1.show();
        }

        // text box 
        private void textBoxFindID_TextChanged(object sender, EventArgs e)
        {
            this.Numplate = textBoxFindID.Text; // når brugern taster en number så indholder den i en text (string)
        }

        // display data

        public void DisplayData()
        {
            connetionSrting = @"Server=.;Database=TT;Trusted_Connection=True;"; // connectiong string 
            cs = new SqlConnection(connetionSrting); //Lad SQL-klassen vide, hvad der er den forbindende string, vi bruger
            cs.Open(); //opening the connection string 
            DataTable dt = new DataTable(); // at kalde den datatable brug indeholder tabellen
            sda = new SqlDataAdapter("select * from Registrering where Nummerplade = '" + Numplate+"';", cs); // gør sql kommandoer for at få data
            sda.Fill(dt); // udfyld datatabellen
            dataGridView1.DataSource = dt; // viser det i gridview
            cs.Close(); //lukker forbindelsen 

        }


        // find button
        private void buttonFindID_Click(object sender, EventArgs e)
        {
            DisplayData(); // Når man klikker på knappen, kører metoden
        }
    }
}
