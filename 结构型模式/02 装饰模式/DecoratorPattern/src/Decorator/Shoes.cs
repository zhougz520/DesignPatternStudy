namespace DecoratorPattern.Decorator;

/// <summary>
/// 具体服饰类（破球鞋）
/// </summary>
public class Sneakers : Finery
{
    public override void Show()
    {
        Console.Write("破球鞋 ");
        base.Show();
    }
}

/// <summary>
/// 具体服饰类（皮鞋）
/// </summary>
public class LeatherShoes : Finery
{
    public override void Show()
    {
        Console.Write("皮鞋 ");
        base.Show();
    }
}