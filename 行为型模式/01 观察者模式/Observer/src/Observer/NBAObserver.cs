using Observer.Subject;

namespace Observer.Observer
{
    /// <summary>
    /// 看NBA的同事
    /// </summary>
    public class NBAObserver : ObserverBase
    {
        public NBAObserver(string name, SubjectBase sub) : base(name, sub) { }

        public override void Update()
        {
            Console.WriteLine("{0} {1} 关闭NBA直播，继续工作！", sub.SubjectState, name);
        }
    }
}
