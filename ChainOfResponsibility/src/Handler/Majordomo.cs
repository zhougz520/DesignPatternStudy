namespace ChainOfResponsibility.Handler
{
    /// <summary>
    /// 总监
    /// </summary>
    public class Majordomo : Manager
    {
        public Majordomo(string name) : base(name)
        {
        }

        public override void RequestApplication(Request request)
        {
            if (request.RequestType == "请假" && request.Number <= 5)
            {
                // 经理的权限可以审批一周内的假期
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
