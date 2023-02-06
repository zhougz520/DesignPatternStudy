using AbstractFactory.Department;
using AbstractFactory.Entitys;

namespace AbstractFactory.Factorys;

public interface IFactory
{
    IUser CreateUser();

    IDepartment CreateDepartment();
}
