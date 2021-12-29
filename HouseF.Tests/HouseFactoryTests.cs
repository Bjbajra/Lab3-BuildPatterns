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
    }
}