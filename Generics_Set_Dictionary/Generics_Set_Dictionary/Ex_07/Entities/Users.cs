using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_07.Entities
{
    internal class Users
    {
        public string Name { get; set; }
        public int Id { get; set; }

        List<Course> Courses = new List<Course>();

        public Users(int id)
        {
            Id = id;
        }

        public Users(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public void JoinCourse(Course course)
        {
            if (!Courses.Contains(course))
            {
                Courses.Add(course);
            }
            else
            {
                Console.WriteLine("User already enrolled in this course.");
            }

        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is Users))
            {
                return false;
            }
            Users other = obj as Users;
            return Id.Equals(other.Id);
        }

        override public string ToString()
        {
            return Name;
        }
    }
}