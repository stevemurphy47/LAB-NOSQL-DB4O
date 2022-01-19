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
    public partial class Form_Project : Form
    {
        IObjectContainer db = null;
        IObjectSet result = null;

        public Form_Project()
        {
            InitializeComponent();
        }
        //Load
        private void Form_Project_Load(object sender, EventArgs e)
        {
            Database.DbFileName = "Database.yap";
            db = Database.Db;

            loadProject();
        }

        private void loadProject()
        {
            var project = new Project();
            result = db.QueryByExample(project);
            dataGridView_Project.DataSource = result;

            Database.SetProjectWorksOn(db, dataGridView_Project);
        }
        //Function Button
        private void button_Add_Click(object sender, EventArgs e)
        {
            string datName = "Project.dat";
            string path = Path.Combine(Environment.CurrentDirectory, @"Data\", datName);
            Database.CreateProject(db, path);

            loadProject();
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
        private void button_ControledBy_Click(object sender, EventArgs e)
        {
            string datName = "ControledBy.dat";
            string path = Path.Combine(Environment.CurrentDirectory, @"Data\", datName);
            Database.SetControls(db, path);

            loadProject();
        }
    }
}
