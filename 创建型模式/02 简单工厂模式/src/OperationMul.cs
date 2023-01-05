namespace SimpleFactoryPattern.src;

/*
    乘法类：
    继承运算类
*/
public class OperationMul : Operation
{
    public override double GetResult()
    {
        double result = 0;
        result = NumberA * NumberB;
        return result;
    }
}
