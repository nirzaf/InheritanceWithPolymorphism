public interface IVehicle
{
    void GearType();
}

public class Vehicle : IVehicle
{
    public string Name { get; set; }
    public string Model { get; set; }
    public string VehicleNumber { get; set; }

    public virtual void GearType()
    {
        WriteLine("Manual");
    }
}