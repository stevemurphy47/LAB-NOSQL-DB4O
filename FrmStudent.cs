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

namespace BT1_LAB_CSDL_NC
{
    public partial class FrmStudent : Form
    {
        public FrmStudent()
        {
            InitializeComponent();
        }

        IObjectContainer db = null;
        IObjectSet result = null;

        private void FrmStudent_Load(object sender, EventArgs e)
        {
            db = Db4oEmbedded.OpenFile("StudentDB.yap");
            loadStudent();
        }

        private void textBox_BirthDate_TextChanged(object sender, EventArgs e)
        {
            DateTime date;
            if (DateTime.TryParse(textBox_BirthDate.Text, out date))
            {
                string text = (DateTime.Now.Year - DateTime.Parse(textBox_BirthDate.Text).Year).ToString();
                textBox_Age.Text = text;
            }
        }

        //Function
        private void button_Add_Click(object sender, EventArgs e)
        {
            //If exist
            var student = new Student(textBox_StudentCode.Text);
            result = db.QueryByExample(student);
            dataGridView_Student.DataSource = result;

            if (dataGridView_Student.Rows.Count == 0)
            {
                student = new Student(textBox_StudentCode.Text,
                                    textBox_LastName.Text,
                                    textBox_FirstName.Text,
                                    Int32.Parse(textBox_AdYear.Text),
                                    DateTime.Parse(textBox_BirthDate.Text),
                                    Int32.Parse(textBox_Age.Text));

                db.Store(student);

                loadStudent();
            }

            else
            {
                MessageBox.Show("A student has already existed");
                loadStudent();
            }

            //Clear
            textBox_StudentCode.Clear();
            textBox_LastName.Clear();
            textBox_FirstName.Clear();
            textBox_AdYear.Clear();
            textBox_BirthDate.Clear();
            textBox_Age.Clear();
        }

        private void button_Reload_Click(object sender, EventArgs e)
        {
            loadStudent();
        }

        private void button_Modify_Click(object sender, EventArgs e)
        {
            var student = new Student(textBox_StudentCode.Text);
            result = db.QueryByExample(student);
            var moStudent = (Student)result[0];

            moStudent.StudentCode = textBox_StudentCode.Text;
            moStudent.LastName = textBox_LastName.Text;
            moStudent.FirstName = textBox_FirstName.Text;
            moStudent.AdYear = Int32.Parse(textBox_AdYear.Text);
            moStudent.BirthDate = DateTime.Parse(textBox_BirthDate.Text);
            moStudent.Age = Int32.Parse(textBox_Age.Text);

            db.Store(moStudent);

            loadStudent();

            //Clear
            textBox_StudentCode.Clear();
            textBox_LastName.Clear();
            textBox_FirstName.Clear();
            textBox_AdYear.Clear();
            textBox_BirthDate.Clear();
            textBox_Age.Clear();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            var student = new Student(textBox_StudentCode.Text);
            result = db.QueryByExample(student);
            var moStudent = (Student)result[0];

            moStudent.StudentCode = textBox_StudentCode.Text;
            moStudent.LastName = textBox_LastName.Text;
            moStudent.FirstName = textBox_FirstName.Text;
            moStudent.AdYear = Int32.Parse(textBox_AdYear.Text);
            moStudent.BirthDate = DateTime.Parse(textBox_BirthDate.Text);
            moStudent.Age = Int32.Parse(textBox_Age.Text);

            db.Delete(moStudent);

            loadStudent();

            //Clear
            textBox_StudentCode.Clear();
            textBox_LastName.Clear();
            textBox_FirstName.Clear();
            textBox_AdYear.Clear();
            textBox_BirthDate.Clear();
            textBox_Age.Clear();
        }

        private void loadStudent()
        {
            var student = new Student(default, default, default, 0, default, 0);
            result = db.QueryByExample(student);
            dataGridView_Student.DataSource = result;
        }

        //Search By
        private void button_Code_Click(object sender, EventArgs e)
        {
            var student = new Student(textBox_StudentCode.Text);
            result = db.QueryByExample(student);
            dataGridView_Student.DataSource = result;

            //Clear
            textBox_StudentCode.Clear();
            textBox_LastName.Clear();
            textBox_FirstName.Clear();
            textBox_AdYear.Clear();
            textBox_BirthDate.Clear();
            textBox_Age.Clear();
        }

        private void button_Age_Click(object sender, EventArgs e)
        {
            if (textBox_Age.Text != "")
            {
                var student = new Student(default, default, default, default, default, Int32.Parse(textBox_Age.Text));
                result = db.QueryByExample(student);
                dataGridView_Student.DataSource = result;
            }

            //Clear
            textBox_StudentCode.Clear();
            textBox_LastName.Clear();
            textBox_FirstName.Clear();
            textBox_AdYear.Clear();
            textBox_BirthDate.Clear();
            textBox_Age.Clear();
        }

        private void button_Name_Click(object sender, EventArgs e)
        {
            if (textBox_LastName.Text != "" && textBox_FirstName.Text != "")
            {
                var student = new Student(default, textBox_LastName.Text, textBox_FirstName.Text, default, default, default);
                result = db.QueryByExample(student);
                dataGridView_Student.DataSource = result;
            }
            if (textBox_LastName.Text != "")
            {
                var student = new Student(default, textBox_LastName.Text, default, default, default, default);
                result = db.QueryByExample(student);
                dataGridView_Student.DataSource = result;
            }
            if (textBox_FirstName.Text != "")
            {
                var student = new Student(default, default, textBox_FirstName.Text, default, default, default);
                result = db.QueryByExample(student);
                dataGridView_Student.DataSource = result;
            }

            //Clear
            textBox_StudentCode.Clear();
            textBox_LastName.Clear();
            textBox_FirstName.Clear();
            textBox_AdYear.Clear();
            textBox_BirthDate.Clear();
            textBox_Age.Clear();
        }

        private void button_AdYear_Click(object sender, EventArgs e)
        {
            if (textBox_AdYear.Text != "")
            {
                var student = new Student(default, default, default, Int32.Parse(textBox_AdYear.Text), default, default);
                result = db.QueryByExample(student);
                dataGridView_Student.DataSource = result;
            }

            //Clear
            textBox_StudentCode.Clear();
            textBox_LastName.Clear();
            textBox_FirstName.Clear();
            textBox_AdYear.Clear();
            textBox_BirthDate.Clear();
            textBox_Age.Clear();
        }

        private void dataGridView_Student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var student = (Student)result[e.RowIndex];

            textBox_StudentCode.Text = student.StudentCode;
            textBox_LastName.Text = student.LastName;
            textBox_FirstName.Text = student.FirstName;
            textBox_AdYear.Text = student.AdYear.ToString();
            textBox_BirthDate.Text = student.BirthDate.ToShortDateString();
            textBox_Age.Text = student.Age.ToString();
        }
    }
}
