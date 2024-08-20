using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InventoryApplication
{
    public partial class ManageOrders : Form
    {
        public ManageOrders()
        {
            InitializeComponent();
        }

        DataTable ordersDataTable = new DataTable("Orders");
        DataTable salesDataTable = new DataTable("Sales");

        // Form Load Event
        private void ManageOrders_Load(object sender, EventArgs e)
        {
            LoadOrdersFromDatabase();
        }

        // Loads Order data from database and fills datatable
        private void LoadOrdersFromDatabase()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                String query = "SELECT OrderID as 'ID Заказа', FirstName + ' ' + LastName as 'ФИО Клиента', OrderDate as 'Дата Заказа', TotalAmount as 'Итоговая стоимость' FROM Orders inner join Customers on Customers.CustomerID = Orders.CustomerID";
                using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                        adapter.Fill(ordersDataTable);
                        dataGridOrders.DataSource = ordersDataTable;
                    }
                    catch
                    {
                        MessageBox.Show("ERROR while loading orders from database");
                    }
                    finally
                    {
                        connection.Close();
                    }

                }
            }
        }

        // Loads Sales data from database and fills datatable
        private void LoadSalesFromDatabase(string orderID)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                String query = "SELECT SaleID as 'ID Строки', OrderID as 'ID Заказа', ProductName as 'Наименование товара', Quantity as 'Кол-во', TotalPrice as 'Итоговая цена строки' FROM V_Sales WHERE OrderID = @OrderID";
                using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        sqlCommand.Parameters.AddWithValue("@OrderID", orderID);
                        SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                        salesDataTable.Clear();
                        adapter.Fill(salesDataTable);
                        dataGridSales.DataSource = salesDataTable;
                    }
                    catch
                    {
                        MessageBox.Show("ERROR while loading orders from database");
                    }
                    finally
                    {
                        connection.Close();
                    }

                }
            }
        }

        // Selects OrderID and fills text field
        private void dataGridOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridOrders.SelectedRows.Count == 1)
            {
                string orderID = dataGridOrders.SelectedCells[0].Value.ToString();
                LoadSalesFromDatabase(orderID);
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }
        private void txtSearchOrderID_TextChanged(object sender, EventArgs e)
        {
            ordersDataTable.DefaultView.RowFilter = string.Format("Convert([ID Заказа], 'System.String') LIKE '%{0}%'", txtSearchOrderID.Text);
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (dataGridOrders.SelectedCells[0].Value.ToString() != "")
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверены что хотите удалить данный заказ?", "Внимание!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                    {
                        using (SqlCommand sqlCommand = new SqlCommand("dbo.uspDeleteOrder", connection))
                        {
                            sqlCommand.CommandType = CommandType.StoredProcedure;

                            // User ID
                            sqlCommand.Parameters.Add(new SqlParameter("@OrderID", SqlDbType.Int));
                            sqlCommand.Parameters["@OrderID"].Value = dataGridOrders.SelectedCells[0].Value.ToString();

                            // Add the OUTPUT parameter.
                            sqlCommand.Parameters.Add(new SqlParameter("@responseMessage", SqlDbType.NVarChar, 250));
                            sqlCommand.Parameters["@responseMessage"].Direction = ParameterDirection.Output;

                            try
                            {
                                connection.Open();
                                // Run the stored procedure.
                                sqlCommand.ExecuteNonQuery();
                                var response = sqlCommand.Parameters["@responseMessage"].Value;
                                string responseMessage = response.ToString();
                                ordersDataTable.Clear();
                                LoadOrdersFromDatabase();
                                salesDataTable.Clear();
                                MessageBox.Show(responseMessage);
                            }
                            catch
                            {
                                MessageBox.Show("Возникла ошибка при попытке удалить заказ!", "Ошибка");
                            }
                            finally
                            {
                                connection.Close();
                            }

                        }
                    }
                }
                    
            }
            else
            {
                MessageBox.Show("Выберите заказ для удаления");
            }
        }
    }
}
