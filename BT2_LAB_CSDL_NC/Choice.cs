using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT2_LAB_CSDL_NC
{
    public partial class FrmChoice : Form
    {
        public FrmChoice()
        {
            InitializeComponent();
        }

        private void button_Course_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCourse course = new FrmCourse();
            course.ShowDialog();
            this.Close();
        }

        private void button_Student_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmStudent student = new FrmStudent();
            student.ShowDialog();
            this.Close();
        }
    }
}
