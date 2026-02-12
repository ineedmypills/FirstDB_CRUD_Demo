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
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            dbWorker = new DBWorker(dbFilenameTextBox.Text);
            LoadStudents();
        }

        private void LoadStudents()
        {
            studentsDataGridView.DataSource = dbWorker.GetAllStudents();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var person = new Person(0, surnameTextBox.Text, nameTextBox.Text, birthDateTimePicker.Value, contactDataTextBox.Text);
            dbWorker.AddStudent(person);
            LoadStudents();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (studentsDataGridView.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(studentsDataGridView.SelectedRows[0].Cells["Id"].Value);
                var person = new Person(selectedId, surnameTextBox.Text, nameTextBox.Text, birthDateTimePicker.Value, contactDataTextBox.Text);
                dbWorker.UpdateStudent(person);
                LoadStudents();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (studentsDataGridView.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(studentsDataGridView.SelectedRows[0].Cells["Id"].Value);
                dbWorker.DeleteStudent(selectedId);
                LoadStudents();
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
    }
}
