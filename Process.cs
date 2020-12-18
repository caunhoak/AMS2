using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2
{
    class Process
    {
        public List<Student> Students;
        public List<string> AllOfMajors;
        public SortedDictionary<string, int> NumberOfStudentOfMajors;
        public Process()
        {
            Students = new List<Student>();
            AllOfMajors = new List<string>();
            NumberOfStudentOfMajors = new SortedDictionary<string, int>();
        }
        public Student CheckId(string id)
        {
            return Students.SingleOrDefault(s => s.Id.Equals(id.ToUpper()));
        }
        public void AddStudentInfo(Student student)
        {
            if (CheckId(student.Id) != null)
            {
                UI.ShowStudentIdExists();
            }
            else
            {
                Students.Add(student);
                AllOfMajors.Add(student.Majors);
                UI.ShowSuccessProcess();
            }
        }
        public void EditStudent(string name, int age, DateTime dob, string gender, string id, string majors)
        {
            var newStudent = CheckId(id);
            newStudent.Name = name.ToUpper();
            newStudent.Age = age;
            newStudent.Dob = dob;
            newStudent.Gender = gender.ToUpper();
            newStudent.Id = id.ToUpper();
            newStudent.Majors = majors.ToUpper();
        }
        public void DeleteStudentInfo(string id)
        {
            var oldStudent = CheckId(id);
            if (oldStudent != null)
            {
                Students.Remove(oldStudent);
                AllOfMajors.Remove(oldStudent.Majors);
                UI.ShowSuccessProcess();
            }
            else
            {
                UI.ShowNoStudentFound();
            }
        }
        public void ListMajorType()
        {
            NumberOfStudentOfMajors.Clear();
            foreach (var checkMajor in AllOfMajors)
            {
                if (NumberOfStudentOfMajors.ContainsKey(checkMajor))
                {
                    NumberOfStudentOfMajors[checkMajor]++;
                }
                else
                {
                    NumberOfStudentOfMajors.Add(checkMajor, 1);
                }
            }
            foreach (var checkMajorType in NumberOfStudentOfMajors)
            {
                Console.WriteLine();
                if (checkMajorType.Value == 1)
                {
                    Console.WriteLine($"{checkMajorType.Key} has {checkMajorType.Value} student");
                }
                else
                {
                    Console.WriteLine($"{checkMajorType.Key} has {checkMajorType.Value} students");
                }
            }
        }
    }
}
