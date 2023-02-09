using Visitor.Element;

namespace Visitor.Visitor
{
    /// <summary>
    /// 成功
    /// </summary>
    public class Success : Action
    {
        public override void GetManConclusion(Man man)
        {
            Console.WriteLine("{0} {1}时，背后多半有一个伟大的女人。", man.GetType().Name, this.GetType().Name);
        }

        public override void GetWomanConclusion(Woman woman)
        {
            Console.WriteLine("{0} {1}时，背后大多有一个不成功的男人。", woman.GetType().Name, this.GetType().Name);
        }
    }
}
