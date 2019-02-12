using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; // using sql classes 
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_and_C_SHARP
{
    public partial class FindData : Form
    {
        // calling out all the sql classes 
        SqlCommand scmd = new SqlCommand();
        SqlDataAdapter sda = new SqlDataAdapter();
        String connetionSrting,Numplate; // making a strings to contain data 
        



        SqlConnection cs = new SqlConnection(); // calling SQl connecting class out and name is cs 


         
        DataTable dt = new DataTable(); // calling SQl datatable class out and name is dt 

        public FindData()
        {
            InitializeComponent();
            DisplayData(); // disply the methode automaaticaly 
        }

        private void FindData_FormClosing(object sender, FormClosingEventArgs e)
        {
            // when the FindData form is closing the Form1 will be open
            Form1 f1 = new Form1();
            f1.show();
        }

        // text box 
        private void textBoxFindID_TextChanged(object sender, EventArgs e)
        {
            this.Numplate = textBoxFindID.Text; // when user type a numberplate the data will contain in this string 
        }

        // display data

        public void DisplayData()
        {
            connetionSrting = @"Server=.;Database=TT;Trusted_Connection=True;"; // connectiong sting will be in the string 
            cs = new SqlConnection(connetionSrting); //letiing the sql class know what is the connecting string we are using 
            cs.Open(); //opening the connection string 
            DataTable dt = new DataTable(); // calling out the datatable use containg the table 
            sda = new SqlDataAdapter("select * from Registrering where Nummerplade = '" + Numplate+"';", cs); // making sql commands to get data 
            sda.Fill(dt); // fill in the data table 
            dataGridView1.DataSource = dt; // displaying it in the Gride viwe 
            cs.Close(); //closing the connection 

        }


        // find button
        private void buttonFindID_Click(object sender, EventArgs e)
        {
            DisplayData(); // when clicking the button the methode will run 
        }
    }
}
