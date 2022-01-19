using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Db4objects.Db4o;
using Db4objects.Db4o.Linq;

namespace BT_LAB05_CSDL_NC
{
    public partial class Form_Query : Form
    {

        IObjectContainer db = null;
        IObjectSet result = null;

        public Form_Query()
        {
            InitializeComponent();
        }

        //Load
        private void Form_Query_Load(object sender, EventArgs e)
        {
            Database.DbFileName = "Database.yap";
            db = Database.Db;
        }
        private void loadEmployee()
        {
            var employee = new Employee();
            result = db.QueryByExample(employee);
            dataGridView_Query.DataSource = result;
        }
        //Function Button
        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Database.CloseDB(db);
            Form_Program program = new Form_Program();
            program.ShowDialog();
            this.Close();
        }
        //Query Button
        private void button_Male_Click(object sender, EventArgs e)
        {
            IList<Employee> emps = db.Query(delegate (Employee emp)
            {
                return (emp.Sex == 'M');
            }).ToList();

            dataGridView_Query.DataSource = emps;
        }

        private void button_TDepartmment_Click(object sender, EventArgs e)
        {
            List<Employee> emps = new List<Employee>();

            IList<Department> dpms = db.Query(delegate (Department dpm)
            {
                return (dpm.DName.StartsWith("T") && dpm.Employees.Count != 0);
            }).ToList();
            foreach(Department dpm in dpms)
            {
                foreach(Employee emp in dpm.Employees)
                {
                    emps.Add(emp);
                }
            }

            dataGridView_Query.DataSource = emps;
        }

        private void button_HostonProject_Click(object sender, EventArgs e)
        {
            IList<WorksOn> wors =
            (
                from WorksOn wor in db
                where
                (
                    from Project pro in db
                    where pro.Location == "Hoston"
                    select pro
                ).ToList().Contains(wor.Project)
                select wor
            ).ToList();

            dataGridView_Query.DataSource = wors;
        }

        private void button_ANameProject_Click(object sender, EventArgs e)
        {
            //Sub-query way
            IList<Employee> emps =
            (
                from Employee emp in db
                where
                (
                    from WorksOn wor in db
                    where
                    (
                        from Project pro in db
                        where pro.PName.IndexOf("a") >= 0
                        select pro
                    ).ToList().Contains(wor.Project) && wor.Hours < 10
                    select wor.Employee
                ).ToList().Contains(emp)
                select emp
            ).ToList();
            //Query way
            /*IList<WorksOn> wors = (from WorksOn wor in db
                                   where wor.Hours < 10
                                   select wor).ToList();
            IList<Project> pros = (from Project pro in db
                                   where pro.PName.IndexOf("a") >= 0
                                   select pro).ToList();
            List<Employee> emp = new List<Employee>();
            foreach(Project pro in pros)
            {
                foreach(WorksOn wor in wors)
                {
                    if(pro.PNumber == wor.Project.PNumber)
                    {
                        emp.Add(wor.Employee);
                    }
                }
            }*/
            dataGridView_Query.DataSource = emps;
        }
    }
}
