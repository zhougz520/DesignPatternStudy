namespace Flyweight.Flyweight
{
    /// <summary>
    /// 用户
    /// </summary>
    public class User
    {
        private string name;
        public string Name { get { return name; } }

        public User(string name)
        {
            this.name = name;
        }
    }
}
