namespace BuilderPattern.Product;

/// <summary>
/// 产品类，由多个部件组成
/// </summary>
public class ProductBase
{
    IList<string> parts = new List<string>();

    /// <summary>
    /// 添加组成部件
    /// </summary>
    /// <param name="part">部件</param>
    public void Add(string part)
    {
        parts.Add(part);
    }

    /// <summary>
    /// 展示产品创建的步骤
    /// </summary>
    public void Show()
    {
        Console.WriteLine("\n 产品 创建 ----");
        foreach (string part in parts)
        {
            Console.WriteLine(part);
        }
    }
}
