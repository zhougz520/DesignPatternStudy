using SimpleFactoryPattern.src;

Operation oper;
oper = OperationFactory.createOperate("+");
oper.NumberA = 1;
oper.NumberB = 2;
double result = oper.GetResult();

Console.WriteLine(result);
