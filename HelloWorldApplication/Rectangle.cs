using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApplication
{
    class Rectangle
    {
        double length;
        double width;

        public void Accepdetails()
        {
            length = 4.5;
            width = 3.5;
        }

        public double GetArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("Length: {0}",length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }
    class ExecuteRectangle
    {
        static void Main2(string[] args)
        {
            Rectangle r = new Rectangle();
            r.Accepdetails();
            r.Display();
            Console.ReadLine();
        }
    }
}
