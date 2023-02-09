using Action = Visitor.Visitor.Action;

namespace Visitor.Element
{
    /// <summary>
    /// 女人
    /// </summary>
    public class Woman : Person
    {
        public override void Accept(Action visitor)
        {
            visitor.GetWomanConclusion(this);
        }
    }
}
