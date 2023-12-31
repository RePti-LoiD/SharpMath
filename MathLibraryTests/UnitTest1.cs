namespace MathLibraryTests;

public class Tests
{
    [TestMethod]
    public void TestDivision4by2()
    {
        MathLibrary libInstance = new();
        double result = libInstance.Div(4, 2);
        double expected = 2;

        Assert.Equals(expected, result);
    }

    [TestMethod]
    public void TestDivision0by0()
    {
        MathLibrary libInstance = new();
        double result = libInstance.Div(0, 0);
        double expected = 0;

        Assert.Equals(expected, result);
    }

    [TestMethod]
    public void TestDivisionValueByZero()
    {
        Assert.ThrowsException<DivideByZeroException>(() => new MathLibrary().Div(155, 0));
    }
}