using System.Collections.Generic;
using Travel_Agency;
using Xunit;

namespace Travel_Agency_Tests
{
    public class HotelTests
    {
        [Fact]
        public void CheckIfHotelNameIsSet()
        {
            var hotel = new Hotels();
            hotel.Name = "Sleeping Beauty";
            Assert.Equal("Sleeping Beauty", hotel.Name);
        }
        [Fact]
        public void CheckIfHotelCityIsSet()
        {
            var hotel = new Hotels();
            hotel.City = "Madrid";
            Assert.Equal("Madrid", hotel.City);
        }
        [Fact]
        public void CheckIfHotelCostPerNightIsSet()
        {
            var hotel = new Hotels();
            hotel.CostPerNight = 120.00;
            Assert.Equal(120.00, hotel.CostPerNight);
        }
        [Fact]
        public void CheckIfHotelStarRating()
        {
            var hotel = new Hotels();
            hotel.StarRating = 4.5;
            Assert.Equal(4.5, hotel.StarRating);
        }
    }
}