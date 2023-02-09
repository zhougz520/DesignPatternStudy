using Strategy.Strategy;

namespace Strategy.Context
{
    public class CashContext
    {
        CashSuper? cs = null;

        /// <summary>
        /// 简单工厂，根据客户端传入类型初始化收费模式
        /// </summary>
        /// <param name="type"></param>
        public CashContext(string type)
        {
            switch (type)
            {
                case "正常收费":
                    cs = new CashNormal();
                    break;
                case "满300返100":
                    cs = new CashReturn("300", "100");
                    break;
                case "打8折":
                    cs = new CashRebate("0.8");
                    break;
            }
        }

        public double? GetResult(double money)
        {
            return cs?.acceptCash(money);
        }
    }
}
