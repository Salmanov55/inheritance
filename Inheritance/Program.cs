using System;

namespace Inheritance
{
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }


        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
    }
    class Teacher : Person
    {
        public void Explain()
        {
            Console.WriteLine("Explaining...");
        }
        public Teacher(string name,string surname, int age) :base (name, surname, age)
        {
            
        }
    }
    class Student : Person
    {
        public void Learn()
        {
            Console.WriteLine("Learning...");
        }
        public Student(string name, string surname, int age) : base(name, surname, age)
        {
            
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student("Ali","Salmanov", 20);
            std.Learn();
            Teacher tch = new Teacher("Mahir", "Teyibov",20);
            tch.Explain();
            
        }
    }
}
