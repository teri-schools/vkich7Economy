// Directory structure:
// - EconomySOLID
//   - Program.cs
//   - Money
//     - Money.cs
//   - Product
//     - Product.cs
//   - Warehouse
//     - Warehouse.cs
//   - Reporting
//     - Reporting.cs


// Program.cs
public class Program
{
    static void Main(string[] args)
    {
        // Example usage
        var money = new Money(100, 50);
        money.DisplayAmount(); // Output: 100.50 units

        var product = new Product("Apple", 2.99m);
        product.ReducePrice(0.50m);
        Console.WriteLine($"Product price: {product.GetPrice()}"); // Output: Product price: 2.49

        var warehouse = new Warehouse("Apples", "kg", 1.99m, 500, new DateTime(2023, 04, 01));
        warehouse.DisplayProductInfo(); // Output: Name: Apples, Unit: kg, Price: 1.99, Quantity: 500, Last Delivery: 04/01/2023

        var reporting = new Reporting();
        reporting.RegisterProductReceipt(warehouse, 100);
        reporting.RegisterProductShipment(warehouse, 50);
        reporting.DisplayInventoryReport();
        // Output:
        // Inventory Report:
        // Receipt of 100 kg of Apples
        // Shipment of 50 kg of Apples
    }
}