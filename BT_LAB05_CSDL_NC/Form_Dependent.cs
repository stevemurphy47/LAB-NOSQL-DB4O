using Db4objects.Db4o;
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

namespace BT_LAB05_CSDL_NC
{
    public partial class Form_Dependent : Form
    {
        IObjectContainer db = null;
        IObjectSet result = null;

        public Form_Dependent()
        {
            InitializeComponent();
        }
        //Load
        private void Form_Dependent_Load(object sender, EventArgs e)
        {
            Database.DbFileName = "Database.yap";
            db = Database.Db;

            loadDependent();
        }

        private void loadDependent()
        {
            var dependent = new Dependent();
            result = db.QueryByExample(dependent);
            dataGridView_Dependent.DataSource = result;
        }
        //Funcion_Button
        private void button_Add_Click(object sender, EventArgs e)
        {
            string datName = "Dependents.dat";
            string path = Path.Combine(Environment.CurrentDirectory, @"Data\", datName);
            Database.CreateDependents(db, path);

            loadDependent();
        }

        private void button_Modify_Click(object sender, EventArgs e)
        {

        }

        private void button_Delete_Click(object sender, EventArgs e)
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
    }
}
