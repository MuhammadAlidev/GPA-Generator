using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class Classes 
    {
        public void Studentname()
        {
            Console.Write("Enter Student Name: ");
        }
        public string StudentName { get; set; }
        
        public void StudentSemester()
        {
            Console.Write("Enter the semester of student: ");
        }
        public string Semester { get; set; }

    }
}
