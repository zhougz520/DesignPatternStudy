namespace AbstractFactory.Department;

public class SqlserverDepartment : IDepartment
{
    public Department? GetDepartment(int id)
    {
        Console.WriteLine("在SQL Server中根据ID得到Department表一条记录");
        return null;
    }

    public void Insert(Department department)
    {
        Console.WriteLine("在SQL Server中给User表增加一条记录");
    }
}
