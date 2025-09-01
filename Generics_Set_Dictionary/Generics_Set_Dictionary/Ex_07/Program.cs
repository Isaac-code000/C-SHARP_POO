using System;
using System.Collections.Generic;
using Ex_07.Entities;
using System.IO;
namespace Ex_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a name of Instructor");
            string name = Console.ReadLine();
            Console.WriteLine("Enter id of instructor");
            int id = int.Parse(Console.ReadLine());

            Instructor instructor = new Instructor(name, id);

            Console.WriteLine("Quantity of courses");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("Course Name:");
                string course_name = Console.ReadLine();
                Course course = new Course(course_name,instructor);
                Console.WriteLine("Quantity of students in this course ?:");
                int num_students = int.Parse(Console.ReadLine());
                for (int j = 1; j <= num_students; j++)
                {
                    Console.WriteLine("Student Id:");
                    int student_id = int.Parse(Console.ReadLine());
                    Users user = new Users(student_id);
                    course.AddStudent(user);
                }
            }

            Console.WriteLine("Total students: " + instructor.AllStudents());



        }
    }
}