namespace State.State
{
    /// <summary>
    /// 睡觉状态
    /// </summary>
    public class SleepingState : StateBase
    {
        public override void WriteProgram(Work w)
        {
            Console.WriteLine("当前时间：{0}点 不行了，睡着了。", w.Hour);
        }
    }
}
