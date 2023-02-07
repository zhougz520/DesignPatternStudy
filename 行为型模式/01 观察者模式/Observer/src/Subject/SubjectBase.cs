using Observer.Observer;

namespace Observer.Subject
{
    /// <summary>
    /// 通知者接口
    /// </summary>
    public interface SubjectBase
    {
        void Attach(ObserverBase observer);

        void Detach(ObserverBase observer);

        void Notify();

        string SubjectState
        {
            get; set;
        }
    }
}
