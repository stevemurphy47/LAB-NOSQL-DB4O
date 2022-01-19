using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2_LAB_CSDL_NC
{
    public class Student
    {
        public string StudentCode { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int AdYear { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age { get; set; }
        public Course Course { get; set; }

        public Student(string studentCode, 
                    string lastName, 
                    string firstName, 
                    int adYear, 
                    DateTime birthDate,
                    int age,
                    Course course)
        {
            StudentCode = studentCode;
            LastName = lastName;
            FirstName = firstName;
            AdYear = adYear;
            BirthDate = birthDate;
            Age = age;
            Course = course;
        }

        public Student(string studentCode)
        {
            StudentCode = studentCode;
        }
    }
}
