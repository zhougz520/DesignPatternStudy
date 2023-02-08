using State.State;

namespace State
{
    /// <summary>
    /// 工作类
    /// </summary>
    public class Work
    {
        // “钟点”属性，状态转换的依据
        private double hour;
        public double Hour
        {
            get { return hour; }
            set { hour = value; }
        }

        // “任务完成”属性，是否能下班的状态
        private bool finish = false;
        public bool TaskFinished
        {
            get { return finish; }
            set { finish = value; }
        }

        private StateBase current;
        public Work()
        {
            // 初始化为上午工作状态，即上午9点开始上班
            current = new ForenoonState();
        }

        public void SetState(StateBase state)
        {
            current = state;
        }

        public void WriteProgram()
        {
            current.WriteProgram(this);
        }
    }
}
