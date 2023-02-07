using Proxy.Subject;

namespace Proxy.Proxy
{
    /// <summary>
    /// 代理类
    /// </summary>
    public class ProxyBase : IGiveGift
    {
        Pursuit gg;
        public ProxyBase(SchoolGirl mm)
        {
            gg = new Pursuit(mm);
        }

        public void GiveChocolate()
        {
            gg.GiveChocolate();
        }

        public void GiveDolls()
        {
            gg.GiveDolls();
        }

        public void GiveFlowers()
        {
            gg.GiveFlowers();
        }
    }
}
