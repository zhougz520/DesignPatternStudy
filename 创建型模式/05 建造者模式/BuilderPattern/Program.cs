using BuilderPattern.Builder;
using BuilderPattern.Director;
using BuilderPattern.Product;

class Program
{
    static void Main(string[] args)
    {
        // 初始化指挥者、建造者1和2
        DirectorBase director = new DirectorBase();
        BuilderBase b1 = new ConcreteBuilder1();
        BuilderBase b2 = new ConcreteBuilder2();

        // 指挥者用ConcreteBuilder1的方法来创建产品
        director.Construct(b1);
        ProductBase p1 = b1.GetResult();
        p1.Show();

        // 指挥者用ConcreteBuilder2的方法来创建产品
        director.Construct(b2);
        ProductBase p2 = b2.GetResult();
        p2.Show();
    }
}
