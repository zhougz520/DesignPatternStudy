using Command.Receiver;

namespace Command.Command
{
    /// <summary>
    /// 抽象命令类
    /// 只需要确定烤肉厨师是谁
    /// </summary>
    public abstract class CommandBase
    {
        protected Barbecuer receiver;

        public CommandBase(Barbecuer barbecuer)
        {
            this.receiver = barbecuer;
        }

        // 执行命令
        public abstract void ExcuteCommand();
    }
}
