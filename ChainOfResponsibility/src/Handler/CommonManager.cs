namespace ChainOfResponsibility.Handler
{
    /// <summary>
    /// 经理
    /// </summary>
    public class CommonManager : Manager
    {
        public CommonManager(string name) : base(name)
        {
        }

        public override void RequestApplication(Request request)
        {
            if (request.RequestType == "请假" && request.Number < 2)
            {
                // 经理的权限可以审批2天内的假期
                Console.WriteLine("{0}:{1} 数量{2} 被批准", name, request.RequestContent, request.Number);
            }
            else
            {
                // 其余的申请都需要转到上级
                if (superior != null)
                {
                    superior.RequestApplication(request);
                }
            }
        }
    }
}
