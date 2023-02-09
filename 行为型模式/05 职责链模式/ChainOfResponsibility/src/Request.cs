namespace ChainOfResponsibility
{
    /// <summary>
    /// 申请
    /// </summary>
    public class Request
    {
        // 申请类别
        public string RequestType { get; set; }

        // 申请类容
        public string RequestContent { get; set; }

        // 数量
        public int Number { get; set; }
    }
}
