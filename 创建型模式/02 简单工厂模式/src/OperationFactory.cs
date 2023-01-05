namespace SimpleFactoryPattern.src;

/*
    运算工厂类
*/
public class OperationFactory
{
    public static Operation createOperate(string operate)
    {
        Operation? oper = null;
        switch (operate)
        {
            case "+":
                oper = new OperationAdd();
                break;
            case "-":
                oper = new OperationSub();
                break;
            case "*":
                oper = new OperationMul();
                break;
            case "/":
                oper = new OperationDiv();
                break;
            default:
                throw new Exception("运算符号输入错误。");
        }
        return oper;
    }
}
