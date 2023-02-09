using Strategy.Context;

class Program
{
    static void Main(string[] args)
    {
        double price = 23.8d;
        double num = 8d;
        string type = "打8折";

        CashContext csuper = new CashContext(type);

        Console.WriteLine("单价：{0} 数量：{1} 折扣：{2} 合计：{3}", price, num, type, csuper.GetResult(price * num));
    }
}