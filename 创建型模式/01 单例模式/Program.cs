using Singleton.src;

namespace Singleton;

class Program
{
    static void Main(string[] args)
    {
        /*
            客户端代码（懒汉模式）
        */
        SingletonLazy sl1 = SingletonLazy.GetInstance();
        SingletonLazy sl2 = SingletonLazy.GetInstance();

        // 比较两次实例化后对象的结果是实例相同
        if (sl1 == sl2)
        {
            Console.WriteLine("懒汉模式：两个对象是相同实例。");
        }


        /*
            客户端代码（饿汉模式）
        */
        SingletonHungry sh1 = SingletonHungry.GetInstance();
        SingletonHungry sh2 = SingletonHungry.GetInstance();

        // 比较两次实例化后对象的结果是实例相同
        if (sh1 == sh2)
        {
            Console.WriteLine("饿汉模式：两个对象是相同实例。");
        }
    }
}
