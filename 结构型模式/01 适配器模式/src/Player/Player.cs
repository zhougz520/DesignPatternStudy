namespace AdapterPattern.Player;

/// <summary>
/// 球员抽象类
/// </summary>
public abstract class PlayerBase
{
    protected string name;

    public PlayerBase(string name)
    {
        this.name = name;
    }

    /// <summary>
    /// 进攻方法
    /// </summary>
    public abstract void Attack();

    /// <summary>
    /// 防守方法
    /// </summary>
    public abstract void Defense();
}
