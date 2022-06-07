using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Class3
    {
        //properties
        /// <summary>
        /// 
        /// </summary>

        class PropertiesInClass
        {
            public PropertiesInClass(double r)
            {
                _radius = r;
            }
            private double _radius;
            private const double _pi = 3.14;
            public double radius
            {
                get
                {
                    return _radius;
                }
            }
            public void PrintCircumference()
            {
                Console.WriteLine(2 * _pi * radius);
            }
        }

        class Classa2
        {
            public static void Main4()
            {
                PropertiesInClass p = new PropertiesInClass(2.5);
                Console.WriteLine("Radius is " + p.radius);
                p.PrintCircumference();
                ;
            }


        }
    }
}
