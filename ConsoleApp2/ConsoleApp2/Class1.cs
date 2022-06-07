using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Class1
    {
        class sample
        {
            //fields

            public int a;
            //constructors
            /*
             * private constructor
             * default constructor
             * Parameterzied Constructor
             * Copy Constructor
             * static Constructor
             */
            //destructors
            //properties
            //methods
        }

        class emp
        {
            private string ename;
            private int eid;
            private string egender;
            private Double salary;
            private string CompanyName;

            //<access-modifier> <class-name> (<parameters>)
            public emp()
            {
                CompanyName = "CapGemini";
            }

            //~ <class-name>()
            //get Input from User
            ~emp()
            {

            }
            //Methods in a class
            public void GetData()
            {
                Console.WriteLine("Please enter Employee Details");
                Console.WriteLine("Please enter Employee Name");
                ename = Console.ReadLine();
                Console.WriteLine("Please enter Employee ID");
                eid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter Employee Gender");
                egender = Console.ReadLine();
                Console.WriteLine("Please enter Employee Salary");
                salary = Convert.ToDouble(Console.ReadLine());
            }

            public void PrintData()
            {
                Console.WriteLine("Employee Details are");
                Console.WriteLine(ename);
                Console.WriteLine(eid);
                Console.WriteLine(egender);
                Console.WriteLine(salary);
            }
        }

        class Class2
        {
            static void Main2(string[] args)
            {
                //sample e1 = new sample();
                //e1.a=6;

                //Console.WriteLine(e1.a);

                //<class-name> <object-name>=new <class-Name>()

                // emp e = new emp();
                //e.GetData();
                //e.PrintData();
                // emp e1 = new emp();
                //e1.GetData();
                //e1.PrintData();

                //emp e = new emp();
                //e.ename = 4;
                //array of objects

                emp[] emplist = new emp[2];
                for (int i = 0; i < emplist.Length; i++)
                {
                    emp e = new emp();
                    e.GetData();
                    emplist[i] = e;
                }

                for (int i = 0; i < emplist.Length; i++)
                {
                    emplist[i].PrintData();
                }

            }
        }
    }
}

