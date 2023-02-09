using ChainOfResponsibility;
using ChainOfResponsibility.Handler;

class Program
{
    static void Main(string[] args)
    {
        // 设置上级
        CommonManager jingli = new CommonManager("经理");
        Majordomo zhongjian = new Majordomo("总监");
        GeneralManager zhongjingli = new GeneralManager("总经理");
        jingli.SetSuperior(zhongjian);
        zhongjian.SetSuperior(zhongjingli);

        // 申请都是由经理来发，谁审批根据职责权限来
        Request request = new Request();
        request.RequestType = "请假";
        request.RequestContent = "小菜请假";
        request.Number = 1;
        jingli.RequestApplication(request);

        Request request2 = new Request();
        request2.RequestType = "请假";
        request2.RequestContent = "小菜请假";
        request2.Number = 4;
        jingli.RequestApplication(request2);

        Request request3 = new Request();
        request3.RequestType = "加薪";
        request3.RequestContent = "小菜请求加薪";
        request3.Number = 500;
        jingli.RequestApplication(request3);

        Request request4 = new Request();
        request4.RequestType = "加薪";
        request4.RequestContent = "小菜请求加薪";
        request4.Number = 1000;
        jingli.RequestApplication(request4);
    }
}