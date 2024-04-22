public class WarehouseTests
{
    [Test]
    public void AddProduct_ShouldIncreaseQuantity()
    {
        // Arrange
        var warehouse = new Warehouse("Apples", "kg", 1.99m, 500, new DateTime(2023, 04, 01));

        // Act
        warehouse.AddProduct(100);

        // Assert
        Assert.AreEqual(600, warehouse.GetType().GetField("quantity", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(warehouse));
    }

    [Test]
    public void RemoveProduct_ShouldDecreaseQuantity()
    {
        // Arrange
        var warehouse = new Warehouse("Apples", "kg", 1.99m, 500, new DateTime(2023, 04, 01));

        // Act
        warehouse.RemoveProduct(50);

        // Assert
        Assert.AreEqual(450, warehouse.GetType().GetField("quantity", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(warehouse));
    }
}
