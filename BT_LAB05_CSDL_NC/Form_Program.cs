using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_LAB05_CSDL_NC
{
    public partial class Form_Program : Form
    {
        public Form_Program()
        {
            InitializeComponent();
        }

        private void button_Employee_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Employee employee = new Form_Employee();
            employee.ShowDialog();
            this.Close();
        }

        private void button_Dependent_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Dependent dependent = new Form_Dependent();
            dependent.ShowDialog();
            this.Close();
        }

        private void button_Department_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Department department = new Form_Department();
            department.ShowDialog();
            this.Close();
        }

        private void button_Project_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Project project = new Form_Project();
            project.ShowDialog();
            this.Close();
        }

        private void button_WorksOn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_WorksOn worksOn = new Form_WorksOn();
            worksOn.ShowDialog();
            this.Close();
        }

        private void button_Query_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Query query = new Form_Query();
            query.ShowDialog();
            this.Close();
        }

        private void button_EditDatFile_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_DatFile datFile = new Form_DatFile();
            datFile.ShowDialog();
            this.Close();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
