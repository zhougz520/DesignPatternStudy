namespace AbstractFactory.Department;

/// <summary>
/// Access实现操作接口
/// </summary>
public class AccessDepartment : IDepartment
{
    public Department? GetDepartment(int id)
    {
        Console.WriteLine("在Access中根据ID得到Department表一条记录");
        return null;
    }

    public void Insert(Department department)
    {
        Console.WriteLine("在Access中给Department表增加一条记录");
    }
}
