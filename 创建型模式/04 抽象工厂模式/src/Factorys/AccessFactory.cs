using AbstractFactory.Department;
using AbstractFactory.Entitys;

namespace AbstractFactory.Factorys;

/// <summary>
/// Access工厂类
/// </summary>
public class AccessFactory : IFactory
{
    public IDepartment CreateDepartment()
    {
        return new AccessDepartment();
    }

    public IUser CreateUser()
    {
        return new AccessUser();
    }
}
