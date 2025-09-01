using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_07.Entities
{
    internal class Course
    {
        public string Name { get; set; }
        public Instructor Creator { get; set; }

        public List<Users> Students = new List<Users>();

        public Course(string name, Instructor creator)
        {
            Name = name;
            Creator = creator;
            creator.AddCourse(this);
        }
        public void AddStudent(Users user)
        {
            if (!Students.Contains(user))
            {
                Students.Add(user);
                user.JoinCourse(this);
                Creator.Total_Students.Add(user);
            }
            else
            {
                Console.WriteLine("User already enrolled in this course.");
            }
        }


    }
}
