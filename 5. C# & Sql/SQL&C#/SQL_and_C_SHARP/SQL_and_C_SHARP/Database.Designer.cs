namespace SQL_and_C_SHARP
{
    partial class Database
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
            this.registreringBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tTDataSet = new SQL_and_C_SHARP.TTDataSet();
            this.registreringTableAdapter = new SQL_and_C_SHARP.TTDataSetTableAdapters.RegistreringTableAdapter();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxUpdateID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxDeleteID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelFindData = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tTDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.registreringBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // registreringBindingSource
            // 
            this.registreringBindingSource.DataMember = "Registrering";
            this.registreringBindingSource.DataSource = this.tTDataSet;
            // 
            // tTDataSet
            // 
            this.tTDataSet.DataSetName = "TTDataSet";
            this.tTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registreringTableAdapter
            // 
            this.registreringTableAdapter.ClearBeforeFill = true;
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(458, 21);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonInsert.Size = new System.Drawing.Size(114, 31);
            this.buttonInsert.TabIndex = 11;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Location = new System.Drawing.Point(458, 122);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(114, 31);
            this.buttonDelete.TabIndex = 12;
            this.buttonDelete.Text = "Delete ";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Enabled = false;
            this.buttonUpdate.Location = new System.Drawing.Point(458, 72);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(114, 31);
            this.buttonUpdate.TabIndex = 13;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxUpdateID
            // 
            this.textBoxUpdateID.Location = new System.Drawing.Point(346, 78);
            this.textBoxUpdateID.Name = "textBoxUpdateID";
            this.textBoxUpdateID.Size = new System.Drawing.Size(85, 20);
            this.textBoxUpdateID.TabIndex = 34;
            this.textBoxUpdateID.TextChanged += new System.EventHandler(this.textBoxUpdateID_TextChanged);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelID.Location = new System.Drawing.Point(288, 78);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(26, 20);
            this.labelID.TabIndex = 33;
            this.labelID.Text = "ID";
            // 
            // textBoxDeleteID
            // 
            this.textBoxDeleteID.Location = new System.Drawing.Point(346, 128);
            this.textBoxDeleteID.Name = "textBoxDeleteID";
            this.textBoxDeleteID.Size = new System.Drawing.Size(85, 20);
            this.textBoxDeleteID.TabIndex = 36;
            this.textBoxDeleteID.TextChanged += new System.EventHandler(this.textBoxDeleteID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(288, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "ID";
            // 
            // labelFindData
            // 
            this.labelFindData.AutoSize = true;
            this.labelFindData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelFindData.Location = new System.Drawing.Point(43, 21);
            this.labelFindData.Name = "labelFindData";
            this.labelFindData.Size = new System.Drawing.Size(0, 20);
            this.labelFindData.TabIndex = 37;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(47, 78);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(104, 36);
            this.buttonRefresh.TabIndex = 40;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 237);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(612, 156);
            this.dataGridView1.TabIndex = 41;
            // 
            // tTDataSetBindingSource
            // 
            this.tTDataSetBindingSource.DataSource = this.tTDataSet;
            this.tTDataSetBindingSource.Position = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Refresh data for more accurate information";
            // 
            // Database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 405);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.labelFindData);
            this.Controls.Add(this.textBoxDeleteID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUpdateID);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonInsert);
            this.Name = "Database";
            this.Text = "Database";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Database_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.registreringBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TTDataSet tTDataSet;
        private System.Windows.Forms.BindingSource registreringBindingSource;
        private TTDataSetTableAdapters.RegistreringTableAdapter registreringTableAdapter;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxUpdateID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxDeleteID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFindData;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tTDataSetBindingSource;
        private System.Windows.Forms.Label label2;
    }
}