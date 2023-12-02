namespace SharpMath;

public class Variable
{
    public char VarName { get; set; }
    public Func<double, double> Eval { get; set; }

    public Variable(char value) : this(value, x => x)
    {
        this.VarName = value;
    }

    private Variable(char value, Func<double, double> eval)
    {
        this.VarName = value;
        this.Eval = eval;
    }

    public static Expression operator *(Variable a, Variable b)
    {
        if (a.VarName == b.VarName) return new Expression((dict) => a.Eval(dict[a]) * a.Eval(dict[a]));

        return new Expression((dict) => a.Eval(dict[a]) * b.Eval(dict[b]));
    }

    public static Expression operator *(Expression a, Variable b)
    {
        return new Expression((dict) => a.Evaluate(dict) * b.Eval(dict[b]));
    }
}