namespace SimpleFactoryPattern.Operations;

/*
    运算类：
    1、定义2个运算变量
    2、定义结果返回虚方法给子类重写
*/
public class Operation
{
    private double _numberA = 0;
    private double _numberB = 0;

    public double NumberA
    {
        get { return _numberA; }
        set { _numberA = value; }
    }

    public double NumberB
    {
        get { return _numberB; }
        set { _numberB = value; }
    }

    public virtual double GetResult()
    {
        double result = 0;
        return result;
    }
}
