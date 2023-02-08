using Command.Receiver;

namespace Command.Command
{
    /// <summary>
    /// 烤鸡翅命令
    /// </summary>
    public class BakeChickenWingCommand : CommandBase
    {
        public BakeChickenWingCommand(Barbecuer receiver) : base(receiver)
        {
        }

        public override void ExcuteCommand()
        {
            receiver.BakeChickenWing();
        }
    }
}
