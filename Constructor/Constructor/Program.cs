using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            baby baby1 = new baby();
            Console.WriteLine($"baby 1 - name {baby1.Firstname} - surname {baby1.Lastname} - DOB {baby1.Dateofbirth.ToShortDateString()}");

            baby baby2 = new baby("ahmet" , "yalmaz");
            Console.WriteLine($"baby 2 - name {baby2.Firstname} - surname {baby2.Lastname} - DOB {baby2.Dateofbirth.ToShortDateString()}");

            Console.ReadLine();
        }
        public class baby
        {
            public string Firstname { get; set; }
            public string Lastname {  get; set; }
            public DateTime Dateofbirth { get; set; }
            public baby()
            {
                Firstname = string.Empty;
                Lastname = string.Empty;
                Dateofbirth = DateTime.Now;
            }
            public baby(string firstname, string lastname)
            {
                Firstname = firstname;
                Lastname = lastname;
                Dateofbirth = DateTime.Now;
                Console.WriteLine("ingaaaa");
            }
        }
    }
}
