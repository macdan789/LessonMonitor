namespace LessonMonitor.WebAPI.Contracts.ApiRoutes;

internal static class ApiRoutes
{
    private const string _root = "api";
    private const string _version = "v1";

    private const string _base = _root + "/" + _version;

    internal static class Group
    {
        public const string GetAll = _base + "/groups";
        public const string Get = _base + "/groups/{groupId}";
        public const string Create = _base + "/groups";
        public const string Update = _base + "/groups/{groupId}";
        public const string Delete = _base + "/groups/{groupId}";
    }

    internal static class Homework
    {
        public const string GetAll = _base + "/homeworks";
        public const string Get = _base + "/homeworks/{homeworkId}";
        public const string Create = _base + "/homeworks";
        public const string Update = _base + "/homeworks/{homeworkId}";
        public const string Delete = _base + "/homeworks/{homeworkId}";
    }

    internal static class Lesson
    {
        public const string GetAll = _base + "/lessons";
        public const string Get = _base + "/lessons/{lessonId}";
        public const string Create = _base + "/lessons";
        public const string Update = _base + "/lessons/{lessonId}";
        public const string Delete = _base + "/lessons/{lessonId}";
    }

    internal static class Member
    {
        public const string GetAll = _base + "/members";
        public const string Get = _base + "/members/{memberId}";
        public const string Create = _base + "/members";
        public const string Update = _base + "/members/{memberId}";
        public const string Delete = _base + "/members/{memberId}";
    }

    internal static class Teacher
    {
        public const string GetAll = _base + "/teachers";
        public const string Get = _base + "/teachers/{teacherId}";
        public const string Create = _base + "/teachers";
        public const string Update = _base + "/teachers/{teacherId}";
        public const string Delete = _base + "/teachers/{teacherId}";
    }
}
