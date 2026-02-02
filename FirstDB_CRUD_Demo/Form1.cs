using FirstDB_CRUDDEmo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FirstDB_CRUD_Demo
{
    public partial class Form1 : Form
    {
        DBWorker storage;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBWorker storage = new DBWorker(tb_dbFilename.Text);
            storage.InitQuery();
            this.storage = storage;
        }

        private void f_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            int age;
            if (int.TryParse(tb_age.Text, out age))
            {
                Person person = new Person(tb_name.Text, age);
                storage.AddData(person);
            }
            else
            {
                MessageBox.Show($"Возраст {tb_age} некорректен");
            }
        }

        private void tb_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_age_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
