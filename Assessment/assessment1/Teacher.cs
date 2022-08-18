using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace Teacher
 {
    class Teacher_data
     {
        public static void Main(string[] args)
         {
            LinkedList<string>list1 =  new LinkedList<string>();
            LinkedList<string>list2 =  new LinkedList<string>();
            string path = @"C:\Users\Sumit.Rana\OneDrive\Documents\GitHub\dotnet_batch\Assessment\assessment1\teacherData.txt";
            string[] lines;
            lines=File.ReadAllLines(path);
            foreach(string line in lines)
            list1.AddLast(line);
            Console.WriteLine("Type view to view data");
            Console.WriteLine("Type delete to delete data");
            Console.WriteLine("Type insert to insert data");
            
            
            string Menu_option = Console.ReadLine();
            switch(Menu_option)
            {
                case "view":
                    Console.WriteLine("Viewing the data");
                    foreach(string i in list1)
                    Console.WriteLine(i);
                   
                    break;



                case "delete":
                    Console.WriteLine("Deleting the data");
                    Console.WriteLine("Enter the Teacher Id that you want to delete: ");
                    string deleted_id = Console.ReadLine();
                    deleted_id = "TeacherId: " + deleted_id;
                    
                    foreach(string line in list1)
                    {
                        if (line.Contains(deleted_id))
                        {
                            continue;
                        }
                        else
                        {
                            list2.AddLast(line);
                        }
                                
                            
                    }
                    foreach(string line in list2)
                    Console.WriteLine(line);
                    TextWriter writer = new StreamWriter(path);
                    writer.Flush();
                    foreach(string i in list2)
                    writer.WriteLine(i);
                    writer.Close();
                    Console.WriteLine("DATA DELETED SUCCESSFULLY!!");
            
                        
                    break;


                case "insert":
                    Console.WriteLine("Inserting the data");

                    Console.WriteLine("Enter the Teacher Id that you want to insert: ");
                    string inserted_id = Console.ReadLine();
                    

                    

                    Console.WriteLine("Enter the Teacher Name that you want to insert: ");
                    string inserted_name = Console.ReadLine();

                    Console.WriteLine("Enter the Teacher class that you want to insert: ");
                    string inserted_class = Console.ReadLine();

                    string insert_data = "TeacherId: " +  inserted_id + " | TeacherName: " + inserted_name + " | Class: " + inserted_class; 
                    

                    list1.AddLast(insert_data);
                    Console.WriteLine("Data inserted");
                    Console.WriteLine("Updated list");

                    foreach(string line in list1)
                    Console.WriteLine(line);
                    TextWriter writer1 = new StreamWriter(path);
                    writer1.Flush();
                    foreach(string i in list1)
                    writer1.WriteLine(i);
                    writer1.Close();
                    Console.WriteLine("DATA INSERTED SUCCESSFULLY!!");
                    
                    break;
                default:
                    Console.WriteLine("Option typed is invalid. Please select correct option");
                    break;
            }

         }    
     }
 }



            