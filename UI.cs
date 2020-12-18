using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2
{
    class UI
    {
        public static void ShowLineDown()
        {
            Console.WriteLine("==================================================================");
        }
        public static void ShowMenuControl()
        {
            Console.WriteLine("Show menu control");
            Console.ReadLine();
            Console.WriteLine("Please enter your choice below");
            Console.WriteLine("1. Add student new");
            Console.WriteLine("2. Edit student by ID");
            Console.WriteLine("3. Delete student by ID");
            Console.WriteLine("4. Find student by ID");
            Console.WriteLine("5. Print the number of male and female students");
            Console.WriteLine("6. Print the number of Business, Graphic Design and IT students");
            Console.WriteLine("7. Print number of students");
            Console.WriteLine("8. Exit the program");
            ShowLineDown();
            Console.WriteLine();
        }
        public static string EnterOption()
        {
            Console.Write("Enter your option: ");
            return Console.ReadLine();
        }
        public static string EnterName()
        {
            Console.Write($"Student's name: ");
            return Console.ReadLine();
        }
        public static int EnterAge()
        {
            Console.Write($"Student's age: ");
            return int.Parse(Console.ReadLine());
        }
        public static DateTime EnterDob()
        {
            Console.Write($"Student's date of birth(year/month/day): ");
            return DateTime.Parse(Console.ReadLine());
        }
        public static string EnterGender()
        {
            Console.Write($"Student's gender(Male or Female): ");
            return Console.ReadLine();
        }
        public static string EnterId()
        {
            Console.Write($"Student's ID: ");
            return Console.ReadLine();
        }
        public static string EnterMajors()
        {
            Console.Write($"Student's majors(Business or Graphic Design or IT): ");
            return Console.ReadLine();
        }
        public static void ShowInfoStudent(Student student)
        {
            Console.WriteLine($"Student's name: {student.Name}");
            Console.WriteLine($"Student's age: {student.Age}");
            Console.WriteLine($"Student's date of birth(month/day/year): {student.Dob.ToString("d")}");
            Console.WriteLine($"Student's gender: {student.Gender}");
            Console.WriteLine($"Student's ID: {student.Id}");
            Console.WriteLine($"Student's majors: {student.Majors}");
        }
        public static void ShowNumberOfStudents(List<Student> students)
        {
            Console.WriteLine();
            Console.WriteLine($"Number of students: {students.Count()}");
        }
        public static void ShowListOfMajorsType(Process process)
        {
            process.ListMajorType();
        }
        public static void ShowStudentIdExists()
        {
            Console.WriteLine();
            Console.WriteLine("This student ID already exists!");
            Console.WriteLine("Please enter student's infomation again");
        }
        public static void ShowStudentFindNeed()
        {
            Console.WriteLine();
            Console.WriteLine("Student you need to find below:");
            Console.WriteLine();
        }
        public static void ShowNoStudentFound()
        {
            Console.WriteLine();
            Console.WriteLine("No student found!");
            Console.WriteLine("Please run program again");
        }
        public static void ShowNoDataFound()
        {
            Console.WriteLine();
            Console.WriteLine("No data found!");
        }
        public static void ShowExit()
        {
            Console.WriteLine();
            Console.WriteLine("Exit the program!");
        }
        public static void ShowEnterAgain()
        {
            Console.WriteLine();
            Console.WriteLine("Please enter your option again");
        }
        public static void ShowSuccessProcess()
        {
            Console.WriteLine();
            Console.WriteLine("Successful processing program");
        }
    }
}
