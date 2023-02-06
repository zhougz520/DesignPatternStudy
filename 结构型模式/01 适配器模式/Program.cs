using AdapterPattern.Adapter;
using AdapterPattern.Player;

class Program
{
    static void Main(string[] args)
    {
        PlayerBase b = new Forwards("巴蒂尔");
        b.Attack();

        PlayerBase m = new Guards("麦克格雷迪");
        m.Attack();

        // 翻译告诉姚明，教练要你进攻 防守
        PlayerBase ym = new Translator("姚明");
        ym.Attack();
        ym.Defense();
    }
}