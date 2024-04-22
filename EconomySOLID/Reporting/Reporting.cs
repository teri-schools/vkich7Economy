public class Reporting
{
    private List<WarehouseEntry> warehouseEntries;

    public Reporting()
    {
        this.warehouseEntries = new List<WarehouseEntry>();
    }

    public void RegisterProductReceipt(Warehouse warehouse, int quantity)
    {
        warehouse.AddProduct(quantity);
        warehouseEntries.Add(new WarehouseEntry(warehouse, quantity, true));
    }

    public void RegisterProductShipment(Warehouse warehouse, int quantity)
    {
        warehouse.RemoveProduct(quantity);
        warehouseEntries.Add(new WarehouseEntry(warehouse, quantity, false));
    }

    public void DisplayInventoryReport()
    {
        Console.WriteLine("Inventory Report:");
        foreach (var entry in warehouseEntries)
        {
            entry.DisplayEntry();
        }
    }
}


