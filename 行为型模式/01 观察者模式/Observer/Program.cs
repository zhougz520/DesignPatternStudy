using Observer.Observer;
using Observer.Subject;

class Programm
{
    static void Main(String[] args)
    {
        // 老板胡汉三
        Boss huhansan = new Boss();

        // 看股票的同事
        StockObserver tongshi1 = new StockObserver("小菜", huhansan);
        // 看NBA的同事
        NBAObserver tongshi2 = new NBAObserver("大鸟", huhansan);

        huhansan.Attach(tongshi1);
        huhansan.Attach(tongshi2);

        huhansan.Detach(tongshi1);

        // 老板回来了
        huhansan.SubjectState = "我胡汉三回来了！";
        // 发出通知
        huhansan.Notify();
    }
}