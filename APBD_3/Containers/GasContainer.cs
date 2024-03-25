using Tutorial3.Exceptions;
using Tutorial3.Interfaces;

namespace Tutorial3.Containers;

public class GasContainer : Container, IHazardNotifier
{
    private double Pressure;
    
    
    public GasContainer(double cargoWeight, double height, double ownWeight, double depth, double maxCapacity, double pressure) 
        : base(cargoWeight, height, ownWeight, depth, "G", maxCapacity)
    {
        Pressure = pressure;
    }

    public override void Load(double cargoWeight)
    {
        if (cargoWeight > MaxCapacity)
        {
            throw new OverfillException("Overload of cargo gas-container with serial number: -" + base.SerialNumber + "-");
        }
        else
        {
            base.Load(cargoWeight);            
        }
    }

    public override void Unload()
    {
        CargoWeight = 0.05 * CargoWeight;
    }

    public void HazardNotifier()
    {
        Console.WriteLine("Hazardous situation with gas-container with serial number: -" + base.SerialNumber + "-");
    }
    
}