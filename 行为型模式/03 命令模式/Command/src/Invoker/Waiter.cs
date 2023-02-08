using Command.Command;

namespace Command.Invoker
{
    /// <summary>
    /// 服务员
    /// </summary>
    public class Waiter
    {
        // 存放具体命令的容器
        private IList<CommandBase> orders = new List<CommandBase>();

        /// <summary>
        /// 设置订单
        /// </summary>
        /// <param name="command">命令</param>
        public void SetOrder(CommandBase command)
        {
            if (command.ToString() == "Command.Command.BakeChickenWingCommand")
            {
                Console.WriteLine("服务员：鸡翅没有了，请点别的烧烤。");
            }
            else
            {
                orders.Add(command);
                Console.WriteLine("增加订单：" + command.ToString() + " 时间：" + DateTime.Now.ToString());
            }
        }

        /// <summary>
        /// 取消订单
        /// </summary>
        /// <param name="command">命令</param>
        public void CancelOrder(CommandBase command)
        {
            orders.Remove(command);
            Console.WriteLine("取消订单：" + command.ToString() + " 时间：" + DateTime.Now.ToString());
        }

        /// <summary>
        /// 通知全部执行
        /// </summary>
        public void Notify()
        {
            foreach (CommandBase command in orders)
            {
                // 根据用户点好的烧烤订单通知厨师制作
                command.ExcuteCommand();
            }
        }
    }
}
