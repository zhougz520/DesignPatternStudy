using Observer.Subject;

namespace Observer.Observer
{
    /// <summary>
    /// 看股票的同事
    /// </summary>
    public class StockObserver : ObserverBase
    {
        public StockObserver(string name, SubjectBase sub) : base(name, sub) { }

        public override void Update()
        {
            Console.WriteLine("{0} {1} 关闭股票行情，继续工作！", sub.SubjectState, name);
        }
    }
}
