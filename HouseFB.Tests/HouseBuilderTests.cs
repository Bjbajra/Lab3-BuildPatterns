using NUnit.Framework;
using System;

namespace HouseFB.Tests
{
    [TestFixture]
    public class HouseBuilderTests
    {
        private HouseBuilder _houseBuilder;

        [SetUp]
        public void SetUp()
        {
            _houseBuilder = new HouseBuilder();
        }

        [Test]
        public void HouseBuilder_SetNegativeValueOfWindow_ThrowAgrumentOutOfRangeException()
        {
            //Arrange
            //Act

            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => _houseBuilder.SetStreetAdressl("NewRoad 1").SetNumberOfWindows(-2).Build());
        }

        [Test]
        public void HouseBuilder_NoParkingSpotInGarage_ReturnHasGarageFalse()
        {
            //Arrange
            House house = _houseBuilder.SetStreetAdressl("Main Street 3").SetNumberOfParkingSpot(0).Build();

            bool result = house.HasGarage;

            //Act

            //Assert   
            Assert.IsFalse(result);
        }
    }
}