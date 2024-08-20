namespace InventoryApplication
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItemUser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemInventory = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCategories = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemOrders = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCreateOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemManageOrders = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemUser,
            this.menuItemInventory,
            this.menuItemCustomers,
            this.menuItemCategories,
            this.menuItemOrders});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(870, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuItemUser
            // 
            this.menuItemUser.Name = "menuItemUser";
            this.menuItemUser.Size = new System.Drawing.Size(122, 25);
            this.menuItemUser.Text = "Пользователи";
            this.menuItemUser.Click += new System.EventHandler(this.menuItemUser_Click);
            // 
            // menuItemInventory
            // 
            this.menuItemInventory.Name = "menuItemInventory";
            this.menuItemInventory.Size = new System.Drawing.Size(136, 25);
            this.menuItemInventory.Text = "Товарный запас";
            this.menuItemInventory.Click += new System.EventHandler(this.menuItemInventory_Click);
            // 
            // menuItemCustomers
            // 
            this.menuItemCustomers.Name = "menuItemCustomers";
            this.menuItemCustomers.Size = new System.Drawing.Size(83, 25);
            this.menuItemCustomers.Text = "Клиенты";
            this.menuItemCustomers.Click += new System.EventHandler(this.menuItemCustomers_Click);
            // 
            // menuItemCategories
            // 
            this.menuItemCategories.Name = "menuItemCategories";
            this.menuItemCategories.Size = new System.Drawing.Size(142, 25);
            this.menuItemCategories.Text = "Товарная группа";
            this.menuItemCategories.Click += new System.EventHandler(this.menuItemCategories_Click);
            // 
            // menuItemOrders
            // 
            this.menuItemOrders.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuItemOrders.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemCreateOrder,
            this.menuItemManageOrders});
            this.menuItemOrders.Name = "menuItemOrders";
            this.menuItemOrders.Size = new System.Drawing.Size(73, 25);
            this.menuItemOrders.Text = "Заказы";
            // 
            // menuItemCreateOrder
            // 
            this.menuItemCreateOrder.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuItemCreateOrder.Name = "menuItemCreateOrder";
            this.menuItemCreateOrder.Size = new System.Drawing.Size(200, 26);
            this.menuItemCreateOrder.Text = "Создать заказ";
            this.menuItemCreateOrder.Click += new System.EventHandler(this.menuItemCreateOrder_Click);
            // 
            // menuItemManageOrders
            // 
            this.menuItemManageOrders.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuItemManageOrders.Name = "menuItemManageOrders";
            this.menuItemManageOrders.Size = new System.Drawing.Size(200, 26);
            this.menuItemManageOrders.Text = "История заказов";
            this.menuItemManageOrders.Click += new System.EventHandler(this.menuItemManageOrders_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(870, 500);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dashboard";
            this.Text = "Главное меню";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItemInventory;
        private System.Windows.Forms.ToolStripMenuItem menuItemCustomers;
        private System.Windows.Forms.ToolStripMenuItem menuItemCategories;
        private System.Windows.Forms.ToolStripMenuItem menuItemOrders;
        private System.Windows.Forms.ToolStripMenuItem menuItemCreateOrder;
        private System.Windows.Forms.ToolStripMenuItem menuItemManageOrders;
        private System.Windows.Forms.ToolStripMenuItem menuItemUser;
    }
}