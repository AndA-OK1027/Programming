namespace ObjectOrientedPractics
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            MainTabControl = new TabControl();
            ItemsTabPage = new TabPage();
            ItemsTab = new View.Tabs.ItemsTab();
            CustomersTabPage = new TabPage();
            CustomersTab = new View.Tabs.CustomersTab();
            CartsTabPage = new TabPage();
            CartsTab = new View.Tabs.CartsTab();
            OrdersTabPage = new TabPage();
            OrdersTab = new View.Tabs.OrdersTab();
            PriorityPage = new TabPage();
            PriorityOrdersTab = new View.Tabs.PriorityOrdersTab();
            MainTabControl.SuspendLayout();
            ItemsTabPage.SuspendLayout();
            CustomersTabPage.SuspendLayout();
            CartsTabPage.SuspendLayout();
            OrdersTabPage.SuspendLayout();
            PriorityPage.SuspendLayout();
            SuspendLayout();
            // 
            // MainTabControl
            // 
            MainTabControl.Controls.Add(ItemsTabPage);
            MainTabControl.Controls.Add(CustomersTabPage);
            MainTabControl.Controls.Add(CartsTabPage);
            MainTabControl.Controls.Add(OrdersTabPage);
            MainTabControl.Controls.Add(PriorityPage);
            MainTabControl.Dock = DockStyle.Fill;
            MainTabControl.Location = new Point(0, 0);
            MainTabControl.Name = "MainTabControl";
            MainTabControl.SelectedIndex = 0;
            MainTabControl.Size = new Size(849, 650);
            MainTabControl.TabIndex = 0;
            MainTabControl.SelectedIndexChanged += MainTabControl_SelectedIndexChanged;
            // 
            // ItemsTabPage
            // 
            ItemsTabPage.Controls.Add(ItemsTab);
            ItemsTabPage.Location = new Point(4, 24);
            ItemsTabPage.Name = "ItemsTabPage";
            ItemsTabPage.Padding = new Padding(3);
            ItemsTabPage.Size = new Size(841, 622);
            ItemsTabPage.TabIndex = 0;
            ItemsTabPage.Text = "Items";
            ItemsTabPage.UseVisualStyleBackColor = true;
            // 
            // ItemsTab
            // 
            ItemsTab.Dock = DockStyle.Fill;
            ItemsTab.Location = new Point(3, 3);
            ItemsTab.MinimumSize = new Size(800, 470);
            ItemsTab.Name = "ItemsTab";
            ItemsTab.Size = new Size(835, 616);
            ItemsTab.TabIndex = 0;
            // 
            // CustomersTabPage
            // 
            CustomersTabPage.Controls.Add(CustomersTab);
            CustomersTabPage.Location = new Point(4, 24);
            CustomersTabPage.Name = "CustomersTabPage";
            CustomersTabPage.Padding = new Padding(3);
            CustomersTabPage.Size = new Size(841, 622);
            CustomersTabPage.TabIndex = 1;
            CustomersTabPage.Text = "Customers";
            CustomersTabPage.UseVisualStyleBackColor = true;
            // 
            // CustomersTab
            // 
            CustomersTab.Dock = DockStyle.Fill;
            CustomersTab.Location = new Point(3, 3);
            CustomersTab.MinimumSize = new Size(589, 507);
            CustomersTab.Name = "CustomersTab";
            CustomersTab.Size = new Size(835, 616);
            CustomersTab.TabIndex = 0;
            // 
            // CartsTabPage
            // 
            CartsTabPage.Controls.Add(CartsTab);
            CartsTabPage.Location = new Point(4, 24);
            CartsTabPage.Name = "CartsTabPage";
            CartsTabPage.Size = new Size(841, 622);
            CartsTabPage.TabIndex = 2;
            CartsTabPage.Text = "Cart";
            CartsTabPage.UseVisualStyleBackColor = true;
            // 
            // CartsTab
            // 
            CartsTab.Customers = null;
            CartsTab.Dock = DockStyle.Fill;
            CartsTab.Items = null;
            CartsTab.Location = new Point(0, 0);
            CartsTab.MinimumSize = new Size(771, 417);
            CartsTab.Name = "CartsTab";
            CartsTab.Size = new Size(841, 622);
            CartsTab.TabIndex = 0;
            // 
            // OrdersTabPage
            // 
            OrdersTabPage.Controls.Add(OrdersTab);
            OrdersTabPage.Location = new Point(4, 24);
            OrdersTabPage.Name = "OrdersTabPage";
            OrdersTabPage.Size = new Size(841, 622);
            OrdersTabPage.TabIndex = 3;
            OrdersTabPage.Text = "Orders";
            OrdersTabPage.UseVisualStyleBackColor = true;
            // 
            // OrdersTab
            // 
            OrdersTab.Dock = DockStyle.Fill;
            OrdersTab.Location = new Point(0, 0);
            OrdersTab.MinimumSize = new Size(979, 616);
            OrdersTab.Name = "OrdersTab";
            OrdersTab.Size = new Size(979, 622);
            OrdersTab.TabIndex = 0;
            // 
            // PriorityPage
            // 
            PriorityPage.Controls.Add(PriorityOrdersTab);
            PriorityPage.Location = new Point(4, 24);
            PriorityPage.Name = "PriorityPage";
            PriorityPage.Padding = new Padding(3);
            PriorityPage.Size = new Size(841, 622);
            PriorityPage.TabIndex = 4;
            PriorityPage.Text = "Priority Order";
            PriorityPage.UseVisualStyleBackColor = true;
            // 
            // PriorityOrdersTab
            // 
            PriorityOrdersTab.Dock = DockStyle.Fill;
            PriorityOrdersTab.Items = null;
            PriorityOrdersTab.Location = new Point(3, 3);
            PriorityOrdersTab.Name = "PriorityOrdersTab";
            PriorityOrdersTab.Size = new Size(835, 616);
            PriorityOrdersTab.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 650);
            Controls.Add(MainTabControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(865, 689);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ObjectOrientedPractics";
            MainTabControl.ResumeLayout(false);
            ItemsTabPage.ResumeLayout(false);
            CustomersTabPage.ResumeLayout(false);
            CartsTabPage.ResumeLayout(false);
            OrdersTabPage.ResumeLayout(false);
            PriorityPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl MainTabControl;
        private TabPage ItemsTabPage;
        private TabPage CustomersTabPage;
        private View.Tabs.ItemsTab ItemsTab;
        private View.Tabs.CustomersTab CustomersTab;
        private TabPage CartsTabPage;
        private View.Tabs.CartsTab CartsTab;
        private TabPage OrdersTabPage;
        private View.Tabs.OrdersTab OrdersTab;
        private TabPage PriorityPage;
        private View.Tabs.PriorityOrdersTab PriorityOrdersTab;
    }
}
