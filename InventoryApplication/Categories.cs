using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InventoryApplication
{
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
            loadCategoriesFromDB();
        }

        DataTable categoriesDataTable = new DataTable("Categories");

        // Load Category Data From Database
        private void loadCategoriesFromDB()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                String query = "SELECT CategoryID as 'ID', CategoryName as 'Наименование' FROM categories";
                using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                        adapter.Fill(categoriesDataTable);
                        dataGridCategories.DataSource = categoriesDataTable;
                    }
                    catch
                    {
                        MessageBox.Show("ERROR while loading categories from database");
                    }
                    finally
                    {
                        connection.Close();
                    }

                }
            }
        }

        // Selects All Row Values - Fills Fields
        private void dataGridCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridCategories.SelectedRows.Count == 1)
            {
                txtCategoryID.Text = dataGridCategories.SelectedCells[0].Value.ToString();
                txtCategoryName.Text = dataGridCategories.SelectedCells[1].Value.ToString();
            }
            else
            {
                MessageBox.Show("Please select a row");
            }
        }

        private void ClearFields()
        {
            txtCategoryID.Text = "";
            txtCategoryName.Text = "";
            txtCategorySearch.Text = "";
        }

        // Clear Data Fields
        private void btnClearFields_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        // Refresh Categories
        private void btnRefreshCategories_Click(object sender, EventArgs e)
        {
            categoriesDataTable.Clear();
            loadCategoriesFromDB();
        }

        // Validate Category
        private Boolean validateCategory()
        {
            if (txtCategoryName.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // CREATE
        private void btnAddNewCategory_Click(object sender, EventArgs e)
        {
            if (txtCategoryName.Text != "")
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                {
                    String query = "INSERT INTO categories(CategoryName) VALUES(@CategoryName)";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            sqlCommand.CommandType = CommandType.Text;
                            sqlCommand.Parameters.AddWithValue("@CategoryName", txtCategoryName.Text);
                            sqlCommand.ExecuteNonQuery();
                            categoriesDataTable.Clear();
                            loadCategoriesFromDB();
                            ClearFields();
                            MessageBox.Show("Новая товарная группа успешно добавлена", "Инфо");
                        }
                        catch
                        {
                            MessageBox.Show("ERROR while loading categories from database");
                        }
                        finally
                        {
                            connection.Close();
                        }

                    }
                }
            }
        }

        // UPDATE
        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            if (validateCategory())
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                {
                    String query = "UPDATE categories SET CategoryName=@CategoryName WHERE CategoryID=@CategoryID";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            sqlCommand.CommandType = CommandType.Text;
                            sqlCommand.Parameters.AddWithValue("@CategoryName", txtCategoryName.Text);
                            sqlCommand.Parameters.AddWithValue("@CategoryID", int.Parse(txtCategoryID.Text));
                            sqlCommand.ExecuteNonQuery();
                            categoriesDataTable.Clear();
                            loadCategoriesFromDB();
                            ClearFields();
                            MessageBox.Show("Информация о товарной группе успешно обновлена.", "Инфо");
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
            else
            {
                MessageBox.Show("Заполните все поля!", "Ошибка!");
            }
        }

        // DELETE
        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (validateCategory())
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверены что хотите удалить выбранную товарную группу?", "Внимание!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                    {
                        String query = "DELETE FROM categories WHERE CategoryID=@CategoryID";
                        using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                        {
                            try
                            {
                                connection.Open();
                                sqlCommand.CommandType = CommandType.Text;
                                sqlCommand.Parameters.AddWithValue("@CategoryID", int.Parse(txtCategoryID.Text));
                                sqlCommand.ExecuteNonQuery();
                                categoriesDataTable.Clear();
                                loadCategoriesFromDB();
                                ClearFields();
                                MessageBox.Show("Товарная группа успешно удалена", "Инфо");
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
                else if (dialogResult == DialogResult.No)
                {

                }
            }
        }

        // Search Filter
        private void txtCategorySearch_TextChanged(object sender, EventArgs e)
        {
            categoriesDataTable.DefaultView.RowFilter = string.Format("Наименование LIKE '%{0}%'", txtCategorySearch.Text);
        }

    }
}
