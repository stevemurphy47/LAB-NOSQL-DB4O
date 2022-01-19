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

namespace BT2_LAB_CSDL_NC
{
    public partial class FrmCourse : Form
    {
        public FrmCourse()
        {
            InitializeComponent();
        }

        IObjectContainer db = null;
        IObjectSet result = null;

        private void FrmCourse_Load(object sender, EventArgs e)
        {
            db = Db4oEmbedded.OpenFile("CourseDB.yap");
            loadCourse();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            //If exist
            var course = new Course(textBox_CourseCode.Text);
            result = db.QueryByExample(course);
            dataGridView_Course.DataSource = result;

            if (dataGridView_Course.Rows.Count == 0)
            {
                course = new Course(textBox_CourseCode.Text,
                                    textBox_CourseName.Text);

                db.Store(course);

                loadCourse();
            }

            else
            {
                MessageBox.Show("A course has already existed");
                loadCourse();
            }

            //Clear
            textBox_CourseCode.Clear();
            textBox_CourseName.Clear();
        }

        private void button_Reload_Click(object sender, EventArgs e)
        {
            loadCourse();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            var course = new Course(textBox_CourseCode.Text);
            result = db.QueryByExample(course);
            var moCourse = (Course)result[0];

            moCourse.CourseCode = textBox_CourseCode.Text;
            moCourse.CourseName = textBox_CourseName.Text;

            db.Delete(moCourse);

            loadCourse();

            //Clear
            textBox_CourseCode.Clear();
            textBox_CourseName.Clear();
        }

        private void button_Modify_Click(object sender, EventArgs e)
        {
            var course = new Course(textBox_CourseCode.Text);
            result = db.QueryByExample(course);
            var moCourse = (Course)result[0];

            moCourse.CourseCode = textBox_CourseCode.Text;
            moCourse.CourseName = textBox_CourseName.Text;

            db.Store(moCourse);

            loadCourse();

            //Clear
            textBox_CourseCode.Clear();
            textBox_CourseName.Clear();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            db.Close();
            FrmChoice choice = new FrmChoice();
            choice.ShowDialog();
            this.Close();
        }

        //Search By
        private void button_Code_Click(object sender, EventArgs e)
        {
            var course = new Course(textBox_CourseCode.Text);
            result = db.QueryByExample(course);
            dataGridView_Course.DataSource = result;

            //Clear
            textBox_CourseCode.Clear();
            textBox_CourseName.Clear();
        }

        private void button_Name_Click(object sender, EventArgs e)
        {
            var course = new Course(default, textBox_CourseName.Text);
            result = db.QueryByExample(course);
            dataGridView_Course.DataSource = result;

            //Clear
            textBox_CourseCode.Clear();
            textBox_CourseName.Clear();
        }

        private void loadCourse()
        {
            var course = new Course(default);
            result = db.QueryByExample(course);
            dataGridView_Course.DataSource = result;
        }

        private void dataGridView_Course_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var course = (Course)result[e.RowIndex];

            textBox_CourseCode.Text = course.CourseCode;
            textBox_CourseName.Text = course.CourseName;
        }
    }
}
