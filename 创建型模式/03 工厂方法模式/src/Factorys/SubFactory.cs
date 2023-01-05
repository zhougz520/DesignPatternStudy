using FactoryMethod.Operations;

namespace FactoryMethod.Factorys;

/*
    减法工厂
*/
public class SubFactory : IFactory
{
    public Operation CreateOperation()
    {
        return new OperationSub();
    }
}
