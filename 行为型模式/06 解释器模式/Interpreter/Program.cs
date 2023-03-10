using Interpreter.Context;
using Interpreter.Expression;

class Program
{
    static void Main(string[] args)
    {
        PlayContext context = new PlayContext();
        // 音乐-上海滩
        Console.WriteLine("上海滩：");
        context.PlayText = "O 2 E 0.5 G 0.5 A 3 E 0.5 G 0.5 D 3 E 0.5 G 0.5 A 0.5 O 3 C 1 O 2 A 0.5 G 1 C 0.5 E 0.5 D 3 ";
        ExpressionBase exception = null;

        try
        {
            while (context.PlayText.Length > 0)
            {
                string str = context.PlayText.Substring(0, 1);
                switch (str)
                {
                    case "O":
                        exception = new Scale();
                        break;
                    case "C":
                    case "D":
                    case "E":
                    case "F":
                    case "G":
                    case "A":
                    case "B":
                    case "P":
                        exception = new Note();
                        break;
                }
                exception.Interpret(context);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}