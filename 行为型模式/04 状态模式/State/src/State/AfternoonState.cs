namespace State.State
{
    /// <summary>
    /// 下午工作状态
    /// </summary>
    public class AfternoonState : StateBase
    {
        public override void WriteProgram(Work w)
        {
            if (w.Hour < 17)
            {
                Console.WriteLine("当前时间：{0}点 下午状态还不错，继续努力", w.Hour);
            }
            else
            {
                w.SetState(new EveningState());
                w.WriteProgram();
            }
        }
    }
}
