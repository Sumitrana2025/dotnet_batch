using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee
{
    class Program
    {
         public static void Main(string[] args)
         {
            string name1 = "Sumit Rana";
            string address1 = "Bhayandar";
            string name2 = "Shubham Mukherjee";
            string address2 = "Mira road";
            string name3 = "Vikram Rao";
            string address3 = "Malad";
            employee.emp.details(name1,address1,name2,address2,name3,address3);


         }
    }
    class emp
    {
        public static void details(string name1,string address1,string name2,string address2,string name3,string  address3)
        {
        string emp_details1 = name1 + address1; 
        string emp_details2=name2 + address2;
        string emp_details3=name3+ address3 ;

        Console.WriteLine("Employee 1 name is: " + name1 + " and address is: "+address1);
        Console.WriteLine("Employee 2 name is: " + name2 + " and address is: "+address2);
        Console.WriteLine("Employee 3 name is: " + name3 + " and address is: "+address3);


        }
    }
}
            