namespace CompositePattern.Component
{
    /// <summary>
    /// 公司抽象类
    /// </summary>
    public abstract class Company
    {
        protected string name;

        public Company(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="c">公司</param>
        public abstract void Add(Company c);

        /// <summary>
        /// 移除
        /// </summary>
        /// <param name="c">公司</param>
        public abstract void Remove(Company c);

        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="depth">层级</param>
        public abstract void Display(int depth);

        /// <summary>
        /// 履行职责
        /// </summary>
        public abstract void LineOfDuty();
    }
}
