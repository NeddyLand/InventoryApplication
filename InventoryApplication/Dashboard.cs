using System;
using System.Windows.Forms;

namespace InventoryApplication
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void menuItemCustomers_Click(object sender, EventArgs e)
        {
            Customers customersForm = new Customers();
            customersForm.MdiParent = this;
            customersForm.Show();
        }

        private void menuItemInventory_Click(object sender, EventArgs e)
        {
            Inventory inventoryForm = new Inventory();
            inventoryForm.MdiParent = this;
            inventoryForm.Show();
        }

        private void menuItemCategories_Click(object sender, EventArgs e)
        {
            Categories categoriesForm = new Categories();
            categoriesForm.MdiParent = this;
            categoriesForm.Show();
        }

        private void menuItemCreateOrder_Click(object sender, EventArgs e)
        {
            CreateOrders ordersForm = new CreateOrders();
            ordersForm.MdiParent = this;
            ordersForm.Show();
        }

        private void menuItemUser_Click(object sender, EventArgs e)
        {
            Users usersForm = new Users();
            usersForm.MdiParent = this;
            usersForm.Show();
        }

        private void menuItemManageOrders_Click(object sender, EventArgs e)
        {
            ManageOrders manageOrders = new ManageOrders();
            manageOrders.MdiParent = this;
            manageOrders.Show();
        }
    }
}
