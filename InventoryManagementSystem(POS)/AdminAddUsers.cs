using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace InventoryManagementSystem_POS_
{
    public partial class AdminAddUsers : UserControl
    {

        SqlConnection connect = new SqlConnection(@"Data Source=(localdb)\POS;Initial Catalog=POS;Integrated Security=True");

        public void dispplayAllUsersData()
        {
            UsersData uData = new UsersData();

            List<UsersData> listData = uData.AllUsersData();

            dataGridView1.DataSource = listData;
        }

        public AdminAddUsers()
        {
            InitializeComponent();
            dispplayAllUsersData();
            dataGridView1.CellClick += dataGridView1_CellClick;

        }

        private void addUsers_addBtn_Click(object sender, EventArgs e)
        {
            if (addUsers_username.Text == "" || addUsers_password.Text ==
                "" || addUsers_role.SelectedIndex == -1 || addUsers_status.SelectedIndex == -1)
            {
                MessageBox.Show("ENPTY FIELDS", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();
                        string checkUsername = "SELECT * FROM POS WHERE username = @usern";

                        using (SqlCommand cmd = new SqlCommand(checkUsername, connect))
                        {
                            cmd.Parameters.AddWithValue("@usern", addUsers_username.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show(addUsers_username.Text.Trim() + " IS ALREADY TAKEN", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO POS (username, password, role, status, date)" + "VALUES(@usern, @password, @role, @status, @date)";


                                using (SqlCommand insertD = new SqlCommand(insertData, connect))
                                {
                                    insertD.Parameters.AddWithValue("@usern", addUsers_username.Text.Trim());
                                    insertD.Parameters.AddWithValue("@password", addUsers_password.Text.Trim());
                                    insertD.Parameters.AddWithValue("@role", addUsers_role.Text.Trim());
                                    insertD.Parameters.AddWithValue("@status", addUsers_status.Text.Trim());

                                    DateTime today = DateTime.Today;
                                    insertD.Parameters.AddWithValue("@date", today);

                                    insertD.ExecuteNonQuery();
                                    clearFields();
                                    dispplayAllUsersData();
                                    dataGridView1.Refresh();
                                    MessageBox.Show("ADDED SUCCESSFULLY", "INFORMATION MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                }


                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("CONNECTION FAILED: " + ex, "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        public bool checkConnection()
        {
            if (connect.State == ConnectionState.Closed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void AdminAddUsers_Load(object sender, EventArgs e)
        {

        }

        public void clearFields()
        {
            addUsers_username.Text = "";
            addUsers_password.Text = "";
            addUsers_role.SelectedIndex = -1;
            addUsers_status.SelectedIndex = -1;
        }
        private void addUsers_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void addUsers_updateBtn_Click(object sender, EventArgs e)
        {
            if (addUsers_username.Text == "" || addUsers_password.Text == "" || addUsers_role.SelectedIndex == -1 || addUsers_status.SelectedIndex == -1)
            {
                MessageBox.Show("ENPTY FIELDS", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("ARE YOU SURE YOU WANT TO UPDATE USER ID: " + getID + "?", "CONFIRMATION MESSAGE",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();

                            string updateData = "UPDATE POS SET username = @usern, " +
                                "password = @password, role = @role, status = @status  WHERE id = @id";

                            using (SqlCommand updateD = new SqlCommand(updateData, connect))
                            {
                                updateD.Parameters.AddWithValue("@usern", addUsers_username.Text.Trim());
                                updateD.Parameters.AddWithValue("@password", addUsers_password.Text.Trim());
                                updateD.Parameters.AddWithValue("@role", addUsers_role.SelectedItem);
                                updateD.Parameters.AddWithValue("@status", addUsers_status.SelectedItem);
                                updateD.Parameters.AddWithValue("@id", getID);

                                updateD.ExecuteNonQuery();
                                clearFields();
                                dispplayAllUsersData();
                                MessageBox.Show("UPDATED SUCCESSFULLY", "INFORMATION MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("CONNECTION FAILED: " + ex, "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
            }
        }

        private int getID = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getID = Convert.ToInt32(row.Cells["id"].Value); 

                string username = row.Cells["username"].Value.ToString();
                string password = row.Cells["password"].Value.ToString();
                string role = row.Cells["role"].Value.ToString();
                string status = row.Cells["status"].Value.ToString();

                addUsers_username.Text = username;
                addUsers_password.Text = password;
                addUsers_role.Text = role;
                addUsers_status.Text = status;
            }
        }

        private void addUsers_removeBtn_Click(object sender, EventArgs e)
        {
            if (addUsers_username.Text == "" || addUsers_password.Text == "" || addUsers_role.SelectedIndex == -1 || addUsers_status.SelectedIndex == -1)
            {
                MessageBox.Show("ENPTY FIELDS", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("ARE YOU SURE YOU WANT TO REMOVE USER ID: " + getID + "?", "CONFIRMATION MESSAGE",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();

                        string deleteData = "DELETE FROM POS WHERE id = @id";

                        using (SqlCommand deleteD = new SqlCommand(deleteData, connect))
                        {
                            deleteD.Parameters.AddWithValue("@id", getID);

                            int rowsAffected = deleteD.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                clearFields();

                                dispplayAllUsersData();

                                MessageBox.Show("REMOVE SUCCESSFULLY", "INFORMATION MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No user found with ID: " + getID, "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error while removing user: " + ex.Message, "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }
        }
    }
