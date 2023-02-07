using SimpleFactoryPattern.Factorys;
using SimpleFactoryPattern.Operations;

namespace SimpleFactoryPattern;

class Program
{
    static void Main(string[] args)
    {
        Operation oper;
        oper = OperationFactory.createOperate("+");
        oper.NumberA = 1;
        oper.NumberB = 2;
        double result = oper.GetResult();

        Console.WriteLine(result);
    }
}
