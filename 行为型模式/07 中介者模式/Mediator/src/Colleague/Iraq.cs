using Mediator.Mediator;

namespace Mediator.Colleague
{
    /// <summary>
    /// 伊拉克
    /// </summary>
    public class Iraq : Country
    {
        public Iraq(UnitedNations mediator) : base(mediator)
        {
        }

        // 声明
        public void Declare(string message)
        {
            mediator.Declare(message, this);
        }

        // 获得消息
        public void GetMessage(string message)
        {
            Console.WriteLine("伊拉克获得对方消息：" + message);
        }
    }
}
