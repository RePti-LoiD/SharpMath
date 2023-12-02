namespace MathLibraryTest;

public class VariableTest
{
    [Test]
    public void MultiplyVariableByVariable()
    {
        Variable x = new('x');

        Expression mult = x * x;
        double expected = 16;

        Assert.AreEqual(expected, mult.Evaluate(new() { { x, 4 } }));
    }

    [Test]
    public void MultiplyVariableByOtherVariable()
    {
        Variable x = new('x');
        Variable y = new('y');

        Expression mult = x * y;
        double expected = 12;

        Assert.AreEqual(expected, mult.Evaluate(new() { { x, 4 }, { y, 3 } }));
    }

    [Test]
    public void MultiplyExpressionByVariable()
    {
        Variable x = new('x');
        Variable y = new('y');

        Expression mult = (x * y) * y;
        double expected = 36;

        Assert.AreEqual(expected, mult.Evaluate(new() { { x, 4 }, { y, 3 } }));
    }

    [Test]
    public void MultiplyVariableByExpression()
    {
        Variable x = new('x');
        Variable y = new('y');

        Expression mult = y * (x * y);
        double expected = 36;

        Assert.AreEqual(expected, mult.Evaluate(new() { { x, 4 }, { y, 3 } }));
    }

    [Test]
    public void MultiplyExpressionByExpression()
    {
        Variable x = new('x');
        Variable y = new('y');

        Expression mult = (y * x) * (x * y);
        double expected = 144;

        Assert.AreEqual(expected, mult.Evaluate(new() { { x, 4 }, { y, 3 } }));
    }

    [Test]
    public void MultiplyVariableByValue()
    {
        Variable x = new('x');

        Assert.AreEqual(20, (4 * x).Eval(5));
    }

    [Test]
    public void MultiplyValueByVariable()
    {
        Variable x = new('x');

        Assert.AreEqual(20, (x * 4).Eval(5));
    }
}