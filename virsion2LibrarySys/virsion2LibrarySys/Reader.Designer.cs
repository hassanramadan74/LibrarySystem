namespace virsion2LibrarySys
{
    partial class Reader
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
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseprDataSet = new virsion2LibrarySys.databaseprDataSet();
            this.userTableAdapter = new virsion2LibrarySys.databaseprDataSetTableAdapters.userTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.categorizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.romanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fantasyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adventureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateadmin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Share = new System.Windows.Forms.Button();
            this.adminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminTableAdapter = new virsion2LibrarySys.databaseprDataSetTableAdapters.adminTableAdapter();
            this.tableAdapterManager = new virsion2LibrarySys.databaseprDataSetTableAdapters.TableAdapterManager();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.otherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseprDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "user";
            this.userBindingSource.DataSource = this.databaseprDataSet;
            // 
            // databaseprDataSet
            // 
            this.databaseprDataSet.DataSetName = "databaseprDataSet";
            this.databaseprDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categorizeToolStripMenuItem,
            this.showAllToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MaximumSize = new System.Drawing.Size(0, 80);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(823, 58);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // categorizeToolStripMenuItem
            // 
            this.categorizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.romanceToolStripMenuItem,
            this.fantasyToolStripMenuItem,
            this.artToolStripMenuItem,
            this.adventureToolStripMenuItem,
            this.historyToolStripMenuItem,
            this.sportsToolStripMenuItem,
            this.otherToolStripMenuItem});
            this.categorizeToolStripMenuItem.Image = global::virsion2LibrarySys.Properties.Resources.download__2_;
            this.categorizeToolStripMenuItem.Name = "categorizeToolStripMenuItem";
            this.categorizeToolStripMenuItem.Size = new System.Drawing.Size(153, 54);
            this.categorizeToolStripMenuItem.Text = "View Categorize";
            // 
            // romanceToolStripMenuItem
            // 
            this.romanceToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.romanceToolStripMenuItem.Name = "romanceToolStripMenuItem";
            this.romanceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.romanceToolStripMenuItem.Text = "Romance";
            // 
            // fantasyToolStripMenuItem
            // 
            this.fantasyToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.fantasyToolStripMenuItem.Name = "fantasyToolStripMenuItem";
            this.fantasyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fantasyToolStripMenuItem.Text = "Fantasy";
            // 
            // artToolStripMenuItem
            // 
            this.artToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.artToolStripMenuItem.Name = "artToolStripMenuItem";
            this.artToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.artToolStripMenuItem.Text = "Art";
            // 
            // adventureToolStripMenuItem
            // 
            this.adventureToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.adventureToolStripMenuItem.Name = "adventureToolStripMenuItem";
            this.adventureToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adventureToolStripMenuItem.Text = "Adventure";
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.historyToolStripMenuItem.Text = "History";
            // 
            // sportsToolStripMenuItem
            // 
            this.sportsToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.sportsToolStripMenuItem.Name = "sportsToolStripMenuItem";
            this.sportsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sportsToolStripMenuItem.Text = "Sports";
            // 
            // showAllToolStripMenuItem
            // 
            this.showAllToolStripMenuItem.Image = global::virsion2LibrarySys.Properties.Resources.download;
            this.showAllToolStripMenuItem.Name = "showAllToolStripMenuItem";
            this.showAllToolStripMenuItem.Size = new System.Drawing.Size(98, 54);
            this.showAllToolStripMenuItem.Text = "Show";
            this.showAllToolStripMenuItem.Click += new System.EventHandler(this.showAllToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Image = global::virsion2LibrarySys.Properties.Resources.search;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(179, 54);
            this.searchToolStripMenuItem.Text = "Search by Categorize";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::virsion2LibrarySys.Properties.Resources.Exit1;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(88, 54);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // updateadmin
            // 
            this.updateadmin.BackColor = System.Drawing.Color.Gold;
            this.updateadmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateadmin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateadmin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updateadmin.Location = new System.Drawing.Point(565, 391);
            this.updateadmin.Name = "updateadmin";
            this.updateadmin.Size = new System.Drawing.Size(177, 33);
            this.updateadmin.TabIndex = 49;
            this.updateadmin.Text = "Update Profile";
            this.updateadmin.UseVisualStyleBackColor = false;
            this.updateadmin.Click += new System.EventHandler(this.updateadmin_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(565, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 33);
            this.button1.TabIndex = 50;
            this.button1.Text = "Buy Content";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Share
            // 
            this.Share.BackColor = System.Drawing.Color.Gold;
            this.Share.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Share.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Share.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Share.Location = new System.Drawing.Point(565, 256);
            this.Share.Name = "Share";
            this.Share.Size = new System.Drawing.Size(177, 33);
            this.Share.TabIndex = 51;
            this.Share.Text = "Share Ideas";
            this.Share.UseVisualStyleBackColor = false;
            this.Share.Click += new System.EventHandler(this.Share_Click);
            // 
            // adminBindingSource
            // 
            this.adminBindingSource.DataMember = "admin";
            this.adminBindingSource.DataSource = this.databaseprDataSet;
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
            this.tableAdapterManager.userTableAdapter = this.userTableAdapter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::virsion2LibrarySys.Properties.Resources.reader;
            this.pictureBox1.Location = new System.Drawing.Point(687, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::virsion2LibrarySys.Properties.Resources.WHAT_IS_THE_PURPOSE_OF_A_LIBRARY_MANAGEMENT_SYSTEM_min;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(-1, 198);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 298);
            this.panel1.TabIndex = 0;
            // 
            // otherToolStripMenuItem
            // 
            this.otherToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            this.otherToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.otherToolStripMenuItem.Text = "Other";
            // 
            // Reader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(823, 495);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Share);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.updateadmin);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "Reader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reader";
            this.Load += new System.EventHandler(this.Reader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseprDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private databaseprDataSet databaseprDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private databaseprDataSetTableAdapters.userTableAdapter userTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem categorizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem romanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fantasyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adventureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button updateadmin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Share;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource adminBindingSource;
        private databaseprDataSetTableAdapters.adminTableAdapter adminTableAdapter;
        private databaseprDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem;
    }
}