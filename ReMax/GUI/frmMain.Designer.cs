namespace ReMax
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.loginMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewClients = new System.Windows.Forms.ToolStripMenuItem();
            this.agentsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAgentsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.housesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHousesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUser = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.menuStrip1.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.dashboardMenu,
            this.searchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(889, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginMenu,
            this.logoutMenu,
            this.exitMenu});
            this.menuFile.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuFile.Image = global::ReMax.Properties.Resources.login__1_;
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(79, 20);
            this.menuFile.Text = "ReMax";
            // 
            // loginMenu
            // 
            this.loginMenu.Font = new System.Drawing.Font("Lucida Fax", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginMenu.Name = "loginMenu";
            this.loginMenu.Size = new System.Drawing.Size(112, 22);
            this.loginMenu.Text = "Login";
            this.loginMenu.Click += new System.EventHandler(this.loginMenu_Click);
            // 
            // logoutMenu
            // 
            this.logoutMenu.Font = new System.Drawing.Font("Lucida Fax", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutMenu.Name = "logoutMenu";
            this.logoutMenu.Size = new System.Drawing.Size(112, 22);
            this.logoutMenu.Text = "Logout";
            this.logoutMenu.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // exitMenu
            // 
            this.exitMenu.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.Size = new System.Drawing.Size(112, 22);
            this.exitMenu.Text = "E&xit";
            this.exitMenu.Click += new System.EventHandler(this.exitMenu_Click);
            // 
            // dashboardMenu
            // 
            this.dashboardMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientsMenu,
            this.agentsMenu,
            this.housesMenu});
            this.dashboardMenu.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardMenu.Image = global::ReMax.Properties.Resources.id_card;
            this.dashboardMenu.Name = "dashboardMenu";
            this.dashboardMenu.Size = new System.Drawing.Size(68, 20);
            this.dashboardMenu.Text = "Staff";
            // 
            // clientsMenu
            // 
            this.clientsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewClients});
            this.clientsMenu.Font = new System.Drawing.Font("Lucida Fax", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientsMenu.Name = "clientsMenu";
            this.clientsMenu.Size = new System.Drawing.Size(115, 22);
            this.clientsMenu.Text = "Clients";
            this.clientsMenu.Click += new System.EventHandler(this.clientsMenu_Click);
            // 
            // viewClients
            // 
            this.viewClients.Name = "viewClients";
            this.viewClients.Size = new System.Drawing.Size(143, 22);
            this.viewClients.Text = "View Clients";
            this.viewClients.Click += new System.EventHandler(this.viewClients_Click);
            // 
            // agentsMenu
            // 
            this.agentsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAgentsMenu});
            this.agentsMenu.Font = new System.Drawing.Font("Lucida Fax", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agentsMenu.Name = "agentsMenu";
            this.agentsMenu.Size = new System.Drawing.Size(115, 22);
            this.agentsMenu.Text = "Agents";
            // 
            // viewAgentsMenu
            // 
            this.viewAgentsMenu.Name = "viewAgentsMenu";
            this.viewAgentsMenu.Size = new System.Drawing.Size(142, 22);
            this.viewAgentsMenu.Text = "View Agents";
            this.viewAgentsMenu.Click += new System.EventHandler(this.viewAgentsMenu_Click);
            // 
            // housesMenu
            // 
            this.housesMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHousesToolStripMenuItem});
            this.housesMenu.Font = new System.Drawing.Font("Lucida Fax", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.housesMenu.Name = "housesMenu";
            this.housesMenu.Size = new System.Drawing.Size(115, 22);
            this.housesMenu.Text = "Houses";
            // 
            // viewHousesToolStripMenuItem
            // 
            this.viewHousesToolStripMenuItem.Name = "viewHousesToolStripMenuItem";
            this.viewHousesToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.viewHousesToolStripMenuItem.Text = "View Houses";
            this.viewHousesToolStripMenuItem.Click += new System.EventHandler(this.viewHousesToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Image = global::ReMax.Properties.Resources.research;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // lblUser
            // 
            this.lblUser.BackColor = System.Drawing.Color.Black;
            this.lblUser.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUser.Location = new System.Drawing.Point(519, 24);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(247, 45);
            this.lblUser.TabIndex = 1;
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUser.Click += new System.EventHandler(this.lblUser_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ReMax.Properties.Resources.skyscrapers_450793_1920;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(889, 357);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReMax ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem loginMenu;
        private System.Windows.Forms.ToolStripMenuItem logoutMenu;
        private System.Windows.Forms.ToolStripMenuItem dashboardMenu;
        private System.Windows.Forms.ToolStripMenuItem clientsMenu;
        private System.Windows.Forms.ToolStripMenuItem agentsMenu;
        private System.Windows.Forms.ToolStripMenuItem housesMenu;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenu;
        private System.Windows.Forms.ToolStripMenuItem viewAgentsMenu;
        private System.Windows.Forms.ToolStripMenuItem viewClients;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ToolStripMenuItem viewHousesToolStripMenuItem;
    }
}

