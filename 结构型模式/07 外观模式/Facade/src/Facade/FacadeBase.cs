using Facade.Subject;

namespace Facade.Facade
{
    /// <summary>
    /// 外观类
    /// 他需要了解所有的子系统方法或属性，进行组合，以备外界调用
    /// </summary>
    public class FacadeBase
    {
        SubSystem1 one;
        SubSystem2 two;
        SubSystem3 three;
        SubSystem4 four;

        public FacadeBase()
        {
            one = new SubSystem1();
            two = new SubSystem2();
            three = new SubSystem3();
            four = new SubSystem4();
        }

        public void MethodA()
        {
            Console.WriteLine("\n 方法组A() ---- ");
            one.Method1();
            two.Method2();
            four.Method4();
        }

        public void MethodB()
        {
            Console.WriteLine("\n 方法组B() ---- ");
            two.Method2();
            three.Method3();
        }
    }
}
