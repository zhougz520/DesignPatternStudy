using Mediator.Colleague;

namespace Mediator.Mediator
{
    /// <summary>
    /// 联合国安全理事会
    /// </summary>
    public class UnitedNationsSecurity : UnitedNations
    {
        // 联合国安理会了解所有国家
        // 美国
        public USA Colleague1 { get; set; }
        // 伊拉克
        public Iraq Colleague2 { get; set; }

        public override void Declare(string message, Country colleague)
        {
            if (colleague == Colleague1)
            {
                Colleague2.GetMessage(message);
            }
            else
            {
                Colleague1.GetMessage(message);
            }
        }
    }
}
