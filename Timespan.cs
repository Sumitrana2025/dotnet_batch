using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timespan
{
    class Date_time
    {
         public static void Main(string[] args)
         {
            DateTime date1 = new DateTime(2022, 08 , 02, 14, 38, 40);
            DateTime date2 = new DateTime(2018, 07, 18, 13, 22, 43);
            Timespan.Datediff.diff(date1,date2);

         }
    }
    class Datediff
    {
        public static void diff(DateTime date1,DateTime date2)
        {
            
            TimeSpan interval  = date1 - date2;
            Console.WriteLine("Time Difference is: " +  interval);
        }


    }
}   

