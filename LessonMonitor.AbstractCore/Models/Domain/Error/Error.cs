using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
