using DecoratorPattern.Component;

namespace DecoratorPattern.Decorator;

/// <summary>
/// 服饰类（Decorator）
/// </summary>
public class Finery : Person
{
    protected Person? component;

    /// <summary>
    /// 打扮
    /// </summary>
    /// <param name="component">打扮的对象</param>
    public void Decorate(Person component)
    {
        this.component = component;
    }

    /// <summary>
    /// 展示
    /// </summary>
    public override void Show()
    {
        if (component != null)
        {
            component.Show();
        }
    }
}
