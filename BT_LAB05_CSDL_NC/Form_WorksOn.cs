using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Db4objects.Db4o;
using Db4objects.Db4o.Linq;

namespace BT_LAB05_CSDL_NC
{
    public partial class Form_WorksOn : Form
    {
        IObjectContainer db = null;
        IObjectSet result = null;

        public Form_WorksOn()
        {
            InitializeComponent();
        }
        //Load
        private void Form_WorksOn_Load(object sender, EventArgs e)
        {
            Database.DbFileName = "Database.yap";
            db = Database.Db;

            loadWorksOn();
        }

        private void loadWorksOn()
        {
            var workson = new WorksOn();
            result = db.QueryByExample(workson);
            dataGridView_WorksOn.DataSource = result;
        }
        //Fucntion Button
        private void button_Add_Click(object sender, EventArgs e)
        {
            string datName = "WorksOn.dat";
            string path = Path.Combine(Environment.CurrentDirectory, @"Data\", datName);
            Database.CreateWorksOn(db, path);

            loadWorksOn();
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

    }
}
