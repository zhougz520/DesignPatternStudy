namespace State.State
{
    /// <summary>
    /// 下班休息状态
    /// </summary>
    public class RestState : StateBase
    {
        public override void WriteProgram(Work w)
        {
            Console.WriteLine("当前时间：{0}点 下班回家了", w.Hour);
        }
    }
}
