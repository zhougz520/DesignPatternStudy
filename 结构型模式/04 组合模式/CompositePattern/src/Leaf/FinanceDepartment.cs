using CompositePattern.Component;

namespace CompositePattern.Leaf
{
    /// <summary>
    /// 财务部
    /// </summary>
    public class FinanceDepartment : Company
    {
        public FinanceDepartment(string name) : base(name)
        {
        }

        public override void Add(Company c)
        {
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);
        }

        public override void LineOfDuty()
        {
            Console.WriteLine("{0} 公司财务收支管理", name);
        }

        public override void Remove(Company c)
        {
        }
    }
}
