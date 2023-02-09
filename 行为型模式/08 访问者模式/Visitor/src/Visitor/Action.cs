using Visitor.Element;

namespace Visitor.Visitor
{
    /// <summary>
    /// 状态的抽象类
    /// </summary>
    public abstract class Action
    {
        // 得到男人结论或反应
        public abstract void GetManConclusion(Man man);

        // 得到女人结论或反应
        public abstract void GetWomanConclusion(Woman woman);
    }
}
