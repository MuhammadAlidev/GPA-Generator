using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class GPA : Courses
    {
        protected double ShowGPA;
        private int percentComplete;
        public void ShowOutput()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Your name is: "+ StudentName);
            Console.WriteLine("Your semester is: "+ Semester);
        }
        public void CalculateGPA()
        {
            if (TotalObtain<=400)
            {
                percentComplete = (int)Math.Round((double)(100 * TotalObtain) / 400);
            }
            else if (TotalObtain<=500)
            {
                percentComplete = (int)Math.Round((double)(100 * TotalObtain) / 500);
            }
            else if (TotalObtain<=600)
            {
                percentComplete = (int)Math.Round((double)(100 * TotalObtain) / 600);
            }
            if (percentComplete>=85 && percentComplete<=100)
            {
                Console.WriteLine("Your GPA is 4.0");
            }
            else if (percentComplete >= 80 && percentComplete <= 84)
            {
                Console.WriteLine("Your GPA is 3.7");
            }
            else if (percentComplete >= 77 && percentComplete <= 79)
            {
                Console.WriteLine("Your GPA is 3.7");
            }
            else if (percentComplete >= 73 && percentComplete <= 76)
            {
                Console.WriteLine("Your GPA is 3.5");
            }
            else if (percentComplete >= 70 && percentComplete <= 72)
            {
                Console.WriteLine("Your GPA is 3.2");
            }
            else if (percentComplete >= 68 && percentComplete <= 70)
            {
                Console.WriteLine("Your GPA is 3.0");
            }
            else if (percentComplete >= 65 && percentComplete <= 67)
            {
                Console.WriteLine("Your GPA is 2.5");
            }
            else if (percentComplete >= 60 && percentComplete <= 65)
            {
                Console.WriteLine("Your GPA is 2.0");
            }
            else if (percentComplete >= 55 && percentComplete <= 59)
            {
                Console.WriteLine("Your GPA is 1.7");
            }
            else if (percentComplete >= 50 && percentComplete <= 54)
            {
                Console.WriteLine("Your GPA is 1.0");
            }
            else if (percentComplete <=49)
            {
                Console.WriteLine("Your GPA is below 1.0");
            }


        }
    }
}
