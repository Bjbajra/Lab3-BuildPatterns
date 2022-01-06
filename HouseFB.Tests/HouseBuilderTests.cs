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
        public void HouseBuilder_GivenStreetNameIsNullOrEmpty_ThrowArgumentException()
        {
            //Arrange
            //Act

            //Assert
            Assert.Throws<ArgumentException>( () =>_houseBuilder.SetStreetAddress("").Build());
            Assert.Throws<ArgumentException>( () =>_houseBuilder.SetStreetAddress(null).Build());
        }

        [Test]
        public void HouseBuilder_SetNegativeValueOfWindow_ThrowAgrumentOutOfRangeException()
        {
            //Arrange
            //Act

            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => _houseBuilder.SetStreetAddress("NewRoad 1").SetNumberOfWindows(-2).Build());
        }

        [Test]
        public void HouseBuilder_AddNegativeValueOfRoom_ThrowAgrumentOutOfRangeException()
        {
            //Arrange
            //Act

            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => _houseBuilder.SetStreetAddress("NewRoad 1").AddNumberOfRooms(-1).Build());
        }

        [Test]
        public void HouseBuilder_NoParkingSpotInGarage_ReturnHasGarageFalse()
        {
            //Arrange

            //Act
            House house = _houseBuilder.SetStreetAddress("Main Street 3").SetNumberOfParkingSpot(0).Build();

            bool result = house.HasGarage;

            //Assert   
            Assert.IsFalse(result);
        }

        [Test]
        [TestCase(2, 2 )]
        [TestCase(5, 5)]
        public void HouseBuilder_SetNoOfWindows_ReturnCorrectValue(int noOfWindows, int expectedResult)
        {
            //Arrange

            //Act
            House houseToCheck = _houseBuilder  
                .SetStreetAddress("Vasagatan 2")
                .SetNumberOfWindows(noOfWindows)                
                .Build();
            

            //Assert
            Assert.That( houseToCheck.NoOfWindows, Is.EqualTo(expectedResult) );
            Assert.That(houseToCheck.NoOfWindows, Is.EqualTo(expectedResult));
        }
    }
}