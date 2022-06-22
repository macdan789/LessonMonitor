using System.ComponentModel.DataAnnotations;

namespace LessonMonitor.WebAPI.Attributes;

public class RequiredAttribute : ValidationAttribute
{
    public RequiredAttribute()
    {
        
    }

    public override bool IsValid(object value) => this.IsValid_FirstExample(value);

    #region PRIVATE METHODS
    private bool IsValid_FirstExample(object value) => value switch
    {
        string => !string.IsNullOrEmpty((string)value) ||
                  !string.IsNullOrWhiteSpace((string)value),
        null => false,
        _ => false
    };


    private bool IsValid_SecondExample(object value) => value is string
            ? (!string.IsNullOrEmpty(value as string) ||
               !string.IsNullOrWhiteSpace(value as string))
            : (value is null) ? false : true;
    #endregion
}
