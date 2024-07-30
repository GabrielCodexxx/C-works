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
    public partial class Form1 : Form
    {
        private SqlConnection connect;

        public Form1()
        {
            InitializeComponent();
            connect = new SqlConnection(@"Data Source=(localdb)\POS;Initial Catalog=POS;Integrated Security=True");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM POS WHERE username = @usern AND password = @pass";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@usern", login_username.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", login_password.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            MessageBox.Show("LOGIN SUCCESSFULLY!", "INFORMATION MESSAGE",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            MainForm mainForm = new MainForm();
                            mainForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("INCORRECT USERNAME/PASSWORD OR THERE IS NO ADMIN'S APPROVAL", "ERROR MESSAGE",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("CONNECTION FAILED: " + ex.Message, "ERROR MESSAGE",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        public bool checkConnection()
        {
            return connect.State == ConnectionState.Closed;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showpassword.Checked ? '\0' : '*';
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
