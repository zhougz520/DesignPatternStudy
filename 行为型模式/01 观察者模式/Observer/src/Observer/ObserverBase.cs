using Observer.Subject;

namespace Observer.Observer
{
    /// <summary>
    /// 抽象观察者
    /// </summary>
    public abstract class ObserverBase
    {
        protected string name;
        protected SubjectBase sub;

        public ObserverBase(string name, SubjectBase sub)
        {
            this.name = name;
            this.sub = sub;
        }

        public abstract void Update();
    }
}
