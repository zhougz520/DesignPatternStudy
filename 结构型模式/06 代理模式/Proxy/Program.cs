using Proxy.Proxy;
using Proxy.Subject;

class Program
{
    static void Main(string[] args)
    {
        SchoolGirl jiaojiao = new SchoolGirl();
        jiaojiao.Name = "李娇娇";

        ProxyBase daili = new ProxyBase(jiaojiao);

        daili.GiveFlowers();
        daili.GiveChocolate();
        daili.GiveDolls();
    }
}