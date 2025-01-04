using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphisim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square { height = 5, width = 5};
            Rectangle rectangle = new Rectangle { height = 4, width = 7};
            Righttriangle traingle = new Righttriangle { height = 2, width = 30};

            Console.WriteLine("area of square " + square.Calculate());
            Console.WriteLine("area of rectangle " + rectangle.Calculate());
            Console.WriteLine("area of right triangle " + traingle.Calculate());
        }

        public class Geometry
        {

            public int height { get; set; }
            public int width { get; set; }
            public virtual int Calculate()
            {
                return 0;
            }


        
        }
        public class  Square : Geometry
        {
            public override int Calculate()
            {
                return height * width;
            }
        }

        public class Righttriangle : Geometry
        {
            public override int Calculate()
            {
                return (height * width) / 2;
            }
        }

        public class Rectangle : Geometry
        {
            public override int Calculate()
            {
                return height * width;
            }
        }

    }
}
