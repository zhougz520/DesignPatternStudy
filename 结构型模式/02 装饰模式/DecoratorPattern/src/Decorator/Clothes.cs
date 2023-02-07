namespace DecoratorPattern.Decorator;

/// <summary>
/// 具体服饰类（大T恤）
/// </summary>
public class TShirts : Finery
{
    public override void Show()
    {
        Console.Write("大T恤 ");
        base.Show();
    }
}

/// <summary>
/// 具体服饰类（西装）
/// </summary>
public class Suit : Finery
{
    public override void Show()
    {
        Console.Write("西装 ");
        base.Show();
    }
}
