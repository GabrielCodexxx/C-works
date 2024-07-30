using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationApplication
{
    public partial class frmStudentRegistration : Form
    {
        private string selectedProgram;

        public frmStudentRegistration()
        {
            InitializeComponent();
            InitializeComboBoxes();
            InitializeProgramComboBox();
        }
        private void InitializeComboBoxes()
        {
            for (int i = 1; i <= 31; i++)
            {
                cbDay.Items.Add(i);
            }

            for (int i = 1; i <= 12; i++)
            {
                cbMonth.Items.Add(i);
            }

            int currentYear = DateTime.Now.Year;
            for (int i = 1900; i <= currentYear; i++)
            {
                cbYear.Items.Add(i);
            }
        }
        private void frmStudentRegistration_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtMiddleName.Text))
            {
                MessageBox.Show("Please enter all names.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!rbMale.Checked && !rbFemale.Checked)
            {
                MessageBox.Show("Please select a gender.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbDay.SelectedItem == null || cbMonth.SelectedItem == null || cbYear.SelectedItem == null)
            {
                MessageBox.Show("Please select a date of birth.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string lastName = txtLastName.Text;
            string firstName = txtFirstName.Text;
            string middleName = txtMiddleName.Text;
            string gender = rbMale.Checked ? "Male" : "Female";
            int day, month, year;
            string selectedProgram = cbCourse.SelectedItem.ToString();

            if (!int.TryParse(cbDay.SelectedItem.ToString(), out day) ||
                !int.TryParse(cbMonth.SelectedItem.ToString(), out month) ||
                !int.TryParse(cbYear.SelectedItem.ToString(), out year))
            {
                MessageBox.Show("Error parsing date of birth.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Call overloaded methods to display student information in MessageBoxes
            Task.Run(() => DisplayStudentInfo(firstName, middleName, lastName, gender, day, month, year, selectedProgram));
            Task.Run(() => DisplayStudentInfo(firstName, middleName, lastName, selectedProgram));
            Task.Run(() => DisplayStudentInfo(firstName, lastName, selectedProgram));
        }

        // Overloaded method to display complete student information
        private void DisplayStudentInfo(string firstName, string middleName, string lastName, string gender, int day, int month, int year, string selectedProgram)
        {
            string studentInfo = $"Student Information:\n" +
                                 $"Full Name: {firstName} {middleName} {lastName}\n" +
                                 $"Gender: {gender}\n" +
                                 $"Date of Birth: {day}/{month}/{year}\n" +
                                 $"Program: {selectedProgram}";

            MessageBox.Show(studentInfo, "Student Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Overloaded method to display student information without gender and date of birth
        private void DisplayStudentInfo(string firstName, string middleName, string lastName, string selectedProgram)
        {
            string studentInfo = $"Student Information:\n" +
                                 $"Full Name: {firstName} {middleName} {lastName}\n" +
                                 $"Program: {selectedProgram}";

            MessageBox.Show(studentInfo, "Student Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Overloaded method to display student information with only first name and last name
        private void DisplayStudentInfo(string firstName, string lastName, string selectedProgram)
        {
            string studentInfo = $"Student Information:\n" +
                                 $"Full Name: {firstName} {lastName}\n" +
                                 $"Program: {selectedProgram}";

            MessageBox.Show(studentInfo, "Student Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void InitializeProgramComboBox()
        {
            string[] programs = {
                "Bachelor of Science in Computer Science",
                "Bachelor of Science in Information Technology",
                "Bachelor of Science in Information Systems",
                "Bachelor of Science in Computer Engineering"
            };

            foreach (string program in programs)
            {
                cbCourse.Items.Add(program);
            }
        }


        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProgram = cbCourse.SelectedItem.ToString();
            MessageBox.Show($"You Selected {selectedProgram}");
        }

        private void cbDay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addPictureBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "JPEG Images (*.jpeg)|*.jpeg|PNG Images (*.png)|*.png";
                string imagePath = "";

            if(dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    addPicture_imageView.ImageLocation = imagePath;
                }  
            }catch(Exception ex)
            {
                MessageBox.Show("ERROR: " + ex,"ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void addPicture_imageView_Click(object sender, EventArgs e)
        {

        }
    }
}
