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
    public partial class Update : Form
    {
        SqlCommand scmd = new SqlCommand();
        SqlDataAdapter sda = new SqlDataAdapter();
        String sql, name, Sname, NumberP, Date, connetionSrting;
        Double Km;
        SqlConnection cs;


        public Update()
        {
            InitializeComponent();
        }



        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            connetionSrting = @"Server=.;Database=TT;Trusted_Connection=True;"; // connection string 
            cs = new SqlConnection(connetionSrting);
            cs.Open(); // Åbn forbindelsen

            // sql-kommando for at opdatere dataene
            sql = "update Registrering set Fornavn = '" + name + "',Efternavn = '" + Sname + "', Nummerplade = '" + NumberP + "',dato = '" + Date + "',kilometre ='" + Km + "'where ID ='"+Database.UpdateID+"'";
            MessageBox.Show("ID " + Database.UpdateID.ToString()+ " has been updated"); //Når opdateringen er færdig, vil en på vil dukke op og sige, at den er blevet opdateret 
            scmd = new SqlCommand(sql, cs);
            sda.UpdateCommand = new SqlCommand(sql, cs); // angiver, at jeg bruger opdateringskommandoen
            sda.UpdateCommand.ExecuteNonQuery();// udfører opdateringskommandoen
            scmd.Dispose(); // fjerne de kommandoer, der har brugt til at lukke forbindelsen
            cs.Close(); // lukker strengen
        }


        // indeholdende alle tekstboksdata i variabler
        //get name    
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
    }
}
