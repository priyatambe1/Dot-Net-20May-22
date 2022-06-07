using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class13
    {

        static void Main14(string[] args)
        {
            //var vs dynamic variable

            //var keyword this will be used for declaring a variable and this will be a compile time variable
            //dynamic keyword will be a runtime variable

            var x = 1;
            //x = "Priyanka";

            var y = "Priyanka";
            //y = 1;
            dynamic x1 = 2;
            x1 = "Priyanka";

            Console.WriteLine(x);
            Console.WriteLine(x1);
        }
    }
}
