using Tutorial3.Exceptions;
using Tutorial3.Interfaces;

namespace Tutorial3.Containers;

public class Container : IContainer
{
    public double CargoWeight { get; set; }
    public double Height { get; set; }
    public double OwnWeight{ get; set; }
    public double Depth { get; set; }
    public string SerialNumber { get; set; }
    public double MaxCapacity { get; set; }

    public Container(double cargoWeight, double height, double ownWeight, double depth, string serialNumberType, double maxCapacity)
    {
        CargoWeight = cargoWeight;
        Height = height;
        OwnWeight = ownWeight;
        Depth = depth;
        SerialNumber = "KON-" + serialNumberType + "-"  + Guid.NewGuid().ToString();
        MaxCapacity = maxCapacity;
    }

    public virtual void Unload()
    {
        CargoWeight = 0;
    }

    public virtual void Load(double cargoWeight)
    {
        if (cargoWeight > MaxCapacity)
        {
            throw new OverfillException("Overload of cargo with serial number: -" + SerialNumber + "-");
        }

        CargoWeight = cargoWeight;
        
    }
}
