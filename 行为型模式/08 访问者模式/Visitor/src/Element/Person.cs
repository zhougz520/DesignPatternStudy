using Action = Visitor.Visitor.Action;

namespace Visitor.Element
{
    /// <summary>
    /// 人的抽象类
    /// </summary>
    public abstract class Person
    {
        // 接受，用来获得状态对象
        public abstract void Accept(Action visitor);
    }
}
