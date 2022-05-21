using LessonMonitor.WebAPI.Attributes;

namespace LessonMonitor.WebAPI.Models
{
    [Description("Description for class Member")]
    public class Member
    {
        public int MemberID { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public Group Group { get; set; }
    }
}