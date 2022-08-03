using System;

namespace math
 {
     class Operations
     {
         static void Main(string[] args)
         {
            int num1=15;
            int num2=5;
            math.Addition.Add(num1,num2);
            math.Subtraction.Sub(num1,num2);
            math.Multiplication.Mul(num1,num2);
            math.Division.Div(num1,num2);
            
    
         }
     }
    class Addition
    {
        public static void Add(int num1, int num2)
        {
            
            int resultAdd;
            resultAdd=num1+num2;
            Console.WriteLine("Using class, Addition of two numbers : "+ resultAdd);
        }
    }
    class Subtraction
    {
        public static void Sub(int num1, int num2)
        {
            
            int resultSub;
            resultSub=num1-num2;
            Console.WriteLine("Using class, Subtraction of two numbers : "+ resultSub);
        }
    }
    class Multiplication
    {
        public static void Mul(int num1, int num2)
        {
            
            int resultMul;
            resultMul=num1*num2;
            Console.WriteLine("Using class, Multiplication of two numbers : "+ resultMul);
        }
    }
    class Division
    {
        public static void Div(int num1, int num2)
        {
           
            int resultDiv;
            resultDiv=num1/num2;
            Console.WriteLine("Using class, Division of two numbers : "+ resultDiv);
        }
    }
 }