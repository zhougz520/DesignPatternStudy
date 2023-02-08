using TemplateMethod.Abstract;

namespace TemplateMethod.Concrete
{
    /// <summary>
    /// 学生A抄的试卷
    /// </summary>
    public class TestPaperA : TestPaper
    {
        protected override string Answer1()
        {
            return "b";
        }

        protected override string Answer2()
        {
            return "c";
        }

        protected override string Answer3()
        {
            return "d";
        }
    }
}
