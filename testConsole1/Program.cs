using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] student = { "Ali", "Ahmed", "Jafer", "Joar" };
            Console.WriteLine("Enter the student name for search");
            string studentName = Console.ReadLine();
            bool contains = false;
            for (int i = 0; i < student.Length; i++)
            {
                if (studentName == student[i])
                {
                    contains = true;
                }
            }
            if (contains == true)
            {
                Console.WriteLine("The student is in the class");
            }
            else
            {
                Console.WriteLine("The student is not in the class");
            }

            //int[] grades = { 55, 58, 66, 77, 88 };
            //for (int i = 0; i<grades.Length;i++)
            //{
            //    grades[i] += 3;
            //    Console.WriteLine(grades[i]);
            //}
        }
    }
}
