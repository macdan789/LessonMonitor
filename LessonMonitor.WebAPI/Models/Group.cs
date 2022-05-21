namespace LessonMonitor.WebAPI.Models
{
    public class Group
    {
        public int GroupID { get; set; }

        public string GroupName { get; set; }

        public int MemberCount { get; set; }
        
        public Teacher Curator { get; set; }

    }
}
