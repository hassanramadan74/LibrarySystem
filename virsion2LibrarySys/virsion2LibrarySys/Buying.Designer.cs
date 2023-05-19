namespace virsion2LibrarySys
{
    partial class Buying
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
            this.buttonBuying = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Cencel = new System.Windows.Forms.Button();
            this.saveadd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxAdminID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxuserID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxBuyDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxOffer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authoridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authornameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.additiondateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookyearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noofavialablecopiesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseprDataSet = new virsion2LibrarySys.databaseprDataSet();
            this.contentTableAdapter = new virsion2LibrarySys.databaseprDataSetTableAdapters.contentTableAdapter();
            this.tableAdapterManager = new virsion2LibrarySys.databaseprDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseprDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBuying
            // 
            this.buttonBuying.BackColor = System.Drawing.Color.IndianRed;
            this.buttonBuying.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBuying.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuying.Location = new System.Drawing.Point(243, 364);
            this.buttonBuying.Name = "buttonBuying";
            this.buttonBuying.Size = new System.Drawing.Size(105, 32);
            this.buttonBuying.TabIndex = 42;
            this.buttonBuying.Text = "Buy";
            this.buttonBuying.UseVisualStyleBackColor = false;
            this.buttonBuying.Click += new System.EventHandler(this.buttonBuying_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::virsion2LibrarySys.Properties.Resources.reader;
            this.pictureBox1.Location = new System.Drawing.Point(652, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Brown;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.label21);
            this.panel5.Location = new System.Drawing.Point(-7, -14);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(804, 87);
            this.panel5.TabIndex = 40;
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
            this.label21.Location = new System.Drawing.Point(295, 23);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(212, 45);
            this.label21.TabIndex = 0;
            this.label21.Text = "Buy Content";
            this.label21.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::virsion2LibrarySys.Properties.Resources.WHAT_IS_THE_PURPOSE_OF_A_LIBRARY_MANAGEMENT_SYSTEM_min;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(482, 313);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 296);
            this.panel2.TabIndex = 39;
            // 
            // Cencel
            // 
            this.Cencel.BackColor = System.Drawing.Color.IndianRed;
            this.Cencel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cencel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cencel.Location = new System.Drawing.Point(356, 546);
            this.Cencel.Name = "Cencel";
            this.Cencel.Size = new System.Drawing.Size(75, 28);
            this.Cencel.TabIndex = 38;
            this.Cencel.Text = "Cencel";
            this.Cencel.UseVisualStyleBackColor = false;
            this.Cencel.Click += new System.EventHandler(this.Cencel_Click);
            // 
            // saveadd
            // 
            this.saveadd.BackColor = System.Drawing.Color.IndianRed;
            this.saveadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveadd.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveadd.Location = new System.Drawing.Point(57, 546);
            this.saveadd.Name = "saveadd";
            this.saveadd.Size = new System.Drawing.Size(75, 28);
            this.saveadd.TabIndex = 37;
            this.saveadd.Text = "Save";
            this.saveadd.UseVisualStyleBackColor = false;
            this.saveadd.Click += new System.EventHandler(this.saveadd_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.buttonBuying);
            this.panel1.Controls.Add(this.textBoxAdminID);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBoxPrice);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBoxuserID);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxNum);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBoxBuyDate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxOffer);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxCName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-6, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 408);
            this.panel1.TabIndex = 36;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(11, 327);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 15);
            this.label14.TabIndex = 44;
            this.label14.Text = "Admin ID";
            // 
            // textBoxAdminID
            // 
            this.textBoxAdminID.Location = new System.Drawing.Point(141, 322);
            this.textBoxAdminID.Name = "textBoxAdminID";
            this.textBoxAdminID.Size = new System.Drawing.Size(266, 20);
            this.textBoxAdminID.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(392, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 16);
            this.label7.TabIndex = 42;
            this.label7.Text = "$";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(141, 69);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(244, 20);
            this.textBoxPrice.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 15);
            this.label8.TabIndex = 40;
            this.label8.Text = "Price";
            // 
            // textBoxuserID
            // 
            this.textBoxuserID.Location = new System.Drawing.Point(141, 273);
            this.textBoxuserID.Name = "textBoxuserID";
            this.textBoxuserID.Size = new System.Drawing.Size(266, 20);
            this.textBoxuserID.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 38;
            this.label5.Text = "User ID";
            // 
            // textBoxNum
            // 
            this.textBoxNum.Location = new System.Drawing.Point(141, 221);
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(266, 20);
            this.textBoxNum.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 15);
            this.label6.TabIndex = 36;
            this.label6.Text = "Number of Content";
            // 
            // textBoxBuyDate
            // 
            this.textBoxBuyDate.Location = new System.Drawing.Point(141, 168);
            this.textBoxBuyDate.Name = "textBoxBuyDate";
            this.textBoxBuyDate.Size = new System.Drawing.Size(266, 20);
            this.textBoxBuyDate.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 34;
            this.label3.Text = "Buying Date";
            // 
            // textBoxOffer
            // 
            this.textBoxOffer.Location = new System.Drawing.Point(141, 116);
            this.textBoxOffer.Name = "textBoxOffer";
            this.textBoxOffer.Size = new System.Drawing.Size(266, 20);
            this.textBoxOffer.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 32;
            this.label1.Text = "Offer";
            // 
            // textBoxCName
            // 
            this.textBoxCName.Location = new System.Drawing.Point(141, 20);
            this.textBoxCName.Name = "textBoxCName";
            this.textBoxCName.Size = new System.Drawing.Size(266, 20);
            this.textBoxCName.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "Content Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.offerDataGridViewTextBoxColumn,
            this.adminidDataGridViewTextBoxColumn,
            this.contentNameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.authoridDataGridViewTextBoxColumn,
            this.authornameDataGridViewTextBoxColumn,
            this.additiondateDataGridViewTextBoxColumn,
            this.bookyearDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn,
            this.noofavialablecopiesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.contentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(451, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(357, 238);
            this.dataGridView1.TabIndex = 43;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
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
            // contentNameDataGridViewTextBoxColumn
            // 
            this.contentNameDataGridViewTextBoxColumn.DataPropertyName = "content_Name";
            this.contentNameDataGridViewTextBoxColumn.HeaderText = "content_Name";
            this.contentNameDataGridViewTextBoxColumn.Name = "contentNameDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // authoridDataGridViewTextBoxColumn
            // 
            this.authoridDataGridViewTextBoxColumn.DataPropertyName = "author_id";
            this.authoridDataGridViewTextBoxColumn.HeaderText = "author_id";
            this.authoridDataGridViewTextBoxColumn.Name = "authoridDataGridViewTextBoxColumn";
            // 
            // authornameDataGridViewTextBoxColumn
            // 
            this.authornameDataGridViewTextBoxColumn.DataPropertyName = "author_name";
            this.authornameDataGridViewTextBoxColumn.HeaderText = "author_name";
            this.authornameDataGridViewTextBoxColumn.Name = "authornameDataGridViewTextBoxColumn";
            // 
            // additiondateDataGridViewTextBoxColumn
            // 
            this.additiondateDataGridViewTextBoxColumn.DataPropertyName = "addition_date";
            this.additiondateDataGridViewTextBoxColumn.HeaderText = "addition_date";
            this.additiondateDataGridViewTextBoxColumn.Name = "additiondateDataGridViewTextBoxColumn";
            // 
            // bookyearDataGridViewTextBoxColumn
            // 
            this.bookyearDataGridViewTextBoxColumn.DataPropertyName = "book_year";
            this.bookyearDataGridViewTextBoxColumn.HeaderText = "book_year";
            this.bookyearDataGridViewTextBoxColumn.Name = "bookyearDataGridViewTextBoxColumn";
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            // 
            // noofavialablecopiesDataGridViewTextBoxColumn
            // 
            this.noofavialablecopiesDataGridViewTextBoxColumn.DataPropertyName = "no_of_avialable_copies";
            this.noofavialablecopiesDataGridViewTextBoxColumn.HeaderText = "no_of_avialable_copies";
            this.noofavialablecopiesDataGridViewTextBoxColumn.Name = "noofavialablecopiesDataGridViewTextBoxColumn";
            // 
            // contentBindingSource
            // 
            this.contentBindingSource.DataMember = "content";
            this.contentBindingSource.DataSource = this.databaseprDataSet;
            // 
            // databaseprDataSet
            // 
            this.databaseprDataSet.DataSetName = "databaseprDataSet";
            this.databaseprDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contentTableAdapter
            // 
            this.contentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.adminTableAdapter = null;
            this.tableAdapterManager.authorTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.buyingTableAdapter = null;
            this.tableAdapterManager.check_salesTableAdapter = null;
            this.tableAdapterManager.contentTableAdapter = this.contentTableAdapter;
            this.tableAdapterManager.make_offerTableAdapter = null;
            this.tableAdapterManager.searchingTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = virsion2LibrarySys.databaseprDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            // 
            // Buying
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 611);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Cencel);
            this.Controls.Add(this.saveadd);
            this.Controls.Add(this.panel1);
            this.Name = "Buying";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buying";
            this.Load += new System.EventHandler(this.Buying_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseprDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBuying;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Cencel;
        private System.Windows.Forms.Button saveadd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxBuyDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxOffer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxuserID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private databaseprDataSet databaseprDataSet;
        private System.Windows.Forms.BindingSource contentBindingSource;
        private databaseprDataSetTableAdapters.contentTableAdapter contentTableAdapter;
        private databaseprDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn offerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authoridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authornameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn additiondateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookyearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noofavialablecopiesDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxAdminID;
    }
}