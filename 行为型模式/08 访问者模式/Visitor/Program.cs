using Visitor.Element;
using Visitor.ObjectStructure;
using Visitor.Visitor;

class Program
{
    static void Main(string[] args)
    {
        ObjectStructure o = new ObjectStructure();
        o.Attach(new Man());
        o.Attach(new Woman());

        // 成功时的反应
        Success v1 = new Success();
        o.Display(v1);
    }
}