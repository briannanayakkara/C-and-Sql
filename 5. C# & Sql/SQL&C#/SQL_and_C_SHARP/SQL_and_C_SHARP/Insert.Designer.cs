namespace SQL_and_C_SHARP
{
    partial class Insert
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxKM = new System.Windows.Forms.TextBox();
            this.textBoxDato = new System.Windows.Forms.TextBox();
            this.textBoxNummerplade = new System.Windows.Forms.TextBox();
            this.textBoxEfterNavn = new System.Windows.Forms.TextBox();
            this.textBoxNavn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxKM
            // 
            this.textBoxKM.Location = new System.Drawing.Point(293, 155);
            this.textBoxKM.Name = "textBoxKM";
            this.textBoxKM.Size = new System.Drawing.Size(153, 20);
            this.textBoxKM.TabIndex = 20;
            this.textBoxKM.TextChanged += new System.EventHandler(this.textBoxKM_TextChanged);
            // 
            // textBoxDato
            // 
            this.textBoxDato.Location = new System.Drawing.Point(293, 126);
            this.textBoxDato.Name = "textBoxDato";
            this.textBoxDato.Size = new System.Drawing.Size(153, 20);
            this.textBoxDato.TabIndex = 19;
            this.textBoxDato.TextChanged += new System.EventHandler(this.textBoxDato_TextChanged);
            // 
            // textBoxNummerplade
            // 
            this.textBoxNummerplade.Location = new System.Drawing.Point(293, 100);
            this.textBoxNummerplade.Name = "textBoxNummerplade";
            this.textBoxNummerplade.Size = new System.Drawing.Size(153, 20);
            this.textBoxNummerplade.TabIndex = 18;
            this.textBoxNummerplade.TextChanged += new System.EventHandler(this.textBoxNummerplade_TextChanged);
            // 
            // textBoxEfterNavn
            // 
            this.textBoxEfterNavn.Location = new System.Drawing.Point(293, 74);
            this.textBoxEfterNavn.Name = "textBoxEfterNavn";
            this.textBoxEfterNavn.Size = new System.Drawing.Size(153, 20);
            this.textBoxEfterNavn.TabIndex = 17;
            this.textBoxEfterNavn.TextChanged += new System.EventHandler(this.textBoxEfterNavn_TextChanged);
            // 
            // textBoxNavn
            // 
            this.textBoxNavn.Location = new System.Drawing.Point(293, 47);
            this.textBoxNavn.Name = "textBoxNavn";
            this.textBoxNavn.Size = new System.Drawing.Size(153, 20);
            this.textBoxNavn.TabIndex = 16;
            this.textBoxNavn.TextChanged += new System.EventHandler(this.textBoxNavn_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(152, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "KM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(152, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Dato";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(152, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nummerplade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(152, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Efternavn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(152, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Fornavn";
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(262, 205);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonInsert.Size = new System.Drawing.Size(114, 31);
            this.buttonInsert.TabIndex = 21;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(452, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "YYYY-MM-DD";
            // 
            // Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 286);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.textBoxKM);
            this.Controls.Add(this.textBoxDato);
            this.Controls.Add(this.textBoxNummerplade);
            this.Controls.Add(this.textBoxEfterNavn);
            this.Controls.Add(this.textBoxNavn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Insert";
            this.Text = "Insert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxKM;
        private System.Windows.Forms.TextBox textBoxDato;
        private System.Windows.Forms.TextBox textBoxNummerplade;
        private System.Windows.Forms.TextBox textBoxEfterNavn;
        private System.Windows.Forms.TextBox textBoxNavn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Label label7;
    }
}