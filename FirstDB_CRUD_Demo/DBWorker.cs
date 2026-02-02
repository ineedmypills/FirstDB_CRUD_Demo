using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace FirstDB_CRUDDEmo
{
    internal class DBWorker
    {
        string dbFilename;
        string connString;
        public string DbFilename { get { return dbFilename; } }
        private SQLiteDataReader MakeQuery(string query)
        {
            SQLiteDataReader result = null;
            using (SQLiteConnection conn =
                new SQLiteConnection(connString))
            {
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                result = cmd.ExecuteReader();
            }
            return result;
        }
        public DBWorker(string dbFilename)
        {
            this.dbFilename = dbFilename;
        }
        public void InitQuery()
        {
            string query = "CREATE TABLE IF NOT EXISTS Persons " +
                "(id INTEGER Primary KEY AUTOINCREMENT," +
                "Name VARCHAR, Age INTEGER);";
            string connString = $"Data Source = {dbFilename};";
            this.connString = connString;
            using (SQLiteConnection conn =
                new SQLiteConnection(connString))
            {
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.ExecuteNonQuery();

            }
        }
        public void AddData(Person person)
        {
            string query = $"INSERT INTO Persons (Name, Age)" +
                $" VALUES ('{person.Name}', {person.Age});";
            MakeQuery(query);
        }
    }
}
