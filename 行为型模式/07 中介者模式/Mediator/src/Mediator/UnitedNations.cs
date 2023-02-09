using Mediator.Colleague;

namespace Mediator.Mediator
{
    /// <summary>
    /// 联合国机构抽象类
    /// </summary>
    public abstract class UnitedNations
    {
        // 声明
        public abstract void Declare(string message, Country colleague);
    }
}
