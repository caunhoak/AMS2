using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName;
            int studentAge;
            DateTime studentDoB;
            string studentGender;
            string studentId;
            string major;
            Process process = new Process();
            string option;
            do
            {
                UI.ShowMenuControl();
                option = UI.EnterOption();
                switch (option)
                {
                    case "1":
                        process.AddStudentInfo(new Student(
                           UI.EnterName(),
                           UI.EnterAge(),
                           UI.EnterDob(),
                           UI.EnterGender(),
                           UI.EnterId(),
                           UI.EnterMajors()));
                        break;
                    case "2":
                        studentId = UI.EnterId();
                        if (process.CheckId(studentId) != null)
                        {
                            studentName = UI.EnterName();
                            studentAge = UI.EnterAge();
                            studentDoB = UI.EnterDob();
                            studentGender = UI.EnterGender();
                            major = UI.EnterMajors();
                            process.EditStudent(studentName, studentAge, studentDoB, studentGender, studentId, major);
                            UI.ShowSuccessProcess();
                        }
                        else
                        {
                            UI.ShowNoStudentFound();
                        }
                        break;
                    case "3":
                        studentId = UI.EnterId();
                        process.DeleteStudentInfo(studentId);
                        break;
                    case "4":
                        studentId = UI.EnterId();
                        if (process.CheckId(studentId) != null)
                        {
                            UI.ShowStudentFindNeed();
                            UI.ShowInfoStudent(process.CheckId(studentId));
                        }
                        else
                        {
                            UI.ShowNoStudentFound();
                        }
                        break;
                    case "5":
                        break;
                    case "6":
                        if (process.AllOfMajors.Count == 0)
                        {
                            UI.ShowNoDataFound();
                        }
                        else
                        {
                            UI.ShowListOfMajorsType(process);
                        }
                        break;
                    case "7":
                        UI.ShowNumberOfStudents(process.Students);
                        break;
                    case "8":
                        UI.ShowExit();
                        break;
                    default:
                        UI.ShowEnterAgain();
                        break;
                }
                UI.ShowLineDown();
                Console.ReadLine();
            } while (option != "8");
        }
    }
}
