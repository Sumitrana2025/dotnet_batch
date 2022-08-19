using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
         public static void Main(string[] args)
         {
            StringBuilder addWord = new StringBuilder("Sumit");
            addWord.Append(", Dinesh");
            addWord.Append(", Rana");
            Console.WriteLine(addWord);
         }
    }
}
