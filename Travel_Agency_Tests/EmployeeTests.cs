using System;
using Travel_Agency;
using Xunit;

namespace Travel_Agency_Tests
{
    public class EmployeeTests
    {
        [Fact]
        public void CheckIfEmployeeFirstNameIsSet()
        {
            var employee = new Employees();
            employee.FirstName = "Alfonso";
            
            Assert.Equal("Alfonso", employee.FirstName);
        }
        
        [Fact]
        public void CheckIfEmployeeLastNameIsSet()
        {
            var employee = new Employees();
            employee.LastName = "Diaz";
            
            Assert.Equal("Diaz", employee.LastName);
            
      
        }
        [Fact]
        public void CheckIfEmployeeIdIsSet()
        {
            var employee = new Employees();
            employee.Id = Guid.NewGuid();
            
            Assert.NotEqual(Guid.Empty, employee.Id);

        }
    }
}