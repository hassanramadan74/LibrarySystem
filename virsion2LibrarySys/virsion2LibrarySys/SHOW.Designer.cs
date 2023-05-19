namespace virsion2LibrarySys
{
    partial class SHOW
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
            this.databaseprDataSet = new virsion2LibrarySys.databaseprDataSet();
            this.contentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contentTableAdapter = new virsion2LibrarySys.databaseprDataSetTableAdapters.contentTableAdapter();
            this.tableAdapterManager = new virsion2LibrarySys.databaseprDataSetTableAdapters.TableAdapterManager();
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.avaContent = new System.Windows.Forms.Button();
            this.buttonshowall = new System.Windows.Forms.Button();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contentNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseprDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 391);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(941, 254);
            this.dataGridView1.TabIndex = 0;
            // 
            // databaseprDataSet
            // 
            this.databaseprDataSet.DataSetName = "databaseprDataSet";
            this.databaseprDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contentBindingSource
            // 
            this.contentBindingSource.DataMember = "content";
            this.contentBindingSource.DataSource = this.databaseprDataSet;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Show All";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Show available Content";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.priceDataGridViewTextBoxColumn1,
            this.contentNameDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.contentBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 69);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(245, 229);
            this.dataGridView2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BackgroundImage = global::virsion2LibrarySys.Properties.Resources.WHAT_IS_THE_PURPOSE_OF_A_LIBRARY_MANAGEMENT_SYSTEM_min;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(626, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 385);
            this.panel1.TabIndex = 1;
            // 
            // avaContent
            // 
            this.avaContent.BackColor = System.Drawing.Color.Firebrick;
            this.avaContent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.avaContent.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avaContent.Location = new System.Drawing.Point(441, 17);
            this.avaContent.Name = "avaContent";
            this.avaContent.Size = new System.Drawing.Size(75, 35);
            this.avaContent.TabIndex = 5;
            this.avaContent.Text = "Show";
            this.avaContent.UseVisualStyleBackColor = false;
            this.avaContent.Click += new System.EventHandler(this.avaContent_Click);
            // 
            // buttonshowall
            // 
            this.buttonshowall.BackColor = System.Drawing.Color.Firebrick;
            this.buttonshowall.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonshowall.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonshowall.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonshowall.Location = new System.Drawing.Point(441, 341);
            this.buttonshowall.Name = "buttonshowall";
            this.buttonshowall.Size = new System.Drawing.Size(75, 30);
            this.buttonshowall.TabIndex = 6;
            this.buttonshowall.Text = "Show all";
            this.buttonshowall.UseVisualStyleBackColor = false;
            this.buttonshowall.Click += new System.EventHandler(this.buttonshowall_Click);
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            // 
            // contentNameDataGridViewTextBoxColumn1
            // 
            this.contentNameDataGridViewTextBoxColumn1.DataPropertyName = "content_Name";
            this.contentNameDataGridViewTextBoxColumn1.HeaderText = "content_Name";
            this.contentNameDataGridViewTextBoxColumn1.Name = "contentNameDataGridViewTextBoxColumn1";
            // 
            // SHOW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(933, 639);
            this.Controls.Add(this.buttonshowall);
            this.Controls.Add(this.avaContent);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SHOW";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SHOW";
            this.Load += new System.EventHandler(this.SHOW_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseprDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button avaContent;
        private System.Windows.Forms.Button buttonshowall;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn contentNameDataGridViewTextBoxColumn1;
    }
}