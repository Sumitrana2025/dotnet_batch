using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_and_builder
{
    class Program
    {
         public static void Main(string[] args)
         {
            string str1 = "Sumit";
            string str2 = "Dinesh";
            string str3 = "Rana";
            string_and_builder.build.builder(str1,str2,str3);
            string_and_builder.string_concatenate.concatenate(str1,str3);
            
         }
    }
    class build
    {
        public static void builder(string str1,string str2,string str3)

        {
            StringBuilder addWord = new StringBuilder();
            addWord.Append(str1);
            addWord.Append(str2);
            addWord.Append(str3);
            Console.WriteLine(addWord);
         }
            
    }
    class string_concatenate
    {
        public static void concatenate(string str1, string str3)
        {
            string resultCon;
            resultCon = str1+str3;
            Console.WriteLine("The string concetanation is: " + resultCon);

        }
    }


}
