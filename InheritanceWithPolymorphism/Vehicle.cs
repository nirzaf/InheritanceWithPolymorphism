public class Vehicle
{
    public string Name { get; set; }
    public string Model { get; set; }
    public string VehicleNumber { get; set; }

    public virtual void GearType()
    {
        Console.WriteLine("Manual");
    }
}