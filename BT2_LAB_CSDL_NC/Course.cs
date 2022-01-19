using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2_LAB_CSDL_NC
{
    public class Course
    {
        public string CourseCode { get; set; }
        public string CourseName { get; set; }

        public Course(string code, string name)
        {
            CourseCode = code;
            CourseName = name;
        }

        public Course(string code)
        {
            CourseCode = code;
        }
        public override string ToString()
        {
            return $"{CourseCode} - {CourseName}";
        }

    }
}
