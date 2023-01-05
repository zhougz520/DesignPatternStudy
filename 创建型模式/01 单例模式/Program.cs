Singleton s1 = Singleton.GetInstance();
Singleton s2 = Singleton.GetInstance();

// 比较两次实例化后对象的结果是实例相同
if (s1 == s2)
{
    Console.WriteLine("两个对象是相同实例。");
}