using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;



namespace DataStructure
 {
     class Largest
     {
        public static void Main(string[] args)
         {
            
            int [] arr=new int[]{2,5,7,12,15,6,9,10,23,1};
            int largest = arr[0];
            DataStructure.Array.array(arr, largest);
            DataStructure.Arrlist.arlist();
            DataStructure.Linkedlist.linklist();           

            
         }
     }
    public static class Array{
        public static void array(int[] arr, int largest )
        {
            for(int i=0;i<arr.Length;i++){
                if(arr[i]>largest)
                largest=arr[i];
            }
            Console.WriteLine("Largest element of the array is: " + largest);
        }
     }
     public static class Arrlist
     {
        public static void arlist()
        {
            var arr2= new ArrayList() {2,5,7,12,15,6,9,10,23,1};
            arr2.Sort();
            int largest2 = 0;
            foreach(int i in arr2)
            {
                if(i>largest2)
                {
                    largest2=i;
                }
            }
            Console.WriteLine("Largest element of the arraylist is: " + largest2);
        }
     }
    
        
     class Linkedlist
     {
        public static void linklist()
        {
            LinkedList<int> list=new LinkedList<int>();
            list.AddLast(2);
            list.AddLast(43);
            list.AddLast(56);
            list.AddLast(28);
            list.AddLast(32);
            list.AddLast(20);
            list.AddLast(12);
            list.AddLast(8);
            list.AddLast(6);
            list.AddLast(14);
            Console.WriteLine("Largest element of the Linkedlist is: " + list.Max());
        }
     }
 }
     
 