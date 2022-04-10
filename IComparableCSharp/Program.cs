using IComparableCSharp.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace IComparableCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string filePath = @"C:\temp\in.csv";
            try
            {
                List<Employee> employees = new List<Employee>();
                using(StreamReader sr = new StreamReader(filePath))
                {
                    while (!sr.EndOfStream)
                    {
                        employees.Add(new Employee(sr.ReadLine()));                       
                    }
                }
                employees.Sort();
                foreach (var employee in employees)
                {
                    Console.WriteLine(employee);
                }
                Console.ReadKey();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }
}
