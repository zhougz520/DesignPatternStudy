namespace SimpleFactoryPattern.Operations;

/*
    加法类：
    继承运算类
*/
public class OperationAdd : Operation
{
    public override double GetResult()
    {
        double result = 0;
        result = NumberA + NumberB;
        return result;
    }
}
