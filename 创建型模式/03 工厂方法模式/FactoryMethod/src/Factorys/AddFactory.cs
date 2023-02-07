using FactoryMethod.Operations;

namespace FactoryMethod.Factorys;

/*
    加法工厂
*/
public class AddFactory : IFactory
{
    public Operation CreateOperation()
    {
        return new OperationAdd();
    }
}
