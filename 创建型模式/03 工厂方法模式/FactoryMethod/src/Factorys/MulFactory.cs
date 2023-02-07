using FactoryMethod.Operations;

namespace FactoryMethod.Factorys;

/*
    乘法工厂
*/
public class MulFactory : IFactory
{
    public Operation CreateOperation()
    {
        return new OperationMul();
    }
}
