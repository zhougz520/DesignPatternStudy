namespace TemplateMethod.Abstract
{
    /// <summary>
    /// 金庸小说试卷
    /// </summary>
    public class TestPaper
    {
        public void TestQuestion1()
        {
            Console.WriteLine("问题1：xxxx");
            Console.WriteLine("答案：" + Answer1());
        }

        /// <summary>
        /// 改成虚方法的目的就是给子类重写，因为每个人的答案都不同
        /// </summary>
        /// <returns></returns>
        protected virtual string Answer1()
        {
            return "";
        }

        public void TestQuestion2()
        {
            Console.WriteLine("问题2：yyyy");
            Console.WriteLine("答案：" + Answer2());
        }

        protected virtual string Answer2()
        {
            return "";
        }

        public void TestQuestion3()
        {
            Console.WriteLine("问题3：zzzz");
            Console.WriteLine("答案：" + Answer3());
        }

        protected virtual string Answer3()
        {
            return "";
        }
    }
}
