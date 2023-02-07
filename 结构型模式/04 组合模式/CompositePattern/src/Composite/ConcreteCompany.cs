using CompositePattern.Component;

namespace CompositePattern.Composite
{
    /// <summary>
    /// 具体公司类 树枝节点
    /// </summary>
    public class ConcreteCompany : Company
    {
        private List<Company> children = new List<Company>();

        public ConcreteCompany(string name) : base(name)
        {
        }

        public override void Add(Company c)
        {
            children.Add(c);
        }

        public override void Remove(Company c)
        {
            children.Remove(c);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);

            foreach (Company component in children)
            {
                component.Display(depth + 2);
            }
        }

        public override void LineOfDuty()
        {
            foreach (Company component in children)
            {
                component.LineOfDuty();
            }
        }
    }
}
