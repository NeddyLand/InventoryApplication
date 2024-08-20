﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InventoryApplication
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
            loadCustomerDataFromDB();
        }

        DataTable customersDataTable = new DataTable("Customers");

        // Load Customer Data
        private void loadCustomerDataFromDB()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                String query = "SELECT CustomerID as 'ID', FirstName as 'Имя', LastName as 'Фамилия', Phone as 'Телефон', Email, City as 'Город', Address as 'Адрес', Balance as 'Баланс' FROM Customers";
                using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                        adapter.Fill(customersDataTable);
                        dataGridCustomers.DataSource = customersDataTable;
                    }
                    catch
                    {
                        MessageBox.Show("ERROR while loading users from database");
                    }
                    finally
                    {
                        connection.Close();
                    }

                }
            }
        }

        // Refresh
        private void btnRefreshCustomers_Click(object sender, EventArgs e)
        {
            customersDataTable.Clear();
            loadCustomerDataFromDB();
        }

        // Selects All Row Values - Fills Fields
        private void dataGridCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridCustomers.SelectedRows.Count == 1)
            {
                txtCustomerID.Text = dataGridCustomers.SelectedCells[0].Value.ToString();
                txtCustomerFirstName.Text = dataGridCustomers.SelectedCells[1].Value.ToString();
                txtCustomerLastName.Text = dataGridCustomers.SelectedCells[2].Value.ToString();
                txtCustomerPhone.Text = dataGridCustomers.SelectedCells[3].Value.ToString();
                txtCustomerEmail.Text = dataGridCustomers.SelectedCells[4].Value.ToString();
                txtCustomerCity.Text = dataGridCustomers.SelectedCells[5].Value.ToString();
                txtCustomerAddress.Text = dataGridCustomers.SelectedCells[6].Value.ToString();
                txtCustomerBalance.Text = dataGridCustomers.SelectedCells[7].Value.ToString();
            }
            else
            {
                MessageBox.Show("Please select a row");
            }
        }

        // Validate Customer
        private Boolean validCustomer()
        {
            if (txtCustomerFirstName.Text != "" && txtCustomerLastName.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void ClearFields()
        {
            txtCustomerID.Text = "";
            txtCustomerFirstName.Text = "";
            txtCustomerLastName.Text = "";
            txtCustomerPhone.Text = "";
            txtCustomerEmail.Text = "";
            txtCustomerCity.Text = "";
            txtCustomerAddress.Text = "";
            txtCustomerBalance.Text = "";
            txtCustomerSearch.Text = "";
        }

        // Clear Fields
        private void btnClearFields_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        // CREATE
        private void btnCreateNewCustomer_Click(object sender, EventArgs e)
        {
            if (validCustomer())
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                {
                    String query = "INSERT INTO customers(FirstName, LastName, Phone, Email, City, Address, Balance) VALUES(@FirstName, @LastName, @Phone, @Email, @City, @Address, @Balance)";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            sqlCommand.CommandType = CommandType.Text;
                            sqlCommand.Parameters.AddWithValue("@FirstName", txtCustomerFirstName.Text);
                            sqlCommand.Parameters.AddWithValue("@LastName", txtCustomerLastName.Text);
                            sqlCommand.Parameters.AddWithValue("@Phone", txtCustomerPhone.Text);
                            sqlCommand.Parameters.AddWithValue("@Email", txtCustomerEmail.Text);
                            sqlCommand.Parameters.AddWithValue("@City", txtCustomerCity.Text);
                            sqlCommand.Parameters.AddWithValue("@Address", txtCustomerAddress.Text);
                            sqlCommand.Parameters.AddWithValue("@Balance", double.TryParse(txtCustomerBalance.Text, out double result));
                            sqlCommand.ExecuteNonQuery();
                            customersDataTable.Clear();
                            ClearFields();
                            loadCustomerDataFromDB();
                            MessageBox.Show("Новый клиент успешно создан", "Инфо");
                        }
                        catch
                        {
                            MessageBox.Show("ERROR while creating customer");
                        }
                        finally
                        {
                            connection.Close();
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("Заполните обязательные поля");
            }
        }

        // UPDATE
        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (validCustomer())
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                {
                    String query = "UPDATE customers SET FirstName=@FirstName, LastName=@LastName, Phone=@Phone, Email=@Email, City=@City, Address=@Address, Balance=@Balance WHERE CustomerID=@CustomerID";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            sqlCommand.CommandType = CommandType.Text;
                            sqlCommand.Parameters.AddWithValue("@FirstName", txtCustomerFirstName.Text);
                            sqlCommand.Parameters.AddWithValue("@LastName", txtCustomerLastName.Text);
                            sqlCommand.Parameters.AddWithValue("@Phone", txtCustomerPhone.Text);
                            sqlCommand.Parameters.AddWithValue("@Email", txtCustomerEmail.Text);
                            sqlCommand.Parameters.AddWithValue("@City", txtCustomerCity.Text);
                            sqlCommand.Parameters.AddWithValue("@Address", txtCustomerAddress.Text);
                            sqlCommand.Parameters.AddWithValue("@Balance", double.Parse(txtCustomerBalance.Text));
                            sqlCommand.Parameters.AddWithValue("@CustomerID", int.Parse(txtCustomerID.Text));
                            sqlCommand.ExecuteNonQuery();
                            customersDataTable.Clear();
                            ClearFields();
                            loadCustomerDataFromDB();
                            MessageBox.Show("Данные о клиенте успешно обновлены", "Инфо");
                        }
                        catch
                        {
                            MessageBox.Show("ERROR while updating customer");
                        }
                        finally
                        {
                            connection.Close();
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("Заполните обязательные поля");
            }
        }

        // DELETE
        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (validCustomer())
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверены что хотите удалить выбранного клиента?", "Внимание!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                    {
                        String query = "DELETE FROM customers WHERE CustomerID=@CustomerID";
                        using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                        {
                            try
                            {
                                connection.Open();
                                sqlCommand.CommandType = CommandType.Text;
                                sqlCommand.Parameters.AddWithValue("@CustomerID", int.Parse(txtCustomerID.Text));
                                sqlCommand.ExecuteNonQuery();
                                customersDataTable.Clear();
                                ClearFields();
                                loadCustomerDataFromDB();
                                MessageBox.Show("Клиент успешно удален", "Инфо");
                            }
                            catch
                            {
                                MessageBox.Show("ERROR while deleting");

                            }
                            finally
                            {
                                connection.Close();
                            }

                        }
                    }
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
        }

        // Search Filter - Customers
        private void txtCustomerSearch_TextChanged(object sender, EventArgs e)
        {
            customersDataTable.DefaultView.RowFilter = string.Format("Фамилия LIKE '%{0}%'", txtCustomerSearch.Text);
        }

    }
}
