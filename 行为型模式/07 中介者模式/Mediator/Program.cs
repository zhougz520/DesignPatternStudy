using Mediator.Colleague;
using Mediator.Mediator;

class Program
{
    static void Main(string[] args)
    {
        UnitedNationsSecurity UNSC = new UnitedNationsSecurity();

        USA c1 = new USA(UNSC);
        Iraq c2 = new Iraq(UNSC);

        UNSC.Colleague1 = c1;
        UNSC.Colleague2 = c2;

        c1.Declare("不准研制核武器，否则要发动战争！");
        c2.Declare("我们没有核武器，也不怕侵略。");
    }
}