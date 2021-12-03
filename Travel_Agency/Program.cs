using System;

namespace Travel_Agency
{
    internal class Program
    {
        public static void Main(string[] args)
        { 
            var data = new FetchData();
            var hotels = data.GetData<Hotels>(DataType.Hotels);
        }
    }
}