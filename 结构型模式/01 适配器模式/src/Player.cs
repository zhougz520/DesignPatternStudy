namespace AdapterPattern;

/// <summary>
/// 球员抽象类
/// </summary>
public abstract class Player
{
    protected string name;

    public Player(string name)
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
