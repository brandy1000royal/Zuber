namespace ZuberSample
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDriversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAdministratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDriverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAdministratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewDriverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewAdministratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDriverListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateAdministratorListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCustomerListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.addToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewDriversToolStripMenuItem,
            this.viewAdministratorToolStripMenuItem,
            this.viewCustomersToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // viewDriversToolStripMenuItem
            // 
            this.viewDriversToolStripMenuItem.Name = "viewDriversToolStripMenuItem";
            this.viewDriversToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewDriversToolStripMenuItem.Text = "View Drivers";
            this.viewDriversToolStripMenuItem.Click += new System.EventHandler(this.viewDriversToolStripMenuItem_Click);
            // 
            // viewAdministratorToolStripMenuItem
            // 
            this.viewAdministratorToolStripMenuItem.Name = "viewAdministratorToolStripMenuItem";
            this.viewAdministratorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewAdministratorToolStripMenuItem.Text = "View Administrator";
            this.viewAdministratorToolStripMenuItem.Click += new System.EventHandler(this.viewAdministratorToolStripMenuItem_Click);
            // 
            // viewCustomersToolStripMenuItem
            // 
            this.viewCustomersToolStripMenuItem.Name = "viewCustomersToolStripMenuItem";
            this.viewCustomersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewCustomersToolStripMenuItem.Text = "View Customers";
            this.viewCustomersToolStripMenuItem.Click += new System.EventHandler(this.viewCustomersToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteDriverToolStripMenuItem,
            this.deleteAdministratorToolStripMenuItem,
            this.deleteCustomerToolStripMenuItem});
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // deleteDriverToolStripMenuItem
            // 
            this.deleteDriverToolStripMenuItem.Name = "deleteDriverToolStripMenuItem";
            this.deleteDriverToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.deleteDriverToolStripMenuItem.Text = "Delete Driver";
            // 
            // deleteAdministratorToolStripMenuItem
            // 
            this.deleteAdministratorToolStripMenuItem.Name = "deleteAdministratorToolStripMenuItem";
            this.deleteAdministratorToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.deleteAdministratorToolStripMenuItem.Text = "Delete Administrator";
            // 
            // deleteCustomerToolStripMenuItem
            // 
            this.deleteCustomerToolStripMenuItem.Name = "deleteCustomerToolStripMenuItem";
            this.deleteCustomerToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.deleteCustomerToolStripMenuItem.Text = "Delete Customer";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewDriverToolStripMenuItem,
            this.addNewAdministratorToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // addNewDriverToolStripMenuItem
            // 
            this.addNewDriverToolStripMenuItem.Name = "addNewDriverToolStripMenuItem";
            this.addNewDriverToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.addNewDriverToolStripMenuItem.Text = "Add New Driver";
            this.addNewDriverToolStripMenuItem.Click += new System.EventHandler(this.addNewDriverToolStripMenuItem_Click);
            // 
            // addNewAdministratorToolStripMenuItem
            // 
            this.addNewAdministratorToolStripMenuItem.Name = "addNewAdministratorToolStripMenuItem";
            this.addNewAdministratorToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.addNewAdministratorToolStripMenuItem.Text = "Add New Administrator";
            this.addNewAdministratorToolStripMenuItem.Click += new System.EventHandler(this.addNewAdministratorToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateDriverListToolStripMenuItem,
            this.updateAdministratorListToolStripMenuItem,
            this.updateCustomerListToolStripMenuItem});
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.updateToolStripMenuItem.Text = "Update";
            // 
            // updateDriverListToolStripMenuItem
            // 
            this.updateDriverListToolStripMenuItem.Name = "updateDriverListToolStripMenuItem";
            this.updateDriverListToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.updateDriverListToolStripMenuItem.Text = "Update Driver List";
            // 
            // updateAdministratorListToolStripMenuItem
            // 
            this.updateAdministratorListToolStripMenuItem.Name = "updateAdministratorListToolStripMenuItem";
            this.updateAdministratorListToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.updateAdministratorListToolStripMenuItem.Text = "Update Administrator List";
            // 
            // updateCustomerListToolStripMenuItem
            // 
            this.updateCustomerListToolStripMenuItem.Name = "updateCustomerListToolStripMenuItem";
            this.updateCustomerListToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.updateCustomerListToolStripMenuItem.Text = "Update Customer List";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDriversToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem viewAdministratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDriverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAdministratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewDriverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewAdministratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDriverListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateAdministratorListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCustomerListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}