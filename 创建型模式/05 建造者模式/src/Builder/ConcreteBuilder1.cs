using BuilderPattern.Product;

namespace BuilderPattern.Builder;

/// <summary>
/// 具体建造者1
/// </summary>
public class ConcreteBuilder1 : BuilderBase
{
    private ProductBase product = new ProductBase();

    public override void BuilderPartA()
    {
        product.Add("部件A");
    }

    public override void BuilderPartB()
    {
        product.Add("部件B");
    }

    public override ProductBase GetResult()
    {
        return product;
    }
}
