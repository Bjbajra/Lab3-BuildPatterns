using HouseFB;

HouseBuilder builder = new HouseBuilder();
builder.SetStreetAdressl("NewRoad 11");
House house = builder
    .WithSwimmingPool()
    .AddNumberOfRooms(3)
    .SetNumberOfWindows(1)
    .SetNumberOfParkingSpot(2)
    .Build();

Console.WriteLine(house);