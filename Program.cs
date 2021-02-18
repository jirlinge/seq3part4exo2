using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> mylist = new List<string> { "html", "css", "javacrit", "jquery","php","bootstrap","java" };
            Console.WriteLine("list avant corection");
            mylist.ForEach(Console.WriteLine);

            Console.WriteLine(mylist[3]);
            Console.WriteLine(mylist[4]);

            mylist.RemoveAt(5);
            Console.WriteLine("l'index de javacrit est "+ mylist.IndexOf("javacrit"));
            mylist[2] = ("javascript");
            mylist.Insert(4,"C");

            Console.WriteLine("voici la list a jour");
            mylist.ForEach(Console.WriteLine);

        }
    }
}
