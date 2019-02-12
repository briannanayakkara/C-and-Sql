namespace SQL_and_C_SHARP
{
    partial class Update
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
            this.components = new System.ComponentModel.Container();
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
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.tTDataSet = new SQL_and_C_SHARP.TTDataSet();
            this.tTDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registreringBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registreringTableAdapter = new SQL_and_C_SHARP.TTDataSetTableAdapters.RegistreringTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registreringBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxKM
            // 
            this.textBoxKM.Location = new System.Drawing.Point(366, 179);
            this.textBoxKM.Name = "textBoxKM";
            this.textBoxKM.Size = new System.Drawing.Size(153, 20);
            this.textBoxKM.TabIndex = 30;
            this.textBoxKM.TextChanged += new System.EventHandler(this.textBoxKM_TextChanged);
            // 
            // textBoxDato
            // 
            this.textBoxDato.Location = new System.Drawing.Point(366, 150);
            this.textBoxDato.Name = "textBoxDato";
            this.textBoxDato.Size = new System.Drawing.Size(153, 20);
            this.textBoxDato.TabIndex = 29;
            this.textBoxDato.TextChanged += new System.EventHandler(this.textBoxDato_TextChanged);
            // 
            // textBoxNummerplade
            // 
            this.textBoxNummerplade.Location = new System.Drawing.Point(366, 124);
            this.textBoxNummerplade.Name = "textBoxNummerplade";
            this.textBoxNummerplade.Size = new System.Drawing.Size(153, 20);
            this.textBoxNummerplade.TabIndex = 28;
            this.textBoxNummerplade.TextChanged += new System.EventHandler(this.textBoxNummerplade_TextChanged);
            // 
            // textBoxEfterNavn
            // 
            this.textBoxEfterNavn.Location = new System.Drawing.Point(366, 98);
            this.textBoxEfterNavn.Name = "textBoxEfterNavn";
            this.textBoxEfterNavn.Size = new System.Drawing.Size(153, 20);
            this.textBoxEfterNavn.TabIndex = 27;
            this.textBoxEfterNavn.TextChanged += new System.EventHandler(this.textBoxEfterNavn_TextChanged);
            // 
            // textBoxNavn
            // 
            this.textBoxNavn.Location = new System.Drawing.Point(366, 71);
            this.textBoxNavn.Name = "textBoxNavn";
            this.textBoxNavn.Size = new System.Drawing.Size(153, 20);
            this.textBoxNavn.TabIndex = 26;
            this.textBoxNavn.TextChanged += new System.EventHandler(this.textBoxNavn_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(225, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "KM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(225, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "Dato";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(225, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "Nummerplade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(225, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "Efternavn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(225, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Fornavn";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(334, 225);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(114, 31);
            this.buttonUpdate.TabIndex = 31;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // tTDataSet
            // 
            this.tTDataSet.DataSetName = "TTDataSet";
            this.tTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tTDataSetBindingSource
            // 
            this.tTDataSetBindingSource.DataSource = this.tTDataSet;
            this.tTDataSetBindingSource.Position = 0;
            // 
            // registreringBindingSource
            // 
            this.registreringBindingSource.DataMember = "Registrering";
            this.registreringBindingSource.DataSource = this.tTDataSetBindingSource;
            // 
            // registreringTableAdapter
            // 
            this.registreringTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(541, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "YYYY-MM-DD";
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 297);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonUpdate);
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
            this.Name = "Update";
            this.Text = "Update";
            ((System.ComponentModel.ISupportInitialize)(this.tTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registreringBindingSource)).EndInit();
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
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.BindingSource tTDataSetBindingSource;
        private TTDataSet tTDataSet;
        private System.Windows.Forms.BindingSource registreringBindingSource;
        private TTDataSetTableAdapters.RegistreringTableAdapter registreringTableAdapter;
        private System.Windows.Forms.Label label6;
    }
}