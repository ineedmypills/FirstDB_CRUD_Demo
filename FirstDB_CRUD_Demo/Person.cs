using System;

namespace FirstDB_CRUD_Demo
{
    public class Person
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string ContactData { get; set; }

        public Person(int id, string surname, string name, DateTime birthDate, string contactData)
        {
            Id = id;
            Surname = surname;
            Name = name;
            BirthDate = birthDate;
            ContactData = contactData;
        }
    }
}
