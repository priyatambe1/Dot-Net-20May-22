﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    
    
    //overriding

    //virtual keyword
    //override


    class BaseClass
    {
        public virtual void show()
        {
            Console.WriteLine("I am coming from Base Class");
        }
    }
    class DerivedClass : BaseClass
    {
        public override void show()
        {
            Console.WriteLine("I am coming from Derived Class");
        }
    }
    class Class3
    {

        public static void Main4()
        {
            DerivedClass d = new DerivedClass();
            d.show();

            BaseClass obj;
            obj = new BaseClass();
            obj.show();

            obj = new DerivedClass();
            obj.show();
        }
    }
}
