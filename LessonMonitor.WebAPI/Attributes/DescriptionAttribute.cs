using System;

namespace LessonMonitor.WebAPI.Attributes;

/// <summary>
/// Display object description and can be read via REFLECTION
/// </summary>
public class DescriptionAttribute : Attribute
{
    private readonly string _description;

    public string Description { get { return _description; } }

    public DescriptionAttribute(string description)
    {
        this._description = description;
    }
}
