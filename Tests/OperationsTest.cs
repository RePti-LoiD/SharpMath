namespace MathLibraryTest;

public class Tests
{
    [SetUp]
    public void Setup() { }

    [Test]
    public void TestDivision4by2()
    {
        MathLibrary libInstance = new();
        double result = libInstance.Div(4, 2);
        double expected = 2;

        Assert.AreEqual(expected, result);
    }

    [Test]
    public void TestDivision0by0()
    {
        MathLibrary libInstance = new();
        double result = libInstance.Div(0, 0);
        double expected = 0;

        Assert.AreEqual(expected, result);
    }

    [Test]
    public void TestDivisionValueByZero()
    {
        Assert.Throws<DivideByZeroException>(() => new MathLibrary().Div(155, 0));
    }
}