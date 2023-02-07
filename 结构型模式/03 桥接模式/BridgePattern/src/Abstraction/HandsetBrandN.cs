namespace BridgePattern.Abstraction
{
    /// <summary>
    /// 手机品牌N
    /// </summary>
    public class HandsetBrandN : HandsetBrand
    {
        public override void Run()
        {
            Console.Write("手机品牌N：");
            soft?.Run();
        }
    }
}
