using System;

namespace Project_27._10._2021
{
    public abstract class Person
    {
        private int Age;
        public int Age1 { get => Age; set => Age = value; }
        private string Name;
        public string Name1 { get=>Name; set=> Name = value; }
        public abstract void Greet();
        public void ShowAge(int Age)
        {
            this.Age = Age;
            Console.WriteLine($"Tuoi = {Age}");
        }

    }
    public class Student: Person
    {
        
        public override void Greet()
        {
            Console.WriteLine($"Hello! I am {Name1}");
        }
        public void Study()
        {
            Console.WriteLine("I am studying");
        }
    }
    public class Teacher: Person
    {
        public override void Greet()
        {
            Console.WriteLine($"Hello! I am {Name1}");
        }
        public void Teach()
        {
            Console.WriteLine("I am giving you a lesson");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student myStudent = new Student();
            myStudent.Name1 = "Keth";
            myStudent.Greet();
            myStudent.Age1 = 12;
            myStudent.ShowAge(myStudent.Age1);
            myStudent.Study();

            Teacher myTeacher = new Teacher();
            myTeacher.Name1 = "Johnson";
            myTeacher.Greet();
            myTeacher.Age1 = 32;
            myTeacher.ShowAge(myTeacher.Age1);
            myTeacher.Teach();
        }
    }
}
