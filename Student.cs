using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2
{
    class Student
    {
        public string Name;
        public int Age;
        public DateTime Dob;
        public string Gender;
        public string Id;
        public string Majors;
        public Student() { }
        public Student(string name, int age, DateTime dob, string gender, string id, string majors)
        {
            Name = name.ToUpper();
            Age = age;
            Dob = dob;
            Gender = gender.ToUpper();
            Id = id.ToUpper();
            Majors = majors.ToUpper();
        }
    }
}
