namespace ChainOfResponsibility.Handler
{
    /// <summary>
    /// 管理者抽象类
    /// </summary>
    public abstract class Manager
    {
        protected string name;
        // 管理者上级
        protected Manager superior;

        public Manager(string name)
        {
            this.name = name;
        }

        // 设置管理者的上级
        public void SetSuperior(Manager superior)
        {
            this.superior = superior;
        }

        // 申请请求
        public abstract void RequestApplication(Request request);
    }
}
