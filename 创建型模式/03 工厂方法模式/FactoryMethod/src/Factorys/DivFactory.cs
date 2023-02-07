using FactoryMethod.Operations;

namespace FactoryMethod.Factorys;

/*
    除法工厂
*/
public class DivFactory : IFactory
{
    public Operation CreateOperation()
    {
        return new OperationDiv();
    }
}
