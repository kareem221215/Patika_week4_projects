using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee pm = new ProjectManager("Hasan", "Çıldırmış", "Management");
            Employee dev = new SoftwareDeveloper("Ali", "Yazıcı", "Development");
            Employee sales = new SalesRepresentative("Zeynep", "Satıcı", "Sales");

            
            pm.PerformDuty();    // Output: Hasan Çıldırmış is working as a Project Manager.
            dev.PerformDuty();   
            sales.PerformDuty(); 
        }
        abstract class Employee
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Department { get; set; }

            public Employee(string firstName, string lastName, string department)
            {
                FirstName = firstName;
                LastName = lastName;
                Department = department;
            }

            // Abstract Method
            public abstract void PerformDuty();
        }

        // Subclass: Project Manager
        class ProjectManager : Employee
        {
            public ProjectManager(string firstName, string lastName, string department)
                : base(firstName, lastName, department) { }

            public override void PerformDuty()
            {
                Console.WriteLine($"{FirstName} {LastName} is working as a Project Manager.");
            }
        }

        // Subclass: Software Developer
        class SoftwareDeveloper : Employee
        {
            public SoftwareDeveloper(string firstName, string lastName, string department)
                : base(firstName, lastName, department) { }

            public override void PerformDuty()
            {
                Console.WriteLine($"{FirstName} {LastName} is working as a Software Developer.");
            }
        }

        // Subclass: Sales Representative
        class SalesRepresentative : Employee
        {
            public SalesRepresentative(string firstName, string lastName, string department)
                : base(firstName, lastName, department) { }

            public override void PerformDuty()
            {
                Console.WriteLine($"{FirstName} {LastName} is working as a Sales Representative.");
            }
        }

    }
}
