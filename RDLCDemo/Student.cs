using System.Collections.Generic;

namespace RDLCDemo
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public Student(string name, int age, string address)
        {
            Name = name;
            Age = age;
            Address = address;
        }

        public static List<Student> GetStudents()
        {
            return new List<Student>()
            {
                new Student("Kannan", 20, "Nagercoil"),
                new Student("Karthi", 20, "Nagercoil"),
                new Student("Rajan", 20, "Nagercoil")
            };
        }
    }
}