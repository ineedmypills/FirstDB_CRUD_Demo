using System;
using System.Windows.Forms;

namespace FirstDB_CRUD_Demo
{
    public partial class Form1 : Form
    {
        private DBWorker dbWorker;

        public Form1()
        {
            InitializeComponent();
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text = "Student Database";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = new System.Drawing.Size(500, 600);
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            try
            {
                dbWorker = new DBWorker(dbFilenameTextBox.Text);
                LoadStudents();
                MessageBox.Show("Successfully connected to the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to the database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadStudents()
        {
            try
            {
                studentsDataGridView.DataSource = dbWorker.GetAllStudents();
                studentsDataGridView.Columns["Id"].Visible = false;
                studentsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading students: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (dbWorker == null)
            {
                MessageBox.Show("Please connect to the database first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var person = new Person(0, surnameTextBox.Text, nameTextBox.Text, birthDateTimePicker.Value, contactDataTextBox.Text);
                dbWorker.AddStudent(person);
                LoadStudents();
                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding student: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (dbWorker == null)
            {
                MessageBox.Show("Please connect to the database first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (studentsDataGridView.SelectedRows.Count > 0)
            {
                try
                {
                    int selectedId = Convert.ToInt32(studentsDataGridView.SelectedRows[0].Cells["Id"].Value);
                    var person = new Person(selectedId, surnameTextBox.Text, nameTextBox.Text, birthDateTimePicker.Value, contactDataTextBox.Text);
                    dbWorker.UpdateStudent(person);
                    LoadStudents();
                    ClearInputFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating student: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a student to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dbWorker == null)
            {
                MessageBox.Show("Please connect to the database first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (studentsDataGridView.SelectedRows.Count > 0)
            {
                try
                {
                    int selectedId = Convert.ToInt32(studentsDataGridView.SelectedRows[0].Cells["Id"].Value);
                    dbWorker.DeleteStudent(selectedId);
                    LoadStudents();
                    ClearInputFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting student: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a student to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void StudentsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (studentsDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = studentsDataGridView.SelectedRows[0];
                surnameTextBox.Text = selectedRow.Cells["Surname"].Value.ToString();
                nameTextBox.Text = selectedRow.Cells["Name"].Value.ToString();
                birthDateTimePicker.Value = Convert.ToDateTime(selectedRow.Cells["BirthDate"].Value);
                contactDataTextBox.Text = selectedRow.Cells["ContactData"].Value.ToString();
            }
        }

        private void ClearInputFields()
        {
            surnameTextBox.Clear();
            nameTextBox.Clear();
            birthDateTimePicker.Value = DateTime.Now;
            contactDataTextBox.Clear();
        }
    }
}
