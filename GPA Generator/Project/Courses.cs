using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class Courses : Classes
    {
        protected string[] subs;

        protected int[] Marks;
        protected int TotalObtain=0;
        public void EntCourses()
        {
            Console.Write("How many courses you want to enter to make a GPA for it: ");
        TryAgain:
            int courses = Int32.Parse(Console.ReadLine());    
            for (int i = 1; i <= courses; i++)
            {
                if (courses == 4)
                {
                    subs = new string[courses];
                    for (int j = 0; j < subs.Length; j++)
                    {
                        if (j >= 0 && j <= 4)
                        {
                            Marks = new int[subs.Length];
                            Console.Write("Enter marks of subject " + (j+1) + " : ");
                            Marks[j] = Int32.Parse(Console.ReadLine());
                            TotalObtain = TotalObtain + Marks[j];
                        }
                        else
                        {
                            break;
                        }
                    }
                    break;
                }
                else if (courses == 5)
                {
                    subs = new string[courses];
                    for (int j = 0; j < subs.Length; j++)
                    {
                        if (j >=0 && j <= 5)
                        {
                            Marks = new int[subs.Length];
                            Console.Write("Enter marks of subject " + (j+1) + " : ");
                            Marks[j] = Int32.Parse(Console.ReadLine());
                            TotalObtain = TotalObtain + Marks[j];
                        }
                        else
                        {
                            break;
                        }
                    }
                    break;
                }
                else if (courses == 6)
                {
                    subs = new string[courses];
                    for (int j = 0; j < subs.Length; j++)
                    {
                        if (j >=0 && j <= 6)
                        {
                            Marks = new int[subs.Length];
                            Console.Write("Enter marks of subject " + (j+1) + " : ");
                            Marks[j] = Int32.Parse(Console.ReadLine());
                            TotalObtain = TotalObtain + Marks[j];
                        }
                        else
                        {
                            break;
                        }

                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Enter courses between 4 to 6 \nTry again: ");
                    goto TryAgain;
                }
            }

        }
    }
}
