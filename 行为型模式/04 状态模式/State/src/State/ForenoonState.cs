namespace State.State
{
    /// <summary>
    /// 上午工作状态
    /// </summary>
    public class ForenoonState : StateBase
    {
        public override void WriteProgram(Work w)
        {
            if (w.Hour < 12)
            {
                Console.WriteLine("当前时间：{0}点 上午工作，精神百倍", w.Hour);
            }
            else
            {
                w.SetState(new NoonState());
                w.WriteProgram();
            }
        }
    }
}
