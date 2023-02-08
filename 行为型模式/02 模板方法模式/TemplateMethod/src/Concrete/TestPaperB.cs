using TemplateMethod.Abstract;

namespace TemplateMethod.Concrete
{
    /// <summary>
    /// 学生B抄的试卷
    /// </summary>
    public class TestPaperB : TestPaper
    {
        protected override string Answer1()
        {
            return "a";
        }

        protected override string Answer2()
        {
            return "d";
        }

        protected override string Answer3()
        {
            return "e";
        }
    }
}
