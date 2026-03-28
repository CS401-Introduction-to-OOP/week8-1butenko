public class CargoContainer<T> where T : DeliveryItem
{
    private List<T> deliveryItems = new();

    public void AddItem(T item)
    {
        deliveryItems.Add(item);
    }

    public double GetTotalCost()
    {
        double totalCost = 0;

        foreach (T item in deliveryItems)
        {
            totalCost += item.CalculateCost();
        }

        return totalCost;
    }
}