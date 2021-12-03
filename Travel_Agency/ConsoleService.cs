using System;
using System.Collections.Generic;

namespace Travel_Agency
{
    public class ConsoleService
    {
        public void Greeting(IFetchData data)
        {
            Console.Write("Good Morning, Please can I take your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Welcome to the Agency Agent {name}");
            
            
            Console.Write("Please select one of the following options: ");
            Console.Write("A - Show all hotels " + "B - Show all employees ");
            var userChoice = Console.ReadLine();

            if (userChoice.ToUpper() == "A")
            {
                List<Hotels> hotels = data.GetData<Hotels>(DataType.Hotels); 
                foreach (var hotel in hotels)
                {
                    Console.WriteLine($"Hotel Name: {hotel.Name}, Hotel City: {hotel.City}");
                }
            } else if (userChoice.ToUpper() == "B")
            {
                List<Employees> employees = data.GetData<Employees>(DataType.Employees); 
                foreach (var employee in employees)
                {
                    Console.WriteLine($"Hotel Name: {employee.FirstName}, Hotel City: {employee.Id}");
                }
            }
            else
            {
                Console.WriteLine("You have selected an invalid option, please try again.");
                var newData = new FetchData();
                Greeting(newData);
            }


        }
    }
}