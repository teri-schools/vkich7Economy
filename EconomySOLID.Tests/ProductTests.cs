public class ProductTests
{
    [Test]
    public void ReducePrice_ShouldDecreaseProductPrice()
    {
        // Arrange
        var product = new Product("Apple", 2.99m);

        // Act
        product.ReducePrice(0.50m);

        // Assert
        Assert.AreEqual(2.49m, product.GetPrice());
    }
}
