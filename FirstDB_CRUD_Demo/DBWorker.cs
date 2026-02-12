using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace FirstDB_CRUD_Demo
{
    public class DBWorker
    {
        private readonly string connectionString;

        public DBWorker(string dbFilename)
        {
            connectionString = $"Data Source={dbFilename};";
            InitTable();
        }

        private void InitTable()
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "CREATE TABLE IF NOT EXISTS Students (" +
                               "Id INTEGER PRIMARY KEY AUTOINCREMENT, " +
                               "Surname TEXT, " +
                               "Name TEXT, " +
                               "BirthDate TEXT, " +
                               "ContactData TEXT);";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Person> GetAllStudents()
        {
            var students = new List<Person>();
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Students";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            students.Add(new Person(
                                Convert.ToInt32(reader["Id"]),
                                reader["Surname"].ToString(),
                                reader["Name"].ToString(),
                                Convert.ToDateTime(reader["BirthDate"]),
                                reader["ContactData"].ToString()
                            ));
                        }
                    }
                }
            }
            return students;
        }

        public void AddStudent(Person person)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Students (Surname, Name, BirthDate, ContactData) " +
                               "VALUES (@Surname, @Name, @BirthDate, @ContactData)";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Surname", person.Surname);
                    cmd.Parameters.AddWithValue("@Name", person.Name);
                    cmd.Parameters.AddWithValue("@BirthDate", person.BirthDate.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@ContactData", person.ContactData);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateStudent(Person person)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Students SET Surname = @Surname, Name = @Name, " +
                               "BirthDate = @BirthDate, ContactData = @ContactData WHERE Id = @Id";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", person.Id);
                    cmd.Parameters.AddWithValue("@Surname", person.Surname);
                    cmd.Parameters.AddWithValue("@Name", person.Name);
                    cmd.Parameters.AddWithValue("@BirthDate", person.BirthDate.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@ContactData", person.ContactData);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteStudent(int id)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Students WHERE Id = @Id";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
