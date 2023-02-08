using Command.Receiver;

namespace Command.Command
{
    /// <summary>
    /// 烤肉串命令
    /// </summary>
    public class BakeMuttonCommand : CommandBase
    {
        public BakeMuttonCommand(Barbecuer receiver) : base(receiver)
        {
        }

        public override void ExcuteCommand()
        {
            receiver.BakeMutton();
        }
    }
}
