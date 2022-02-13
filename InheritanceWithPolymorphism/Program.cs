global using static System.Console;
using InheritanceWithPolymorphism;

Vehicle v1 = new();
v1.GearType();
Car c1 = new();
c1.GearType();

List<Car> carList = new();

for (int i = 0; i < 50; i++)
{
    Car car = new()
    {
        Name = Faker.Country.Name(),
        Model = Faker.Internet.DomainSuffix(),
        VehicleNumber = Faker.Address.UkPostCode()
    };
    carList.Add(car);
}

WriteLine("Printing list of Cars");
WriteLine(carList[10].Name);


