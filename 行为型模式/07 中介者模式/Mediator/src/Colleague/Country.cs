using Mediator.Mediator;

namespace Mediator.Colleague
{
    /// <summary>
    /// 国家抽象类
    /// </summary>
    public abstract class Country
    {
        protected UnitedNations mediator;

        public Country(UnitedNations mediator)
        {
            this.mediator = mediator;
        }
    }
}
