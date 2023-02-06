namespace AbstractFactory.Entitys;

/// <summary>
/// User实体操作接口
/// </summary>
public interface IUser
{
    void Insert(User user);

    User? GetUser(int id);
}
