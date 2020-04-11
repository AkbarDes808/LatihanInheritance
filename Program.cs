using System;

namespace _LatihanInheritance_
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Mike";
            person.Age = 20;
            person.GetNameAndAge();

            Teacher teacher = new Teacher();
            teacher.Name = "Thomas";
            teacher.Age = 35;
            teacher.TeacherId = "190302";
            teacher.Subject = "Math";
            teacher.GetNameAndAge();

            student student = new student();
            student.Name = "Sara";
            student.Age = 19;
            student.StudentId = "10506";
            student.Email = "sarah1234@amikom.ac.id";
            student.GetNameAndAge();

            Console.ReadKey();
        }
    }
}
