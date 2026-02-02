using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDB_CRUDDEmo
{
    internal class Person
    {
        int id;
        string name;
        int age;
        public int Id { get { return id; } }
        public string Name { get { return name; } }
        public int Age { get { return age; } }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public override string ToString()
        {
            return $"{name}, {age}";
        }
        public string ToString(string format)
        {
            if (format == "/")
            {
                return $"{name}/{age}";
            }
            else return this.ToString();
            //var tmp = DateTime.Now.ToString("yyyy-MM-dd");
        }
        public void SetId(int id)
        {
            this.id = id;
        }
    }
}
