﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InventoryManagementSystem_POS_
{
    public partial class AdminAddCategories : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(localdb)\POS;Initial Catalog=POS;Integrated Security=True");
        public AdminAddCategories()
        {
            InitializeComponent();
            displayCategoriesData();
        }
        public void displayCategoriesData()
        {
            CategoriesData cData = new CategoriesData();
            List<CategoriesData> listData = cData.AllCategoriesData();

            dataGridView1.DataSource = listData;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addUsers_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void addCategories_addBtn_Click(object sender, EventArgs e)
        {
            if (addCategories_category.Text == "")
            {
                MessageBox.Show("EMPTY FIELDS", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();
                        string checkCat = "SELECT * FROM categories WHERE category = @cat";
                        using (SqlCommand cmd = new SqlCommand(checkCat, connect))
                        {
                            cmd.Parameters.AddWithValue("@cat", addCategories_category.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd); 
                            DataTable table = new DataTable();

                            adapter.Fill(table);
                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show("CATEGORY " + addCategories_category.Text.Trim() + " ALREADY EXISTS", "ERROR MESSAGE",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO categories (category, date) VALUES (@cat, @date)";
                                using (SqlCommand insertD = new SqlCommand(insertData, connect))
                                {
                                    insertD.Parameters.AddWithValue("@cat", addCategories_category.Text.Trim());
                                    DateTime today = DateTime.Today;
                                    insertD.Parameters.AddWithValue("@date", today);
                                    insertD.ExecuteNonQuery();
                                    clearFields();
                                    displayCategoriesData();
                                    MessageBox.Show("ADDED SUCCESSFULLY", "INFORMATION MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("CONNECTION FAILED: " + ex.Message, "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public void clearFields()
        {
            addCategories_category.Text = "";
        }
        private void addCategories_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private int getID = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                getID = (int)row.Cells[0].Value;
                addCategories_category.Text = row.Cells[1].Value.ToString();
            }
        }

        private void addCategories_updateBtn_Click(object sender, EventArgs e)
        {
            if (addCategories_category.Text == "")
            {
                MessageBox.Show("EMPTY FIELDS", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {   if(MessageBox.Show("ARE YOU SURE YOU WANT TO UPDATE CATEGORY ID: " + getID + 
                "?", "CONFIRMATION MESSAGE", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();

                            string updateData = "UPDATE categories SET category = @cat WHERE id = @id";
                            using (SqlCommand insertD = new SqlCommand(updateData, connect))
                            {
                                insertD.Parameters.AddWithValue("@cat", addCategories_category.Text.Trim());
                                insertD.Parameters.AddWithValue("@id", getID);
                                insertD.ExecuteNonQuery();
                                clearFields();
                                displayCategoriesData();
                                MessageBox.Show("UPDATE SUCCESSFULLY", "INFORMATION MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }


                        catch (Exception ex)
                        {
                            MessageBox.Show("CONNECTION FAILED: " + ex.Message, "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
                
            }
        }

        private void addCategories_removeBtn_Click(object sender, EventArgs e)
        {
            if (addCategories_category.Text == "")
            {
                MessageBox.Show("EMPTY FIELDS", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("ARE YOU SURE YOU WANT TO REMOVE CATEGORY ID: " + getID +
                "?", "CONFIRMATION MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();

                            string removeData = "DELETE FROM categories WHERE id = @id";
                            using (SqlCommand deleteD = new SqlCommand(removeData, connect))
                            {
                                deleteD.Parameters.AddWithValue("@cat", addCategories_category.Text.Trim());
                                deleteD.Parameters.AddWithValue("@id", getID);
                                deleteD.ExecuteNonQuery();
                                clearFields();
                                displayCategoriesData();
                                MessageBox.Show("DELETED SUCCESSFULLY", "INFORMATION MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }


                        catch (Exception ex)
                        {
                            MessageBox.Show("CONNECTION FAILED: " + ex.Message, "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
