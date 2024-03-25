namespace Tutorial3.Containers;

public class ColdContainer: Container
{
    private double Temperature;
    private PossibleProducts ProductType;
    
    private Dictionary<PossibleProducts, double> TemperaturesChart= new Dictionary<PossibleProducts, double>();

    public ColdContainer(double cargoWeight, double height, double ownWeight, double depth, double maxCapacity, double temperature, PossibleProducts productType) 
                            : base(cargoWeight, height, ownWeight, depth, "C", maxCapacity)
    {
        Temperature = temperature;
        ProductType = productType;
    }
    

}