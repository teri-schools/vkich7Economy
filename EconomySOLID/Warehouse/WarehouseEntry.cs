public class WarehouseEntry
{
    private Warehouse warehouse;
    private int quantity;
    private bool isReceipt;

    public WarehouseEntry(Warehouse warehouse, int quantity, bool isReceipt)
    {
        this.warehouse = warehouse;
        this.quantity = quantity;
        this.isReceipt = isReceipt;
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"{(isReceipt ? "Receipt" : "Shipment")} of {quantity} {warehouse.unit} of {warehouse.name}");
    }
}