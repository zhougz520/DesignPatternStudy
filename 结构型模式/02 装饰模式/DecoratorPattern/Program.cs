using DecoratorPattern.Component;
using DecoratorPattern.Decorator;

class Program
{
    static void Main(string[] args)
    {
        Person xc = new Person("小菜");

        Console.WriteLine("\n第一种装扮：");
        Sneakers pqx = new Sneakers();
        BigTrouser kk = new BigTrouser();
        TShirts dtx = new TShirts();
        // 装饰过程
        pqx.Decorate(xc);
        kk.Decorate(pqx);
        dtx.Decorate(kk);
        dtx.Show();

        Console.WriteLine("\n第二种装扮：");
        LeatherShoes px = new LeatherShoes();
        Suit xz = new Suit();
        // 装饰过程
        px.Decorate(xc);
        xz.Decorate(px);
        xz.Show();
    }
}