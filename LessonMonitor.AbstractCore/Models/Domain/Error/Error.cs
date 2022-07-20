namespace LessonMonitor.AbstractCore.Models.Domain.Error;

public class Error
{
    public IEnumerable<string> Messages { get; set; }

    public bool HasErrors
    {
        get
        {
            return Messages.Any();
        }
    }
}
