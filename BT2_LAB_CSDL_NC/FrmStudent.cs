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

namespace BT2_LAB_CSDL_NC
{
    public partial class FrmStudent : Form
    {
        public FrmStudent()
        {
            InitializeComponent();
        }

        IObjectContainer dbStudent = null;
        IObjectContainer dbCourse = null;
        IObjectSet resultStudent = null;

        private void FrmStudent_Load(object sender, EventArgs e)
        {
            dbStudent = Db4oEmbedded.OpenFile("StudentDB.yap");
            dbCourse = Db4oEmbedded.OpenFile("CourseDB.yap");
            loadStudent();
        }

        private void dateTimePicker_BirthDate_ValueChanged(object sender, EventArgs e)
        {

            DateTime date;
            if (DateTime.TryParse(dateTimePicker_BirthDate.Text, out date))
            {
                string text = (DateTime.Now.Year - DateTime.Parse(dateTimePicker_BirthDate.Text).Year).ToString();
                textBox_Age.Text = text;
            }
        }

        //Function
        private void button_Add_Click(object sender, EventArgs e)
        {
            //If exist
            var course = new Course(comboBox_CourseCode.Text , default);

            var student = new Student(textBox_StudentCode.Text,
                                    textBox_LastName.Text,
                                    textBox_FirstName.Text,
                                    Int32.Parse(textBox_AdYear.Text),
                                    DateTime.Parse(dateTimePicker_BirthDate.Text),
                                    Int32.Parse(textBox_Age.Text),
                                    course);
            resultStudent = dbStudent.QueryByExample(student);
            dataGridView_Student.DataSource = resultStudent;

            if (dataGridView_Student.Rows.Count == 0)
            {
                dbStudent.Store(student);

                loadStudent();
            }

            else
            {
                if(textBox_LastName.Text == student.LastName && 
                    textBox_FirstName.Text == student.FirstName &&
                    comboBox_CourseCode.Text != student.Course.CourseCode)
                {
                    dbStudent.Store(student);
                }
                else
                {
                    MessageBox.Show("Already have a student in this course");
                }
                loadStudent();
            }

            //Clear
            textBox_StudentCode.Clear();
            textBox_LastName.Clear();
            textBox_FirstName.Clear();
            textBox_AdYear.Clear();
            textBox_Age.Clear();
        }

        private void button_Reload_Click(object sender, EventArgs e)
        {
            loadStudent();
        }

        private void button_Modify_Click(object sender, EventArgs e)
        {
            var student = new Student(textBox_StudentCode.Text);
            resultStudent = dbStudent.QueryByExample(student);
            var moStudent = (Student)resultStudent[0];

            moStudent.StudentCode = textBox_StudentCode.Text;
            moStudent.LastName = textBox_LastName.Text;
            moStudent.FirstName = textBox_FirstName.Text;
            moStudent.AdYear = Int32.Parse(textBox_AdYear.Text);
            moStudent.BirthDate = DateTime.Parse(dateTimePicker_BirthDate.Text);
            moStudent.Age = Int32.Parse(textBox_Age.Text);
            moStudent.Course = new Course(comboBox_CourseCode.Text);


            dbStudent.Store(moStudent);

            loadStudent();

            //Clear
            textBox_StudentCode.Clear();
            textBox_LastName.Clear();
            textBox_FirstName.Clear();
            textBox_AdYear.Clear();
            textBox_Age.Clear();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            var student = new Student(textBox_StudentCode.Text);
            resultStudent = dbStudent.QueryByExample(student);
            var moStudent = (Student)resultStudent[0];

            moStudent.StudentCode = textBox_StudentCode.Text;
            moStudent.LastName = textBox_LastName.Text;
            moStudent.FirstName = textBox_FirstName.Text;
            moStudent.AdYear = Int32.Parse(textBox_AdYear.Text);
            moStudent.BirthDate = DateTime.Parse(dateTimePicker_BirthDate.Text);
            moStudent.Age = Int32.Parse(textBox_Age.Text);
            moStudent.Course.CourseCode = comboBox_CourseCode.Text;

            dbStudent.Delete(moStudent);

            loadStudent();

            //Clear
            textBox_StudentCode.Clear();
            textBox_LastName.Clear();
            textBox_FirstName.Clear();
            textBox_AdYear.Clear();
            textBox_Age.Clear();
        }

        private void loadStudent()
        {
            var student = new Student(default);
            resultStudent = dbStudent.QueryByExample(student);
            dataGridView_Student.DataSource = resultStudent;

            var course = from Course c
                         in dbCourse
                         select c.CourseCode;
            comboBox_CourseCode.DataSource = course.ToList();

        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            dbStudent.Close();
            dbCourse.Close();
            FrmChoice choice = new FrmChoice();
            choice.ShowDialog();
            this.Close();
        }

        //Search By
        private void button_StudentCode_Click(object sender, EventArgs e)
        {
            var student = new Student(textBox_StudentCode.Text);
            resultStudent = dbStudent.QueryByExample(student);
            dataGridView_Student.DataSource = resultStudent;

            //Clear
            textBox_StudentCode.Clear();
            textBox_LastName.Clear();
            textBox_FirstName.Clear();
            textBox_AdYear.Clear();
            textBox_Age.Clear();
        }

        private void button_Age_Click(object sender, EventArgs e)
        {
            if (textBox_Age.Text != "")
            {
                var student = new Student(default, default, default, default, default, Int32.Parse(textBox_Age.Text), default);
                resultStudent = dbStudent.QueryByExample(student);
                dataGridView_Student.DataSource = resultStudent;
            }

            //Clear
            textBox_StudentCode.Clear();
            textBox_LastName.Clear();
            textBox_FirstName.Clear();
            textBox_AdYear.Clear();
            textBox_Age.Clear();
        }

        private void button_Name_Click(object sender, EventArgs e)
        {
            if (textBox_LastName.Text != "" && textBox_FirstName.Text != "")
            {
                var student = new Student(default, textBox_LastName.Text, textBox_FirstName.Text, default, default, default, default);
                resultStudent = dbStudent.QueryByExample(student);
                dataGridView_Student.DataSource = resultStudent;
            }
            if (textBox_LastName.Text != "")
            {
                var student = new Student(default, textBox_LastName.Text, default, default, default, default, default);
                resultStudent = dbStudent.QueryByExample(student);
                dataGridView_Student.DataSource = resultStudent;
            }
            if (textBox_FirstName.Text != "")
            {
                var student = new Student(default, default, textBox_FirstName.Text, default, default, default, default);
                resultStudent = dbStudent.QueryByExample(student);
                dataGridView_Student.DataSource = resultStudent;
            }

            //Clear
            textBox_StudentCode.Clear();
            textBox_LastName.Clear();
            textBox_FirstName.Clear();
            textBox_AdYear.Clear();
            textBox_Age.Clear();
        }

        private void button_AdYear_Click(object sender, EventArgs e)
        {
            if (textBox_AdYear.Text != "")
            {
                var student = new Student(default, default, default, Int32.Parse(textBox_AdYear.Text), default, default, default);
                resultStudent = dbStudent.QueryByExample(student);
                dataGridView_Student.DataSource = resultStudent;
            }

            //Clear
            textBox_StudentCode.Clear();
            textBox_LastName.Clear();
            textBox_FirstName.Clear();
            textBox_AdYear.Clear();
            textBox_Age.Clear();
        }

        private void button_CourseCode_Click(object sender, EventArgs e)
        {
            var course = new Course(comboBox_CourseCode.Text);
            var student = new Student(default, default, default, default, default, default, course);
            resultStudent = dbStudent.QueryByExample(student);
            dataGridView_Student.DataSource = resultStudent;

            //Clear
            textBox_StudentCode.Clear();
            textBox_LastName.Clear();
            textBox_FirstName.Clear();
            textBox_AdYear.Clear();
            textBox_Age.Clear();
        }

        private void dataGridView_Student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            var student = (Student)resultStudent[e.RowIndex];

            textBox_StudentCode.Text = student.StudentCode;
            textBox_LastName.Text = student.LastName;
            textBox_FirstName.Text = student.FirstName;
            textBox_AdYear.Text = student.AdYear.ToString();
            dateTimePicker_BirthDate.Text = student.BirthDate.ToShortDateString();
            textBox_Age.Text = student.Age.ToString();
            comboBox_CourseCode.Text = student.Course.CourseCode.ToString();
        }
    }
}
