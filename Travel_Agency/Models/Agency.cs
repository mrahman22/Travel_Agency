using System.Collections.Generic;

namespace Travel_Agency
{
    public class Agency
    {
        public List<Hotels> Hotels { get; set; }
        public List<Employees> Employees { get; set; }

        
        public Agency(IFetchData data)
        {
            Hotels = data.GetData<Hotels>(DataType.hotels);
            Employees = data.GetData<Employees>(DataType.employees);
        }

    }
}