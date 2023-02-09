namespace Strategy.Strategy
{
    /// <summary>
    /// 现金收费抽象类
    /// </summary>
    public abstract class CashSuper
    {
        /// <summary>
        /// 现金收取超类的抽象方法
        /// 接收原价，返回打折价
        /// </summary>
        /// <param name="money">原价</param>
        /// <returns></returns>
        public abstract double acceptCash(double money);
    }
}
