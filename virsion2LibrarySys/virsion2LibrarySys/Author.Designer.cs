namespace virsion2LibrarySys
{
    partial class Author
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
            this.authorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseprDataSet = new virsion2LibrarySys.databaseprDataSet();
            this.authorTableAdapter = new virsion2LibrarySys.databaseprDataSetTableAdapters.authorTableAdapter();
            this.dataGridViewauthor = new System.Windows.Forms.DataGridView();
            this.authoremailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authornameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonshauthor = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonuppro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseprDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewauthor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // authorBindingSource
            // 
            this.authorBindingSource.DataMember = "author";
            this.authorBindingSource.DataSource = this.databaseprDataSet;
            // 
            // databaseprDataSet
            // 
            this.databaseprDataSet.DataSetName = "databaseprDataSet";
            this.databaseprDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // authorTableAdapter
            // 
            this.authorTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewauthor
            // 
            this.dataGridViewauthor.AutoGenerateColumns = false;
            this.dataGridViewauthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewauthor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.authoremailDataGridViewTextBoxColumn,
            this.authornameDataGridViewTextBoxColumn});
            this.dataGridViewauthor.DataSource = this.authorBindingSource;
            this.dataGridViewauthor.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewauthor.Name = "dataGridViewauthor";
            this.dataGridViewauthor.Size = new System.Drawing.Size(245, 243);
            this.dataGridViewauthor.TabIndex = 1;
            // 
            // authoremailDataGridViewTextBoxColumn
            // 
            this.authoremailDataGridViewTextBoxColumn.DataPropertyName = "author_email";
            this.authoremailDataGridViewTextBoxColumn.HeaderText = "author_email";
            this.authoremailDataGridViewTextBoxColumn.Name = "authoremailDataGridViewTextBoxColumn";
            // 
            // authornameDataGridViewTextBoxColumn
            // 
            this.authornameDataGridViewTextBoxColumn.DataPropertyName = "author_name";
            this.authornameDataGridViewTextBoxColumn.HeaderText = "author_name";
            this.authornameDataGridViewTextBoxColumn.Name = "authornameDataGridViewTextBoxColumn";
            // 
            // buttonshauthor
            // 
            this.buttonshauthor.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonshauthor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonshauthor.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonshauthor.Location = new System.Drawing.Point(412, 384);
            this.buttonshauthor.Name = "buttonshauthor";
            this.buttonshauthor.Size = new System.Drawing.Size(133, 26);
            this.buttonshauthor.TabIndex = 2;
            this.buttonshauthor.Text = "Show all Author";
            this.buttonshauthor.UseVisualStyleBackColor = false;
            this.buttonshauthor.Click += new System.EventHandler(this.buttonshauthor_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::virsion2LibrarySys.Properties.Resources.Author;
            this.pictureBox1.Location = new System.Drawing.Point(388, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::virsion2LibrarySys.Properties.Resources.WHAT_IS_THE_PURPOSE_OF_A_LIBRARY_MANAGEMENT_SYSTEM_min;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(0, 261);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 318);
            this.panel1.TabIndex = 0;
            // 
            // buttonuppro
            // 
            this.buttonuppro.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonuppro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonuppro.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonuppro.Location = new System.Drawing.Point(412, 277);
            this.buttonuppro.Name = "buttonuppro";
            this.buttonuppro.Size = new System.Drawing.Size(133, 26);
            this.buttonuppro.TabIndex = 4;
            this.buttonuppro.Text = "Update Profile";
            this.buttonuppro.UseVisualStyleBackColor = false;
            this.buttonuppro.Click += new System.EventHandler(this.button1_Click);
            // 
            // Author
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(706, 577);
            this.Controls.Add(this.buttonuppro);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonshauthor);
            this.Controls.Add(this.dataGridViewauthor);
            this.Controls.Add(this.panel1);
            this.Name = "Author";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Author";
            this.Load += new System.EventHandler(this.Author_Load);
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseprDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewauthor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private databaseprDataSet databaseprDataSet;
        private System.Windows.Forms.BindingSource authorBindingSource;
        private databaseprDataSetTableAdapters.authorTableAdapter authorTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewauthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn authoremailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authornameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonshauthor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonuppro;
    }
}