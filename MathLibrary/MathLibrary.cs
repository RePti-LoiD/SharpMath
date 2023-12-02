namespace SharpMath;

public class MathLibrary
{
    public double Div(double a, double b)
    {
        if (a == 0 && b == 0) return 0;
        else if (b == 0) throw new DivideByZeroException();
        
        return a / b;
    }
}