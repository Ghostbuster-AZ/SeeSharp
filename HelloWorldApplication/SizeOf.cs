using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApplication
{
    class SizeOf
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Size of int: {0}", sizeof(int));
            Console.WriteLine("Size of char: {0}", sizeof(char));
            Console.WriteLine("Size of float: {0}", sizeof(float));
        }
    }
}
