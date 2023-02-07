using BridgePattern.Abstraction;
using BridgePattern.Implementor;

class Program
{
    static void Main(string[] args)
    {
        HandsetBrand ab;

        // 手机品牌N
        ab = new HandsetBrandN();
        // 手机品牌N设置游戏 & 运行
        ab.SetHandsetSoft(new HandsetGame());
        ab.Run();
        // 手机品牌N设置通讯录 & 运行
        ab.SetHandsetSoft(new HandsetAddressList());
        ab.Run();

        // 手机品牌M
        ab = new HandsetBrandM();
        // 手机品牌N设置游戏 & 运行
        ab.SetHandsetSoft(new HandsetGame());
        ab.Run();
        // 手机品牌N设置通讯录 & 运行
        ab.SetHandsetSoft(new HandsetAddressList());
        ab.Run();
    }
}