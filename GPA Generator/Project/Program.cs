using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                                         GPA Generator");
            GPA Sem = new GPA();
            Sem.Studentname();
            Sem.StudentName = Console.ReadLine();
            Sem.StudentSemester();
            Sem.Semester = Console.ReadLine();
            Sem.EntCourses();
            Sem.ShowOutput();
            Sem.CalculateGPA();
        }
    }
}
