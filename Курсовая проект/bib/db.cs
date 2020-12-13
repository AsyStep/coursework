using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Курсовая.forms;

namespace Курсовая.bib
{
    public static class db
    {
        #region vars
        private static string full_path;
        private static string connString;
        private static Form1 mainForm;   
        public static List<string> table = new List<string>(); //все таблицы базы
        public static List<string> tableName = new List<string>(); //отсортированные аудитории
        public static List<string> users = new List<string>(); //все пользователи
        public static List<string> categories = new List<string>() {"mo", "tech", "furniture"};
        private static DataSet set_workshop;
        private static SqlDataAdapter adapter_workshop;
        private static SqlConnection connection_workshop;



        #endregion

        #region function
        public async static Task<bool> load_db_preferences(Form1 form1)
        {
            mainForm = form1;

            string full_path = Path.GetFullPath("DataBase\\Main.mdf");
            string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='" + full_path + "';Integrated Security=True;Connect Timeout=30";

            await load_table_name();
            await load_users();
            return true;
        }

        public static void sorted_table_name()
        {
            if (table.Count > 1)
            {
                tableName.Clear();
                for (int i = 1; i < table.Count; i += 3)
                {
                    tableName.Add(table[i].Split('_')[0]);
                    Console.WriteLine(table[i].Split('_')[0]);
                }
            }
        }

        private async static Task<bool> load_table_name()
        {
            try
            {
                table.Clear();
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    await connection.OpenAsync();
                    string query = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES";

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = await command.ExecuteReaderAsync();

                    if (reader.HasRows)
                    {
                        while (await reader.ReadAsync())
                        {
                            table.Add(reader.GetString(0));
                        }
                    }
                    reader.Close();
                }
                sorted_table_name();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return true;
        }

        private async static Task<bool> load_users()
        {
            try
            {
                users.Clear();
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    await connection.OpenAsync();
                    string query = "SELECT Login FROM Users";

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = await command.ExecuteReaderAsync();

                    if (reader.HasRows)
                    {
                        while (await reader.ReadAsync())
                        {
                            users.Add(reader.GetString(0));
                        }
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return true;
        }

        public async static Task authorization(string login, string password)
        {
            try
            {
                if (login == "" || password == "")
                {
                    MessageBox.Show("Заполните поля");
                }
                else
                {
                    using (SqlConnection connection = new SqlConnection(connString))
                    {
                        await connection.OpenAsync();

                        string query = String.Format("select * from Users where Login = '{0}' and Password = '{1}'", login, password);
                        SqlCommand command = new SqlCommand(query, connection);
                        SqlDataReader reader = await command.ExecuteReaderAsync();
                        if (reader.HasRows)
                        {
                            mainForm.open_child_form(new admin(mainForm));
                        }
                        else
                        {
                            MessageBox.Show("Неправильный логин или пароль");
                        }
                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        

        public async static Task search(string library, string request, DataGridView dataGridView)
        {
            try
            {
                string query;
                List<string> table = new List<string>();

                if (library == "")
                    MessageBox.Show("Выберите мастерскую");
                else if (request == "")
                    MessageBox.Show("Введите запрос");
                else
                {
                    dataGridView.Rows.Clear();
                    int rowNumber;
                    using (SqlConnection connection = new SqlConnection(connString))
                    {
                        await connection.OpenAsync();

                        for (int i = 0; i < 3; i++)
                        {
                            query = $@"select name,description,quantity from [{library}_{categories[i]}] where concat(name,description,quantity) like '%{request}%'";
                            SqlCommand command = new SqlCommand(query, connection);
                            SqlDataReader reader = await command.ExecuteReaderAsync();

                            if (reader.HasRows)
                            {
                                while (await reader.ReadAsync())
                                {
                                    rowNumber = dataGridView.Rows.Add();
                                    dataGridView.Rows[rowNumber].Cells[0].Value = reader.GetValue(0);
                                    dataGridView.Rows[rowNumber].Cells[1].Value = reader.GetValue(1);
                                    dataGridView.Rows[rowNumber].Cells[2].Value = reader.GetValue(2);
                                }
                            }
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public async static Task add_auditory(TextBox textBox, ComboBox comboBox)
        {
            try
            {
                if (!tableName.Contains(textBox.Text))
                {
                    string table_name;
                    string query;
                    using (SqlConnection connection = new SqlConnection(connString))
                    {
                        await connection.OpenAsync();

                        foreach (string name in categories)
                        {
                            table_name = textBox.Text + "_" + name;
                            query = String.Format("CREATE TABLE [dbo].[{0}] ( [Id] INT NOT NULL PRIMARY KEY IDENTITY, [name] NVARCHAR(256) NOT NULL, [description] NVARCHAR(1024) NULL, [quantity] NCHAR(10) NULL)", table_name);

                            SqlCommand command = new SqlCommand(query, connection);
                            await command.ExecuteNonQueryAsync();
                        }
                    }
                    bool load = await load_table_name();
                    if (load)
                        load_combo_box(comboBox);

                }
                else
                    MessageBox.Show("Данная аудитория уже существует");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static void load_combo_box(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            foreach(string name in tableName)
            {
                comboBox.Items.Add(name);
            }
        }

        public static void load_combo_box_users(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            foreach (string name in users)
            {
                comboBox.Items.Add(name);
            }
        }

        public async static Task delete_auditory(string auditory, ComboBox comboBox)
        {
            try 
            {
                if (auditory != "")
                {
                    string table_name;
                    string query;
                    using (SqlConnection connection = new SqlConnection(connString))
                    {
                        await connection.OpenAsync();

                        foreach (string name in categories)
                        {
                            table_name = auditory + "_" + name;
                            query = String.Format("drop table [{0}]", table_name);

                            SqlCommand command = new SqlCommand(query, connection);
                            await command.ExecuteNonQueryAsync();
                        }
                    }
                    tableName.Remove(auditory);
                    load_combo_box(comboBox);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public async static Task delete_user(string user, ComboBox comboBox)
        {
            try
            {
                if (user != "" && users.Count > 1)
                {
                    using (SqlConnection connection = new SqlConnection(connString))
                    {
                        await connection.OpenAsync();

                        string query = String.Format("delete from Users where Login = '{0}'", user);

                        SqlCommand command = new SqlCommand(query, connection);
                        await command.ExecuteNonQueryAsync();
                    }
                    users.Remove(user);
                    load_combo_box_users(comboBox);
                }
                else
                    MessageBox.Show("нельзя удалить последнего пользователя");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public async static Task<bool> add_user(string login, string password,  ComboBox comboBox)
        {
            try
            {
                if (login != "" && password != "" && !users.Contains(login))
                {
                    using (SqlConnection connection = new SqlConnection(connString))
                    {
                        await connection.OpenAsync();

                        string query = String.Format("insert into Users (Login, Password) values ('{0}', '{1}')", login, password);

                        SqlCommand command = new SqlCommand(query, connection);
                        await command.ExecuteNonQueryAsync();
                    }
                    users.Add(login);
                    load_combo_box_users(comboBox);
                    return true;
                }
                else if (users.Contains(login))
                {
                    MessageBox.Show("данный пользователь уже существует");
                    return false;
                }
                else
                {
                    MessageBox.Show("введите логин или пароль");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }

        }

        public async static Task<bool> load_table(string category, DataGridView dataGridView)
        {

            try
            {
                connection_workshop = new SqlConnection(connString);
                await connection_workshop.OpenAsync();

                string query = String.Format("select * from [{0}]", mainForm.selected_auditory_cb.Text + "_" + category);
                adapter_workshop = new SqlDataAdapter(query, connection_workshop);
                set_workshop = new DataSet();
                adapter_workshop.Fill(set_workshop);

                string sql = String.Format("update [{0}] set name=@name, description=@description, quantity=@quantity", mainForm.selected_auditory_cb.Text + "_" + category);

                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter_workshop);

                dataGridView.DataSource = set_workshop.Tables[0];
                dataGridView.Columns[0].Width = 70;
                dataGridView.Columns[0].ReadOnly = true;
                dataGridView.Columns[1].Width = 120;
                dataGridView.Columns[3].Width = 70;
                dataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
                ((DataGridViewTextBoxColumn)dataGridView.Columns[1]).MaxInputLength = 256;
                ((DataGridViewTextBoxColumn)dataGridView.Columns[2]).MaxInputLength = 1024;
                ((DataGridViewTextBoxColumn)dataGridView.Columns[3]).MaxInputLength = 10;
                connection_workshop.Close();
                return true;
            }
            catch (Exception ex)
            {
                connection_workshop.Close();
                MessageBox.Show(ex.ToString());
                return false;
            }

        }
        public async static Task save_changed()
        {
            await connection_workshop.OpenAsync();
            adapter_workshop.Update(set_workshop);
            connection_workshop.Close();
        }
        public async static Task delete_changed(DataGridView dataGridView)
        {
            try
            {
                await connection_workshop.OpenAsync();

                foreach (DataGridViewRow row in dataGridView.SelectedRows)
                {
                    dataGridView.Rows.RemoveAt(row.Index);
                }

                connection_workshop.Close();

                await save_changed();
            }
            catch
            {
                connection_workshop.Close();
            }
        }

    }

    #endregion
}
