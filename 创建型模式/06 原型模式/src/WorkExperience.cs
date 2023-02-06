using System;

namespace PrototypePattern;

/// <summary>
/// 工作经历
/// </summary>
public class WorkExperience : ICloneable
{
    private string? workDate;
    public string? WorkDate
    {
        get { return workDate; }
        set { workDate = value; }
    }

    private string? company;
    public string? Company
    {
        get { return company; }
        set { company = value; }
    }

    public object Clone()
    {
        return this.MemberwiseClone();
    }
}
