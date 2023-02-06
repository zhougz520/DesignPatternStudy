using AbstractFactory.Department;
using AbstractFactory.Entitys;

namespace AbstractFactory.Factorys;

/// <summary>
/// Sqlserver工厂类
/// </summary>
public class SqlserverFactory : IFactory
{
    public IDepartment CreateDepartment()
    {
        return new SqlserverDepartment();
    }

    public IUser CreateUser()
    {
        return new SqlserverUser();
    }
}
