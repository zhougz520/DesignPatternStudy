using AdapterPattern.Player;

namespace AdapterPattern.Adapter;

/// <summary>
/// 翻译者
/// </summary>
public class Translator : PlayerBase
{
    // 实例化“外籍中锋”对象，表明翻译者与外籍球员有关联
    private ForeignCenter wjzf = new ForeignCenter();

    public Translator(string name) : base(name)
    {
        wjzf.Name = name;
    }

    /// <summary>
    /// 翻译者将Attack 翻译为 进攻
    /// </summary>
    public override void Attack()
    {
        wjzf.进攻();
    }

    /// <summary>
    /// 翻译者将Defense 翻译为 防守
    /// </summary>
    public override void Defense()
    {
        wjzf.防守();
    }
}