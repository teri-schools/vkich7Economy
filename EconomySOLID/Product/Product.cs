
public class Product
{
    private string name;
    private decimal price;

    public Product(string name, decimal price)
    {
        this.name = name;
        this.price = price;
    }

    public void ReducePrice(decimal amount)
    {
        this.price -= amount;
    }

    public decimal GetPrice()
    {
        return this.price;
    }
}
