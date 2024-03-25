using Tutorial3.Exceptions;

namespace Tutorial3.Containers;

public class ContainerShip
{
    public List<Container> Containers { get; set; } = new List<Container>();
    public int MaxSpeed { get; set; }
    public int MaxContainerQuantity { get; set; }
    public double MaxLoadWeight { get; set; }
    private int ContainerCount;
    private double WeightCount;
    
    

    public ContainerShip(int maxSpeed, int maxContainerQuantity, double maxLoadWeight)
    {
        MaxSpeed = maxSpeed;
        MaxContainerQuantity = maxContainerQuantity;
        MaxLoadWeight = maxLoadWeight;
    }

    public void LoadContainer(Container container)
    {
        if (ContainerCount + 1 > MaxContainerQuantity ^ WeightCount+container.CargoWeight+container.OwnWeight > MaxLoadWeight)
        {
            throw new OverfillException("Ship overload, to many containers");
        }
        else
        {
            Containers.Add(container);
        }
    }

    public void UnloadContainer(String serialNumber)
    {
        bool exists = false;
        foreach (Container container in Containers)
        {
            if (container.SerialNumber.Equals(serialNumber))
            {
                exists = true;
                Containers.RemoveAt(Containers.IndexOf(container));
            }
        }

        if (!exists)
        {
            Console.WriteLine("No matching container");   
        }
        else
        {
            Console.WriteLine("Unload complete.");
        }
    }

}