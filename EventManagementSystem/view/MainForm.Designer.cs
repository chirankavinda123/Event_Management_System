namespace EventManagementSystem
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyContractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editDetailedEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.View_SuppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VenueViewItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FoodBeveragesViewItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DecorsViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TransportViewItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PhotographyViewItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EntertainmentViewItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Modify_SuppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.venueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foodAndBeveragesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.photographyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entertainmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdatePaymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.incomeReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createCoordinatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToolStripMenuItem,
            this.eventsToolStripMenuItem,
            this.suppliersToolStripMenuItem,
            this.toolStripMenuItem1,
            this.reportsToolStripMenuItem,
            this.utilityToolStripMenuItem,
            this.administratorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.TabStop = true;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientToolStripMenuItem,
            this.eventStatusToolStripMenuItem});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.masterToolStripMenuItem.Text = "&Main";
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.clientToolStripMenuItem.Text = "Client...";
            this.clientToolStripMenuItem.Click += new System.EventHandler(this.clientToolStripMenuItem_Click);
            // 
            // eventStatusToolStripMenuItem
            // 
            this.eventStatusToolStripMenuItem.Name = "eventStatusToolStripMenuItem";
            this.eventStatusToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.eventStatusToolStripMenuItem.Text = "Events Schedule...";
            this.eventStatusToolStripMenuItem.Click += new System.EventHandler(this.eventStatusToolStripMenuItem_Click);
            // 
            // eventsToolStripMenuItem
            // 
            this.eventsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifyContractToolStripMenuItem,
            this.editDetailedEventToolStripMenuItem,
            this.viewEventsToolStripMenuItem});
            this.eventsToolStripMenuItem.Name = "eventsToolStripMenuItem";
            this.eventsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.eventsToolStripMenuItem.Text = "&Events";
            // 
            // modifyContractToolStripMenuItem
            // 
            this.modifyContractToolStripMenuItem.Name = "modifyContractToolStripMenuItem";
            this.modifyContractToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.modifyContractToolStripMenuItem.Text = "Modify Contract...";
            this.modifyContractToolStripMenuItem.Click += new System.EventHandler(this.clientToolStripMenuItem_Click);
            // 
            // editDetailedEventToolStripMenuItem
            // 
            this.editDetailedEventToolStripMenuItem.Name = "editDetailedEventToolStripMenuItem";
            this.editDetailedEventToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.editDetailedEventToolStripMenuItem.Text = "Edit Detailed Event...";
            this.editDetailedEventToolStripMenuItem.Click += new System.EventHandler(this.editDetailedEventToolStripMenuItem_Click);
            // 
            // viewEventsToolStripMenuItem
            // 
            this.viewEventsToolStripMenuItem.Name = "viewEventsToolStripMenuItem";
            this.viewEventsToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.viewEventsToolStripMenuItem.Text = "View Events...";
            this.viewEventsToolStripMenuItem.Click += new System.EventHandler(this.editDetailedEventToolStripMenuItem_Click);
            // 
            // suppliersToolStripMenuItem
            // 
            this.suppliersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.View_SuppliersToolStripMenuItem,
            this.Modify_SuppliersToolStripMenuItem});
            this.suppliersToolStripMenuItem.Name = "suppliersToolStripMenuItem";
            this.suppliersToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.suppliersToolStripMenuItem.Text = "&Suppliers";
            // 
            // View_SuppliersToolStripMenuItem
            // 
            this.View_SuppliersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VenueViewItem,
            this.FoodBeveragesViewItem,
            this.DecorsViewMenuItem,
            this.TransportViewItem,
            this.PhotographyViewItem,
            this.EntertainmentViewItem});
            this.View_SuppliersToolStripMenuItem.Name = "View_SuppliersToolStripMenuItem";
            this.View_SuppliersToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.View_SuppliersToolStripMenuItem.Text = "View Suppliers";
            // 
            // VenueViewItem
            // 
            this.VenueViewItem.Name = "VenueViewItem";
            this.VenueViewItem.Size = new System.Drawing.Size(272, 22);
            this.VenueViewItem.Text = "Venue Suppliers";
            this.VenueViewItem.Click += new System.EventHandler(this.venueToolStripMenuItem_Click);
            // 
            // FoodBeveragesViewItem
            // 
            this.FoodBeveragesViewItem.Name = "FoodBeveragesViewItem";
            this.FoodBeveragesViewItem.Size = new System.Drawing.Size(272, 22);
            this.FoodBeveragesViewItem.Text = "Food And Beverages Suppliers";
            this.FoodBeveragesViewItem.Click += new System.EventHandler(this.foodAndBeveragesToolStripMenuItem_Click);
            // 
            // DecorsViewMenuItem
            // 
            this.DecorsViewMenuItem.Name = "DecorsViewMenuItem";
            this.DecorsViewMenuItem.Size = new System.Drawing.Size(272, 22);
            this.DecorsViewMenuItem.Text = "Decors Suppliers";
            this.DecorsViewMenuItem.Click += new System.EventHandler(this.decorsToolStripMenuItem_Click);
            // 
            // TransportViewItem
            // 
            this.TransportViewItem.Name = "TransportViewItem";
            this.TransportViewItem.Size = new System.Drawing.Size(272, 22);
            this.TransportViewItem.Text = "Transport Suppliers";
            this.TransportViewItem.Click += new System.EventHandler(this.transportToolStripMenuItem_Click);
            // 
            // PhotographyViewItem
            // 
            this.PhotographyViewItem.Name = "PhotographyViewItem";
            this.PhotographyViewItem.Size = new System.Drawing.Size(272, 22);
            this.PhotographyViewItem.Text = "Photography Suppliers";
            this.PhotographyViewItem.Click += new System.EventHandler(this.photographyToolStripMenuItem_Click);
            // 
            // EntertainmentViewItem
            // 
            this.EntertainmentViewItem.Name = "EntertainmentViewItem";
            this.EntertainmentViewItem.Size = new System.Drawing.Size(272, 22);
            this.EntertainmentViewItem.Text = "Entertainment Suppliers";
            this.EntertainmentViewItem.Click += new System.EventHandler(this.entertainmentToolStripMenuItem_Click);
            // 
            // Modify_SuppliersToolStripMenuItem
            // 
            this.Modify_SuppliersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.venueToolStripMenuItem,
            this.foodAndBeveragesToolStripMenuItem,
            this.decorsToolStripMenuItem,
            this.transportToolStripMenuItem,
            this.photographyToolStripMenuItem,
            this.entertainmentToolStripMenuItem});
            this.Modify_SuppliersToolStripMenuItem.Name = "Modify_SuppliersToolStripMenuItem";
            this.Modify_SuppliersToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.Modify_SuppliersToolStripMenuItem.Text = "Modify Suppliers";
            // 
            // venueToolStripMenuItem
            // 
            this.venueToolStripMenuItem.Name = "venueToolStripMenuItem";
            this.venueToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.venueToolStripMenuItem.Text = "Venue";
            this.venueToolStripMenuItem.Click += new System.EventHandler(this.venueToolStripMenuItem_Click);
            // 
            // foodAndBeveragesToolStripMenuItem
            // 
            this.foodAndBeveragesToolStripMenuItem.Name = "foodAndBeveragesToolStripMenuItem";
            this.foodAndBeveragesToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.foodAndBeveragesToolStripMenuItem.Text = "Food And Beverages";
            this.foodAndBeveragesToolStripMenuItem.Click += new System.EventHandler(this.foodAndBeveragesToolStripMenuItem_Click);
            // 
            // decorsToolStripMenuItem
            // 
            this.decorsToolStripMenuItem.Name = "decorsToolStripMenuItem";
            this.decorsToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.decorsToolStripMenuItem.Text = "Decors";
            this.decorsToolStripMenuItem.Click += new System.EventHandler(this.decorsToolStripMenuItem_Click);
            // 
            // transportToolStripMenuItem
            // 
            this.transportToolStripMenuItem.Name = "transportToolStripMenuItem";
            this.transportToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.transportToolStripMenuItem.Text = "Transport";
            this.transportToolStripMenuItem.Click += new System.EventHandler(this.transportToolStripMenuItem_Click);
            // 
            // photographyToolStripMenuItem
            // 
            this.photographyToolStripMenuItem.Name = "photographyToolStripMenuItem";
            this.photographyToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.photographyToolStripMenuItem.Text = "Photography";
            this.photographyToolStripMenuItem.Click += new System.EventHandler(this.photographyToolStripMenuItem_Click);
            // 
            // entertainmentToolStripMenuItem
            // 
            this.entertainmentToolStripMenuItem.Name = "entertainmentToolStripMenuItem";
            this.entertainmentToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.entertainmentToolStripMenuItem.Text = "Entertainment";
            this.entertainmentToolStripMenuItem.Click += new System.EventHandler(this.entertainmentToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paymentDetailsToolStripMenuItem,
            this.UpdatePaymentsToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(82, 20);
            this.toolStripMenuItem1.Text = "&Payments";
            // 
            // paymentDetailsToolStripMenuItem
            // 
            this.paymentDetailsToolStripMenuItem.Name = "paymentDetailsToolStripMenuItem";
            this.paymentDetailsToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.paymentDetailsToolStripMenuItem.Text = "Payment Details...";
            this.paymentDetailsToolStripMenuItem.Click += new System.EventHandler(this.UpdatePaymentsToolStripMenuItem_Click);
            // 
            // UpdatePaymentsToolStripMenuItem
            // 
            this.UpdatePaymentsToolStripMenuItem.Name = "UpdatePaymentsToolStripMenuItem";
            this.UpdatePaymentsToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.UpdatePaymentsToolStripMenuItem.Text = "Update Payments...";
            this.UpdatePaymentsToolStripMenuItem.Click += new System.EventHandler(this.UpdatePaymentsToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eventsToolStripMenuItem1,
            this.incomeReportsToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.reportsToolStripMenuItem.Text = "&Reports";
            // 
            // eventsToolStripMenuItem1
            // 
            this.eventsToolStripMenuItem1.Name = "eventsToolStripMenuItem1";
            this.eventsToolStripMenuItem1.Size = new System.Drawing.Size(225, 22);
            this.eventsToolStripMenuItem1.Text = "Events Report";
            this.eventsToolStripMenuItem1.Click += new System.EventHandler(this.eventsToolStripMenuItem1_Click);
            // 
            // incomeReportsToolStripMenuItem
            // 
            this.incomeReportsToolStripMenuItem.Name = "incomeReportsToolStripMenuItem";
            this.incomeReportsToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.incomeReportsToolStripMenuItem.Text = "Income Analysis Report";
            this.incomeReportsToolStripMenuItem.Click += new System.EventHandler(this.incomeReportsToolStripMenuItem_Click);
            // 
            // utilityToolStripMenuItem
            // 
            this.utilityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.utilityToolStripMenuItem.Name = "utilityToolStripMenuItem";
            this.utilityToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.utilityToolStripMenuItem.Text = "&Utility";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // administratorToolStripMenuItem
            // 
            this.administratorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createCoordinatorToolStripMenuItem});
            this.administratorToolStripMenuItem.Name = "administratorToolStripMenuItem";
            this.administratorToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.administratorToolStripMenuItem.Text = "&Admin";
            this.administratorToolStripMenuItem.Click += new System.EventHandler(this.administratorToolStripMenuItem_Click);
            // 
            // createCoordinatorToolStripMenuItem
            // 
            this.createCoordinatorToolStripMenuItem.Name = "createCoordinatorToolStripMenuItem";
            this.createCoordinatorToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.createCoordinatorToolStripMenuItem.Text = "Add/Edit Coordinator...";
            this.createCoordinatorToolStripMenuItem.Click += new System.EventHandler(this.createCoordinatorToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 369);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Saki Events - Main Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppliersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Modify_SuppliersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem View_SuppliersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem incomeReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyContractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editDetailedEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem venueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foodAndBeveragesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem photographyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entertainmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VenueViewItem;
        private System.Windows.Forms.ToolStripMenuItem FoodBeveragesViewItem;
        private System.Windows.Forms.ToolStripMenuItem DecorsViewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TransportViewItem;
        private System.Windows.Forms.ToolStripMenuItem PhotographyViewItem;
        private System.Windows.Forms.ToolStripMenuItem EntertainmentViewItem;
        private System.Windows.Forms.ToolStripMenuItem createCoordinatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpdatePaymentsToolStripMenuItem;
    }
}