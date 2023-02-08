using Command.Command;
using Command.Invoker;
using Command.Receiver;

class Program
{
    static void Main(string[] args)
    {
        // 开店前准备
        Barbecuer boy = new Barbecuer();
        CommandBase bakeMuttonCommand1 = new BakeMuttonCommand(boy);
        CommandBase bakeMuttonCommand2 = new BakeMuttonCommand(boy);
        CommandBase bakeChickenWingCommand1 = new BakeChickenWingCommand(boy);
        Waiter girl = new Waiter();

        // 开门营业 顾客点菜
        girl.SetOrder(bakeMuttonCommand1);
        girl.SetOrder(bakeMuttonCommand2);
        girl.SetOrder(bakeChickenWingCommand1);

        // 点菜完毕 通知厨师
        girl.Notify();
    }
}