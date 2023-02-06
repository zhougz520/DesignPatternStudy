namespace DecoratorPattern.Component;

/// <summary>
/// 人（ConcreteComponent），可以穿不同的服饰
/// </summary>
public class Person
{
    public Person() { }

    private string? name;
    public Person(string name)
    {
        this.name = name;
    }

    public virtual void Show()
    {
        Console.WriteLine("装扮的{0}", name);
    }
}
