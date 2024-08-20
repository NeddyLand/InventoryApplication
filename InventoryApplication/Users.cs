using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InventoryApplication
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private DataTable userDataTable = new DataTable("User");

        // Clear All Fields
        private void ClearFields()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtLoginName.Text = "";
            txtPassword.Text = "";
            txtUserID.Text = "";
            txtUserSearch.Text = "";
        }

        // Load User Data From Database
        private void LoadUserDataFromDB()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                string query = "SELECT DISTINCT UserID as ID, LoginName as Логин, FirstName as Имя, LastName as Фамилия FROM [dbo].[Users]";
                using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                        adapter.Fill(userDataTable);
                        dataGridUser.DataSource = userDataTable;
                    }
                    catch
                    {
                        MessageBox.Show("Возникла ошибка при попытке загрузить информацию о пользователях.", "Ошибка");
                    }
                    finally
                    {
                        connection.Close();
                    }

                }
            }
        }

        // Form Loading Event
        private void User_Load(object sender, EventArgs e)
        {
            LoadUserDataFromDB();
        }

        // Refresh
        private void btnRefreshUsers_Click(object sender, EventArgs e)
        {
            userDataTable.Clear();
            LoadUserDataFromDB();
        }

        // Clear All Fields
        private void btnClearFields_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        // Selects All Row Values - Fills Fields
        private void dataGridUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridUser.SelectedRows.Count == 1)
            {
                txtUserID.Text = dataGridUser.SelectedCells[0].Value.ToString();
                txtLoginName.Text = dataGridUser.SelectedCells[1].Value.ToString();
                txtFirstName.Text = dataGridUser.SelectedCells[2].Value.ToString();
                txtLastName.Text = dataGridUser.SelectedCells[3].Value.ToString();
                //txtPassword.Text = dataGridUser.SelectedCells[4].Value.ToString();
            }
            else
            {
                MessageBox.Show("Ошибка!");
            }
        }

        // Validate User
        private Boolean ValidateUser()
        {
            if (txtLoginName.Text != "" && txtFirstName.Text != "" && txtLastName.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // CREATE
        private void btnCreateNewUser_Click(object sender, EventArgs e)
        {
            if (ValidateUser() && txtPassword.Text != "")
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                {
                    // Create a SqlCommand, and identify it as a stored procedure.
                    using (SqlCommand sqlCommand = new SqlCommand("dbo.uspAddUser", connection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        // LoginName
                        sqlCommand.Parameters.Add(new SqlParameter("@pLogin", SqlDbType.NVarChar, 50));
                        sqlCommand.Parameters["@pLogin"].Value = txtLoginName.Text;

                        // Password
                        sqlCommand.Parameters.Add(new SqlParameter("@pPassword", SqlDbType.NVarChar, 50));
                        sqlCommand.Parameters["@pPassword"].Value = txtPassword.Text;

                        // First Name
                        sqlCommand.Parameters.Add(new SqlParameter("@pFirstName", SqlDbType.NVarChar, 40));
                        sqlCommand.Parameters["@pFirstName"].Value = txtFirstName.Text;

                        // Last Name
                        sqlCommand.Parameters.Add(new SqlParameter("@pLastName", SqlDbType.NVarChar, 40));
                        sqlCommand.Parameters["@pLastName"].Value = txtLastName.Text;

                        // Add the OUTPUT parameter.
                        sqlCommand.Parameters.Add(new SqlParameter("@responseMessage", SqlDbType.NVarChar, 250));
                        sqlCommand.Parameters["@responseMessage"].Direction = ParameterDirection.Output;

                        try
                        {
                            connection.Open();
                            sqlCommand.ExecuteNonQuery();
                            var response = sqlCommand.Parameters["@responseMessage"].Value;
                            string responseMessage = response.ToString();
                            ClearFields();
                            userDataTable.Clear();
                            LoadUserDataFromDB();
                            MessageBox.Show(responseMessage);
                        }
                        catch
                        {
                            MessageBox.Show("Произошла неопознанная ошибка!");
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
                MessageBox.Show("Заполните все поля!","Ошибка");
            }
        }

        // UPDATE - USER INFO
        private void btnUpdateUserInfo_Click(object sender, EventArgs e)
        {
            if (ValidateUser() && txtPassword.Text == "")
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                {
                    string query = "UPDATE [dbo].[Users] SET LoginName=@LoginName, FirstName=@FirstName, LastName=@LastName WHERE UserID=@UserID";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            sqlCommand.CommandType = CommandType.Text;
                            sqlCommand.Parameters.AddWithValue("@LoginName", txtLoginName.Text);
                            sqlCommand.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                            sqlCommand.Parameters.AddWithValue("@LastName", txtLastName.Text);
                            sqlCommand.Parameters.AddWithValue("@UserID", int.Parse(txtUserID.Text));
                            sqlCommand.ExecuteNonQuery();
                            userDataTable.Clear();
                            LoadUserDataFromDB();
                            MessageBox.Show("Информация о пользователе обновлена.", "Инфо");
                        }
                        catch
                        {
                            MessageBox.Show("Ошибка!");
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
                MessageBox.Show("Заполните все поля, кроме пароля!");
            }
        }

        // UPDATE - USER PASSWORD
        private void btnUpdateUserPassword_Click(object sender, EventArgs e)
        {
            if (ValidateUser() && txtPassword.Text != "")
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                {
                    // Create a SqlCommand, and identify it as a stored procedure.
                    using (SqlCommand sqlCommand = new SqlCommand("dbo.uspUpdateUser", connection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        // User ID
                        sqlCommand.Parameters.Add(new SqlParameter("@pUserID", SqlDbType.Int));
                        sqlCommand.Parameters["@pUserID"].Value = int.Parse(txtUserID.Text);

                        // Password
                        sqlCommand.Parameters.Add(new SqlParameter("@pPassword", SqlDbType.NVarChar, 50));
                        sqlCommand.Parameters["@pPassword"].Value = txtPassword.Text;

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
                            ClearFields();
                            MessageBox.Show(responseMessage);
                        }
                        catch
                        {
                            MessageBox.Show("Возникла ошибка при попытке обновить пароль!", "Ошибка!");
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
                MessageBox.Show("Заполните все поля!", "Ошибка");
            }
        }

        // DELETE
        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверены что хотите удалить данного пользователя?", "Внимание!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                    {
                        using (SqlCommand sqlCommand = new SqlCommand("dbo.uspDeleteUser", connection))
                        {
                            sqlCommand.CommandType = CommandType.StoredProcedure;

                            // User ID
                            sqlCommand.Parameters.Add(new SqlParameter("@pUserID", SqlDbType.Int));
                            sqlCommand.Parameters["@pUserID"].Value = int.Parse(txtUserID.Text);

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
                                ClearFields();
                                userDataTable.Clear();
                                LoadUserDataFromDB();
                                if (responseMessage != "")
                                {
                                    MessageBox.Show(responseMessage);

                                }
                                else
                                {
                                    MessageBox.Show("Пользователь успешно удален!", "Инфо");
                                }
                            }
                            catch
                            {
                                MessageBox.Show("Возникла ошибка при попытке удалить пользователя!", "Ошибка");
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
            else
            {
                MessageBox.Show("Заполните все поля!", "Ошибка");
            }
        }

        // Search Filter
        private void txtUserSearch_TextChanged(object sender, EventArgs e)
        {
            userDataTable.DefaultView.RowFilter = string.Format("Логин LIKE '{0}%'", txtUserSearch.Text);
        }

        private void Users_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
    }
}
