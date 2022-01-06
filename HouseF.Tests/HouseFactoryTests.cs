using HouseF.Houses;
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
        public void HouseFactory_GivenInvalidHouseName_ThrowsKeyNotFoundException()
        {
            //Arrange

            //Act
            string nonExsistsHouse = "beachHouse";

            //Assert
            Assert.Throws<KeyNotFoundException>(() => _factory.ConstructHouse(nonExsistsHouse));
        }

        [Test]
        [TestCase("normalhouse", true)]
        [TestCase("housewithgarage", true)]
        [TestCase("perfecthouse", true)]
        public void HouseFactory_GivenExistingHouse_ReturnCorrectHouse(string houseToCheck, bool expectedHouse)
        {
            //Arrange

            //Act
            House calculatedHouse = _factory.ConstructHouse(houseToCheck);

            bool result = false;

            if (calculatedHouse is NormalHouse || calculatedHouse is HouseWithGarage || calculatedHouse is PerfectHouse)
            {
                result = true;
            }

            //Assert
            Assert.That(result, Is.EqualTo(expectedHouse));
        }

        [Test]
        public void HouseFactory_NormalHouse_ReturnsCorrectHouseType()
        {
            //Arrange

            //Act
            House houseToCheck = _factory.ConstructHouse("normalhouse");

            //Assert
            Assert.That(houseToCheck.NoOfRooms, Is.EqualTo(2));
            Assert.That(houseToCheck.NoOfWindows, Is.EqualTo(3));
            Assert.That(houseToCheck.StreetAdress, Is.EqualTo("Newroad 12"));
            Assert.That(houseToCheck.HasSwimmingPool, Is.False);
            Assert.That(houseToCheck.ParkingSpotsInGarage, Is.EqualTo(0));
        }
        
        [Test]
        public void HouseFactory_HouseWithGarage_ReturnsCorrectHouseType()
        {
            //Arrange

            //Act
            House houseToCheck = _factory.ConstructHouse("housewithgarage");

            //Assert
            Assert.That(houseToCheck.NoOfRooms, Is.EqualTo(3));
            Assert.That(houseToCheck.NoOfWindows, Is.EqualTo(4));
            Assert.That(houseToCheck.StreetAdress, Is.EqualTo("FreakStreet 07"));
            Assert.That(houseToCheck.HasSwimmingPool, Is.False);
            Assert.That(houseToCheck.ParkingSpotsInGarage, Is.EqualTo(1));
        }
        
        [Test]
        public void HouseFactory_Perfect_ReturnsCorrectHouseType()
        {
            //Arrange

            //Act
            House houseToCheck = _factory.ConstructHouse("perfecthouse");

            //Assert
            Assert.That(houseToCheck.NoOfRooms, Is.EqualTo(5));
            Assert.That(houseToCheck.NoOfWindows, Is.EqualTo(8));
            Assert.That(houseToCheck.StreetAdress, Is.EqualTo("HighStreet 13"));
            Assert.That(houseToCheck.HasSwimmingPool, Is.True);
            Assert.That(houseToCheck.ParkingSpotsInGarage, Is.EqualTo(3));
        }
    }
}