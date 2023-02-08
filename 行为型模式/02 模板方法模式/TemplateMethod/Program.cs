using TemplateMethod.Abstract;
using TemplateMethod.Concrete;

class Program
{
    static void Main(string[] args)
    {
        // 将子类变量的声明改成了父类，利用了多态性，实现了代码的复用
        TestPaper testPaper;

        Console.WriteLine("学生A抄的试卷：");
        testPaper = new TestPaperA();
        testPaper.TestQuestion1();
        testPaper.TestQuestion2();
        testPaper.TestQuestion3();

        Console.WriteLine("学生B抄的试卷：");
        testPaper = new TestPaperB();
        testPaper.TestQuestion1();
        testPaper.TestQuestion2();
        testPaper.TestQuestion3();
    }
}
