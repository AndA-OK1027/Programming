using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            AddCustomerButton = new Button();
            RemoveCustomerButton = new Button();
            CustomersListBox = new ListBox();
            CustomersPanel = new Panel();
            label1 = new Label();
            SelectedCustomerPanel = new Panel();
            CustomerFullNameTextBox = new TextBox();
            label4 = new Label();
            CustomerIdTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            CustomerAddressControl = new Controls.AddressControl();
            CustomersPanel.SuspendLayout();
            SelectedCustomerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // AddCustomerButton
            // 
            AddCustomerButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddCustomerButton.Location = new Point(3, 589);
            AddCustomerButton.Name = "AddCustomerButton";
            AddCustomerButton.Size = new Size(94, 37);
            AddCustomerButton.TabIndex = 0;
            AddCustomerButton.Text = "Add";
            AddCustomerButton.UseVisualStyleBackColor = true;
            AddCustomerButton.Click += AddUserButton_Click;
            // 
            // RemoveCustomerButton
            // 
            RemoveCustomerButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RemoveCustomerButton.Location = new Point(103, 589);
            RemoveCustomerButton.Name = "RemoveCustomerButton";
            RemoveCustomerButton.Size = new Size(94, 37);
            RemoveCustomerButton.TabIndex = 2;
            RemoveCustomerButton.Text = "Remove";
            RemoveCustomerButton.UseVisualStyleBackColor = true;
            RemoveCustomerButton.Click += RemoveUserButton_Click;
            // 
            // CustomersListBox
            // 
            CustomersListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.ItemHeight = 15;
            CustomersListBox.Location = new Point(3, 25);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(279, 544);
            CustomersListBox.TabIndex = 3;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
            // 
            // CustomersPanel
            // 
            CustomersPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CustomersPanel.Controls.Add(label1);
            CustomersPanel.Controls.Add(CustomersListBox);
            CustomersPanel.Controls.Add(RemoveCustomerButton);
            CustomersPanel.Controls.Add(AddCustomerButton);
            CustomersPanel.Location = new Point(3, 3);
            CustomersPanel.Name = "CustomersPanel";
            CustomersPanel.RightToLeft = RightToLeft.No;
            CustomersPanel.Size = new Size(286, 629);
            CustomersPanel.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 5);
            label1.Name = "label1";
            label1.Size = new Size(73, 17);
            label1.TabIndex = 4;
            label1.Text = "Customers";
            // 
            // SelectedCustomerPanel
            // 
            SelectedCustomerPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SelectedCustomerPanel.Controls.Add(CustomerFullNameTextBox);
            SelectedCustomerPanel.Controls.Add(label4);
            SelectedCustomerPanel.Controls.Add(CustomerIdTextBox);
            SelectedCustomerPanel.Controls.Add(label2);
            SelectedCustomerPanel.Controls.Add(label3);
            SelectedCustomerPanel.Location = new Point(292, 3);
            SelectedCustomerPanel.Name = "SelectedCustomerPanel";
            SelectedCustomerPanel.Size = new Size(716, 85);
            SelectedCustomerPanel.TabIndex = 5;
            // 
            // CustomerFullNameTextBox
            // 
            CustomerFullNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomerFullNameTextBox.Location = new Point(77, 51);
            CustomerFullNameTextBox.Name = "CustomerFullNameTextBox";
            CustomerFullNameTextBox.Size = new Size(636, 23);
            CustomerFullNameTextBox.TabIndex = 7;
            CustomerFullNameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 54);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 7;
            label4.Text = "Full Name:";
            // 
            // CustomerIdTextBox
            // 
            CustomerIdTextBox.Location = new Point(77, 22);
            CustomerIdTextBox.Name = "CustomerIdTextBox";
            CustomerIdTextBox.ReadOnly = true;
            CustomerIdTextBox.Size = new Size(191, 23);
            CustomerIdTextBox.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(3, 5);
            label2.Name = "label2";
            label2.Size = new Size(122, 17);
            label2.TabIndex = 6;
            label2.Text = "Selected Customer";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 25);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 6;
            label3.Text = "ID:";
            // 
            // CustomerAddressControl
            // 
            CustomerAddressControl.Location = new Point(291, 94);
            CustomerAddressControl.Name = "CustomerAddressControl";
            CustomerAddressControl.Size = new Size(559, 177);
            CustomerAddressControl.TabIndex = 6;
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CustomerAddressControl);
            Controls.Add(SelectedCustomerPanel);
            Controls.Add(CustomersPanel);
            MinimumSize = new Size(589, 507);
            Name = "CustomersTab";
            Size = new Size(1011, 635);
            CustomersPanel.ResumeLayout(false);
            CustomersPanel.PerformLayout();
            SelectedCustomerPanel.ResumeLayout(false);
            SelectedCustomerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button AddCustomerButton;
        private Button RemoveCustomerButton;
        private ListBox CustomersListBox;
        private Panel CustomersPanel;
        private Label label1;
        private Panel SelectedCustomerPanel;
        private TextBox CustomerFullNameTextBox;
        private Label label4;
        private TextBox CustomerIdTextBox;
        private Label label2;
        private Label label3;
        private Controls.AddressControl CustomerAddressControl;
    }
}
