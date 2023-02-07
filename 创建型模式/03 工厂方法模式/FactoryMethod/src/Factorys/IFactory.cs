using FactoryMethod.Operations;

namespace FactoryMethod.Factorys;

/*
    工厂接口
*/
public interface IFactory
{
    Operation CreateOperation();
}
