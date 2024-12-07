using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Claims;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {       
            string filePath = @"/Users/Serik/Desktop/C#/Module 13/Text1.txt"; 

            var list = new List<String>();
            var linkedList = new LinkedList<String>();
          
            using (StreamReader sr = File.OpenText(filePath))
            {
                string str = "";
                while ((str = sr.ReadLine()) != null) 
                {
                    list.Add(str);
                    linkedList.AddFirst(str);
                }
            }

            var watch1= Stopwatch.StartNew();
            list.Insert(1, "Новая строка");
            Console.WriteLine($"Вставка в  List: {watch1.Elapsed.TotalMilliseconds}  мс");

            var watch2 = Stopwatch.StartNew();  
            linkedList.AddAfter(linkedList.First, "Новая строка");
            Console.WriteLine($"Вставка в  linkedList: {watch2.Elapsed.TotalMilliseconds}  мс");

            Console.ReadKey();
        }
    }
}
