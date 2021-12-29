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
        [Ignore("this")]
        public void HouseBuilder_SetNegativeValueOfWindow_ThrowAgrumentOutOfRangeException()
        {
            //Arrange
            
            //Act
            ArgumentOutOfRangeException? ex = Assert.Throws<ArgumentOutOfRangeException>(() => _houseBuilder.SetNumberOfWindows(-1));

            //Assert
            Assert.That("Can not set a negative number of windows!", Is.EqualTo(ex.Message));
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