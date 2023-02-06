namespace AbstractFactory.Department;

public interface IDepartment
{
    void Insert(Department department);

    Department? GetDepartment(int id);
}
