using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Class6
    {
        /*Create a new C # project with three classes plus another class to test the logic in your code. The main classes of the program are the following classes:

        Person
        Student
        Teacher

The Student and Teacher classes inherit from the Person class.

The Student class will include a public Study() method that will write I'm studying on the screen.

The Person class must have two public methods Greet() and SetAge(int age) that will assign the age of the person.

The Teacher class will include a public Explain() method that will write I'm explaining on the screen.

Also create a public method ShowAge() in the Student class that writes My age is: x years old on the screen.

You must create another test class called StudentProfessorTest with a Main method to do the following:

Create a new Person and make him say hello
Create a new Student, set an age, say hello, and display her age on the screen.
Create a new Teacher, set an age, say hello and start the explanation. */

       
        class Person
        {
            protected int age;
            public void Greet()
            {
                Console.WriteLine("Hello");
            }

            public void SetAge(int n)
            {
                age = n;
            }
        }
        class Student : Person
        {
            public void Study()
            {
                Console.WriteLine("I'm studying on the screen.");
            }

            public void ShowAge()
            {
                Console.WriteLine("My age is: {0} ",age);
            }

        }
        class Teacher : Student
        {
            public void Explain()
            {
                Console.WriteLine("I'm explaining on the screen.");
            }
        }
        class StudentProfessorTest
        {
            public static void Main7()
            {
                Person p = new Person();
                p.Greet();

                Student s = new Student();
                s.SetAge(25);
                s.Greet();
                s.ShowAge();
                s.Study();

                Teacher t = new Teacher();
                t.SetAge(30);
                t.Greet();
                t.Explain();


            }
        }

    }
}
