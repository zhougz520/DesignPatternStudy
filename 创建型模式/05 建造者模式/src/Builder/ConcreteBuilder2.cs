using BuilderPattern.Product;

namespace BuilderPattern.Builder;

/// <summary>
/// 具体建造者2
/// </summary>
public class ConcreteBuilder2 : BuilderBase
{
    private ProductBase product = new ProductBase();

    public override void BuilderPartA()
    {
        product.Add("部件X");
    }

    public override void BuilderPartB()
    {
        product.Add("部件Y");
    }

    public override ProductBase GetResult()
    {
        return product;
    }
}
