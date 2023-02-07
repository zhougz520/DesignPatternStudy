using BridgePattern.Implementor;

namespace BridgePattern.Abstraction
{
    /// <summary>
    /// 手机品牌抽象类
    /// </summary>
    public abstract class HandsetBrand
    {
        protected HandsetSoft? soft;

        /// <summary>
        /// 设置手机软件
        /// </summary>
        /// <param name="soft">软件</param>
        public void SetHandsetSoft(HandsetSoft soft) { this.soft = soft; }

        /// <summary>
        /// 运行
        /// </summary>
        public abstract void Run();
    }
}
