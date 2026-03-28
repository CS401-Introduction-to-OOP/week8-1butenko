public abstract class DeliveryNumber
{
    public string TrackingNumber { get; }
    public double Weight { get; protected set; }

    public DeliveryNumber(string trackingNumber, double weight)
    {
        TrackingNumber = trackingNumber;
        Weight = weight;
    }

    public abstract double CalculateCost();

    public abstract void PrintInfo();
}