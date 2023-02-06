using PrototypePattern;

class Program
{
    static void Main(string[] args)
    {
        Resume a = new Resume("大鸟");
        a.SetPersonalInfo("男", "29");
        a.SetWorkExperience("1998-2000", "XX公司");

        Resume b = (Resume)a.Clone();
        b.SetWorkExperience("1998-2006", "YY公司");

        Resume c = (Resume)a.Clone();
        c.SetPersonalInfo("男", "24");
        c.SetWorkExperience("1998-2003", "ZZ公司");

        a.Display();
        b.Display();
        c.Display();
    }
}