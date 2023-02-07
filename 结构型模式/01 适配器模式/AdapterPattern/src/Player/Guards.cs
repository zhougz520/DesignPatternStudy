namespace AdapterPattern.Player;

/// <summary>
/// 后卫
/// </summary>
public class Guards : PlayerBase
{
    public Guards(string name) : base(name) { }

    public override void Attack()
    {
        Console.WriteLine("后卫 {0} 进攻", name);
    }

    public override void Defense()
    {
        Console.WriteLine("后卫 {0} 防守", name);
    }
}
