using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person Student1 = new Person("ahmet " , "baba " ,  new DateTime(2000,10,10));
            Console.WriteLine(Student1.Firstname + Student1.Lastname + Student1.Dateofbirth.ToShortDateString());

            Person Student2 = new Person("mehmet ", "joseph ", new DateTime(2002, 8, 24));
            Console.WriteLine(Student2.Firstname + Student2.Lastname + Student2.Dateofbirth.ToShortDateString());

            Person Teacher1 = new Person("fevzeyi ", "babushka ", new DateTime(1950, 1, 26));
            Console.WriteLine(Teacher1.Firstname + Teacher1.Lastname + Teacher1.Dateofbirth.ToShortDateString());

            Person Teacher2 = new Person("sicak ", "simit ", new DateTime(2024, 12, 30));
            Console.WriteLine(Teacher2.Firstname + Teacher2.Lastname + Teacher2.Dateofbirth.ToShortDateString());

            Console.ReadKey();
          

        }
        class Person
        {
            public string Firstname { get; set; }
            public string Lastname { get; set; }
            public DateTime Dateofbirth { get; set; }

            public Person(string firstname, string lastname, DateTime dateofbirth)
            {
                Firstname = firstname;
                Lastname = lastname;
                Dateofbirth = dateofbirth;
            }
        }
    }
}
