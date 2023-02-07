namespace AbstractFactory.Entitys;

/// <summary>
/// User实体类
/// </summary>
public class User
{
    private int _id;

    public int ID
    {
        get { return _id; }
        set { _id = value; }
    }

    private string? _name;

    public string? Name
    {
        get { return _name; }
        set { _name = value; }
    }
}
