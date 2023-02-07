using CompositePattern.Component;

namespace CompositePattern.Leaf
{
    /// <summary>
    /// 人力资源部
    /// </summary>
    public class HRDepartment : Company
    {
        public HRDepartment(string name) : base(name)
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
            Console.WriteLine("{0} 员工招聘培训管理", name);
        }

        public override void Remove(Company c)
        {
        }
    }
}
