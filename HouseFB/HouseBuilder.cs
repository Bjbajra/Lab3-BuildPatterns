namespace HouseFB
{
    public class HouseBuilder
    {
        private House _house;
        public HouseBuilder()
        {
            _house = new House();
        }
        public HouseBuilder SetStreetAddress(string streetAddress)
        {
            _house.StreetAddress = streetAddress;
            return this;
        }
        public HouseBuilder WithSwimmingPool()
        {
            _house.HasSwimmingPool = true;
            return this;
        }
        public HouseBuilder AddNumberOfRooms(int noOfRooms)
        {
            _house.NoOfRooms += noOfRooms;
            return this;
        }
        public HouseBuilder SetNumberOfWindows(int noOfWindows)
        {
            _house.NoOfWindows = noOfWindows;
            return this;
        }
        public HouseBuilder SetNumberOfParkingSpot(int noOfParkingSpotInGarage)
        {
            _house.ParkingSpotsInGarage = noOfParkingSpotInGarage;
            return this;

        }
        public House Build()
        {
            if (String.IsNullOrEmpty(_house.StreetAddress))
            {
                throw new ArgumentException("You must provide the street address.");
            }
            if (_house.NoOfRooms <= 0)
            {
                throw new ArgumentOutOfRangeException("Can not add a negative number of rooms!");
            }
            if (_house.NoOfWindows < 0)
            {
                throw new ArgumentOutOfRangeException("Can not set a negative number of windows!");
            }
            if (_house.ParkingSpotsInGarage < 0)
            {
                throw new ArgumentOutOfRangeException("Can not set a negative number of parking spot!");
            }
            return _house;
        }
    }
}
