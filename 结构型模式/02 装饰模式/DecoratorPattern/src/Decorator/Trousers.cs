namespace DecoratorPattern.Decorator;

/// <summary>
/// 具体服饰类（垮裤）
/// </summary>
public class BigTrouser : Finery
{
    public override void Show()
    {
        Console.Write("垮裤 ");
        base.Show();
    }
}
