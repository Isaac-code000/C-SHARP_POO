using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_07.Entities
{
    internal class Instructor
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public List<Course> Courses { get; set; } = new List<Course>();
        public HashSet<Users> Total_Students { get; set; } = new HashSet<Users>();

        public Instructor(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public void AddCourse(Course course)
        {
            Courses.Add(course);
        }

        public void ShowCourse()
        {
            foreach (var course in Courses)
            {
                Console.WriteLine(course);
            }
        }

        public int AllStudents()
        {
            foreach(var course in Courses)
            {
                foreach (Users student in course.Students)
                {
                    Total_Students.Add(student);
                }
            }
            return Total_Students.Count;
        }

        override public string ToString()
        {
            return "Name:" + Name
                + "Cousers: " + ShowCourse;
        }
    }
}
