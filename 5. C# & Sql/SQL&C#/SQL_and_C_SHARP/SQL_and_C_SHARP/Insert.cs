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
    public partial class Insert : Form
    {
        public Insert()
        {
            InitializeComponent();
        }

        //calling out all the sql classes that I need to be use for the project and making variables 
        SqlCommand scmd = new SqlCommand();
        SqlDataAdapter sda = new SqlDataAdapter();
        String sql,name,Sname,NumberP,Date, connetionSrting;
        Double Km;
        SqlConnection cs;




        // containing all the textbox data in to variables 
        // get name 
        private void textBoxNavn_TextChanged(object sender, EventArgs e)
        {
            this.name = textBoxNavn.Text;
        }

        // get sername
        private void textBoxEfterNavn_TextChanged(object sender, EventArgs e)
        {
            this.Sname = textBoxEfterNavn.Text;
        }
        //get numberplate
        private void textBoxNummerplade_TextChanged(object sender, EventArgs e)
        {
            this.NumberP = textBoxNummerplade.Text;
        }
        //get date
        private void textBoxDato_TextChanged(object sender, EventArgs e)
        {
            this.Date = textBoxDato.Text;
        }
        //get Km

        private void textBoxKM_TextChanged(object sender, EventArgs e)
        {
            this.Km = double.Parse(textBoxKM.Text);
        }
        //insert button

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            connetionSrting = @"Server=.;Database=TT;Trusted_Connection=True;"; 
            cs = new SqlConnection(connetionSrting);
            cs.Open();
            
            sql = "insert into Registrering(Fornavn,Efternavn,Nummerplade,dato,kilometre) values('" + name + "','"+ Sname + "','"+ NumberP +"','"+ Date +"',"+ Km +")"; // sql comands for insert data 
            scmd = new SqlCommand(sql, cs);
          
            sda.InsertCommand = new SqlCommand(sql,cs);
            sda.InsertCommand.ExecuteNonQuery();
            scmd.Dispose();
            cs.Close();
            this.Close(); // closing the running form at the end by it self 
        }

    }

}
