namespace State.State
{
    /// <summary>
    /// 晚间工作状态
    /// </summary>
    public class EveningState : StateBase
    {
        public override void WriteProgram(Work w)
        {
            if (w.TaskFinished)
            {
                w.SetState(new RestState());
                w.WriteProgram();
            }
            else
            {
                if (w.Hour < 21)
                {
                    Console.WriteLine("当前时间：{0}点 加班哦，疲累之极", w.Hour);
                }
                else
                {
                    w.SetState(new SleepingState());
                    w.WriteProgram();
                }
            }
        }
    }
}
