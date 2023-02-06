using AbstractFactory.Department;
using AbstractFactory.Entitys;

namespace AbstractFactory.Factorys;

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
