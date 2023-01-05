public class Singleton
{
    // 定义变量用于存储单例的实例
    private static Singleton? instance;

    // 构造方法让其private，避免外界利用new创建此类实例
    private Singleton() { }

    // 此方法是获得本类实例的唯一全局访问点
    public static Singleton GetInstance()
    {
        // 若实例不存在，则new一个新实例，否则返回已有的实例
        if (instance == null)
        {
            instance = new Singleton();
        }

        return instance;
    }
}
