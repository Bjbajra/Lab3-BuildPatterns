using NUnit.Framework;
using System.Collections.Generic;

namespace HouseF.Tests
{
    public class HouseFactoryTests
    {
        private HouseFactory _factory;
        [SetUp]
        public void Setup()
        {
            _factory = new HouseFactory();
        }

        [Test]
        public void BuildHouse_GivenInvalidHouseName_ThrowsKeyNotFoundException()
        { 
            //Arrange
           
            //Act
            string nonExsistsHouse = "beachHouse";

            //Assert
            Assert.Throws<KeyNotFoundException>(() => _factory.ConstructHouse(nonExsistsHouse));
        }

    }
}