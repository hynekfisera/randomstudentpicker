using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPicker
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
        public Student()
        {
            Name = "Anonymous";
            Age = 0;
            BirthDate = DateTime.Now;
        }
        public Student(string name, int age, DateTime birthDate)
        {
            Name = name;
            Age = age;
            BirthDate = birthDate;
        }
        public override string ToString()
        {
            return Name+","+Age+","+BirthDate;
        }
    }
}
