namespace SimpleFactoryPattern.src;

/*
    减法类：
    继承运算类
*/
public class OperationSub : Operation
{
    public override double GetResult()
    {
        double result = 0;
        result = NumberA - NumberB;
        return result;
    }
}
