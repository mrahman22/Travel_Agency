using System.Collections.Generic;

namespace Travel_Agency
{
    public class Agency
    {
        public List<Hotels> Hotels { get; set; }
        public List<Employees> Employees { get; set; }
        
        public List<Customers> Customers { get; set; }

        
        public Agency(IFetchData data)
        {
            Hotels = data.GetData<Hotels>(DataType.Hotels);
            Employees = data.GetData<Employees>(DataType.Employees);
            Customers = data.GetData<Customers>(DataType.Customers);
        }

    }
}