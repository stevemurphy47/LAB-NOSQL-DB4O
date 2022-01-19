using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Db4objects.Db4o;
using Db4objects.Db4o.Linq;

namespace BT_LAB05_CSDL_NC
{
    public partial class Form_Department : Form
    {
        IObjectContainer db = null;
        IObjectSet result = null;

        public Form_Department()
        {
            InitializeComponent();
        }
        //Load
        private void Form_Department_Load(object sender, EventArgs e)
        {
            Database.DbFileName = "Database.yap";
            db = Database.Db;

            loadDepartment();
        }

        private void loadDepartment()
        {
            var department = new Department();
            result = db.QueryByExample(department);
            dataGridView_Department.DataSource = result;

            Database.SetLocations(db, dataGridView_Department);
            Database.SetProjects(db, dataGridView_Department);
            Database.SetEmployees(db, dataGridView_Department);

            foreach (DataGridViewRow row in dataGridView_Department.Rows)
            {
                if (row.Cells["Manager"].Value == null && row.Cells["MgrStartDate"].Value != null)
                {
                    row.Cells["MgrStartDate"].Value = null;
                } 
            }
        }
        //Function Button
        private void button_Add_Click(object sender, EventArgs e)
        {
            string datName = "Department.dat";
            string path = Path.Combine(Environment.CurrentDirectory, @"Data\", datName);
            Database.CreateDepartment(db, path);

            loadDepartment();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {

        }

        private void button_Modify_Click(object sender, EventArgs e)
        {

        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Database.CloseDB(db);
            Form_Program program = new Form_Program();
            program.ShowDialog();
            this.Close();
        }
        //Insert Button
        private void buttonManager_Click(object sender, EventArgs e)
        {
            string datName = "Manager.dat";
            string path = Path.Combine(Environment.CurrentDirectory, @"Data\", datName);
            Database.SetManagers(db, path);

            loadDepartment();
        }

        private void button_Projects_Click(object sender, EventArgs e)
        {
            string datName = "ControledBy.dat";
            string path = Path.Combine(Environment.CurrentDirectory, @"Data\", datName);
            Database.SetControls(db, path);

            loadDepartment();
        }

        private void button_WorksFor_Click(object sender, EventArgs e)
        {
            string datName = "WorksFor.dat";
            string path = Path.Combine(Environment.CurrentDirectory, @"Data\", datName);
            Database.SetWorksFor(db, path);

            loadDepartment();
        }
    }
}
