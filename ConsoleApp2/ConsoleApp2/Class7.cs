using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    /*Create a C# program to manage a photo book using object-oriented programming.

    To start, create a class called PhotoBook with a private attribute numPages of type int.
    It must also have a public method GetNumberPages that will return the number of photo book pages.

    The default constructor will create an album with 16 pages.There will be an additional constructor,
    with which we can specify the number of pages we want in the album.

    There is also a BigPhotoBook class whose constructor will create an album with 64 pages.

    Finally create a PhotoBookTest class to perform the following actions:

    Create a default photo book and show the number of pages
    Create a photo book with 24 pages and show the number of pages
    Create a Big photo book and show the number of pages  */

    public class PhotoBook
    {
        protected int numPages;

        public PhotoBook()
        {
            numPages = 16;
        }

        public PhotoBook(int numPages)                        //default constructor
        {
            this.numPages = numPages;
        }

        public int GetNumberPages()                              //Constructor
        {
            return numPages;
        }
    }

    public class SuperPhotoBook : PhotoBook
    {
        public SuperPhotoBook()
        {
            numPages = 64;
        }
    }
    public class PhotoBookTest
    {
        public static void Main8()
        {
            PhotoBook p = new PhotoBook();
            Console.WriteLine(p.GetNumberPages());

            PhotoBook p2 = new PhotoBook(24);
            Console.WriteLine(p2.GetNumberPages());

            SuperPhotoBook sp = new SuperPhotoBook();
            Console.WriteLine(sp.GetNumberPages());
        }
    }
}


