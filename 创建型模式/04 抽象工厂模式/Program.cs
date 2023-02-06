using AbstractFactory.Department;
using AbstractFactory.Entitys;
using AbstractFactory.Factorys;

class Program
{
    static void Main(string[] args)
    {
        User user = new User();
        Department department = new Department();

        // IFactory factory = new SqlserverFactory();
        IFactory factory = new AccessFactory();

        IUser iUser = factory.CreateUser();
        iUser.Insert(user);
        iUser.GetUser(1);

        IDepartment iDept = factory.CreateDepartment();
        iDept.Insert(department);
        iDept.GetDepartment(1);
    }
}
