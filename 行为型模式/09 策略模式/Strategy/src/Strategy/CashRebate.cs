namespace Strategy.Strategy
{
    /// <summary>
    /// 打折收费
    /// </summary>
    public class CashRebate : CashSuper
    {
        private double moneyRebate = 1d;
        public CashRebate(string moneyRebate)
        {
            // 打折收费初始化时需要指定折扣
            this.moneyRebate = double.Parse(moneyRebate);
        }

        public override double acceptCash(double money)
        {
            return money * moneyRebate;
        }
    }
}
