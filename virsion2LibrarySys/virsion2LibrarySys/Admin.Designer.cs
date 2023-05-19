namespace virsion2LibrarySys
{
    partial class Admin
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
            this.adminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseprDataSet = new virsion2LibrarySys.databaseprDataSet();
            this.adminTableAdapter = new virsion2LibrarySys.databaseprDataSetTableAdapters.adminTableAdapter();
            this.tableAdapterManager = new virsion2LibrarySys.databaseprDataSetTableAdapters.TableAdapterManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.adminidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyingdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nocopiesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.check_salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.check_salesTableAdapter = new virsion2LibrarySys.databaseprDataSetTableAdapters.check_salesTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sIGItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolChSales = new System.Windows.Forms.ToolStripMenuItem();
            this.toolOffers = new System.Windows.Forms.ToolStripMenuItem();
            this.UploadCon = new System.Windows.Forms.Button();
            this.updateadmin = new System.Windows.Forms.Button();
            this.buttonexit = new System.Windows.Forms.Button();
            this.make_offerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contentTableAdapter = new virsion2LibrarySys.databaseprDataSetTableAdapters.contentTableAdapter();
            this.make_offerTableAdapter = new virsion2LibrarySys.databaseprDataSetTableAdapters.make_offerTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseprDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_salesBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.make_offerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // adminBindingSource
            // 
            this.adminBindingSource.DataMember = "admin";
            this.adminBindingSource.DataSource = this.databaseprDataSet;
            // 
            // databaseprDataSet
            // 
            this.databaseprDataSet.DataSetName = "databaseprDataSet";
            this.databaseprDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminTableAdapter
            // 
            this.adminTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.adminTableAdapter = this.adminTableAdapter;
            this.tableAdapterManager.authorTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.buyingTableAdapter = null;
            this.tableAdapterManager.check_salesTableAdapter = null;
            this.tableAdapterManager.contentTableAdapter = null;
            this.tableAdapterManager.make_offerTableAdapter = null;
            this.tableAdapterManager.searchingTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = virsion2LibrarySys.databaseprDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView3);
            this.panel1.Location = new System.Drawing.Point(-4, 360);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 261);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adminidDataGridViewTextBoxColumn,
            this.useridDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.contentNameDataGridViewTextBoxColumn,
            this.offerDataGridViewTextBoxColumn,
            this.buyingdateDataGridViewTextBoxColumn,
            this.nocopiesDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.check_salesBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(744, 258);
            this.dataGridView3.TabIndex = 0;
            // 
            // adminidDataGridViewTextBoxColumn
            // 
            this.adminidDataGridViewTextBoxColumn.DataPropertyName = "admin_id";
            this.adminidDataGridViewTextBoxColumn.HeaderText = "admin_id";
            this.adminidDataGridViewTextBoxColumn.Name = "adminidDataGridViewTextBoxColumn";
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "user_id";
            this.useridDataGridViewTextBoxColumn.HeaderText = "user_id";
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
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
            // buyingdateDataGridViewTextBoxColumn
            // 
            this.buyingdateDataGridViewTextBoxColumn.DataPropertyName = "buying_date";
            this.buyingdateDataGridViewTextBoxColumn.HeaderText = "buying_date";
            this.buyingdateDataGridViewTextBoxColumn.Name = "buyingdateDataGridViewTextBoxColumn";
            // 
            // nocopiesDataGridViewTextBoxColumn
            // 
            this.nocopiesDataGridViewTextBoxColumn.DataPropertyName = "no_copies";
            this.nocopiesDataGridViewTextBoxColumn.HeaderText = "no_copies";
            this.nocopiesDataGridViewTextBoxColumn.Name = "nocopiesDataGridViewTextBoxColumn";
            // 
            // check_salesBindingSource
            // 
            this.check_salesBindingSource.DataMember = "check_sales";
            this.check_salesBindingSource.DataSource = this.databaseprDataSet;
            // 
            // check_salesTableAdapter
            // 
            this.check_salesTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sIGItem});
            this.menuStrip1.Location = new System.Drawing.Point(602, 123);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(177, 31);
            this.menuStrip1.TabIndex = 46;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sIGItem
            // 
            this.sIGItem.BackColor = System.Drawing.Color.Orange;
            this.sIGItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolChSales,
            this.toolOffers});
            this.sIGItem.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sIGItem.Name = "sIGItem";
            this.sIGItem.Size = new System.Drawing.Size(169, 27);
            this.sIGItem.Text = "Generate Reports";
            // 
            // toolChSales
            // 
            this.toolChSales.BackColor = System.Drawing.Color.Orange;
            this.toolChSales.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.toolChSales.Name = "toolChSales";
            this.toolChSales.Padding = new System.Windows.Forms.Padding(5, 8, 9, 0);
            this.toolChSales.Size = new System.Drawing.Size(194, 34);
            this.toolChSales.Text = "Check Sales";
            this.toolChSales.Click += new System.EventHandler(this.toolChSales_Click);
            // 
            // toolOffers
            // 
            this.toolOffers.BackColor = System.Drawing.Color.Orange;
            this.toolOffers.Name = "toolOffers";
            this.toolOffers.Size = new System.Drawing.Size(180, 28);
            this.toolOffers.Text = "Make Offers";
            this.toolOffers.Click += new System.EventHandler(this.toolOffers_Click);
            // 
            // UploadCon
            // 
            this.UploadCon.BackColor = System.Drawing.Color.DarkRed;
            this.UploadCon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UploadCon.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadCon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UploadCon.Location = new System.Drawing.Point(602, 204);
            this.UploadCon.Name = "UploadCon";
            this.UploadCon.Size = new System.Drawing.Size(177, 33);
            this.UploadCon.TabIndex = 47;
            this.UploadCon.Text = "Upload Content";
            this.UploadCon.UseVisualStyleBackColor = false;
            this.UploadCon.Click += new System.EventHandler(this.UploadCon_Click);
            // 
            // updateadmin
            // 
            this.updateadmin.BackColor = System.Drawing.Color.Olive;
            this.updateadmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateadmin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateadmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateadmin.Location = new System.Drawing.Point(602, 284);
            this.updateadmin.Name = "updateadmin";
            this.updateadmin.Size = new System.Drawing.Size(177, 33);
            this.updateadmin.TabIndex = 48;
            this.updateadmin.Text = "Update Profile";
            this.updateadmin.UseVisualStyleBackColor = false;
            this.updateadmin.Click += new System.EventHandler(this.updateadmin_Click);
            // 
            // buttonexit
            // 
            this.buttonexit.BackColor = System.Drawing.Color.IndianRed;
            this.buttonexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonexit.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonexit.Location = new System.Drawing.Point(661, 31);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(118, 49);
            this.buttonexit.TabIndex = 49;
            this.buttonexit.Text = "Exit";
            this.buttonexit.UseVisualStyleBackColor = false;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // make_offerBindingSource
            // 
            this.make_offerBindingSource.DataMember = "make_offer";
            this.make_offerBindingSource.DataSource = this.databaseprDataSet;
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
            // make_offerTableAdapter
            // 
            this.make_offerTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::virsion2LibrarySys.Properties.Resources.Exit;
            this.pictureBox1.Location = new System.Drawing.Point(602, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::virsion2LibrarySys.Properties.Resources.WHAT_IS_THE_PURPOSE_OF_A_LIBRARY_MANAGEMENT_SYSTEM_min;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(513, 364);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::virsion2LibrarySys.Properties.Resources.Admin;
            this.pictureBox2.Location = new System.Drawing.Point(35, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(130, 95);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(388, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "SQL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(833, 621);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonexit);
            this.Controls.Add(this.updateadmin);
            this.Controls.Add(this.UploadCon);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseprDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_salesBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.make_offerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private databaseprDataSet databaseprDataSet;
        private System.Windows.Forms.BindingSource adminBindingSource;
        private databaseprDataSetTableAdapters.adminTableAdapter adminTableAdapter;
        private databaseprDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource check_salesBindingSource;
        private databaseprDataSetTableAdapters.check_salesTableAdapter check_salesTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sIGItem;
        private System.Windows.Forms.ToolStripMenuItem toolChSales;
        private System.Windows.Forms.ToolStripMenuItem toolOffers;
        private System.Windows.Forms.Button UploadCon;
        private System.Windows.Forms.Button updateadmin;
        private System.Windows.Forms.Button buttonexit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource contentBindingSource;
        private databaseprDataSetTableAdapters.contentTableAdapter contentTableAdapter;
        private System.Windows.Forms.BindingSource make_offerBindingSource;
        private databaseprDataSetTableAdapters.make_offerTableAdapter make_offerTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn offerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyingdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nocopiesDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
    }
}