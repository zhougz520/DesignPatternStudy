using Flyweight.Flyweight;
using System.Collections;

namespace Flyweight.Factory
{
    /// <summary>
    /// 网站工厂
    /// </summary>
    public class WebSiteFactory
    {
        private Hashtable flyweights = new Hashtable();

        /// <summary>
        /// 获得网站分类
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public WebSite GetWebSiteCategory(string key)
        {
            if (!flyweights.ContainsKey(key))
            {
                flyweights.Add(key, new ConcreteWebSite(key));
            }

            return (WebSite)flyweights[key];
        }

        /// <summary>
        /// 获得网站分类总数
        /// </summary>
        /// <returns></returns>
        public int GetWebSiteCount() { return flyweights.Count; }
    }
}
