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

namespace InventoryManagementSystem_POS_
{
    public partial class RegisterForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(localdb)\POS;Initial Catalog=POS;Integrated Security=True");

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void register_label_Click(object sender, EventArgs e)
        {
            Form1 loginform = new Form1();
            loginform.Show();

            this.Hide();
        }

        private void signup_button_Click(object sender, EventArgs e)
        {
            if (register_username.Text == "" || register_password.Text == "" || register_cpassword.Text == "")
            {
                MessageBox.Show("PLEASE FILL ALL EMPTY FIELDS", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            cmd.Parameters.AddWithValue("@usern", register_username.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd); 
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show(register_username.Text.Trim() + " IS ALREADY TAKEN", "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (register_password.Text.Length < 8)
                            {
                                MessageBox.Show("INVALID PASSWORD, AT LEAST 8 CHARACTERS ARE NEEDED",
                                    "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (register_password.Text.Trim() != register_cpassword.Text.Trim())
                            {
                                MessageBox.Show("PASSWORDS DO NOT MATCH.",
                                    "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            } 
                            else
                            {
                                string insertData = "INSERT INTO POS(username, password, role, status, date) VALUES(@usern, @pass, @role, @status, @date)";

                                using (SqlCommand insertD = new SqlCommand(insertData, connect))
                                {
                                    insertD.Parameters.AddWithValue("@usern", register_username.Text.Trim());
                                    insertD.Parameters.AddWithValue("@pass", register_password.Text.Trim());
                                    insertD.Parameters.AddWithValue("@role", "Cashier");
                                    insertD.Parameters.AddWithValue("@status", "Approval");

                                    DateTime today = DateTime.Today;
                                    insertD.Parameters.AddWithValue("@date", today);

                                    insertD.ExecuteNonQuery();

                                    MessageBox.Show("REGISTERED SUCCESSFULLY!",
                                        "INFORMATION MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Form1 loginForm = new Form1();
                                    loginForm.Show();

                                    this.Hide();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("CONNECTION FAILED: " + ex.Message,
                                            "ERROR MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            register_password.PasswordChar = register_showpassword.Checked ? '\0' : '*';
            register_cpassword.PasswordChar = register_showpassword.Checked ? '\0' : '*';
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
