namespace AdapterPattern.Player;

/// <summary>
/// 前锋
/// </summary>
public class Forwards : PlayerBase
{
    public Forwards(string name) : base(name) { }

    public override void Attack()
    {
        Console.WriteLine("前锋 {0} 进攻", name);
    }

    public override void Defense()
    {
        Console.WriteLine("前锋 {0} 防守", name);
    }
}
