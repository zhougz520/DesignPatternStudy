using Action = Visitor.Visitor.Action;

namespace Visitor.Element
{
    /// <summary>
    /// 男人
    /// </summary>
    public class Man : Person
    {
        public override void Accept(Action visitor)
        {
            visitor.GetManConclusion(this);
        }
    }
}
