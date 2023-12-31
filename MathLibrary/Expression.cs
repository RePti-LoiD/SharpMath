﻿namespace SharpMath;

public class Expression
{
    private Func<Dictionary<Variable, double>, double> expression;

    public Expression(Func<Dictionary<Variable, double>, double> expression)
    {
        this.expression = expression;
    }

    public double Evaluate(Dictionary<Variable, double> values) => expression(values);

    public static Expression operator *(Expression a, Expression b)
    {
        return new Expression((dict) => a.Evaluate(dict) * b.Evaluate(dict));
    }
}