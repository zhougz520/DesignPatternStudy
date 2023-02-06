using AbstractFactory.Department;
using AbstractFactory.Entitys;

namespace AbstractFactory.Factorys;

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
