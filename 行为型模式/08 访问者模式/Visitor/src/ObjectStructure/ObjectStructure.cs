using Visitor.Element;
using Action = Visitor.Visitor.Action;

namespace Visitor.ObjectStructure
{
    /// <summary>
    /// 对象结构
    /// </summary>
    public class ObjectStructure
    {
        private IList<Person> elements = new List<Person>();

        // 增加
        public void Attach(Person element)
        {
            elements.Add(element);
        }

        // 移除
        public void Detach(Person element)
        {
            elements.Remove(element);
        }

        // 查看显示
        public void Display(Action visitor)
        {
            foreach (Person element in elements)
            {
                element.Accept(visitor);
            }
        }
    }
}
