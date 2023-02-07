namespace AbstractFactory.Department;

/// <summary>
/// Department实体操作接口
/// </summary>
public interface IDepartment
{
    void Insert(Department department);

    Department? GetDepartment(int id);
}
