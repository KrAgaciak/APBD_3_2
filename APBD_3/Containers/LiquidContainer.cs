using Tutorial3.Interfaces;

namespace Tutorial3.Containers;

public class LiquidContainer : Container, IHazardNotifier
{
    private bool UnsafeCargo;
    public LiquidContainer(double cargoWeight, double height, double ownWeight, double depth, double maxCapacity, bool unsafeCargo) 
                            : base(cargoWeight, height, ownWeight, depth, "L", maxCapacity)
    {
        UnsafeCargo = unsafeCargo;
    }

    public bool LoadChecker(double cargoWeight)
    {
        return (UnsafeCargo & cargoWeight > 0.5 * MaxCapacity) 
               ^ (!UnsafeCargo & cargoWeight > 0.9 * MaxCapacity);
    }

    public override void Load(double cargoWeight)
    {
        if (LoadChecker(cargoWeight))
        {
            HazardNotifier();
        }else
        {
            base.Load(cargoWeight);
            Console.WriteLine("LiquidContainer was successfully loaded.");            
        }
    }

    public void HazardNotifier()
    {
        Console.WriteLine("Overload of cargo liquid-container with serial number: -" + base.SerialNumber + "-");
    }
}