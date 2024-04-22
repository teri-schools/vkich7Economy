
public class Money
{
    private int dollars;
    private int cents;

    public Money(int dollars, int cents)
    {
        this.dollars = dollars;
        this.cents = cents;
    }

    public void DisplayAmount()
    {
        Console.WriteLine($"{dollars}.{cents:D2} units");
    }

    public void SetDollars(int dollars)
    {
        this.dollars = dollars;
    }

    public void SetCents(int cents)
    {
        this.cents = cents;
    }
}

