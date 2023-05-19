namespace virsion2LibrarySys
{
    partial class Make_Offer
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.make_offerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseprDataSet = new virsion2LibrarySys.databaseprDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxIDforAdmin = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Cencel = new System.Windows.Forms.Button();
            this.MakeOffer = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxoffer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxCName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.make_offerTableAdapter = new virsion2LibrarySys.databaseprDataSetTableAdapters.make_offerTableAdapter();
            this.tableAdapterManager = new virsion2LibrarySys.databaseprDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.make_offerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseprDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.priceDataGridViewTextBoxColumn,
            this.contentNameDataGridViewTextBoxColumn,
            this.offerDataGridViewTextBoxColumn,
            this.adminidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.make_offerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(460, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(313, 151);
            this.dataGridView1.TabIndex = 11;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // contentNameDataGridViewTextBoxColumn
            // 
            this.contentNameDataGridViewTextBoxColumn.DataPropertyName = "content_Name";
            this.contentNameDataGridViewTextBoxColumn.HeaderText = "content_Name";
            this.contentNameDataGridViewTextBoxColumn.Name = "contentNameDataGridViewTextBoxColumn";
            // 
            // offerDataGridViewTextBoxColumn
            // 
            this.offerDataGridViewTextBoxColumn.DataPropertyName = "offer";
            this.offerDataGridViewTextBoxColumn.HeaderText = "offer";
            this.offerDataGridViewTextBoxColumn.Name = "offerDataGridViewTextBoxColumn";
            // 
            // adminidDataGridViewTextBoxColumn
            // 
            this.adminidDataGridViewTextBoxColumn.DataPropertyName = "admin_id";
            this.adminidDataGridViewTextBoxColumn.HeaderText = "admin_id";
            this.adminidDataGridViewTextBoxColumn.Name = "adminidDataGridViewTextBoxColumn";
            // 
            // make_offerBindingSource
            // 
            this.make_offerBindingSource.DataMember = "make_offer";
            this.make_offerBindingSource.DataSource = this.databaseprDataSet;
            // 
            // databaseprDataSet
            // 
            this.databaseprDataSet.DataSetName = "databaseprDataSet";
            this.databaseprDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.textBoxIDforAdmin);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.Cencel);
            this.panel2.Controls.Add(this.MakeOffer);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.textBoxoffer);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textBoxPrice);
            this.panel2.Controls.Add(this.textBoxCName);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(-1, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(461, 403);
            this.panel2.TabIndex = 10;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // textBoxIDforAdmin
            // 
            this.textBoxIDforAdmin.Location = new System.Drawing.Point(179, 165);
            this.textBoxIDforAdmin.Name = "textBoxIDforAdmin";
            this.textBoxIDforAdmin.Size = new System.Drawing.Size(267, 20);
            this.textBoxIDforAdmin.TabIndex = 31;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(149, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 30;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cencel
            // 
            this.Cencel.BackColor = System.Drawing.Color.IndianRed;
            this.Cencel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cencel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cencel.Location = new System.Drawing.Point(284, 283);
            this.Cencel.Name = "Cencel";
            this.Cencel.Size = new System.Drawing.Size(75, 28);
            this.Cencel.TabIndex = 29;
            this.Cencel.Text = "Cencel";
            this.Cencel.UseVisualStyleBackColor = false;
            this.Cencel.Click += new System.EventHandler(this.Cencel_Click);
            // 
            // MakeOffer
            // 
            this.MakeOffer.BackColor = System.Drawing.Color.IndianRed;
            this.MakeOffer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MakeOffer.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MakeOffer.Location = new System.Drawing.Point(149, 224);
            this.MakeOffer.Name = "MakeOffer";
            this.MakeOffer.Size = new System.Drawing.Size(144, 28);
            this.MakeOffer.TabIndex = 28;
            this.MakeOffer.Text = "Make Offer";
            this.MakeOffer.UseVisualStyleBackColor = false;
            this.MakeOffer.Click += new System.EventHandler(this.saveadd_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(49, 170);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 15);
            this.label14.TabIndex = 27;
            this.label14.Text = "Admin ID";
            // 
            // textBoxoffer
            // 
            this.textBoxoffer.Location = new System.Drawing.Point(179, 118);
            this.textBoxoffer.Name = "textBoxoffer";
            this.textBoxoffer.Size = new System.Drawing.Size(266, 20);
            this.textBoxoffer.TabIndex = 26;
            this.textBoxoffer.Text = "None";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(43, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 15);
            this.label8.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(49, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "Offer";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(430, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "$";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(180, 70);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(244, 20);
            this.textBoxPrice.TabIndex = 7;
            // 
            // textBoxCName
            // 
            this.textBoxCName.Location = new System.Drawing.Point(180, 31);
            this.textBoxCName.Name = "textBoxCName";
            this.textBoxCName.Size = new System.Drawing.Size(266, 20);
            this.textBoxCName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Content Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(11, -92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 77);
            this.panel1.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(455, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(271, 189);
            this.panel3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Upload Content";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Brown;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.label21);
            this.panel5.Location = new System.Drawing.Point(-1, 1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(775, 77);
            this.panel5.TabIndex = 12;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(455, 82);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(271, 189);
            this.panel6.TabIndex = 8;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(250, 8);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(192, 45);
            this.label21.TabIndex = 0;
            this.label21.Text = "Make Offer";
            this.label21.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.BackgroundImage = global::virsion2LibrarySys.Properties.Resources.WHAT_IS_THE_PURPOSE_OF_A_LIBRARY_MANAGEMENT_SYSTEM_min;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(460, 226);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(303, 254);
            this.panel4.TabIndex = 13;
            // 
            // make_offerTableAdapter
            // 
            this.make_offerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.adminTableAdapter = null;
            this.tableAdapterManager.authorTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.buyingTableAdapter = null;
            this.tableAdapterManager.check_salesTableAdapter = null;
            this.tableAdapterManager.contentTableAdapter = null;
            this.tableAdapterManager.make_offerTableAdapter = this.make_offerTableAdapter;
            this.tableAdapterManager.searchingTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = virsion2LibrarySys.databaseprDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            // 
            // Make_Offer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 481);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Make_Offer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Make_Offer";
            this.Load += new System.EventHandler(this.Make_Offer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.make_offerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseprDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Cencel;
        private System.Windows.Forms.Button MakeOffer;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxoffer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxCName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel4;
        private databaseprDataSet databaseprDataSet;
        private System.Windows.Forms.BindingSource make_offerBindingSource;
        private databaseprDataSetTableAdapters.make_offerTableAdapter make_offerTableAdapter;
        private databaseprDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn offerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxIDforAdmin;
    }
}