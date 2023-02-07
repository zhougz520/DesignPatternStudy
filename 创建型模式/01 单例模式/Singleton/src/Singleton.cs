namespace Singleton.src;

/*
    懒汉模式：
    sealed阻止发生派生，而派生可能会增加实例
*/
public sealed class SingletonLazy
{
    // 定义变量用于存储单例的实例
    // 初始化时就实例化（懒汉模式）
    private static readonly SingletonLazy instance = new SingletonLazy();

    // 构造方法让其private，避免外界利用new创建此类实例
    private SingletonLazy() { }

    // 此方法是获得本类实例的唯一全局访问点
    public static SingletonLazy GetInstance()
    {
        return instance;
    }
}

/*
    饿汉模式：
    通过“双重锁定”保证线程安全
*/
public class SingletonHungry
{
    // 定义变量用于存储单例的实例
    private static SingletonHungry? instance;
    // 程序运行时创建一个静态只读的进程辅助对象
    private static readonly object syncRoot = new object();

    // 构造方法让其private，避免外界利用new创建此类实例
    private SingletonHungry() { }

    // 此方法是获得本类实例的唯一全局访问点
    public static SingletonHungry GetInstance()
    {
        // 先判断实例是否存在，不存在再加锁处理
        if (instance == null)
        {
            // 在同一个时刻加了锁的那部分程序只有一个线程可以进入
            lock (syncRoot)
            {
                if (instance == null)
                {
                    instance = new SingletonHungry();
                }
            }
        }

        return instance;
    }
}
