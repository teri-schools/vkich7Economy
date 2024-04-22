public class Warehouse
{
    public string name;
    public string unit;
    private decimal price;
    private int quantity;
    private DateTime lastDelivery;

    public Warehouse(string name, string unit, decimal price, int quantity, DateTime lastDelivery)
    {
        this.name = name;
        this.unit = unit;
        this.price = price;
        this.quantity = quantity;
        this.lastDelivery = lastDelivery;
    }

    public void AddProduct(int quantity)
    {
        this.quantity += quantity;
    }

    public void RemoveProduct(int quantity)
    {
        this.quantity -= quantity;
    }

    public void DisplayProductInfo()
    {
        Console.WriteLine($"Name: {name}, Unit: {unit}, Price: {price}, Quantity: {quantity}, Last Delivery: {lastDelivery.ToShortDateString()}");
    }
}
