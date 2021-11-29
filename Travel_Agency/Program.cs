using System;

namespace Travel_Agency
{
    internal class Program
    {
        public static void Main(string[] args)
        {

           Console.Write("Please may I take your name: ");
           string name = Console.ReadLine();
           var console = new ConsoleService(name);
           Console.Write(console);
        }
    }
}