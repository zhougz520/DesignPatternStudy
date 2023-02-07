using System;

namespace PrototypePattern;

/// <summary>
/// 简历
/// </summary>
public class Resume : ICloneable
{
    private string? name;
    private string? sex;
    private string? age;
    private WorkExperience work;

    public Resume(string name)
    {
        this.name = name;
        this.work = new WorkExperience();
    }

    private Resume(WorkExperience work)
    {
        this.work = (WorkExperience)work.Clone();
    }

    /// <summary>
    /// 设置个人信息
    /// </summary>
    /// <param name="sex">性别</param>
    /// <param name="age">年龄</param>
    public void SetPersonalInfo(string sex, string age)
    {
        this.sex = sex;
        this.age = age;
    }

    /// <summary>
    /// 设置工作经历
    /// </summary>
    /// <param name="workDate">工作时间</param>
    /// <param name="company">公司</param>
    public void SetWorkExperience(string workDate, string company)
    {
        work.WorkDate = workDate;
        work.Company = company;
    }

    /// <summary>
    /// 显示
    /// </summary>
    public void Display()
    {
        Console.WriteLine("{0} {1} {2}", name, sex, age);
        Console.WriteLine("工作经历：{0} {1}", work.WorkDate, work.Company);
    }

    public object Clone()
    {
        Resume obj = new Resume(this.work);
        obj.name = this.name;
        obj.sex = this.sex;
        obj.age = this.age;
        return obj;
    }
}
