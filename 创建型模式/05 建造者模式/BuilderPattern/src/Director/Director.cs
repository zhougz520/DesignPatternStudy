using BuilderPattern.Builder;

namespace BuilderPattern.Director;

/// <summary>
/// 指挥者类，用来指挥建造过程
/// </summary>
public class DirectorBase
{
    /// <summary>
    /// 指挥建造过程，先创建PartA后创建PartB
    /// </summary>
    /// <param name="builder"></param>
    public void Construct(BuilderBase builder)
    {
        builder.BuilderPartA();
        builder.BuilderPartB();
    }
}
