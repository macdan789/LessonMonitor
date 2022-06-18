using System;
using System.Collections.Generic;

namespace LessonMonitor.WebAPI.Models;

public class Lesson
{
    public int LessonID { get; set; }

    public string LessonName { get; set; }

    public TimeSpan Duration { get; set; }

    public DateTime StartDate { get; set; }
    
    public Teacher Teacher { get; set; }

    public List<Group> Groups { get; set; }
}
