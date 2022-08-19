/*using System;
class new1{
    static public void Main[]
    {
        byte[] B ={2,4,6,8,10};
        Console.WriteLine("BArray is :{0}", BitConverter.ToString(B));

        Console.WriteLine();
        String str = Convert.ToBase64String(B);
        Console.WriteLine("Base 64 string is :{0}", str);
    }
}
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1,num2,result;
            Console.Write("Enter the first number: ");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            num2=Convert.ToInt32(Console.ReadLine());
            result=num1+num2;
            Console.WriteLine(string.Format($"Addition of {num1} and {num2} is:  "));
            result=num1-num2;
            Console.WriteLine(string.Format($"Subtraction of {num1} and {num2} is:  "));
            result=num1*num2;
            Console.WriteLine(string.Format($"Multiplication of {num1} and {num2} is:  "));
            result=num1/num2;
            Console.WriteLine(string.Format($"Division of {num1} and {num2} is:  "));
            
        }
    }
    
}
