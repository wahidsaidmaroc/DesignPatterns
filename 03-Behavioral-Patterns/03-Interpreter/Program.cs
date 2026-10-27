IExpression expression = new AddExpression(
    new NumberExpression(3),
    new AddExpression(new NumberExpression(4), new NumberExpression(2)));

Console.WriteLine($"3 + (4 + 2) = {expression.Interpret()}");

public interface IExpression
{
    int Interpret();
}

public sealed record NumberExpression(int Value) : IExpression
{
    public int Interpret() => Value;
}

public sealed record AddExpression(IExpression Left, IExpression Right) : IExpression
{
    public int Interpret() => Left.Interpret() + Right.Interpret();
}
