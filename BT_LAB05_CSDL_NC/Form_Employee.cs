using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Db4objects.Db4o;
using Db4objects.Db4o.Linq;

namespace BT_LAB05_CSDL_NC
{
    public partial class Form_Employee : Form
    {
        IObjectContainer db = null;
        IObjectSet result = null;

        public Form_Employee()
        {
            InitializeComponent();
        }
        //Load
        private void Form_Employee_Load(object sender, EventArgs e)
        {
            Database.DbFileName = "Database.yap";
            db = Database.Db;

            loadEmployee();
        }

        private void loadEmployee()
        {
            var employee = new Employee();
            result = db.QueryByExample(employee);
            dataGridView_Employee.DataSource = result;

            Database.SetDependents(db, dataGridView_Employee);
            Database.SetSupervisees(db, dataGridView_Employee);
            Database.SetEmployeeWorksOn(db, dataGridView_Employee);
        }
        //Function_Button
        private void button_Add_Click(object sender, EventArgs e)
        {
            string datName = "Employee.dat";
            string path = Path.Combine(Environment.CurrentDirectory, @"Data\", datName);
            Database.CreateEmployees(db, path);

            loadEmployee();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            string datName = "Employee.dat";
            string path = Path.Combine(Environment.CurrentDirectory, @"Data\", datName);
            Database.DeleteEmployees(db, path);

            loadEmployee();
        }

        private void button_Modify_Click(object sender, EventArgs e)
        {
            string datName = "Employee.dat";
            string path = Path.Combine(Environment.CurrentDirectory, @"Data\", datName);
            Database.ModifyEmployees(db, path);

            loadEmployee();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Database.CloseDB(db);
            Form_Program program = new Form_Program();
            program.ShowDialog();
            this.Close();
        }
        //Insert_Button
        private void button_Manager_Click(object sender, EventArgs e)
        {
            string datName = "Manager.dat";
            string path = Path.Combine(Environment.CurrentDirectory, @"Data\", datName);
            Database.SetManagers(db, path);

            loadEmployee();
        }

        private void button_WorksFor_Click(object sender, EventArgs e)
        {
            string datName = "WorksFor.dat";
            string path = Path.Combine(Environment.CurrentDirectory, @"Data\", datName);
            Database.SetWorksFor(db, path);

            loadEmployee();
        }

        private void button_Supervisors_Click(object sender, EventArgs e)
        {
            string datName = "Supervisors.dat";
            string path = Path.Combine(Environment.CurrentDirectory, @"Data\", datName);
            Database.SetSupervisors(db, path);

            loadEmployee();
        }
    }
}
