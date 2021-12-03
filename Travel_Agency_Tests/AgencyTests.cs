using System;
using System.Collections.Generic;
using Travel_Agency;
using Xunit;

namespace Travel_Agency_Tests
{
    public class AgencyTests
    {
        [Fact]
        public void CheckHotelsDataIsReturnedCorrectly()
        {
            List<Hotels> hotels = new FetchData().GetData<Hotels>(DataType.Hotels);
            
            Assert.Equal(hotels[0].City, "Paris");
            Assert.Equal(hotels[2].City, "Berlin");
            Assert.NotEmpty(hotels);
        }

        [Fact]
        public void CheckEmployeesDataIsReturnedCorrectly()
        {
            List<Employees> employees = new FetchData().GetData<Employees>(DataType.Employees);
            
            Assert.Equal(employees[0].FirstName, "Tom");
            Assert.Equal(employees[2].FirstName, "Amir");
            Assert.NotEmpty(employees);
            
        }
    }
}