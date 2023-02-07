using Observer.Observer;

namespace Observer.Subject
{
    /// <summary>
    /// 老板
    /// </summary>
    public class Boss : SubjectBase
    {
        // 同事列表
        private IList<ObserverBase> observers = new List<ObserverBase>();
        private string action = "";

        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="observer">同事</param>
        public void Attach(ObserverBase observer)
        {
            observers.Add(observer);
        }

        /// <summary>
        /// 减少
        /// </summary>
        /// <param name="observer">同事</param>
        public void Detach(ObserverBase observer)
        {
            observers.Remove(observer);
        }

        /// <summary>
        /// 通知
        /// </summary>
        public void Notify()
        {
            foreach (ObserverBase observer in observers)
            {
                observer.Update();
            }
        }

        public string SubjectState
        {
            get { return action; }
            set { action = value; }
        }
    }
}
