using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace InventoryManagementSystem_POS_
{
    internal class AddProductsData
    {
        public int ID { get; set; }
        public string ProdID { get; set; }
        public string ProdName { get; set; }
        public string Category { get; set; }
        public string Price { get; set; }
        public string Stock { get; set; }
        public string ImagePath { get; set; }
        public string Status { get; set; }
        public DateTime Date { get; set; }

        public List<AddProductsData> AllProductsData()
        {
            List<AddProductsData> ListData = new List<AddProductsData>();

            using (SqlConnection connect = new SqlConnection(@"Data Source=(localdb)\POS;Initial Catalog=POS;Integrated Security=True"))
            {
                connect.Open();
                string selectData = "SELECT * FROM products";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            AddProductsData apData = new AddProductsData();
                            apData.ID = (int)reader["id"];
                            apData.ProdID = reader["prod_id"].ToString();
                            apData.ProdName = reader["prod_name"].ToString();
                            apData.Category = reader["category"].ToString();
                            apData.Price = reader["price"].ToString();
                            apData.Stock = reader["stock"].ToString();
                            apData.ImagePath = reader["image_path"].ToString();
                            apData.Status = reader["status"].ToString();

                            // Handle nullable DateTime
                            if (!reader.IsDBNull(reader.GetOrdinal("date")))
                            {
                                // Attempt to parse DateTime value
                                if (DateTime.TryParse(reader["date"].ToString(), out DateTime date))
                                {
                                    apData.Date = date;
                                }
                                else
                                {
                                    // Log or handle parsing failure
                                    // For now, assign a default value
                                    apData.Date = DateTime.MinValue;
                                }
                            }
                            else
                            {
                                // If column is null, assign a default value
                                apData.Date = DateTime.MinValue;
                            }

                            ListData.Add(apData);
                        }
                    }
                }
            }
            return ListData;
        }
    }
}