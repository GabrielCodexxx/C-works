using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace InventoryManagementSystem_POS_
{
    internal class CategoriesData
    {

        public int ID { set; get; }
        public string Catergory { set; get; }
        public string Date { set; get; }
        public List<CategoriesData> AllCategoriesData()
        {
            List<CategoriesData> ListData = new List<CategoriesData>();

            using (SqlConnection connect = new SqlConnection(@"Data Source=(localdb)\POS;Initial Catalog=POS;Integrated Security=True"))
            {
                connect.Open();
                string selectData = "SELECT * FROM categories";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        CategoriesData cData = new CategoriesData();
                        cData.ID = (int)reader["id"];
                        cData.Catergory = reader["category"].ToString();
                        cData.Date = reader["date"].ToString();
                        ListData.Add(cData);
                    }


                }

            }
            return ListData;
        }
    }
}
