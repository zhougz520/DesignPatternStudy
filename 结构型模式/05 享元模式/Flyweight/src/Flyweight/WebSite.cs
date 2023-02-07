namespace Flyweight.Flyweight
{
    /// <summary>
    /// 网站抽象类
    /// </summary>
    public abstract class WebSite
    {
        /// <summary>
        /// 传递用户对象
        /// </summary>
        /// <param name="user">用户</param>
        public abstract void Use(User user);
    }
}
