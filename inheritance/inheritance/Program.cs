using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student student1 = new student("karem" , "alsayed" , 45);
            student1.PrintStudentDetails();

            Teacher teacher = new Teacher("jason", "smith", 500);
            teacher.PrintTeacherDetails();

        }
 
        class Base
        {
            public string Name { get; set; }
            public string LastName { get; set; }

            public Base(string name, string lastName)
            {
                Name = name;
                LastName = lastName;
            }

            public  void print()
            {
                System.Console.WriteLine(Name +" " +LastName);
            }
        }
        class student : Base
        {
            public int Id {  get; set; }

            public student(string name, string lastName, int id) : base(name , lastName)
            {
                Id = id;
            }
            public void PrintStudentDetails()
            {
                Console.WriteLine($"Student ID {Id}");
                base.print();
            }
        }

        class Teacher : Base 
        {
            public int salary {  get; set; }

            public Teacher(string name, string LastName,int salary) :base(name,LastName)
            {
                this.salary = salary;
            }
            public  void PrintTeacherDetails()
            {
                Console.WriteLine($"Teacher salary {salary}");
                base.print();
            }
        }
    }
}
