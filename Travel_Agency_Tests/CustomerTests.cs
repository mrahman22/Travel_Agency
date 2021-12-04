using System;
using Travel_Agency;
using Xunit;

namespace Travel_Agency_Tests
{
    public class CustomerTests
    {
        [Fact]
        public void CheckIfCustomerFirstNameIsSet()
        {

            var customer = new Customers();
            customer.FirstName = "Kayden";
            
            Assert.Equal("Kayden", customer.FirstName);

        }
        
        [Fact]
        public void CheckIfCustomerLastNameIsSet()
        {
          
            var customer = new Customers();
            customer.LastName = "Hill";
            
            Assert.Equal("Hill", customer.LastName);
            
        }
        [Fact]
        public void CheckIfCustomerIdIsSet()
        {
            var customer = new Customers();
            customer.Id = Guid.NewGuid();
            
            Assert.NotEqual(Guid.Empty, customer.Id);
        
        }
        [Fact]
        public void CheckIfCustomerIsAcceptingMarketingIdIsSet()
        {
            var customer = new Customers();
            customer.IsAcceptingMarketing = true;
            
            Assert.Equal(true, customer.IsAcceptingMarketing);
        
        }
    }
}