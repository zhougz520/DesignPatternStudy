using AbstractFactory.Entitys;

namespace AbstractFactory.Entitys;

public class AccessUser : IUser
{
    public User? GetUser(int id)
    {
        Console.WriteLine("在Access中根据ID得到User表一条记录");
        return null;
    }

    public void Insert(User user)
    {
        Console.WriteLine("在Access中给User表增加一条记录");
    }
}
