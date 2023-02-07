﻿namespace Flyweight.Flyweight
{
    /// <summary>
    /// 具体网站类
    /// </summary>
    public class ConcreteWebSite : WebSite
    {
        private string name = "";

        public ConcreteWebSite(string name)
        {
            this.name = name;
        }

        public override void Use(User user)
        {
            Console.WriteLine("网站分类：" + name + " 用户：" + user.Name);
        }
    }
}
