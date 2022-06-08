using ConsoleApp4.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace ConsoleApp4
{
    class Class1
    {
        static void ListData(SampleDB1Context db)
        {
            var data = db.Tblsamples;
            foreach (var item in data)
            {
                Console.WriteLine(item.Id + " | " + item.Text);
            }
        }
        static void Main(string[] args)
        {
            SampleDB1Context db = new SampleDB1Context();
            bool Exit = false;
            while (true)
            {
                Console.WriteLine("Please enter some choice \n 1.Add Record \n 2.List Record \n 3.Update Record \n 4.Delete Record \n 5.Exit");
                Console.WriteLine("================================");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Please enter your name");
                        string name = Console.ReadLine();

                        Tblsample tblsample = new Tblsample();
                        tblsample.Text = name;
                        db.Tblsamples.Add(tblsample);
                        db.SaveChanges();
                        Console.WriteLine("Record added successfully.");
                        Console.WriteLine("================================");
                        break;
                    case 2:
                        ListData(db);
                        break;
                    case 3:
                        ListData(db);
                        Console.WriteLine("Pleae enter id which you want to update");
                        int UpdateId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter the new name");
                        var newName = Console.ReadLine();
                        var UpdateObject = db.Tblsamples.Where(x => x.Id == UpdateId).FirstOrDefault();
                        UpdateObject.Text = newName;
                        db.Tblsamples.Update(UpdateObject);
                        db.SaveChanges();
                        Console.WriteLine("Record is successfully updated.");
                        break;
                    case 4:
                        ListData(db);
                        Console.WriteLine("Pleae enter id of your name which you want to delete");
                        int DeleteItem = Convert.ToInt32(Console.ReadLine());
                        var DeleteObject = db.Tblsamples.Where(x => x.Id == DeleteItem).FirstOrDefault();
                        db.Tblsamples.Remove(DeleteObject);
                        db.SaveChanges();
                        Console.WriteLine("Record is successfully Deleted.");

                        //   foreach (var item in data)
                        // {
                        //  Console.WriteLine(item.Id + " | " + item.Text);
                        //  }
                        break;
                    case 5:
                        Exit = true;
                        break;
                    default:
                        Console.WriteLine("Please enter correct choice!!");
                        break;
                }
                if (Exit)
                    break;
            }
        }
    }
}
