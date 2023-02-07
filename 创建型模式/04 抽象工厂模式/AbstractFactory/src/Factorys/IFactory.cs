using AbstractFactory.Department;
using AbstractFactory.Entitys;

namespace AbstractFactory.Factorys;

/*
    工厂接口
*/
public interface IFactory
{
    IUser CreateUser();

    IDepartment CreateDepartment();
}
