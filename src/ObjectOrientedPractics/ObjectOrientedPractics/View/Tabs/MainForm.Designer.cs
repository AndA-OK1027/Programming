namespace ObjectOrientedPractics.View.Tabs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.itemsTab1 = new ObjectOrientedPractics.ItemsTab();
            this.itemsTab2 = new ObjectOrientedPractics.ItemsTab();
            this.usersTab1 = new ObjectOrientedPractics.UsersTab();
            this.SuspendLayout();
            // 
            // itemsTab1
            // 
            this.itemsTab1.Location = new System.Drawing.Point(0, 0);
            this.itemsTab1.MinimumSize = new System.Drawing.Size(589, 507);
            this.itemsTab1.Name = "itemsTab1";
            this.itemsTab1.Size = new System.Drawing.Size(589, 507);
            this.itemsTab1.TabIndex = 0;
            // 
            // itemsTab2
            // 
            this.itemsTab2.Location = new System.Drawing.Point(0, 0);
            this.itemsTab2.MinimumSize = new System.Drawing.Size(589, 507);
            this.itemsTab2.Name = "itemsTab2";
            this.itemsTab2.Size = new System.Drawing.Size(589, 507);
            this.itemsTab2.TabIndex = 0;
            // 
            // usersTab1
            // 
            this.usersTab1.Location = new System.Drawing.Point(0, 0);
            this.usersTab1.MinimumSize = new System.Drawing.Size(589, 507);
            this.usersTab1.Name = "usersTab1";
            this.usersTab1.Size = new System.Drawing.Size(589, 507);
            this.usersTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 524);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private ItemsTab itemsTab1;
        private ItemsTab itemsTab2;
        private UsersTab usersTab1;
    }
}