using AdapterPattern;

class Program
{
    static void Main(string[] args)
    {
        Player b = new Forwards("巴蒂尔");
        b.Attack();

        Player m = new Guards("麦克格雷迪");
        m.Attack();

        // 翻译告诉姚明，教练要你进攻 防守
        Player ym = new Translator("姚明");
        ym.Attack();
        ym.Defense();
    }
}