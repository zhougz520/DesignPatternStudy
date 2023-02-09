using Interpreter.Context;

namespace Interpreter.Expression
{
    /// <summary>
    /// 抽象表达式
    /// </summary>
    public abstract class ExpressionBase
    {
        // 解释器
        public void Interpret(PlayContext context)
        {
            if (context.PlayText.Length == 0)
            {
                return;
            }
            else
            {
                string playKey = context.PlayText.Substring(0, 1);
                context.PlayText = context.PlayText.Substring(2);

                double playValue = Convert.ToDouble(context.PlayText.Substring(0, context.PlayText.IndexOf(" ")));
                context.PlayText = context.PlayText.Substring(context.PlayText.IndexOf(" ") + 1);

                Excute(playKey, playValue);
            }
        }

        // 执行
        public abstract void Excute(string key, double value);
    }
}
