using System;

namespace Travel_Agency
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            var greeting = new ConsoleService();
            var data = new FetchData();
            
            greeting.Greeting(data);

            // var hotels = new FetchData().GetData<Hotels>(DataType.Hotels);
        }
    }
}