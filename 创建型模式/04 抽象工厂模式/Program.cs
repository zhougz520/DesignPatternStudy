using AbstractFactory.Department;
using AbstractFactory.Entitys;
using AbstractFactory.Factorys;

class Program
{
    static void Main(string[] args)
    {
        // 定义使用的数据库工厂
        // IFactory factory = new SqlserverFactory();
        IFactory factory = new AccessFactory();

        // 通过工厂操作对应的实体
        IUser iUser = factory.CreateUser();
        User user = new User();
        iUser.Insert(user);
        iUser.GetUser(1);

        IDepartment iDept = factory.CreateDepartment();
        Department department = new Department();
        iDept.Insert(department);
        iDept.GetDepartment(1);
    }
}
