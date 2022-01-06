using HouseFB;

HouseBuilder builder = new HouseBuilder();
builder.SetStreetAddress("NewRoad 11");
House house = builder
    .WithSwimmingPool()
    .AddNumberOfRooms(2)
    .SetNumberOfWindows(1)
    .SetNumberOfParkingSpot(2)
    .Build();

Console.WriteLine(house);