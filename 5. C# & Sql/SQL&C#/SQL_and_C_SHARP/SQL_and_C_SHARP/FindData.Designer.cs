namespace SQL_and_C_SHARP
{
    partial class FindData
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
            this.buttonFindID = new System.Windows.Forms.Button();
            this.textBoxFindID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tTDataSet = new SQL_and_C_SHARP.TTDataSet();
            this.registreringBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registreringTableAdapter = new SQL_and_C_SHARP.TTDataSetTableAdapters.RegistreringTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registreringBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFindID
            // 
            this.buttonFindID.Location = new System.Drawing.Point(282, 67);
            this.buttonFindID.Name = "buttonFindID";
            this.buttonFindID.Size = new System.Drawing.Size(92, 27);
            this.buttonFindID.TabIndex = 41;
            this.buttonFindID.Text = "Find";
            this.buttonFindID.UseVisualStyleBackColor = true;
            this.buttonFindID.Click += new System.EventHandler(this.buttonFindID_Click);
            // 
            // textBoxFindID
            // 
            this.textBoxFindID.Location = new System.Drawing.Point(273, 41);
            this.textBoxFindID.Name = "textBoxFindID";
            this.textBoxFindID.Size = new System.Drawing.Size(118, 20);
            this.textBoxFindID.TabIndex = 40;
            this.textBoxFindID.TextChanged += new System.EventHandler(this.textBoxFindID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Vehicle number plate";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 175);
            this.dataGridView1.TabIndex = 43;
            // 
            // tTDataSet
            // 
            this.tTDataSet.DataSetName = "TTDataSet";
            this.tTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registreringBindingSource
            // 
            this.registreringBindingSource.DataMember = "Registrering";
            this.registreringBindingSource.DataSource = this.tTDataSet;
            // 
            // registreringTableAdapter
            // 
            this.registreringTableAdapter.ClearBeforeFill = true;
            // 
            // FindData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 317);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonFindID);
            this.Controls.Add(this.textBoxFindID);
            this.Name = "FindData";
            this.Text = "FindData";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FindData_FormClosing);           
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registreringBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFindID;
        private System.Windows.Forms.TextBox textBoxFindID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TTDataSet tTDataSet;
        private System.Windows.Forms.BindingSource registreringBindingSource;
        private TTDataSetTableAdapters.RegistreringTableAdapter registreringTableAdapter;
    }
}