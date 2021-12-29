using HouseFB;

HouseBuilder builder = new HouseBuilder();
builder.SetStreetAdressl("NewRoad 11");
House house = builder    
    .WithSwimmingPool()
    .AddNumberOfRooms(3)
    .SetNumberOfWindows(1)
    .SetNumberOfParkingSpot(2)    
    .Build();

/*HouseBuilder builder1 = new HouseBuilder();
    builder1.SetStreetAdressl("NewRoad 11");
House house1 = builder1    
    .WithSwimmingPool()
    .AddNumberOfRooms(3)
    .SetNumberOfWindows(1)
    .SetNumberOfParkingSpot(2)    
    .Build();*/


Console.WriteLine(house);
//Console.WriteLine(house1);