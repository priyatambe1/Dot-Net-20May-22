using System;

namespace ConsoleApp2
{
    class Program
    {
      
        // Print Employee Details
        class Employee
        {

            public string E_Name;
            public int E_Id;
            public string E_Gender;
            public Double Salary;
        }
        public static void Main1(string[] args)
        {

            Employee e = new Employee();
            e.E_Name = "Priyanka";
            e.E_Id = 1;
            e.E_Gender = "Female";
            e.Salary = 10000;

            Console.WriteLine("Employee Details");
            Console.WriteLine(e.E_Name);
            Console.WriteLine(e.E_Id);
            Console.WriteLine(e.E_Gender);
            Console.WriteLine(e.Salary);
        }
    }
}
