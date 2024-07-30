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
using System.IO;

namespace InventoryManagementSystem_POS_
{
    public partial class AdminAddProducts : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(localdb)\POS;Initial Catalog=POS;Integrated Security=True");
        public AdminAddProducts()
        {
            InitializeComponent();
            displayCategories();
            displayAllProducts();
        }
        public void displayAllProducts() 
            {
                AddProductsData apData = new AddProductsData();
                List<AddProductsData> listData = apData.AllProductsData();
                    dataGridView1.DataSource = listData;

       
            } 

        private void AdminAddProducts_Load(object sender, EventArgs e)
        {

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

        public bool checkEmptyFields()
        {
            if(addProducts_prodID.Text == "" || addProducts_prodName.Text == "" || addProducts_category.SelectedIndex == -1
               || addProducts_price.Text == "" || addProducts_stock.Text == "" || addProducts_status.SelectedIndex == -1 ||
               addProducts_imageView.Image == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public void displayCategories()
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM categories";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                addProducts_category.Items.Add(reader["category"].ToString());
                            }
                        }


                    }
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    connect.Close();
                }
            }
        }
        private void addProducts_addBtn_Click(object sender, EventArgs e)
        {
            if (checkEmptyFields())
            {
                MessageBox.Show("EMPTY FIELDS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            string connectionString = @"Data Source=(localdb)\POS;Initial Catalog=POS;Integrated Security=True;";
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM products WHERE prod_id = @prodID";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@prodID", addProducts_prodID.Text.Trim());
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            MessageBox.Show("PRODUCT ID: " + addProducts_prodID.Text.Trim() + " IS ALREADY EXIST", "ERROR",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                            string relativePath = Path.Combine("Products_Directory", addProducts_prodID.Text.Trim() + ".jpeg");
                            string path = Path.Combine(baseDirectory, relativePath);
                            string directoryPath = Path.GetDirectoryName(path);
                            if (!Directory.Exists(directoryPath))
                            {
                                Directory.CreateDirectory(directoryPath);
                            }

                            if (!string.IsNullOrEmpty(addProducts_imageView.ImageLocation) && File.Exists(addProducts_imageView.ImageLocation))
                            {
                                File.Copy(addProducts_imageView.ImageLocation, path, true);

                                string insertData = "INSERT INTO products " +
                                    "(prod_id, prod_name, category, price, stock, image_path, status, date_insert)" +
                                        "VALUES(@prodID, @prodName, @cat, @price, @stock, @path, @status, @date)";

                                using (SqlCommand insertD = new SqlCommand(insertData, connect))
                                {
                                    insertD.Parameters.AddWithValue("@prodID", addProducts_prodID.Text.Trim());
                                    insertD.Parameters.AddWithValue("@prodName", addProducts_prodName.Text.Trim());
                                    insertD.Parameters.AddWithValue("@cat", addProducts_category.SelectedItem);
                                    insertD.Parameters.AddWithValue("@price", addProducts_price.Text.Trim());
                                    insertD.Parameters.AddWithValue("@stock", addProducts_stock.Text.Trim());
                                    insertD.Parameters.AddWithValue("@path", path);
                                    insertD.Parameters.AddWithValue("@status", addProducts_status.SelectedItem);
                                    insertD.Parameters.AddWithValue("@date", DateTime.Today);

                                    insertD.ExecuteNonQuery();
                                    clearFields();
                                    MessageBox.Show("ADDED SUCCESSFULLY", "INFORMATION MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid image location", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void addProducts_importBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "JPEG Images (*.jpeg)|*.jpeg|PNG Images (*.png)|*.png";
                string imagePath = "";

            if(dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    addProducts_imageView.ImageLocation = imagePath;
                }  
            }catch(Exception ex)
            {
                MessageBox.Show("ERROR: " + ex,"ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }


        public void clearFields()
        {
            addProducts_prodID.Text = "";
            addProducts_prodName.Text = "";
            addProducts_category.SelectedIndex = -1;
            addProducts_price.Text = "";
            addProducts_stock.Text = "";
            addProducts_status.SelectedIndex = -1;
            addProducts_imageView.Image = null;
        }
        private void addProducts_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }


        private int getID = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           if(e.RowIndex != 1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getID = (int)row.Cells[0].Value;

                addProducts_prodID.Text = row.Cells[1].Value.ToString();
                addProducts_prodName.Text = row.Cells[2].Value.ToString();
                addProducts_category.Text = row.Cells[3].Value.ToString();
                addProducts_price.Text = row.Cells[4].Value.ToString();
                addProducts_stock.Text = row.Cells[5].Value.ToString();

                string imagepath = row.Cells[6].Value.ToString();
                try
                {
                    if(imagepath != null)
                    {
                        addProducts_imageView.Image = Image.FromFile(imagepath);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR IMAGE: " + ex, "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                {

                }
                
                addProducts_status.Text = row.Cells[7].Value.ToString();

            }
        }
    }
}
