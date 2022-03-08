using LessonMonitor.WebAPI.Attributes;

namespace LessonMonitor.WebAPI.Models
{
    [Description("Description for class Member")]
    public class Member
    {
        [Required]
        public int Age { get; set; }
        
        [Required]
        public string Name { get; set; }
    }
}
