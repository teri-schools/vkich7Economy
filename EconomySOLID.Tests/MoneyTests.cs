
public class MoneyTests
{
    [Test]
    public void DisplayAmount_ShouldDisplayCorrectFormat()
    {
        // Arrange
        var money = new Money(100, 50);

        // Act
        var consoleOutput = CaptureConsoleOutput(() => money.DisplayAmount());

        // Assert
        Assert.AreEqual("100.50 units", consoleOutput.Trim());
    }

    [Test]
    public void SetDollars_ShouldUpdateDollarsProperty()
    {
        // Arrange
        var money = new Money(100, 50);

        // Act
        money.SetDollars(200);

        // Assert
        Assert.AreEqual(200, money.GetType().GetField("dollars", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(money));
    }

    private string CaptureConsoleOutput(Action action)
    {
        var stringWriter = new StringWriter();
        var previousConsole = Console.Out;
        Console.SetOut(stringWriter);

        action();

        Console.SetOut(previousConsole);
        return stringWriter.ToString();
    }
}
