using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area
{
    class Program
    {
         public static void Main(string[] args)
         {
            int side = 4;
            int length = 3;
            int breadth = 5;
            area.square.area_of_square(side);
            area.rectangle.area_of_rectangle(length,breadth);
         }
    }
    class square
    {
        public static void area_of_square(int side)
        {
            int resultarea;
            resultarea = side*side;
            Console.WriteLine("Area of square is: " + resultarea);

        }
    }
    class rectangle
    {
        public static void area_of_rectangle(int length, int breadth)
        {
            int resultrec;
            resultrec = length* breadth;
            Console.WriteLine("Area of rectangle is: " + resultrec);
        }
    }
}

