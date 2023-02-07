namespace BridgePattern.Abstraction
{
    /// <summary>
    /// 手机品牌M
    /// </summary>
    public class HandsetBrandM : HandsetBrand
    {
        public override void Run()
        {
            Console.Write("手机品牌M：");
            soft?.Run();
        }
    }
}
