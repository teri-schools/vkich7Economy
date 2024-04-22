public class ReportingTests
{
    [Test]
    public void RegisterProductReceipt_ShouldIncreaseWarehouseQuantityAndAddEntry()
    {
        // Arrange
        var warehouse = new Warehouse("Apples", "kg", 1.99m, 500, new DateTime(2023, 04, 01));
        var reporting = new Reporting();

        // Act
        reporting.RegisterProductReceipt(warehouse, 100);

        // Assert
        Assert.That(warehouse.GetType().GetField("quantity", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(warehouse), Is.InRange(550, 650));
        Assert.That(reporting.GetType().GetField("warehouseEntries", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(reporting) as List<WarehouseEntry>, Has.Count.EqualTo(1));
    }

    [Test]
    public void RegisterProductShipment_ShouldDecreaseWarehouseQuantityAndAddEntry()
    {
        // Arrange
        var warehouse = new Warehouse("Apples", "kg", 1.99m, 500, new DateTime(2023, 04, 01));
        var reporting = new Reporting();

        // Act
        reporting.RegisterProductShipment(warehouse, 50);

        // Assert
        Assert.That(warehouse.GetType().GetField("quantity", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(warehouse), Is.InRange(400, 500));
        Assert.That(reporting.GetType().GetField("warehouseEntries", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(reporting) as List<WarehouseEntry>, Has.Count.EqualTo(1));
    }
}