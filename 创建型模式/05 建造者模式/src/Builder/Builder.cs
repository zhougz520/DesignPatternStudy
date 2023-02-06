using BuilderPattern.Product;

namespace BuilderPattern.Builder;

/// <summary>
/// 抽象建造者类，确定产品由两个部件PartA和PartB组成，并声明一个得到产品建造后结果的方法GetResult
/// </summary>
public abstract class BuilderBase
{

    public abstract void BuilderPartA();

    public abstract void BuilderPartB();

    public abstract ProductBase GetResult();
}
